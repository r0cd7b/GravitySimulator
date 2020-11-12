using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SpaceForm : Form
    {
        Image image; // 화면에 표시하기 전에 그래픽을 그려낼 임시 이미지.
        Graphics graphics; // 화면 그래픽 객체.
        Space space; // 우주 클래스.

        double mass, diameter; // 질량, 지름.
        Color planetColor; // 행성 색.
        System.Windows.Vector speed; // 행성 속도.

        int generating; // 생성 모드. (사용자가 행성을 생성하는 과정을 화면에 나타내는 모드를 구분함.)
        int downX, downY, moveX, moveY; // 마우스 Down, Move 이벤트가 일어난 좌표.

        public SpaceForm()
        {
            space = new Space(); // 새로운 space 클래스 생성.
            InitializeComponent();
        }

        private void SpaceForm_ClientSizeChanged(object sender, EventArgs e) // 클라이언트 사이즈 변경시 발생 이벤트.
        {
            if (ClientSize.IsEmpty) // 사이즈가 0일 경우 리턴.
                return;
            if (image != null) // 이미지 객체가 null이 아닐 경우 수행
            {
                image.Dispose(); // 이미지 리소스 해제.
                graphics.Dispose(); // 그래픽 리소스 해제.
            }
            image = new Bitmap(ClientSize.Width, ClientSize.Height); // 새로운 클라이언트 사이즈를 이용하여 이미지 객체 생성.
            graphics = Graphics.FromImage(image); // 그래픽 객체 생성.
        }

        private void SpaceForm_Paint(object sender, PaintEventArgs e) // 화면 Paint 이벤트
        {
            graphics.Clear(BackColor); // 이미지를 배경 색으로 클리어.
            foreach (Planet p in space.Planets) // 전체 행성 반복.
            {
                Color c = p.Color; // 사용자 지정 색
                double d = p.Diameter, r = p.Diameter / 2.0;
                RectangleF rectangle = new RectangleF((float)(p.X - r), (float)(p.Y - r), (float)d, (float)d);
                graphics.FillEllipse(new SolidBrush(c), rectangle); // 행성 내부를 그린다.
                graphics.DrawEllipse(new Pen(c), rectangle); // 행성 외곽선을 그린다.
            }
            if (generating > 0) // 생성 모드가 0 이상일 경우 (새로운 행성을 만드는 중인 경우)
            {
                double r = diameter / 2.0;
                RectangleF rectangle = new RectangleF((float)(downX - r), (float)(downY - r), (float)diameter, (float)diameter);
                graphics.FillEllipse(new SolidBrush(planetColor), rectangle); // 새로운 행성을 임시로 그린다.
                graphics.DrawEllipse(new Pen(planetColor), rectangle);
                if (generating > 1) // 생성 모드가 1 이상일 경우 (새로운 행성이 움직일 벡터를 만드는 중인 경우)
                    graphics.DrawLine(new Pen(Color.White) { EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor }, downX, downY, moveX, moveY); // 벡터를 Pen으로 시각화하여 화면에 그린다.
            }
            CreateGraphics().DrawImage(image, 0, 0); // 그래픽을 그려놓은 이미지를 화면에 띄운다.
        }

        private void Renew_Tick(object sender, EventArgs e) // 타이머 Tick 이벤트.
        {
            space.Move(ClientSize.Width, ClientSize.Height); // 모든 행성이 나아가야할 벡터로 움직인다.
            OnPaint(null); // Paint 이벤트를 호출하여 화면 갱신.
        }

        private void SpaceForm_MouseDown(object sender, MouseEventArgs e) // 마우스 Down 이벤트.
        {
            if (e.Button == MouseButtons.Left) // 마우스 버튼 클릭이 왼쪽일 때 수행.
            {
                Renew.Stop(); // 타이머 일시정지.

                // 사용자가 입력한 정보를 종합하여 변수에 저장.
                mass = (double)massNumeric.Value;
                planetColor = Color.FromArgb((int)rNumeric.Value, (int)gNumeric.Value, (int)bNumeric.Value);
                speed = new System.Windows.Vector();
                diameter = (double)volumeNumeric.Value;
                downX = e.Location.X; // 마우스 Down 좌표 저장.
                downY = e.Location.Y;
                generating = 1; // 모드 1로 변경.
                OnPaint(null); // 화면 갱신.
            }
            else if (e.Button == MouseButtons.Right) // 오른쪽 버튼일 경우 작업 취소.
            {
                generating = 0;
                OnPaint(null);
                Renew.Start();
            }
        }

        private void SpaceForm_MouseMove(object sender, MouseEventArgs e) // 마우스 Move 이벤트
        {
            if (e.Button == MouseButtons.Left && generating > 0) // 왼쪽 버튼일 때, 모드 0을 거쳤을 때.
            {
                speed = new System.Windows.Vector((e.X - downX) / 13.0, (e.Y - downY) / 13.0); // Down 좌표와의 마우스 벡터 차이 값을 speed 변수에 저장.
                moveX = e.Location.X; // Move 좌표 값 저장.
                moveY = e.Location.Y;
                generating = 2; // 모드 2로 변경.
                OnPaint(null);
            }
        }

        private void SpaceForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && generating > 0) // 왼쪽 버튼일 때, 모드 0을 거쳤을 때.
            {
                double r = diameter / 2.0;
                space.AddPlanet(new Planet(downX, downY, mass, diameter, planetColor, speed)); // space 객체에 행성 추가.
                generating = 0; // 모드 0으로 초기화.
                OnPaint(null);
                Renew.Start(); // 타이머 재시작.
            }
        }

        void ColorChanged() // 색 Numeric 컨트롤 값이 변경되면 수행.
        {
            colorBox.BackColor = Color.FromArgb((int)rNumeric.Value, (int)gNumeric.Value, (int)bNumeric.Value); // coloBox의 색을 바꿔 변결될 때마다 보여줌.
        }

        // 사용자 지정색을 나타내는 Numeric 컨트롤
        private void rNumeric_ValueChanged(object sender, EventArgs e)
        {
            ColorChanged();
        }
        private void gNumeric_ValueChanged(object sender, EventArgs e)
        {
            ColorChanged();
        }
        private void bNumeric_ValueChanged(object sender, EventArgs e)
        {
            ColorChanged();
        }
    }
}

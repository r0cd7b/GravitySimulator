namespace WindowsFormsApp1
{
    partial class SpaceForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Renew = new System.Windows.Forms.Timer(this.components);
            this.volumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.bNumeric = new System.Windows.Forms.NumericUpDown();
            this.gNumeric = new System.Windows.Forms.NumericUpDown();
            this.rNumeric = new System.Windows.Forms.NumericUpDown();
            this.bLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.massLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.massNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Renew
            // 
            this.Renew.Enabled = true;
            this.Renew.Interval = 17;
            this.Renew.Tick += new System.EventHandler(this.Renew_Tick);
            // 
            // volumeNumeric
            // 
            this.volumeNumeric.BackColor = System.Drawing.Color.White;
            this.volumeNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeNumeric.ForeColor = System.Drawing.Color.Black;
            this.volumeNumeric.Location = new System.Drawing.Point(89, 12);
            this.volumeNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.volumeNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.volumeNumeric.Name = "volumeNumeric";
            this.volumeNumeric.Size = new System.Drawing.Size(56, 25);
            this.volumeNumeric.TabIndex = 0;
            this.volumeNumeric.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.BackColor = System.Drawing.Color.Transparent;
            this.diameterLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.diameterLabel.ForeColor = System.Drawing.Color.White;
            this.diameterLabel.Location = new System.Drawing.Point(12, 14);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(71, 15);
            this.diameterLabel.TabIndex = 1;
            this.diameterLabel.Text = "Diameter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.colorBox);
            this.panel1.Controls.Add(this.bNumeric);
            this.panel1.Controls.Add(this.volumeNumeric);
            this.panel1.Controls.Add(this.gNumeric);
            this.panel1.Controls.Add(this.diameterLabel);
            this.panel1.Controls.Add(this.rNumeric);
            this.panel1.Controls.Add(this.bLabel);
            this.panel1.Controls.Add(this.colorLabel);
            this.panel1.Controls.Add(this.gLabel);
            this.panel1.Controls.Add(this.massLabel);
            this.panel1.Controls.Add(this.rLabel);
            this.panel1.Controls.Add(this.massNumeric);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 50);
            this.panel1.TabIndex = 2;
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Blue;
            this.colorBox.Location = new System.Drawing.Point(567, 12);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(25, 25);
            this.colorBox.TabIndex = 8;
            this.colorBox.TabStop = false;
            // 
            // bNumeric
            // 
            this.bNumeric.BackColor = System.Drawing.Color.White;
            this.bNumeric.ForeColor = System.Drawing.Color.Black;
            this.bNumeric.Location = new System.Drawing.Point(513, 12);
            this.bNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bNumeric.Name = "bNumeric";
            this.bNumeric.Size = new System.Drawing.Size(48, 25);
            this.bNumeric.TabIndex = 7;
            this.bNumeric.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bNumeric.ValueChanged += new System.EventHandler(this.bNumeric_ValueChanged);
            // 
            // gNumeric
            // 
            this.gNumeric.BackColor = System.Drawing.Color.White;
            this.gNumeric.ForeColor = System.Drawing.Color.Black;
            this.gNumeric.Location = new System.Drawing.Point(436, 12);
            this.gNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gNumeric.Name = "gNumeric";
            this.gNumeric.Size = new System.Drawing.Size(48, 25);
            this.gNumeric.TabIndex = 7;
            this.gNumeric.ValueChanged += new System.EventHandler(this.gNumeric_ValueChanged);
            // 
            // rNumeric
            // 
            this.rNumeric.BackColor = System.Drawing.Color.White;
            this.rNumeric.ForeColor = System.Drawing.Color.Black;
            this.rNumeric.Location = new System.Drawing.Point(356, 12);
            this.rNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rNumeric.Name = "rNumeric";
            this.rNumeric.Size = new System.Drawing.Size(48, 25);
            this.rNumeric.TabIndex = 7;
            this.rNumeric.ValueChanged += new System.EventHandler(this.rNumeric_ValueChanged);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.BackColor = System.Drawing.Color.Transparent;
            this.bLabel.ForeColor = System.Drawing.Color.White;
            this.bLabel.Location = new System.Drawing.Point(490, 14);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(17, 15);
            this.bLabel.TabIndex = 6;
            this.bLabel.Text = "B";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.BackColor = System.Drawing.Color.Transparent;
            this.colorLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.colorLabel.ForeColor = System.Drawing.Color.White;
            this.colorLabel.Location = new System.Drawing.Point(274, 14);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(53, 15);
            this.colorLabel.TabIndex = 5;
            this.colorLabel.Text = "Color:";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.BackColor = System.Drawing.Color.Transparent;
            this.gLabel.ForeColor = System.Drawing.Color.White;
            this.gLabel.Location = new System.Drawing.Point(412, 14);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(18, 15);
            this.gLabel.TabIndex = 6;
            this.gLabel.Text = "G";
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.BackColor = System.Drawing.Color.Transparent;
            this.massLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.massLabel.ForeColor = System.Drawing.Color.White;
            this.massLabel.Location = new System.Drawing.Point(151, 14);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(47, 15);
            this.massLabel.TabIndex = 3;
            this.massLabel.Text = "Mass";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.BackColor = System.Drawing.Color.Transparent;
            this.rLabel.ForeColor = System.Drawing.Color.White;
            this.rLabel.Location = new System.Drawing.Point(333, 14);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(17, 15);
            this.rLabel.TabIndex = 6;
            this.rLabel.Text = "R";
            // 
            // massNumeric
            // 
            this.massNumeric.BackColor = System.Drawing.Color.White;
            this.massNumeric.ForeColor = System.Drawing.Color.Black;
            this.massNumeric.Location = new System.Drawing.Point(204, 12);
            this.massNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.massNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.massNumeric.Name = "massNumeric";
            this.massNumeric.Size = new System.Drawing.Size(64, 25);
            this.massNumeric.TabIndex = 4;
            this.massNumeric.Value = new decimal(new int[] {
            81,
            0,
            0,
            0});
            // 
            // SpaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(620, 620);
            this.Name = "SpaceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gravity Simulator 1.0";
            this.ClientSizeChanged += new System.EventHandler(this.SpaceForm_ClientSizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SpaceForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SpaceForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SpaceForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SpaceForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.volumeNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Renew;
        private System.Windows.Forms.NumericUpDown volumeNumeric;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.NumericUpDown massNumeric;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.NumericUpDown bNumeric;
        private System.Windows.Forms.NumericUpDown gNumeric;
        private System.Windows.Forms.NumericUpDown rNumeric;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.PictureBox colorBox;
    }
}


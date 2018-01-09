namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_stage = new System.Windows.Forms.Button();
            this.textBox10L = new System.Windows.Forms.TextBox();
            this.textBox80L = new System.Windows.Forms.TextBox();
            this.textBoxVac = new System.Windows.Forms.TextBox();
            this.textBoxStg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBarVac = new System.Windows.Forms.ProgressBar();
            this.progressBarTerm = new System.Windows.Forms.ProgressBar();
            this.btnTermOff = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTermOn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVacOn = new System.Windows.Forms.Button();
            this.btnVacOff = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxTermSet = new System.Windows.Forms.TextBox();
            this.textBoxVacSet = new System.Windows.Forms.TextBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxPumpL = new System.Windows.Forms.TextBox();
            this.btnPumpLon = new System.Windows.Forms.Button();
            this.btnPumpLoff = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBarPumpL = new System.Windows.Forms.ProgressBar();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBoxPumpR = new System.Windows.Forms.TextBox();
            this.btnPumpRon = new System.Windows.Forms.Button();
            this.btnPumpRoff = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBarPumpR = new System.Windows.Forms.ProgressBar();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.Location = new System.Drawing.Point(272, 241);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(112, 34);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stop.Location = new System.Drawing.Point(272, 297);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(112, 40);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(35, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "send";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 69);
            this.textBox1.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(41, 326);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(185, 35);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Open Port";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_close
            // 
            this.btn_close.Enabled = false;
            this.btn_close.Location = new System.Drawing.Point(186, 97);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close Port";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(539, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 101);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "read";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(186, 82);
            this.textBox2.TabIndex = 0;
            // 
            // btn_read
            // 
            this.btn_read.Enabled = false;
            this.btn_read.Location = new System.Drawing.Point(656, 121);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stage";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "STOP",
            "WELCOME",
            "STAGE1",
            "STAGE2",
            "STAGE3",
            "STAGE4",
            "STAGE5",
            "STAGE6",
            "STAGE7",
            "STAGE8",
            "STAGE9",
            "STAGE10",
            "STAGE11",
            "STAGE12",
            "STAGE13",
            "STAGE14",
            "STAGE15",
            "STAGE16",
            "STAGE17",
            "STAGE18",
            "STAGE19",
            "STAGE20",
            "STAGE21",
            "STAGE22",
            "STAGE23"});
            this.comboBox2.Location = new System.Drawing.Point(28, 203);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // btn_stage
            // 
            this.btn_stage.Enabled = false;
            this.btn_stage.Location = new System.Drawing.Point(168, 203);
            this.btn_stage.Name = "btn_stage";
            this.btn_stage.Size = new System.Drawing.Size(75, 23);
            this.btn_stage.TabIndex = 12;
            this.btn_stage.Text = "send";
            this.btn_stage.UseVisualStyleBackColor = true;
            this.btn_stage.Click += new System.EventHandler(this.btn_stage_Click);
            // 
            // textBox10L
            // 
            this.textBox10L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10L.Location = new System.Drawing.Point(284, 37);
            this.textBox10L.Name = "textBox10L";
            this.textBox10L.ReadOnly = true;
            this.textBox10L.Size = new System.Drawing.Size(100, 29);
            this.textBox10L.TabIndex = 13;
            // 
            // textBox80L
            // 
            this.textBox80L.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox80L.Location = new System.Drawing.Point(284, 123);
            this.textBox80L.Name = "textBox80L";
            this.textBox80L.ReadOnly = true;
            this.textBox80L.Size = new System.Drawing.Size(100, 29);
            this.textBox80L.TabIndex = 14;
            // 
            // textBoxVac
            // 
            this.textBoxVac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVac.Location = new System.Drawing.Point(421, 36);
            this.textBoxVac.Name = "textBoxVac";
            this.textBoxVac.ReadOnly = true;
            this.textBoxVac.Size = new System.Drawing.Size(100, 29);
            this.textBoxVac.TabIndex = 16;
            // 
            // textBoxStg
            // 
            this.textBoxStg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStg.Location = new System.Drawing.Point(425, 123);
            this.textBoxStg.Name = "textBoxStg";
            this.textBoxStg.ReadOnly = true;
            this.textBoxStg.Size = new System.Drawing.Size(100, 29);
            this.textBoxStg.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(284, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Temp 10 L";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(284, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Temp 80 L";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(421, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Vacuum";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(433, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Stage";
            // 
            // timer1
            // 
            this.timer1.Interval = 120000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBarVac
            // 
            this.progressBarVac.Location = new System.Drawing.Point(659, 246);
            this.progressBarVac.Maximum = 1;
            this.progressBarVac.Name = "progressBarVac";
            this.progressBarVac.Size = new System.Drawing.Size(39, 23);
            this.progressBarVac.TabIndex = 26;
            // 
            // progressBarTerm
            // 
            this.progressBarTerm.Location = new System.Drawing.Point(518, 246);
            this.progressBarTerm.Maximum = 1;
            this.progressBarTerm.Name = "progressBarTerm";
            this.progressBarTerm.Size = new System.Drawing.Size(35, 23);
            this.progressBarTerm.TabIndex = 28;
            // 
            // btnTermOff
            // 
            this.btnTermOff.Enabled = false;
            this.btnTermOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTermOff.Location = new System.Drawing.Point(499, 288);
            this.btnTermOff.Name = "btnTermOff";
            this.btnTermOff.Size = new System.Drawing.Size(54, 32);
            this.btnTermOff.TabIndex = 29;
            this.btnTermOff.Text = "off";
            this.btnTermOff.UseVisualStyleBackColor = true;
            this.btnTermOff.Click += new System.EventHandler(this.btnTermOff_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(578, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Vacuum";
            // 
            // btnTermOn
            // 
            this.btnTermOn.Enabled = false;
            this.btnTermOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTermOn.Location = new System.Drawing.Point(433, 288);
            this.btnTermOn.Name = "btnTermOn";
            this.btnTermOn.Size = new System.Drawing.Size(56, 32);
            this.btnTermOn.TabIndex = 31;
            this.btnTermOn.Text = "on";
            this.btnTermOn.UseVisualStyleBackColor = true;
            this.btnTermOn.Click += new System.EventHandler(this.btnTermOn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(408, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Thermostat";
            // 
            // btnVacOn
            // 
            this.btnVacOn.Enabled = false;
            this.btnVacOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVacOn.Location = new System.Drawing.Point(582, 288);
            this.btnVacOn.Name = "btnVacOn";
            this.btnVacOn.Size = new System.Drawing.Size(56, 32);
            this.btnVacOn.TabIndex = 34;
            this.btnVacOn.Text = "on";
            this.btnVacOn.UseVisualStyleBackColor = true;
            this.btnVacOn.Click += new System.EventHandler(this.btnVacOn_Click);
            // 
            // btnVacOff
            // 
            this.btnVacOff.Enabled = false;
            this.btnVacOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVacOff.Location = new System.Drawing.Point(644, 288);
            this.btnVacOff.Name = "btnVacOff";
            this.btnVacOff.Size = new System.Drawing.Size(54, 32);
            this.btnVacOff.TabIndex = 33;
            this.btnVacOff.Text = "off";
            this.btnVacOff.UseVisualStyleBackColor = true;
            this.btnVacOff.Click += new System.EventHandler(this.btnVacOff_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(572, 222);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(146, 156);
            this.textBox3.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(407, 222);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(159, 156);
            this.textBox4.TabIndex = 36;
            // 
            // textBoxTermSet
            // 
            this.textBoxTermSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTermSet.Location = new System.Drawing.Point(437, 338);
            this.textBoxTermSet.Name = "textBoxTermSet";
            this.textBoxTermSet.Size = new System.Drawing.Size(100, 29);
            this.textBoxTermSet.TabIndex = 37;
            // 
            // textBoxVacSet
            // 
            this.textBoxVacSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxVacSet.Location = new System.Drawing.Point(582, 338);
            this.textBoxVacSet.Name = "textBoxVacSet";
            this.textBoxVacSet.Size = new System.Drawing.Size(100, 29);
            this.textBoxVacSet.TabIndex = 38;
            // 
            // textBoxPumpL
            // 
            this.textBoxPumpL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPumpL.Location = new System.Drawing.Point(422, 500);
            this.textBoxPumpL.Name = "textBoxPumpL";
            this.textBoxPumpL.Size = new System.Drawing.Size(100, 29);
            this.textBoxPumpL.TabIndex = 44;
            // 
            // btnPumpLon
            // 
            this.btnPumpLon.Enabled = false;
            this.btnPumpLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPumpLon.Location = new System.Drawing.Point(422, 450);
            this.btnPumpLon.Name = "btnPumpLon";
            this.btnPumpLon.Size = new System.Drawing.Size(56, 32);
            this.btnPumpLon.TabIndex = 42;
            this.btnPumpLon.Text = "on";
            this.btnPumpLon.UseVisualStyleBackColor = true;
            this.btnPumpLon.Click += new System.EventHandler(this.btnPumpLon_Click);
            // 
            // btnPumpLoff
            // 
            this.btnPumpLoff.Enabled = false;
            this.btnPumpLoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPumpLoff.Location = new System.Drawing.Point(484, 450);
            this.btnPumpLoff.Name = "btnPumpLoff";
            this.btnPumpLoff.Size = new System.Drawing.Size(54, 32);
            this.btnPumpLoff.TabIndex = 41;
            this.btnPumpLoff.Text = "off";
            this.btnPumpLoff.UseVisualStyleBackColor = true;
            this.btnPumpLoff.Click += new System.EventHandler(this.btnPumpLoff_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(421, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 48);
            this.label10.TabIndex = 40;
            this.label10.Text = "Pump\r\n  left";
            // 
            // progressBarPumpL
            // 
            this.progressBarPumpL.Location = new System.Drawing.Point(499, 408);
            this.progressBarPumpL.Maximum = 1;
            this.progressBarPumpL.Name = "progressBarPumpL";
            this.progressBarPumpL.Size = new System.Drawing.Size(39, 23);
            this.progressBarPumpL.TabIndex = 39;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(412, 384);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(146, 156);
            this.textBox6.TabIndex = 43;
            // 
            // textBoxPumpR
            // 
            this.textBoxPumpR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPumpR.Location = new System.Drawing.Point(582, 500);
            this.textBoxPumpR.Name = "textBoxPumpR";
            this.textBoxPumpR.Size = new System.Drawing.Size(100, 29);
            this.textBoxPumpR.TabIndex = 50;
            // 
            // btnPumpRon
            // 
            this.btnPumpRon.Enabled = false;
            this.btnPumpRon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPumpRon.Location = new System.Drawing.Point(582, 450);
            this.btnPumpRon.Name = "btnPumpRon";
            this.btnPumpRon.Size = new System.Drawing.Size(56, 32);
            this.btnPumpRon.TabIndex = 48;
            this.btnPumpRon.Text = "on";
            this.btnPumpRon.UseVisualStyleBackColor = true;
            this.btnPumpRon.Click += new System.EventHandler(this.btnPumpRon_Click);
            // 
            // btnPumpRoff
            // 
            this.btnPumpRoff.Enabled = false;
            this.btnPumpRoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPumpRoff.Location = new System.Drawing.Point(644, 450);
            this.btnPumpRoff.Name = "btnPumpRoff";
            this.btnPumpRoff.Size = new System.Drawing.Size(54, 32);
            this.btnPumpRoff.TabIndex = 47;
            this.btnPumpRoff.Text = "off";
            this.btnPumpRoff.UseVisualStyleBackColor = true;
            this.btnPumpRoff.Click += new System.EventHandler(this.btnPumpRoff_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(578, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 48);
            this.label11.TabIndex = 46;
            this.label11.Text = "Pump \r\n right";
            // 
            // progressBarPumpR
            // 
            this.progressBarPumpR.Location = new System.Drawing.Point(659, 408);
            this.progressBarPumpR.Maximum = 1;
            this.progressBarPumpR.Name = "progressBarPumpR";
            this.progressBarPumpR.Size = new System.Drawing.Size(39, 23);
            this.progressBarPumpR.TabIndex = 45;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(572, 384);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(146, 156);
            this.textBox8.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 599);
            this.Controls.Add(this.textBoxPumpR);
            this.Controls.Add(this.btnPumpRon);
            this.Controls.Add(this.btnPumpRoff);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.progressBarPumpR);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBoxPumpL);
            this.Controls.Add(this.btnPumpLon);
            this.Controls.Add(this.btnPumpLoff);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBarPumpL);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBoxVacSet);
            this.Controls.Add(this.textBoxTermSet);
            this.Controls.Add(this.btnVacOn);
            this.Controls.Add(this.btnVacOff);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTermOn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTermOff);
            this.Controls.Add(this.progressBarTerm);
            this.Controls.Add(this.progressBarVac);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStg);
            this.Controls.Add(this.textBoxVac);
            this.Controls.Add(this.textBox80L);
            this.Controls.Add(this.textBox10L);
            this.Controls.Add(this.btn_stage);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Name = "Form1";
            this.Text = "Serial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_stage;
        private System.Windows.Forms.TextBox textBox10L;
        private System.Windows.Forms.TextBox textBox80L;
        private System.Windows.Forms.TextBox textBoxVac;
        private System.Windows.Forms.TextBox textBoxStg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBarVac;
        private System.Windows.Forms.ProgressBar progressBarTerm;
        private System.Windows.Forms.Button btnTermOff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTermOn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVacOn;
        private System.Windows.Forms.Button btnVacOff;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxTermSet;
        private System.Windows.Forms.TextBox textBoxVacSet;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.TextBox textBoxPumpL;
        private System.Windows.Forms.Button btnPumpLon;
        private System.Windows.Forms.Button btnPumpLoff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBarPumpL;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBoxPumpR;
        private System.Windows.Forms.Button btnPumpRon;
        private System.Windows.Forms.Button btnPumpRoff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBarPumpR;
        private System.Windows.Forms.TextBox textBox8;
    }
}


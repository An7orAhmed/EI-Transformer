
namespace EI_Transformer_Calculator {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CWidth = new System.Windows.Forms.TextBox();
            this.WidthEnable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.TextBox();
            this.PowerEnable = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CHeight = new System.Windows.Forms.TextBox();
            this.HeightEnable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TurnVolt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Frequency = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FluxLines = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.PampList = new System.Windows.Forms.ListBox();
            this.PRemove = new System.Windows.Forms.Button();
            this.Pvolt = new System.Windows.Forms.TextBox();
            this.PSWG = new System.Windows.Forms.TextBox();
            this.PAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PturnList = new System.Windows.Forms.ListBox();
            this.PvoltList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.SampList = new System.Windows.Forms.ListBox();
            this.SRemove = new System.Windows.Forms.Button();
            this.Svolt = new System.Windows.Forms.TextBox();
            this.SSWG = new System.Windows.Forms.TextBox();
            this.SAdd = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SturnList = new System.Windows.Forms.ListBox();
            this.SvoltList = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CWidth);
            this.panel1.Controls.Add(this.WidthEnable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 115);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "in.";
            // 
            // CWidth
            // 
            this.CWidth.Location = new System.Drawing.Point(38, 26);
            this.CWidth.Name = "CWidth";
            this.CWidth.Size = new System.Drawing.Size(84, 27);
            this.CWidth.TabIndex = 3;
            this.CWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CWidth.TextChanged += new System.EventHandler(this.Width_TextChanged);
            // 
            // WidthEnable
            // 
            this.WidthEnable.AutoSize = true;
            this.WidthEnable.Location = new System.Drawing.Point(13, 33);
            this.WidthEnable.Name = "WidthEnable";
            this.WidthEnable.Size = new System.Drawing.Size(15, 14);
            this.WidthEnable.TabIndex = 2;
            this.WidthEnable.UseVisualStyleBackColor = true;
            this.WidthEnable.CheckedChanged += new System.EventHandler(this.WidthEnable_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Core Width";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Power);
            this.panel2.Controls.Add(this.PowerEnable);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(392, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 115);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "VA";
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(39, 26);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(79, 27);
            this.Power.TabIndex = 4;
            this.Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Power.TextChanged += new System.EventHandler(this.Power_TextChanged);
            // 
            // PowerEnable
            // 
            this.PowerEnable.AutoSize = true;
            this.PowerEnable.Location = new System.Drawing.Point(14, 33);
            this.PowerEnable.Name = "PowerEnable";
            this.PowerEnable.Size = new System.Drawing.Size(15, 14);
            this.PowerEnable.TabIndex = 2;
            this.PowerEnable.UseVisualStyleBackColor = true;
            this.PowerEnable.CheckedChanged += new System.EventHandler(this.PowerEnable_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Power";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.CHeight);
            this.panel3.Controls.Add(this.HeightEnable);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(204, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 115);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "in.";
            // 
            // CHeight
            // 
            this.CHeight.Location = new System.Drawing.Point(41, 26);
            this.CHeight.Name = "CHeight";
            this.CHeight.Size = new System.Drawing.Size(81, 27);
            this.CHeight.TabIndex = 5;
            this.CHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHeight.TextChanged += new System.EventHandler(this.Height_TextChanged);
            // 
            // HeightEnable
            // 
            this.HeightEnable.AutoSize = true;
            this.HeightEnable.Location = new System.Drawing.Point(16, 33);
            this.HeightEnable.Name = "HeightEnable";
            this.HeightEnable.Size = new System.Drawing.Size(15, 14);
            this.HeightEnable.TabIndex = 2;
            this.HeightEnable.UseVisualStyleBackColor = true;
            this.HeightEnable.CheckedChanged += new System.EventHandler(this.HeightEnable_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-1, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Core Height";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.TurnVolt);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(392, 160);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 115);
            this.panel5.TabIndex = 4;
            // 
            // TurnVolt
            // 
            this.TurnVolt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TurnVolt.ForeColor = System.Drawing.Color.Green;
            this.TurnVolt.Location = new System.Drawing.Point(26, 25);
            this.TurnVolt.Name = "TurnVolt";
            this.TurnVolt.ReadOnly = true;
            this.TurnVolt.Size = new System.Drawing.Size(112, 33);
            this.TurnVolt.TabIndex = 4;
            this.TurnVolt.Text = "0";
            this.TurnVolt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.MidnightBlue;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-1, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "Turn Per Volt";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.Frequency);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(16, 160);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(164, 115);
            this.panel6.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Hz";
            // 
            // Frequency
            // 
            this.Frequency.Location = new System.Drawing.Point(18, 26);
            this.Frequency.Name = "Frequency";
            this.Frequency.Size = new System.Drawing.Size(99, 27);
            this.Frequency.TabIndex = 3;
            this.Frequency.Text = "50";
            this.Frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Frequency.TextChanged += new System.EventHandler(this.Frequency_TextChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.MidnightBlue;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-1, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Frequency";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.FluxLines);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(204, 160);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 115);
            this.panel4.TabIndex = 5;
            // 
            // FluxLines
            // 
            this.FluxLines.Location = new System.Drawing.Point(24, 26);
            this.FluxLines.Name = "FluxLines";
            this.FluxLines.Size = new System.Drawing.Size(114, 27);
            this.FluxLines.TabIndex = 3;
            this.FluxLines.Text = "62000";
            this.FluxLines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FluxLines.TextChanged += new System.EventHandler(this.FluxLines_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.MidnightBlue;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-1, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Flux Lines";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(576, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Link.Location = new System.Drawing.Point(578, 246);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(279, 24);
            this.Link.TabIndex = 7;
            this.Link.TabStop = true;
            this.Link.Text = ".:: DEVELOPED BY ANTOR ::.";
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.PampList);
            this.panel7.Controls.Add(this.PRemove);
            this.panel7.Controls.Add(this.Pvolt);
            this.panel7.Controls.Add(this.PSWG);
            this.panel7.Controls.Add(this.PAdd);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.PturnList);
            this.panel7.Controls.Add(this.PvoltList);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(16, 296);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(408, 269);
            this.panel7.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(268, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 21);
            this.label15.TabIndex = 10;
            this.label15.Text = "Amps List:";
            // 
            // PampList
            // 
            this.PampList.FormattingEnabled = true;
            this.PampList.ItemHeight = 21;
            this.PampList.Location = new System.Drawing.Point(268, 42);
            this.PampList.Name = "PampList";
            this.PampList.Size = new System.Drawing.Size(115, 130);
            this.PampList.TabIndex = 9;
            this.PampList.SelectedIndexChanged += new System.EventHandler(this.PampList_SelectedIndexChanged);
            // 
            // PRemove
            // 
            this.PRemove.Location = new System.Drawing.Point(187, 185);
            this.PRemove.Name = "PRemove";
            this.PRemove.Size = new System.Drawing.Size(38, 33);
            this.PRemove.TabIndex = 8;
            this.PRemove.Text = "-";
            this.PRemove.UseVisualStyleBackColor = true;
            this.PRemove.Click += new System.EventHandler(this.PrimaryRemove_Click);
            // 
            // Pvolt
            // 
            this.Pvolt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pvolt.ForeColor = System.Drawing.Color.Green;
            this.Pvolt.Location = new System.Drawing.Point(25, 186);
            this.Pvolt.Name = "Pvolt";
            this.Pvolt.Size = new System.Drawing.Size(113, 31);
            this.Pvolt.TabIndex = 7;
            this.Pvolt.Text = "0";
            this.Pvolt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PSWG
            // 
            this.PSWG.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PSWG.ForeColor = System.Drawing.Color.Green;
            this.PSWG.Location = new System.Drawing.Point(311, 185);
            this.PSWG.Name = "PSWG";
            this.PSWG.ReadOnly = true;
            this.PSWG.Size = new System.Drawing.Size(72, 31);
            this.PSWG.TabIndex = 5;
            this.PSWG.Text = "0";
            this.PSWG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PAdd
            // 
            this.PAdd.Location = new System.Drawing.Point(145, 185);
            this.PAdd.Name = "PAdd";
            this.PAdd.Size = new System.Drawing.Size(38, 33);
            this.PAdd.TabIndex = 6;
            this.PAdd.Text = "+";
            this.PAdd.UseVisualStyleBackColor = true;
            this.PAdd.Click += new System.EventHandler(this.PrimaryAdd_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(238, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 21);
            this.label14.TabIndex = 5;
            this.label14.Text = "SWG #:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(145, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "Turns List:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "Volts List:";
            // 
            // PturnList
            // 
            this.PturnList.FormattingEnabled = true;
            this.PturnList.ItemHeight = 21;
            this.PturnList.Location = new System.Drawing.Point(145, 42);
            this.PturnList.Name = "PturnList";
            this.PturnList.Size = new System.Drawing.Size(115, 130);
            this.PturnList.TabIndex = 2;
            // 
            // PvoltList
            // 
            this.PvoltList.FormattingEnabled = true;
            this.PvoltList.ItemHeight = 21;
            this.PvoltList.Location = new System.Drawing.Point(25, 42);
            this.PvoltList.Name = "PvoltList";
            this.PvoltList.Size = new System.Drawing.Size(113, 130);
            this.PvoltList.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-1, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(408, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Primary Coil";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.SampList);
            this.panel8.Controls.Add(this.SRemove);
            this.panel8.Controls.Add(this.Svolt);
            this.panel8.Controls.Add(this.SSWG);
            this.panel8.Controls.Add(this.SAdd);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.SturnList);
            this.panel8.Controls.Add(this.SvoltList);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Location = new System.Drawing.Point(452, 296);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(408, 269);
            this.panel8.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(268, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 21);
            this.label16.TabIndex = 10;
            this.label16.Text = "Amps List:";
            // 
            // SampList
            // 
            this.SampList.FormattingEnabled = true;
            this.SampList.ItemHeight = 21;
            this.SampList.Location = new System.Drawing.Point(268, 42);
            this.SampList.Name = "SampList";
            this.SampList.Size = new System.Drawing.Size(115, 130);
            this.SampList.TabIndex = 9;
            this.SampList.SelectedIndexChanged += new System.EventHandler(this.SampList_SelectedIndexChanged);
            // 
            // SRemove
            // 
            this.SRemove.Location = new System.Drawing.Point(187, 185);
            this.SRemove.Name = "SRemove";
            this.SRemove.Size = new System.Drawing.Size(38, 33);
            this.SRemove.TabIndex = 8;
            this.SRemove.Text = "-";
            this.SRemove.UseVisualStyleBackColor = true;
            this.SRemove.Click += new System.EventHandler(this.SRemove_Click);
            // 
            // Svolt
            // 
            this.Svolt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Svolt.ForeColor = System.Drawing.Color.Green;
            this.Svolt.Location = new System.Drawing.Point(25, 186);
            this.Svolt.Name = "Svolt";
            this.Svolt.Size = new System.Drawing.Size(113, 31);
            this.Svolt.TabIndex = 7;
            this.Svolt.Text = "0";
            this.Svolt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SSWG
            // 
            this.SSWG.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SSWG.ForeColor = System.Drawing.Color.Green;
            this.SSWG.Location = new System.Drawing.Point(311, 185);
            this.SSWG.Name = "SSWG";
            this.SSWG.ReadOnly = true;
            this.SSWG.Size = new System.Drawing.Size(72, 31);
            this.SSWG.TabIndex = 5;
            this.SSWG.Text = "0";
            this.SSWG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SAdd
            // 
            this.SAdd.Location = new System.Drawing.Point(145, 185);
            this.SAdd.Name = "SAdd";
            this.SAdd.Size = new System.Drawing.Size(38, 33);
            this.SAdd.TabIndex = 6;
            this.SAdd.Text = "+";
            this.SAdd.UseVisualStyleBackColor = true;
            this.SAdd.Click += new System.EventHandler(this.SAdd_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(238, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 21);
            this.label17.TabIndex = 5;
            this.label17.Text = "SWG #:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(145, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 21);
            this.label18.TabIndex = 4;
            this.label18.Text = "Turns List:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 21);
            this.label19.TabIndex = 3;
            this.label19.Text = "Volts List:";
            // 
            // SturnList
            // 
            this.SturnList.FormattingEnabled = true;
            this.SturnList.ItemHeight = 21;
            this.SturnList.Location = new System.Drawing.Point(145, 42);
            this.SturnList.Name = "SturnList";
            this.SturnList.Size = new System.Drawing.Size(115, 130);
            this.SturnList.TabIndex = 2;
            // 
            // SvoltList
            // 
            this.SvoltList.FormattingEnabled = true;
            this.SvoltList.ItemHeight = 21;
            this.SvoltList.Location = new System.Drawing.Point(25, 42);
            this.SvoltList.Name = "SvoltList";
            this.SvoltList.Size = new System.Drawing.Size(113, 130);
            this.SvoltList.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.MidnightBlue;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(-1, 235);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(408, 32);
            this.label20.TabIndex = 0;
            this.label20.Text = "Secondary Coil";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(876, 588);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EI Transformer Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox WidthEnable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox PowerEnable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox HeightEnable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CWidth;
        private System.Windows.Forms.TextBox Power;
        private System.Windows.Forms.TextBox CHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TurnVolt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Frequency;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox FluxLines;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox PturnList;
        private System.Windows.Forms.ListBox PvoltList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PSWG;
        private System.Windows.Forms.Button PAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Pvolt;
        private System.Windows.Forms.Button PRemove;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox PampList;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox SampList;
        private System.Windows.Forms.Button SRemove;
        private System.Windows.Forms.TextBox Svolt;
        private System.Windows.Forms.TextBox SSWG;
        private System.Windows.Forms.Button SAdd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox SturnList;
        private System.Windows.Forms.ListBox SvoltList;
        private System.Windows.Forms.Label label20;
    }
}


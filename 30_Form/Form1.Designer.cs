namespace _30_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Clock = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl_log = new System.Windows.Forms.Panel();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_screen = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_addvalue = new System.Windows.Forms.Button();
            this.grp_settings = new System.Windows.Forms.GroupBox();
            this.btn_Clock = new System.Windows.Forms.Button();
            this.lbl_Opacity = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ch_TopMost = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.pnl_log.SuspendLayout();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grp_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_Clock});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clock.LinkColor = System.Drawing.Color.Red;
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(59, 20);
            this.lbl_Clock.Text = "SAAT";
            // 
            // pnl_log
            // 
            this.pnl_log.Controls.Add(this.txt_log);
            this.pnl_log.Controls.Add(this.button1);
            this.pnl_log.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_log.Location = new System.Drawing.Point(545, 0);
            this.pnl_log.Name = "pnl_log";
            this.pnl_log.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_log.Size = new System.Drawing.Size(255, 424);
            this.pnl_log.TabIndex = 3;
            // 
            // txt_log
            // 
            this.txt_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_log.Location = new System.Drawing.Point(10, 10);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.Size = new System.Drawing.Size(235, 365);
            this.txt_log.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(10, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Padding = new System.Windows.Forms.Padding(10);
            this.pnl_header.Size = new System.Drawing.Size(545, 57);
            this.pnl_header.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap Makinası";
            // 
            // txt_screen
            // 
            this.txt_screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_screen.Location = new System.Drawing.Point(31, 63);
            this.txt_screen.Name = "txt_screen";
            this.txt_screen.ReadOnly = true;
            this.txt_screen.Size = new System.Drawing.Size(338, 34);
            this.txt_screen.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(31, 103);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(93, 49);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(134, 103);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 49);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(236, 103);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(93, 49);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(31, 158);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(93, 49);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(134, 158);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(93, 49);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(236, 158);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(93, 49);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(31, 213);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(93, 49);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(134, 213);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(93, 49);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(236, 213);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(93, 49);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(134, 268);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(93, 49);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(385, 63);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 38);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btn_addvalue
            // 
            this.btn_addvalue.Location = new System.Drawing.Point(455, 63);
            this.btn_addvalue.Name = "btn_addvalue";
            this.btn_addvalue.Size = new System.Drawing.Size(79, 38);
            this.btn_addvalue.TabIndex = 17;
            this.btn_addvalue.Text = "Add Value";
            this.btn_addvalue.UseVisualStyleBackColor = true;
            this.btn_addvalue.Click += new System.EventHandler(this.btn_addvalue_Click);
            // 
            // grp_settings
            // 
            this.grp_settings.Controls.Add(this.btn_Clock);
            this.grp_settings.Controls.Add(this.lbl_Opacity);
            this.grp_settings.Controls.Add(this.trackBar1);
            this.grp_settings.Controls.Add(this.ch_TopMost);
            this.grp_settings.Controls.Add(this.checkBox1);
            this.grp_settings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp_settings.Location = new System.Drawing.Point(0, 323);
            this.grp_settings.Name = "grp_settings";
            this.grp_settings.Size = new System.Drawing.Size(545, 101);
            this.grp_settings.TabIndex = 18;
            this.grp_settings.TabStop = false;
            this.grp_settings.Text = "Ayarlar";
            // 
            // btn_Clock
            // 
            this.btn_Clock.Location = new System.Drawing.Point(325, 46);
            this.btn_Clock.Name = "btn_Clock";
            this.btn_Clock.Size = new System.Drawing.Size(75, 23);
            this.btn_Clock.TabIndex = 6;
            this.btn_Clock.Text = "Saati Aç";
            this.btn_Clock.UseVisualStyleBackColor = true;
            this.btn_Clock.Click += new System.EventHandler(this.btn_Clock_Click);
            // 
            // lbl_Opacity
            // 
            this.lbl_Opacity.AutoSize = true;
            this.lbl_Opacity.Location = new System.Drawing.Point(242, 49);
            this.lbl_Opacity.Name = "lbl_Opacity";
            this.lbl_Opacity.Size = new System.Drawing.Size(53, 16);
            this.lbl_Opacity.TabIndex = 5;
            this.lbl_Opacity.Text = "Opacity";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 42);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(230, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ch_TopMost
            // 
            this.ch_TopMost.AutoSize = true;
            this.ch_TopMost.Location = new System.Drawing.Point(6, 18);
            this.ch_TopMost.Name = "ch_TopMost";
            this.ch_TopMost.Size = new System.Drawing.Size(79, 20);
            this.ch_TopMost.TabIndex = 3;
            this.ch_TopMost.Text = "En Üstte";
            this.ch_TopMost.UseVisualStyleBackColor = true;
            this.ch_TopMost.CheckedChanged += new System.EventHandler(this.ch_TopMost_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Location = new System.Drawing.Point(455, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 80);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Günce Aç";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_settings);
            this.Controls.Add(this.btn_addvalue);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt_screen);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_log);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hesap Makinam_v1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnl_log.ResumeLayout(false);
            this.pnl_log.PerformLayout();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grp_settings.ResumeLayout(false);
            this.grp_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel pnl_log;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_screen;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_addvalue;
        private System.Windows.Forms.GroupBox grp_settings;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ch_TopMost;
        private System.Windows.Forms.Label lbl_Opacity;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_Clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Clock;
    }
}


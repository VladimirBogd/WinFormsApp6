namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSpreading = new System.Windows.Forms.Label();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGraviton1 = new System.Windows.Forms.Label();
            this.tbGraviton1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGraviton2 = new System.Windows.Forms.Label();
            this.tbGraviton2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPartPerTick = new System.Windows.Forms.Label();
            this.tbPartPerTick = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.tbLife = new System.Windows.Forms.TrackBar();
            this.lblPartCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPartPerTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLife)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(2, 2);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(550, 350);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.AccessibleName = "";
            this.tbDirection.LargeChange = 10;
            this.tbDirection.Location = new System.Drawing.Point(558, 148);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(150, 45);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Tag = "";
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(714, 163);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(18, 15);
            this.lblDirection.TabIndex = 2;
            this.lblDirection.Text = "0°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Разброс";
            // 
            // lblSpreading
            // 
            this.lblSpreading.AutoSize = true;
            this.lblSpreading.Location = new System.Drawing.Point(714, 229);
            this.lblSpreading.Name = "lblSpreading";
            this.lblSpreading.Size = new System.Drawing.Size(18, 15);
            this.lblSpreading.TabIndex = 5;
            this.lblSpreading.Text = "0°";
            // 
            // tbSpreading
            // 
            this.tbSpreading.AccessibleName = "";
            this.tbSpreading.LargeChange = 10;
            this.tbSpreading.Location = new System.Drawing.Point(558, 214);
            this.tbSpreading.Maximum = 359;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(150, 45);
            this.tbSpreading.TabIndex = 4;
            this.tbSpreading.Tag = "";
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Гравитон 1";
            // 
            // lblGraviton1
            // 
            this.lblGraviton1.AutoSize = true;
            this.lblGraviton1.Location = new System.Drawing.Point(158, 388);
            this.lblGraviton1.Name = "lblGraviton1";
            this.lblGraviton1.Size = new System.Drawing.Size(13, 15);
            this.lblGraviton1.TabIndex = 8;
            this.lblGraviton1.Text = "0";
            // 
            // tbGraviton1
            // 
            this.tbGraviton1.AccessibleName = "";
            this.tbGraviton1.LargeChange = 10;
            this.tbGraviton1.Location = new System.Drawing.Point(2, 373);
            this.tbGraviton1.Maximum = 100;
            this.tbGraviton1.Name = "tbGraviton1";
            this.tbGraviton1.Size = new System.Drawing.Size(150, 45);
            this.tbGraviton1.TabIndex = 7;
            this.tbGraviton1.Tag = "";
            this.tbGraviton1.Scroll += new System.EventHandler(this.tbGraviton_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Гравитон 2";
            // 
            // lblGraviton2
            // 
            this.lblGraviton2.AutoSize = true;
            this.lblGraviton2.Location = new System.Drawing.Point(342, 388);
            this.lblGraviton2.Name = "lblGraviton2";
            this.lblGraviton2.Size = new System.Drawing.Size(13, 15);
            this.lblGraviton2.TabIndex = 11;
            this.lblGraviton2.Text = "0";
            // 
            // tbGraviton2
            // 
            this.tbGraviton2.AccessibleName = "";
            this.tbGraviton2.LargeChange = 10;
            this.tbGraviton2.Location = new System.Drawing.Point(186, 373);
            this.tbGraviton2.Maximum = 100;
            this.tbGraviton2.Name = "tbGraviton2";
            this.tbGraviton2.Size = new System.Drawing.Size(150, 45);
            this.tbGraviton2.TabIndex = 10;
            this.tbGraviton2.Tag = "";
            this.tbGraviton2.Scroll += new System.EventHandler(this.tbGraviton2_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Скорость";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(714, 299);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(13, 15);
            this.lblSpeed.TabIndex = 14;
            this.lblSpeed.Text = "0";
            // 
            // tbSpeed
            // 
            this.tbSpeed.AccessibleName = "";
            this.tbSpeed.LargeChange = 2;
            this.tbSpeed.Location = new System.Drawing.Point(558, 284);
            this.tbSpeed.Maximum = 20;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(150, 45);
            this.tbSpeed.TabIndex = 13;
            this.tbSpeed.Tag = "";
            this.tbSpeed.Value = 10;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Количество частиц в тик";
            // 
            // lblPartPerTick
            // 
            this.lblPartPerTick.AutoSize = true;
            this.lblPartPerTick.Location = new System.Drawing.Point(714, 35);
            this.lblPartPerTick.Name = "lblPartPerTick";
            this.lblPartPerTick.Size = new System.Drawing.Size(13, 15);
            this.lblPartPerTick.TabIndex = 17;
            this.lblPartPerTick.Text = "0";
            // 
            // tbPartPerTick
            // 
            this.tbPartPerTick.AccessibleName = "";
            this.tbPartPerTick.LargeChange = 2;
            this.tbPartPerTick.Location = new System.Drawing.Point(558, 20);
            this.tbPartPerTick.Maximum = 30;
            this.tbPartPerTick.Name = "tbPartPerTick";
            this.tbPartPerTick.Size = new System.Drawing.Size(150, 45);
            this.tbPartPerTick.TabIndex = 16;
            this.tbPartPerTick.Tag = "";
            this.tbPartPerTick.Value = 10;
            this.tbPartPerTick.Scroll += new System.EventHandler(this.tbPartPerTick_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Продолжительность жизни";
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Location = new System.Drawing.Point(714, 101);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(13, 15);
            this.lblLife.TabIndex = 20;
            this.lblLife.Text = "0";
            // 
            // tbLife
            // 
            this.tbLife.AccessibleName = "";
            this.tbLife.LargeChange = 10;
            this.tbLife.Location = new System.Drawing.Point(558, 86);
            this.tbLife.Maximum = 100;
            this.tbLife.Name = "tbLife";
            this.tbLife.Size = new System.Drawing.Size(150, 45);
            this.tbLife.TabIndex = 19;
            this.tbLife.Tag = "";
            this.tbLife.Value = 50;
            this.tbLife.Scroll += new System.EventHandler(this.tbLife_Scroll);
            // 
            // lblPartCount
            // 
            this.lblPartCount.AutoSize = true;
            this.lblPartCount.Location = new System.Drawing.Point(558, 332);
            this.lblPartCount.Name = "lblPartCount";
            this.lblPartCount.Size = new System.Drawing.Size(116, 15);
            this.lblPartCount.TabIndex = 22;
            this.lblPartCount.Text = "Количество частиц:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 423);
            this.Controls.Add(this.lblPartCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.tbLife);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPartPerTick);
            this.Controls.Add(this.tbPartPerTick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGraviton2);
            this.Controls.Add(this.tbGraviton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGraviton1);
            this.Controls.Add(this.tbGraviton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSpreading);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Частицы";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPartPerTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLife)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private TrackBar tbDirection;
        private Label lblDirection;
        private Label label1;
        private Label label2;
        private Label lblSpreading;
        private TrackBar tbSpreading;
        private Label label3;
        private Label lblGraviton1;
        private TrackBar tbGraviton1;
        private Label label4;
        private Label lblGraviton2;
        private TrackBar tbGraviton2;
        private Label label5;
        private Label lblSpeed;
        private TrackBar tbSpeed;
        private Label label6;
        private Label lblPartPerTick;
        private TrackBar tbPartPerTick;
        private Label label7;
        private Label lblLife;
        private TrackBar tbLife;
        private Label lblPartCount;
    }
}

namespace Q01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckInTime = new System.Windows.Forms.DateTimePicker();
            this.CheckOutTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Date_Display = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NonSub0 = new System.Windows.Forms.RadioButton();
            this.Sub10 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Single = new System.Windows.Forms.RadioButton();
            this.Double = new System.Windows.Forms.RadioButton();
            this.Suite = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Total_Price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check Out";
            // 
            // CheckInTime
            // 
            this.CheckInTime.Location = new System.Drawing.Point(320, 61);
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.Size = new System.Drawing.Size(200, 26);
            this.CheckInTime.TabIndex = 2;
            this.CheckInTime.ValueChanged += new System.EventHandler(this.CheckInTime_ValueChanged);
            // 
            // CheckOutTime
            // 
            this.CheckOutTime.Location = new System.Drawing.Point(320, 130);
            this.CheckOutTime.Name = "CheckOutTime";
            this.CheckOutTime.Size = new System.Drawing.Size(200, 26);
            this.CheckOutTime.TabIndex = 3;
            this.CheckOutTime.ValueChanged += new System.EventHandler(this.CheckOutTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "จำนวนชั่วโมง";
            // 
            // Date_Display
            // 
            this.Date_Display.Location = new System.Drawing.Point(320, 197);
            this.Date_Display.Name = "Date_Display";
            this.Date_Display.ReadOnly = true;
            this.Date_Display.Size = new System.Drawing.Size(200, 26);
            this.Date_Display.TabIndex = 5;
            this.Date_Display.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sub10);
            this.groupBox1.Controls.Add(this.NonSub0);
            this.groupBox1.Location = new System.Drawing.Point(241, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ส่วนลด";
            // 
            // NonSub0
            // 
            this.NonSub0.AutoSize = true;
            this.NonSub0.Location = new System.Drawing.Point(65, 42);
            this.NonSub0.Name = "NonSub0";
            this.NonSub0.Size = new System.Drawing.Size(155, 24);
            this.NonSub0.TabIndex = 0;
            this.NonSub0.TabStop = true;
            this.NonSub0.Text = "ไม่เป็นสมาชิก (0%)";
            this.NonSub0.UseVisualStyleBackColor = true;
            this.NonSub0.CheckedChanged += new System.EventHandler(this.NonSub0_CheckedChanged);
            // 
            // Sub10
            // 
            this.Sub10.AutoSize = true;
            this.Sub10.Location = new System.Drawing.Point(344, 42);
            this.Sub10.Name = "Sub10";
            this.Sub10.Size = new System.Drawing.Size(123, 24);
            this.Sub10.TabIndex = 1;
            this.Sub10.TabStop = true;
            this.Sub10.Text = "สมาชิก (10%)";
            this.Sub10.UseVisualStyleBackColor = true;
            this.Sub10.CheckedChanged += new System.EventHandler(this.Sub10_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Suite);
            this.groupBox2.Controls.Add(this.Double);
            this.groupBox2.Controls.Add(this.Single);
            this.groupBox2.Location = new System.Drawing.Point(241, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ประเภทห้อง";
            // 
            // Single
            // 
            this.Single.AutoSize = true;
            this.Single.Location = new System.Drawing.Point(37, 41);
            this.Single.Name = "Single";
            this.Single.Size = new System.Drawing.Size(149, 24);
            this.Single.TabIndex = 0;
            this.Single.TabStop = true;
            this.Single.Text = "Single (500 บาท)";
            this.Single.UseVisualStyleBackColor = true;
            this.Single.CheckedChanged += new System.EventHandler(this.Single_CheckedChanged);
            // 
            // Double
            // 
            this.Double.AutoSize = true;
            this.Double.Location = new System.Drawing.Point(247, 41);
            this.Double.Name = "Double";
            this.Double.Size = new System.Drawing.Size(156, 24);
            this.Double.TabIndex = 1;
            this.Double.TabStop = true;
            this.Double.Text = "Double (700 บาท)";
            this.Double.UseVisualStyleBackColor = true;
            this.Double.CheckedChanged += new System.EventHandler(this.Double_CheckedChanged);
            // 
            // Suite
            // 
            this.Suite.AutoSize = true;
            this.Suite.Location = new System.Drawing.Point(459, 41);
            this.Suite.Name = "Suite";
            this.Suite.Size = new System.Drawing.Size(151, 24);
            this.Suite.TabIndex = 2;
            this.Suite.TabStop = true;
            this.Suite.Text = "Suite (1100 บาท)";
            this.Suite.UseVisualStyleBackColor = true;
            this.Suite.CheckedChanged += new System.EventHandler(this.Suite_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "รวม";
            // 
            // Total_Price
            // 
            this.Total_Price.Location = new System.Drawing.Point(320, 611);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.ReadOnly = true;
            this.Total_Price.Size = new System.Drawing.Size(200, 26);
            this.Total_Price.TabIndex = 9;
            this.Total_Price.TextChanged += new System.EventHandler(this.Total_Price_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 693);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "คำนวณ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 790);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Total_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Date_Display);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckOutTime);
            this.Controls.Add(this.CheckInTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker CheckInTime;
        private System.Windows.Forms.DateTimePicker CheckOutTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Date_Display;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Sub10;
        private System.Windows.Forms.RadioButton NonSub0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Suite;
        private System.Windows.Forms.RadioButton Double;
        private System.Windows.Forms.RadioButton Single;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Total_Price;
        private System.Windows.Forms.Button button1;
    }
}


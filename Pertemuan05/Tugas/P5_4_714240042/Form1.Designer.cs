namespace P5_4_714240042
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
            this.NameLB = new System.Windows.Forms.Label();
            this.GenderLB = new System.Windows.Forms.Label();
            this.Birthdate = new System.Windows.Forms.Label();
            this.NamePlaceholder = new System.Windows.Forms.TextBox();
            this.GenderChoose = new System.Windows.Forms.ComboBox();
            this.DateSelect = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Football = new System.Windows.Forms.CheckBox();
            this.Swim = new System.Windows.Forms.CheckBox();
            this.Tenis = new System.Windows.Forms.CheckBox();
            this.Yoga = new System.Windows.Forms.CheckBox();
            this.Archery = new System.Windows.Forms.CheckBox();
            this.Basket = new System.Windows.Forms.CheckBox();
            this.Volly = new System.Windows.Forms.CheckBox();
            this.Badminton = new System.Windows.Forms.CheckBox();
            this.Schedule = new System.Windows.Forms.GroupBox();
            this.Day1 = new System.Windows.Forms.RadioButton();
            this.Day2 = new System.Windows.Forms.RadioButton();
            this.Day3 = new System.Windows.Forms.RadioButton();
            this.Day4 = new System.Windows.Forms.RadioButton();
            this.Show = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Tittle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Schedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Location = new System.Drawing.Point(241, 75);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(38, 13);
            this.NameLB.TabIndex = 0;
            this.NameLB.Text = "NAMA";
            this.NameLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // GenderLB
            // 
            this.GenderLB.AutoSize = true;
            this.GenderLB.Location = new System.Drawing.Point(241, 116);
            this.GenderLB.Name = "GenderLB";
            this.GenderLB.Size = new System.Drawing.Size(71, 13);
            this.GenderLB.TabIndex = 1;
            this.GenderLB.Text = "Jenis Kelamin";
            // 
            // Birthdate
            // 
            this.Birthdate.AutoSize = true;
            this.Birthdate.Location = new System.Drawing.Point(241, 161);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(72, 13);
            this.Birthdate.TabIndex = 2;
            this.Birthdate.Text = "Tanggal Lahir";
            // 
            // NamePlaceholder
            // 
            this.NamePlaceholder.Location = new System.Drawing.Point(439, 68);
            this.NamePlaceholder.MaxLength = 30;
            this.NamePlaceholder.Name = "NamePlaceholder";
            this.NamePlaceholder.Size = new System.Drawing.Size(100, 20);
            this.NamePlaceholder.TabIndex = 3;
            // 
            // GenderChoose
            // 
            this.GenderChoose.FormattingEnabled = true;
            this.GenderChoose.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.GenderChoose.Location = new System.Drawing.Point(439, 113);
            this.GenderChoose.Name = "GenderChoose";
            this.GenderChoose.Size = new System.Drawing.Size(121, 21);
            this.GenderChoose.TabIndex = 4;
            this.GenderChoose.Text = "--Pilih Jenis Kelamin--";
            this.GenderChoose.SelectedIndexChanged += new System.EventHandler(this.GenderChoose_SelectedIndexChanged);
            // 
            // DateSelect
            // 
            this.DateSelect.Location = new System.Drawing.Point(439, 161);
            this.DateSelect.Name = "DateSelect";
            this.DateSelect.Size = new System.Drawing.Size(200, 20);
            this.DateSelect.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Football);
            this.groupBox1.Controls.Add(this.Swim);
            this.groupBox1.Controls.Add(this.Tenis);
            this.groupBox1.Controls.Add(this.Yoga);
            this.groupBox1.Controls.Add(this.Archery);
            this.groupBox1.Controls.Add(this.Basket);
            this.groupBox1.Controls.Add(this.Volly);
            this.groupBox1.Controls.Add(this.Badminton);
            this.groupBox1.Location = new System.Drawing.Point(131, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 216);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // Football
            // 
            this.Football.AutoSize = true;
            this.Football.Location = new System.Drawing.Point(19, 33);
            this.Football.Name = "Football";
            this.Football.Size = new System.Drawing.Size(81, 17);
            this.Football.TabIndex = 11;
            this.Football.Text = "Sepak Bola";
            this.Football.UseVisualStyleBackColor = true;
            // 
            // Swim
            // 
            this.Swim.AutoSize = true;
            this.Swim.Location = new System.Drawing.Point(19, 79);
            this.Swim.Name = "Swim";
            this.Swim.Size = new System.Drawing.Size(64, 17);
            this.Swim.TabIndex = 12;
            this.Swim.Text = "Renang";
            this.Swim.UseVisualStyleBackColor = true;
            // 
            // Tenis
            // 
            this.Tenis.AutoSize = true;
            this.Tenis.Location = new System.Drawing.Point(19, 121);
            this.Tenis.Name = "Tenis";
            this.Tenis.Size = new System.Drawing.Size(52, 17);
            this.Tenis.TabIndex = 13;
            this.Tenis.Text = "Tenis";
            this.Tenis.UseVisualStyleBackColor = true;
            // 
            // Yoga
            // 
            this.Yoga.AutoSize = true;
            this.Yoga.Location = new System.Drawing.Point(19, 170);
            this.Yoga.Name = "Yoga";
            this.Yoga.Size = new System.Drawing.Size(51, 17);
            this.Yoga.TabIndex = 14;
            this.Yoga.Text = "Yoga";
            this.Yoga.UseVisualStyleBackColor = true;
            // 
            // Archery
            // 
            this.Archery.AutoSize = true;
            this.Archery.Location = new System.Drawing.Point(162, 170);
            this.Archery.Name = "Archery";
            this.Archery.Size = new System.Drawing.Size(69, 17);
            this.Archery.TabIndex = 18;
            this.Archery.Text = "Panahan";
            this.Archery.UseVisualStyleBackColor = true;
            // 
            // Basket
            // 
            this.Basket.AutoSize = true;
            this.Basket.Location = new System.Drawing.Point(162, 33);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(59, 17);
            this.Basket.TabIndex = 15;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // Volly
            // 
            this.Volly.AutoSize = true;
            this.Volly.Location = new System.Drawing.Point(162, 120);
            this.Volly.Name = "Volly";
            this.Volly.Size = new System.Drawing.Size(43, 17);
            this.Volly.TabIndex = 17;
            this.Volly.Text = "Voli";
            this.Volly.UseVisualStyleBackColor = true;
            // 
            // Badminton
            // 
            this.Badminton.AutoSize = true;
            this.Badminton.Location = new System.Drawing.Point(162, 78);
            this.Badminton.Name = "Badminton";
            this.Badminton.Size = new System.Drawing.Size(88, 17);
            this.Badminton.TabIndex = 16;
            this.Badminton.Text = "Bulu Tangkis";
            this.Badminton.UseVisualStyleBackColor = true;
            // 
            // Schedule
            // 
            this.Schedule.Controls.Add(this.Day1);
            this.Schedule.Controls.Add(this.Day2);
            this.Schedule.Controls.Add(this.Day3);
            this.Schedule.Controls.Add(this.Day4);
            this.Schedule.Location = new System.Drawing.Point(455, 227);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(272, 216);
            this.Schedule.TabIndex = 0;
            this.Schedule.TabStop = false;
            this.Schedule.Text = "Pilihan Jadwal";
            this.Schedule.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Day1
            // 
            this.Day1.AutoSize = true;
            this.Day1.Location = new System.Drawing.Point(18, 33);
            this.Day1.Name = "Day1";
            this.Day1.Size = new System.Drawing.Size(169, 17);
            this.Day1.TabIndex = 7;
            this.Day1.TabStop = true;
            this.Day1.Text = "Senin s/d Rabu, 14.00 - 16.00";
            this.Day1.UseVisualStyleBackColor = true;
            this.Day1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Day2
            // 
            this.Day2.AutoSize = true;
            this.Day2.Location = new System.Drawing.Point(18, 78);
            this.Day2.Name = "Day2";
            this.Day2.Size = new System.Drawing.Size(176, 17);
            this.Day2.TabIndex = 8;
            this.Day2.TabStop = true;
            this.Day2.Text = "Selasa s/d Kamis, 14.00 - 16.00";
            this.Day2.UseVisualStyleBackColor = true;
            this.Day2.CheckedChanged += new System.EventHandler(this.Day2_CheckedChanged);
            // 
            // Day3
            // 
            this.Day3.AutoSize = true;
            this.Day3.Location = new System.Drawing.Point(18, 120);
            this.Day3.Name = "Day3";
            this.Day3.Size = new System.Drawing.Size(179, 17);
            this.Day3.TabIndex = 9;
            this.Day3.TabStop = true;
            this.Day3.Text = "Sabtu s/d Minggu, 09.00 - 11.00";
            this.Day3.UseVisualStyleBackColor = true;
            // 
            // Day4
            // 
            this.Day4.AutoSize = true;
            this.Day4.Location = new System.Drawing.Point(18, 169);
            this.Day4.Name = "Day4";
            this.Day4.Size = new System.Drawing.Size(129, 17);
            this.Day4.TabIndex = 10;
            this.Day4.TabStop = true;
            this.Day4.Text = "Minggu, 13.00 - 20.00";
            this.Day4.UseVisualStyleBackColor = true;
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(278, 474);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(87, 21);
            this.Show.TabIndex = 19;
            this.Show.Text = "Tampilkan";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(485, 474);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 20;
            this.Close.Text = "Selesai";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("JetBrainsMono NF", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Tittle.Location = new System.Drawing.Point(272, 11);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(238, 31);
            this.Tittle.TabIndex = 21;
            this.Tittle.Text = "FORM PENDAFTARAN";
            this.Tittle.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(834, 519);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DateSelect);
            this.Controls.Add(this.GenderChoose);
            this.Controls.Add(this.NamePlaceholder);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.GenderLB);
            this.Controls.Add(this.NameLB);
            this.Name = "Form1";
            this.Text = "ULBI SPORT SCHOOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Schedule.ResumeLayout(false);
            this.Schedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label GenderLB;
        private System.Windows.Forms.Label Birthdate;
        private System.Windows.Forms.TextBox NamePlaceholder;
        private System.Windows.Forms.ComboBox GenderChoose;
        private System.Windows.Forms.DateTimePicker DateSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Schedule;
        private System.Windows.Forms.RadioButton Day1;
        private System.Windows.Forms.RadioButton Day2;
        private System.Windows.Forms.RadioButton Day3;
        private System.Windows.Forms.RadioButton Day4;
        private System.Windows.Forms.CheckBox Football;
        private System.Windows.Forms.CheckBox Swim;
        private System.Windows.Forms.CheckBox Tenis;
        private System.Windows.Forms.CheckBox Yoga;
        private System.Windows.Forms.CheckBox Basket;
        private System.Windows.Forms.CheckBox Badminton;
        private System.Windows.Forms.CheckBox Volly;
        private System.Windows.Forms.CheckBox Archery;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Button Show;
    }
}


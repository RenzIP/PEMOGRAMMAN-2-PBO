namespace P6_4_714240042
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usnTxt = new System.Windows.Forms.TextBox();
            this.nckTxt = new System.Windows.Forms.TextBox();
            this.emlTxt = new System.Windows.Forms.TextBox();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.pswdTxt = new System.Windows.Forms.TextBox();
            this.cpswdTxt = new System.Windows.Forms.TextBox();
            this.ptagTxt = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrainsMono NF SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Account Registration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nickname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Player Tag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // usnTxt
            // 
            this.usnTxt.Location = new System.Drawing.Point(367, 87);
            this.usnTxt.Name = "usnTxt";
            this.usnTxt.Size = new System.Drawing.Size(141, 20);
            this.usnTxt.TabIndex = 9;
            this.usnTxt.TextChanged += new System.EventHandler(this.usnTxt_TextChanged);
            // 
            // nckTxt
            // 
            this.nckTxt.Location = new System.Drawing.Point(367, 132);
            this.nckTxt.Name = "nckTxt";
            this.nckTxt.Size = new System.Drawing.Size(141, 20);
            this.nckTxt.TabIndex = 10;
            this.nckTxt.TextChanged += new System.EventHandler(this.nckTxt_TextChanged);
            // 
            // emlTxt
            // 
            this.emlTxt.Location = new System.Drawing.Point(367, 166);
            this.emlTxt.Name = "emlTxt";
            this.emlTxt.Size = new System.Drawing.Size(141, 20);
            this.emlTxt.TabIndex = 11;
            this.emlTxt.TextChanged += new System.EventHandler(this.emlTxt_TextChanged);
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(367, 205);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(141, 20);
            this.ageTxt.TabIndex = 12;
            this.ageTxt.TextChanged += new System.EventHandler(this.ageTxt_TextChanged);
            // 
            // pswdTxt
            // 
            this.pswdTxt.Location = new System.Drawing.Point(367, 248);
            this.pswdTxt.Name = "pswdTxt";
            this.pswdTxt.Size = new System.Drawing.Size(141, 20);
            this.pswdTxt.TabIndex = 13;
            this.pswdTxt.TextChanged += new System.EventHandler(this.pswdTxt_TextChanged);
            // 
            // cpswdTxt
            // 
            this.cpswdTxt.Location = new System.Drawing.Point(367, 300);
            this.cpswdTxt.Name = "cpswdTxt";
            this.cpswdTxt.Size = new System.Drawing.Size(141, 20);
            this.cpswdTxt.TabIndex = 14;
            this.cpswdTxt.TextChanged += new System.EventHandler(this.cpswdTxt_TextChanged);
            // 
            // ptagTxt
            // 
            this.ptagTxt.Location = new System.Drawing.Point(367, 353);
            this.ptagTxt.Name = "ptagTxt";
            this.ptagTxt.Size = new System.Drawing.Size(141, 20);
            this.ptagTxt.TabIndex = 15;
            this.ptagTxt.TextChanged += new System.EventHandler(this.ptagTxt_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(556, 408);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 16;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(97, 408);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.ptagTxt);
            this.Controls.Add(this.cpswdTxt);
            this.Controls.Add(this.pswdTxt);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.emlTxt);
            this.Controls.Add(this.nckTxt);
            this.Controls.Add(this.usnTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Game Account Registration";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usnTxt;
        private System.Windows.Forms.TextBox nckTxt;
        private System.Windows.Forms.TextBox emlTxt;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.TextBox pswdTxt;
        private System.Windows.Forms.TextBox cpswdTxt;
        private System.Windows.Forms.TextBox ptagTxt;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


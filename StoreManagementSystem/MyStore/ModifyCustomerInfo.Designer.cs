namespace MyStore
{
    partial class ModifyCustomerInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UMale = new System.Windows.Forms.RadioButton();
            this.UFemale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UAddress = new System.Windows.Forms.TextBox();
            this.UMobile = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UEmail = new System.Windows.Forms.TextBox();
            this.UName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UMale);
            this.groupBox1.Controls.Add(this.UFemale);
            this.groupBox1.Location = new System.Drawing.Point(145, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(217, 38);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // UMale
            // 
            this.UMale.AutoSize = true;
            this.UMale.Location = new System.Drawing.Point(8, 12);
            this.UMale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UMale.Name = "UMale";
            this.UMale.Size = new System.Drawing.Size(59, 19);
            this.UMale.TabIndex = 1;
            this.UMale.TabStop = true;
            this.UMale.Text = "Male";
            this.UMale.UseVisualStyleBackColor = true;
            // 
            // UFemale
            // 
            this.UFemale.AutoSize = true;
            this.UFemale.Location = new System.Drawing.Point(139, 12);
            this.UFemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UFemale.Name = "UFemale";
            this.UFemale.Size = new System.Drawing.Size(74, 19);
            this.UFemale.TabIndex = 0;
            this.UFemale.TabStop = true;
            this.UFemale.Text = "Female";
            this.UFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Address";
            // 
            // UAddress
            // 
            this.UAddress.Location = new System.Drawing.Point(145, 243);
            this.UAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UAddress.Multiline = true;
            this.UAddress.Name = "UAddress";
            this.UAddress.Size = new System.Drawing.Size(216, 69);
            this.UAddress.TabIndex = 21;
            // 
            // UMobile
            // 
            this.UMobile.Location = new System.Drawing.Point(145, 189);
            this.UMobile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UMobile.Multiline = true;
            this.UMobile.Name = "UMobile";
            this.UMobile.Size = new System.Drawing.Size(216, 28);
            this.UMobile.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 334);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "초기화";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UEmail
            // 
            this.UEmail.Location = new System.Drawing.Point(145, 69);
            this.UEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UEmail.Multiline = true;
            this.UEmail.Name = "UEmail";
            this.UEmail.Size = new System.Drawing.Size(216, 28);
            this.UEmail.TabIndex = 17;
            // 
            // UName
            // 
            this.UName.Location = new System.Drawing.Point(145, 12);
            this.UName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UName.Multiline = true;
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(216, 28);
            this.UName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // ModifyCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UAddress);
            this.Controls.Add(this.UMobile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UEmail);
            this.Controls.Add(this.UName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(419, 430);
            this.Name = "ModifyCustomerInfo";
            this.Text = "고객 정보 수정";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton UMale;
        private System.Windows.Forms.RadioButton UFemale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UAddress;
        private System.Windows.Forms.TextBox UMobile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox UEmail;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
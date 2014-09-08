namespace regex
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
            this.txt_c = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_parentesis = new System.Windows.Forms.Button();
            this.txt_parentesis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_email = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "String en C:";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(94, 40);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(174, 20);
            this.txt_c.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_parentesis
            // 
            this.btn_parentesis.Location = new System.Drawing.Point(297, 81);
            this.btn_parentesis.Name = "btn_parentesis";
            this.btn_parentesis.Size = new System.Drawing.Size(75, 23);
            this.btn_parentesis.TabIndex = 5;
            this.btn_parentesis.Text = "Validar";
            this.btn_parentesis.UseVisualStyleBackColor = true;
            this.btn_parentesis.Click += new System.EventHandler(this.btn_parentesis_Click);
            // 
            // txt_parentesis
            // 
            this.txt_parentesis.Location = new System.Drawing.Point(94, 85);
            this.txt_parentesis.Name = "txt_parentesis";
            this.txt_parentesis.Size = new System.Drawing.Size(174, 20);
            this.txt_parentesis.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parentesis:";
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(297, 128);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(75, 23);
            this.btn_email.TabIndex = 8;
            this.btn_email.Text = "Validar";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(94, 132);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(174, 20);
            this.txt_email.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 355);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_parentesis);
            this.Controls.Add(this.txt_parentesis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGEX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_parentesis;
        private System.Windows.Forms.TextBox txt_parentesis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
    }
}


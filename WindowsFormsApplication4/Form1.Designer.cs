namespace WindowsFormsApplication4
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
            this.loginButton = new System.Windows.Forms.Button();
            this.dreBox = new System.Windows.Forms.TextBox();
            this.pwsdBox = new System.Windows.Forms.TextBox();
            this.singupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(101, 136);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Entrar";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // dreBox
            // 
            this.dreBox.Location = new System.Drawing.Point(90, 84);
            this.dreBox.Name = "dreBox";
            this.dreBox.Size = new System.Drawing.Size(100, 20);
            this.dreBox.TabIndex = 1;
            // 
            // pwsdBox
            // 
            this.pwsdBox.Location = new System.Drawing.Point(90, 110);
            this.pwsdBox.Name = "pwsdBox";
            this.pwsdBox.Size = new System.Drawing.Size(100, 20);
            this.pwsdBox.TabIndex = 2;
            this.pwsdBox.UseSystemPasswordChar = true;
            // 
            // singupButton
            // 
            this.singupButton.Location = new System.Drawing.Point(101, 166);
            this.singupButton.Name = "singupButton";
            this.singupButton.Size = new System.Drawing.Size(75, 23);
            this.singupButton.TabIndex = 3;
            this.singupButton.Text = "Cadastro";
            this.singupButton.UseVisualStyleBackColor = true;
            this.singupButton.Click += new System.EventHandler(this.singupButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.singupButton);
            this.Controls.Add(this.pwsdBox);
            this.Controls.Add(this.dreBox);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox dreBox;
        private System.Windows.Forms.TextBox pwsdBox;
        private System.Windows.Forms.Button singupButton;
    }
}


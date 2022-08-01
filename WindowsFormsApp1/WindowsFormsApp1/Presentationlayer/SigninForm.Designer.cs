namespace WindowsFormsApp1.Presentationlayer
{
    partial class SigninForm
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
            this.Name = new System.Windows.Forms.TextBox();
            this.Conbox = new System.Windows.Forms.TextBox();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(301, 77);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(193, 20);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name:";
            // 
            // Conbox
            // 
            this.Conbox.Location = new System.Drawing.Point(301, 140);
            this.Conbox.Name = "Conbox";
            this.Conbox.Size = new System.Drawing.Size(193, 20);
            this.Conbox.TabIndex = 0;
            this.Conbox.Text = "Password";
            // 
            // Passbox
            // 
            this.Passbox.Location = new System.Drawing.Point(301, 200);
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(193, 20);
            this.Passbox.TabIndex = 0;
            this.Passbox.Text = "Confarm Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Signin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SigninForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Passbox);
            this.Controls.Add(this.Conbox);
            this.Controls.Add(this.Name);
        //    this.Name = "SigninForm";
            this.Text = "SigninForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Conbox;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
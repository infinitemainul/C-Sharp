namespace CSPharma.GUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.lblAdminTitle = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblIdTitle = new System.Windows.Forms.Label();
            this.lblEditDoctor = new System.Windows.Forms.Label();
            this.lblEditUser = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblAdminId = new System.Windows.Forms.Label();
            this.lblEditInventory = new System.Windows.Forms.Label();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminTitle
            // 
            this.lblAdminTitle.AutoSize = true;
            this.lblAdminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblAdminTitle.Location = new System.Drawing.Point(7, 89);
            this.lblAdminTitle.Name = "lblAdminTitle";
            this.lblAdminTitle.Size = new System.Drawing.Size(169, 29);
            this.lblAdminTitle.TabIndex = 0;
            this.lblAdminTitle.Text = "Admin Name:";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblAdminName.Location = new System.Drawing.Point(201, 89);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(86, 29);
            this.lblAdminName.TabIndex = 1;
            this.lblAdminName.Text = "NAME";
            this.lblAdminName.Click += new System.EventHandler(this.lblAdminName_Click);
            // 
            // lblIdTitle
            // 
            this.lblIdTitle.AutoSize = true;
            this.lblIdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblIdTitle.Location = new System.Drawing.Point(131, 143);
            this.lblIdTitle.Name = "lblIdTitle";
            this.lblIdTitle.Size = new System.Drawing.Size(45, 29);
            this.lblIdTitle.TabIndex = 2;
            this.lblIdTitle.Text = "ID:";
            // 
            // lblEditDoctor
            // 
            this.lblEditDoctor.AutoSize = true;
            this.lblEditDoctor.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDoctor.ForeColor = System.Drawing.Color.White;
            this.lblEditDoctor.Location = new System.Drawing.Point(380, 261);
            this.lblEditDoctor.Name = "lblEditDoctor";
            this.lblEditDoctor.Size = new System.Drawing.Size(276, 35);
            this.lblEditDoctor.TabIndex = 5;
            this.lblEditDoctor.Text = "UPDATE DOCTOR";
            this.lblEditDoctor.Click += new System.EventHandler(this.lblEditDoctor_Click);
            this.lblEditDoctor.MouseLeave += new System.EventHandler(this.lblEditDoctor_MouseLeave);
            this.lblEditDoctor.MouseHover += new System.EventHandler(this.lblEditDoctor_MouseHover);
            // 
            // lblEditUser
            // 
            this.lblEditUser.AutoSize = true;
            this.lblEditUser.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUser.ForeColor = System.Drawing.Color.White;
            this.lblEditUser.Location = new System.Drawing.Point(380, 314);
            this.lblEditUser.Name = "lblEditUser";
            this.lblEditUser.Size = new System.Drawing.Size(243, 35);
            this.lblEditUser.TabIndex = 6;
            this.lblEditUser.Text = "UPDATE USERS";
            this.lblEditUser.Click += new System.EventHandler(this.lblEditUser_Click);
            this.lblEditUser.MouseLeave += new System.EventHandler(this.lblEditUser_MouseLeave);
            this.lblEditUser.MouseHover += new System.EventHandler(this.lblEditUser_MouseHover);
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.ForeColor = System.Drawing.Color.White;
            this.lblRegistration.Location = new System.Drawing.Point(380, 204);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(277, 35);
            this.lblRegistration.TabIndex = 9;
            this.lblRegistration.Text = "REGISTER USERS";
            this.lblRegistration.Click += new System.EventHandler(this.lblRegistration_Click);
            this.lblRegistration.MouseLeave += new System.EventHandler(this.lblRegistration_MouseLeave);
            this.lblRegistration.MouseHover += new System.EventHandler(this.RegistrationLabel_MouseHover);
            // 
            // lblAdminId
            // 
            this.lblAdminId.AutoSize = true;
            this.lblAdminId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.lblAdminId.Location = new System.Drawing.Point(201, 143);
            this.lblAdminId.Name = "lblAdminId";
            this.lblAdminId.Size = new System.Drawing.Size(54, 29);
            this.lblAdminId.TabIndex = 17;
            this.lblAdminId.Text = "AID";
            // 
            // lblEditInventory
            // 
            this.lblEditInventory.AutoSize = true;
            this.lblEditInventory.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditInventory.ForeColor = System.Drawing.Color.White;
            this.lblEditInventory.Location = new System.Drawing.Point(380, 367);
            this.lblEditInventory.Name = "lblEditInventory";
            this.lblEditInventory.Size = new System.Drawing.Size(327, 35);
            this.lblEditInventory.TabIndex = 18;
            this.lblEditInventory.Text = "UPDATE INVENTORY";
            this.lblEditInventory.Click += new System.EventHandler(this.lblEditInventory_Click);
            this.lblEditInventory.MouseLeave += new System.EventHandler(this.lblEditInventory_MouseLeave);
            this.lblEditInventory.MouseHover += new System.EventHandler(this.lblEditInventory_MouseHover);
            // 
            // LogoLabel
            // 
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.LogoLabel.Location = new System.Drawing.Point(377, 11);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(263, 46);
            this.LogoLabel.TabIndex = 20;
            this.LogoLabel.Text = "C# PHARMA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.lblRegistration);
            this.panel1.Controls.Add(this.LogoLabel);
            this.panel1.Controls.Add(this.lblAdminTitle);
            this.panel1.Controls.Add(this.lblAdminName);
            this.panel1.Controls.Add(this.lblEditInventory);
            this.panel1.Controls.Add(this.lblIdTitle);
            this.panel1.Controls.Add(this.lblAdminId);
            this.panel1.Controls.Add(this.lblEditDoctor);
            this.panel1.Controls.Add(this.lblEditUser);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 558);
            this.panel1.TabIndex = 21;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(217)))), ((int)(((byte)(160)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(12, 500);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(197, 48);
            this.btnChangePassword.TabIndex = 23;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(825, 498);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(172, 48);
            this.btnLogOut.TabIndex = 22;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1045, 587);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblIdTitle;
        private System.Windows.Forms.Label lblEditDoctor;
        private System.Windows.Forms.Label lblEditUser;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblAdminId;
        private System.Windows.Forms.Label lblEditInventory;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChangePassword;
    }
}


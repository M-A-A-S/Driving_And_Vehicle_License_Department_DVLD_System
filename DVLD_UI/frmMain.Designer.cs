namespace DVLD
{
    partial class frmMain
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDrivingLicensesServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInternationalLicesne = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReplacementForLostOrDamagedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmReleaseDetainedDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInternationalLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReleaseLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccountSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmApplications,
            this.tsmPeople,
            this.tsmDrivers,
            this.tsmUsers,
            this.tsmAccountSetting});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.msMainMenu.Size = new System.Drawing.Size(1924, 74);
            this.msMainMenu.TabIndex = 2;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // tsmApplications
            // 
            this.tsmApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDrivingLicensesServices,
            this.toolStripMenuItem1,
            this.tsmManageApplications,
            this.toolStripMenuItem3,
            this.tsmDetainLicenses,
            this.tsmManageApplicationTypes,
            this.tsmManageTestTypes});
            this.tsmApplications.Image = global::DVLD.Properties.Resources.Applications_64;
            this.tsmApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmApplications.Name = "tsmApplications";
            this.tsmApplications.Size = new System.Drawing.Size(182, 68);
            this.tsmApplications.Text = "Applications";
            // 
            // tsmDrivingLicensesServices
            // 
            this.tsmDrivingLicensesServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewDrivingLicense,
            this.tsmRenewDrivingLicense,
            this.toolStripMenuItem4,
            this.tsmReplacementForLostOrDamagedLicense,
            this.toolStripMenuItem5,
            this.tsmReleaseDetainedDrivingLicense,
            this.tsmRetakeTest});
            this.tsmDrivingLicensesServices.Image = global::DVLD.Properties.Resources.Driver_License_48;
            this.tsmDrivingLicensesServices.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDrivingLicensesServices.Name = "tsmDrivingLicensesServices";
            this.tsmDrivingLicensesServices.Size = new System.Drawing.Size(331, 70);
            this.tsmDrivingLicensesServices.Text = "Driving Licenses Services";
            // 
            // tsmNewDrivingLicense
            // 
            this.tsmNewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalLicense,
            this.tsmInternationalLicesne});
            this.tsmNewDrivingLicense.Image = global::DVLD.Properties.Resources.New_Driving_License_32;
            this.tsmNewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmNewDrivingLicense.Name = "tsmNewDrivingLicense";
            this.tsmNewDrivingLicense.Size = new System.Drawing.Size(415, 38);
            this.tsmNewDrivingLicense.Text = "New Driving License";
            // 
            // tsmLocalLicense
            // 
            this.tsmLocalLicense.Image = global::DVLD.Properties.Resources.Local_32;
            this.tsmLocalLicense.Name = "tsmLocalLicense";
            this.tsmLocalLicense.Size = new System.Drawing.Size(240, 26);
            this.tsmLocalLicense.Text = "Local License";
            this.tsmLocalLicense.Click += new System.EventHandler(this.tsmLocalLicense_Click);
            // 
            // tsmInternationalLicesne
            // 
            this.tsmInternationalLicesne.Image = global::DVLD.Properties.Resources.International_32;
            this.tsmInternationalLicesne.Name = "tsmInternationalLicesne";
            this.tsmInternationalLicesne.Size = new System.Drawing.Size(240, 26);
            this.tsmInternationalLicesne.Text = "International License";
            this.tsmInternationalLicesne.Click += new System.EventHandler(this.tsmInternationalLicesne_Click);
            // 
            // tsmRenewDrivingLicense
            // 
            this.tsmRenewDrivingLicense.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.tsmRenewDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmRenewDrivingLicense.Name = "tsmRenewDrivingLicense";
            this.tsmRenewDrivingLicense.Size = new System.Drawing.Size(415, 38);
            this.tsmRenewDrivingLicense.Text = "Renew Driving License";
            this.tsmRenewDrivingLicense.Click += new System.EventHandler(this.tsmRenewDrivingLicense_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmReplacementForLostOrDamagedLicense
            // 
            this.tsmReplacementForLostOrDamagedLicense.Image = global::DVLD.Properties.Resources.Damaged_Driving_License_32;
            this.tsmReplacementForLostOrDamagedLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmReplacementForLostOrDamagedLicense.Name = "tsmReplacementForLostOrDamagedLicense";
            this.tsmReplacementForLostOrDamagedLicense.Size = new System.Drawing.Size(415, 38);
            this.tsmReplacementForLostOrDamagedLicense.Text = "Replacement for Lost or Damaged License";
            this.tsmReplacementForLostOrDamagedLicense.Click += new System.EventHandler(this.tsmReplacementForLostOrDamagedLicense_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(412, 6);
            // 
            // tsmReleaseDetainedDrivingLicense
            // 
            this.tsmReleaseDetainedDrivingLicense.Image = global::DVLD.Properties.Resources.Detained_Driving_License_32;
            this.tsmReleaseDetainedDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmReleaseDetainedDrivingLicense.Name = "tsmReleaseDetainedDrivingLicense";
            this.tsmReleaseDetainedDrivingLicense.Size = new System.Drawing.Size(415, 38);
            this.tsmReleaseDetainedDrivingLicense.Text = "Release Detained Driving License";
            this.tsmReleaseDetainedDrivingLicense.Click += new System.EventHandler(this.tsmReleaseDetainedDrivingLicense_Click);
            // 
            // tsmRetakeTest
            // 
            this.tsmRetakeTest.Image = global::DVLD.Properties.Resources.Retake_Test_32;
            this.tsmRetakeTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmRetakeTest.Name = "tsmRetakeTest";
            this.tsmRetakeTest.Size = new System.Drawing.Size(415, 38);
            this.tsmRetakeTest.Text = "Retake Test";
            this.tsmRetakeTest.Click += new System.EventHandler(this.tsmRetakeTest_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(328, 6);
            // 
            // tsmManageApplications
            // 
            this.tsmManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalDrivingLicenseApplications,
            this.tsmInternationalLicenseApplications});
            this.tsmManageApplications.Image = global::DVLD.Properties.Resources.Manage_Applications_64;
            this.tsmManageApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmManageApplications.Name = "tsmManageApplications";
            this.tsmManageApplications.Size = new System.Drawing.Size(331, 70);
            this.tsmManageApplications.Text = "Manage Applications";
            // 
            // tsmLocalDrivingLicenseApplications
            // 
            this.tsmLocalDrivingLicenseApplications.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.tsmLocalDrivingLicenseApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmLocalDrivingLicenseApplications.Name = "tsmLocalDrivingLicenseApplications";
            this.tsmLocalDrivingLicenseApplications.Size = new System.Drawing.Size(357, 38);
            this.tsmLocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            this.tsmLocalDrivingLicenseApplications.Click += new System.EventHandler(this.tsmLocalDrivingLicenseApplications_Click);
            // 
            // tsmInternationalLicenseApplications
            // 
            this.tsmInternationalLicenseApplications.Image = global::DVLD.Properties.Resources.International_32;
            this.tsmInternationalLicenseApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmInternationalLicenseApplications.Name = "tsmInternationalLicenseApplications";
            this.tsmInternationalLicenseApplications.Size = new System.Drawing.Size(357, 38);
            this.tsmInternationalLicenseApplications.Text = "International License Applications";
            this.tsmInternationalLicenseApplications.Click += new System.EventHandler(this.tsmInternationalLicenseApplications_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(328, 6);
            // 
            // tsmDetainLicenses
            // 
            this.tsmDetainLicenses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManageDetainedLicenses,
            this.tsmDetainLicense,
            this.tsmReleaseLicense});
            this.tsmDetainLicenses.Image = global::DVLD.Properties.Resources.Detain_64;
            this.tsmDetainLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDetainLicenses.Name = "tsmDetainLicenses";
            this.tsmDetainLicenses.Size = new System.Drawing.Size(331, 70);
            this.tsmDetainLicenses.Text = "Detain Licenses";
            // 
            // tsmManageDetainedLicenses
            // 
            this.tsmManageDetainedLicenses.Image = global::DVLD.Properties.Resources.Detain_32;
            this.tsmManageDetainedLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmManageDetainedLicenses.Name = "tsmManageDetainedLicenses";
            this.tsmManageDetainedLicenses.Size = new System.Drawing.Size(300, 38);
            this.tsmManageDetainedLicenses.Text = "Manage Detained Licenses";
            this.tsmManageDetainedLicenses.Click += new System.EventHandler(this.tsmManageDetainedLicenses_Click);
            // 
            // tsmDetainLicense
            // 
            this.tsmDetainLicense.Image = global::DVLD.Properties.Resources.Detain_32;
            this.tsmDetainLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDetainLicense.Name = "tsmDetainLicense";
            this.tsmDetainLicense.Size = new System.Drawing.Size(300, 38);
            this.tsmDetainLicense.Text = "Detain Licence";
            this.tsmDetainLicense.Click += new System.EventHandler(this.tsmDetainLicense_Click);
            // 
            // tsmReleaseLicense
            // 
            this.tsmReleaseLicense.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.tsmReleaseLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmReleaseLicense.Name = "tsmReleaseLicense";
            this.tsmReleaseLicense.Size = new System.Drawing.Size(300, 38);
            this.tsmReleaseLicense.Text = "Release Detained License";
            this.tsmReleaseLicense.Click += new System.EventHandler(this.tsmReleaseLicense_Click);
            // 
            // tsmManageApplicationTypes
            // 
            this.tsmManageApplicationTypes.Image = global::DVLD.Properties.Resources.Application_Types_64;
            this.tsmManageApplicationTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmManageApplicationTypes.Name = "tsmManageApplicationTypes";
            this.tsmManageApplicationTypes.Size = new System.Drawing.Size(331, 70);
            this.tsmManageApplicationTypes.Text = "Manage Application Types";
            this.tsmManageApplicationTypes.Click += new System.EventHandler(this.tsmManageApplicationTypes_Click);
            // 
            // tsmManageTestTypes
            // 
            this.tsmManageTestTypes.Image = global::DVLD.Properties.Resources.Test_Type_64;
            this.tsmManageTestTypes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmManageTestTypes.Name = "tsmManageTestTypes";
            this.tsmManageTestTypes.Size = new System.Drawing.Size(331, 70);
            this.tsmManageTestTypes.Text = "Manage Test Types";
            this.tsmManageTestTypes.Click += new System.EventHandler(this.tsmManageTestTypes_Click);
            // 
            // tsmPeople
            // 
            this.tsmPeople.Image = global::DVLD.Properties.Resources.People_64;
            this.tsmPeople.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmPeople.Name = "tsmPeople";
            this.tsmPeople.Size = new System.Drawing.Size(139, 68);
            this.tsmPeople.Text = "People";
            this.tsmPeople.Click += new System.EventHandler(this.tsmPeople_Click);
            // 
            // tsmDrivers
            // 
            this.tsmDrivers.Image = global::DVLD.Properties.Resources.Drivers_64;
            this.tsmDrivers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDrivers.Name = "tsmDrivers";
            this.tsmDrivers.Size = new System.Drawing.Size(140, 68);
            this.tsmDrivers.Text = "Drivers";
            this.tsmDrivers.Click += new System.EventHandler(this.tsmDrivers_Click);
            // 
            // tsmUsers
            // 
            this.tsmUsers.Image = global::DVLD.Properties.Resources.Users_2_64;
            this.tsmUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmUsers.Name = "tsmUsers";
            this.tsmUsers.Size = new System.Drawing.Size(127, 68);
            this.tsmUsers.Text = "Users";
            this.tsmUsers.Click += new System.EventHandler(this.tsmUsers_Click);
            // 
            // tsmAccountSetting
            // 
            this.tsmAccountSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCurrentUserInfo,
            this.tsmChangePassword,
            this.toolStripMenuItem2,
            this.tsmSignOut});
            this.tsmAccountSetting.Image = global::DVLD.Properties.Resources.account_settings_64;
            this.tsmAccountSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmAccountSetting.Name = "tsmAccountSetting";
            this.tsmAccountSetting.Size = new System.Drawing.Size(215, 68);
            this.tsmAccountSetting.Text = "Account Settings";
            // 
            // tsmCurrentUserInfo
            // 
            this.tsmCurrentUserInfo.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.tsmCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmCurrentUserInfo.Name = "tsmCurrentUserInfo";
            this.tsmCurrentUserInfo.Size = new System.Drawing.Size(230, 38);
            this.tsmCurrentUserInfo.Text = "Current User Info";
            this.tsmCurrentUserInfo.Click += new System.EventHandler(this.tsmCurrentUserInfo_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Image = global::DVLD.Properties.Resources.Password_32;
            this.tsmChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(230, 38);
            this.tsmChangePassword.Text = "Change Password";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(227, 6);
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.Image = global::DVLD.Properties.Resources.sign_out_32__2;
            this.tsmSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(230, 38);
            this.tsmSignOut.Text = "Sign Out";
            this.tsmSignOut.Click += new System.EventHandler(this.tsmSignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Logo_Final;
            this.pictureBox1.Location = new System.Drawing.Point(0, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1924, 987);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmDrivingLicensesServices;
        private System.Windows.Forms.ToolStripMenuItem tsmNewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalLicesne;
        private System.Windows.Forms.ToolStripMenuItem tsmRenewDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmReplacementForLostOrDamagedLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmReleaseDetainedDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmRetakeTest;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem tsmInternationalLicenseApplications;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmDetainLicenses;
        private System.Windows.Forms.ToolStripMenuItem tsmManageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem tsmDetainLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmReleaseLicense;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmPeople;
        private System.Windows.Forms.ToolStripMenuItem tsmDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmAccountSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


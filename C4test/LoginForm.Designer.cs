namespace C4test
{
    partial class LoginForm
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
            LoginForm loginForm = this;
            loginForm.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            loginForm.WrongUserPassLabel = new System.Windows.Forms.Label();
            loginForm.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            loginForm.txtUsername = new DevExpress.XtraEditors.TextEdit();
            loginForm.txtPassword = new DevExpress.XtraEditors.TextEdit();
            loginForm.OkBtn = new DevExpress.XtraEditors.SimpleButton();
            loginForm.CancelBtn = new DevExpress.XtraEditors.SimpleButton();
            loginForm.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            loginForm.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            loginForm.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            loginForm.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            loginForm.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            loginForm.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            loginForm.WrongUserPassContainer = new DevExpress.XtraLayout.LayoutControlItem();
            loginForm.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            loginForm.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            loginForm.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControl1).BeginInit();
            loginForm.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginForm.txtUsername.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.txtPassword.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.simpleSeparator1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.WrongUserPassContainer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControlItem6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.emptySpaceItem2).BeginInit();
            loginForm.SuspendLayout();
            // 
            // layoutControl1
            // 
            loginForm.layoutControl1.Controls.Add(loginForm.WrongUserPassLabel);
            loginForm.layoutControl1.Controls.Add(loginForm.labelControl1);
            loginForm.layoutControl1.Controls.Add(loginForm.txtUsername);
            loginForm.layoutControl1.Controls.Add(loginForm.txtPassword);
            loginForm.layoutControl1.Controls.Add(loginForm.OkBtn);
            loginForm.layoutControl1.Controls.Add(loginForm.CancelBtn);
            loginForm.layoutControl1.Location = new System.Drawing.Point(-2, 26);
            loginForm.layoutControl1.Name = "layoutControl1";
            loginForm.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(791, 67, 650, 400);
            loginForm.layoutControl1.Root = loginForm.Root;
            loginForm.layoutControl1.Size = new System.Drawing.Size(447, 280);
            loginForm.layoutControl1.TabIndex = 1;
            loginForm.layoutControl1.Text = "layoutControl1";
            // 
            // WrongUserPassLabel
            // 
            loginForm.WrongUserPassLabel.Location = new System.Drawing.Point(12, 83);
            loginForm.WrongUserPassLabel.Name = "WrongUserPassLabel";
            loginForm.WrongUserPassLabel.Size = new System.Drawing.Size(422, 20);
            loginForm.WrongUserPassLabel.TabIndex = 9;
            loginForm.WrongUserPassLabel.Text = "Password or username incorrect";
            // 
            // labelControl1
            // 
            loginForm.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            loginForm.labelControl1.Appearance.Options.UseFont = true;
            loginForm.labelControl1.Location = new System.Drawing.Point(12, 12);
            loginForm.labelControl1.Name = "labelControl1";
            loginForm.labelControl1.Size = new System.Drawing.Size(39, 19);
            loginForm.labelControl1.StyleController = loginForm.layoutControl1;
            loginForm.labelControl1.TabIndex = 8;
            loginForm.labelControl1.Text = "Login";
            // 
            // txtUsername
            // 
            loginForm.txtUsername.EditValue = "";
            loginForm.txtUsername.Location = new System.Drawing.Point(72, 35);
            loginForm.txtUsername.Name = "txtUsername";
            loginForm.txtUsername.Size = new System.Drawing.Size(363, 20);
            loginForm.txtUsername.StyleController = loginForm.layoutControl1;
            loginForm.txtUsername.TabIndex = 4;
            loginForm.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(loginForm.OkBtn_KeyDown);
            // 
            // txtPassword
            // 
            loginForm.txtPassword.EditValue = "Password";
            loginForm.txtPassword.Location = new System.Drawing.Point(72, 59);
            loginForm.txtPassword.Name = "txtPassword";
            loginForm.txtPassword.Properties.PasswordChar = '*';
            loginForm.txtPassword.Size = new System.Drawing.Size(363, 20);
            loginForm.txtPassword.StyleController = loginForm.layoutControl1;
            loginForm.txtPassword.TabIndex = 5;
            loginForm.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(loginForm.OkBtn_KeyDown);
            // 
            // OkBtn
            // 
            loginForm.OkBtn.Location = new System.Drawing.Point(12, 107);
            loginForm.OkBtn.Name = "OkBtn";
            loginForm.OkBtn.Size = new System.Drawing.Size(209, 22);
            loginForm.OkBtn.StyleController = loginForm.layoutControl1;
            loginForm.OkBtn.TabIndex = 7;
            loginForm.OkBtn.Text = "OK";
            loginForm.OkBtn.Click += new System.EventHandler(loginForm.OkBtn_Click);
            loginForm.OkBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(loginForm.OkBtn_KeyDown);
            // 
            // CancelBtn
            // 
            loginForm.CancelBtn.Location = new System.Drawing.Point(225, 107);
            loginForm.CancelBtn.Name = "CancelBtn";
            loginForm.CancelBtn.Size = new System.Drawing.Size(210, 22);
            loginForm.CancelBtn.StyleController = loginForm.layoutControl1;
            loginForm.CancelBtn.TabIndex = 10;
            loginForm.CancelBtn.Text = "Cancel";
            loginForm.CancelBtn.Click += new System.EventHandler(loginForm.CancelBtn_Click);
            // 
            // Root
            // 
            loginForm.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            loginForm.Root.GroupBordersVisible = false;
            loginForm.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            loginForm.layoutControlItem1,
            loginForm.layoutControlItem4,
            loginForm.layoutControlItem5,
            loginForm.layoutControlItem2,
            loginForm.simpleSeparator1,
            loginForm.WrongUserPassContainer,
            loginForm.layoutControlItem6,
            loginForm.emptySpaceItem1,
            loginForm.emptySpaceItem2});
            loginForm.Root.Name = "Root";
            loginForm.Root.Size = new System.Drawing.Size(447, 280);
            loginForm.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            loginForm.layoutControlItem1.Control = loginForm.txtUsername;
            loginForm.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            loginForm.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            loginForm.layoutControlItem1.Location = new System.Drawing.Point(0, 23);
            loginForm.layoutControlItem1.Name = "layoutControlItem1";
            loginForm.layoutControlItem1.Size = new System.Drawing.Size(427, 24);
            loginForm.layoutControlItem1.Text = "Username";
            loginForm.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            loginForm.layoutControlItem1.TextSize = new System.Drawing.Size(48, 13);
            // 
            // layoutControlItem4
            // 
            loginForm.layoutControlItem4.Control = loginForm.OkBtn;
            loginForm.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            loginForm.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            loginForm.layoutControlItem4.Location = new System.Drawing.Point(0, 95);
            loginForm.layoutControlItem4.MaxSize = new System.Drawing.Size(213, 0);
            loginForm.layoutControlItem4.MinSize = new System.Drawing.Size(213, 26);
            loginForm.layoutControlItem4.Name = "layoutControlItem4";
            loginForm.layoutControlItem4.Size = new System.Drawing.Size(213, 26);
            loginForm.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            loginForm.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            loginForm.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            loginForm.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            loginForm.layoutControlItem5.Control = loginForm.labelControl1;
            loginForm.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            loginForm.layoutControlItem5.Name = "layoutControlItem5";
            loginForm.layoutControlItem5.Size = new System.Drawing.Size(427, 23);
            loginForm.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            loginForm.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            loginForm.layoutControlItem2.Control = loginForm.txtPassword;
            loginForm.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            loginForm.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            loginForm.layoutControlItem2.Location = new System.Drawing.Point(0, 47);
            loginForm.layoutControlItem2.Name = "layoutControlItem2";
            loginForm.layoutControlItem2.Size = new System.Drawing.Size(427, 24);
            loginForm.layoutControlItem2.Text = "Password";
            loginForm.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            loginForm.layoutControlItem2.TextSize = new System.Drawing.Size(48, 13);
            // 
            // simpleSeparator1
            // 
            loginForm.simpleSeparator1.AllowHotTrack = false;
            loginForm.simpleSeparator1.Location = new System.Drawing.Point(426, 71);
            loginForm.simpleSeparator1.Name = "simpleSeparator1";
            loginForm.simpleSeparator1.Size = new System.Drawing.Size(1, 24);
            loginForm.simpleSeparator1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // WrongUserPassContainer
            // 
            loginForm.WrongUserPassContainer.ContentVisible = false;
            loginForm.WrongUserPassContainer.Control = loginForm.WrongUserPassLabel;
            loginForm.WrongUserPassContainer.Location = new System.Drawing.Point(0, 71);
            loginForm.WrongUserPassContainer.MaxSize = new System.Drawing.Size(426, 24);
            loginForm.WrongUserPassContainer.MinSize = new System.Drawing.Size(426, 24);
            loginForm.WrongUserPassContainer.Name = "WrongUserPassContainer";
            loginForm.WrongUserPassContainer.Size = new System.Drawing.Size(426, 24);
            loginForm.WrongUserPassContainer.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            loginForm.WrongUserPassContainer.TextSize = new System.Drawing.Size(0, 0);
            loginForm.WrongUserPassContainer.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            loginForm.layoutControlItem6.Control = loginForm.CancelBtn;
            loginForm.layoutControlItem6.Location = new System.Drawing.Point(213, 95);
            loginForm.layoutControlItem6.MaxSize = new System.Drawing.Size(214, 0);
            loginForm.layoutControlItem6.MinSize = new System.Drawing.Size(214, 26);
            loginForm.layoutControlItem6.Name = "layoutControlItem6";
            loginForm.layoutControlItem6.Size = new System.Drawing.Size(214, 26);
            loginForm.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            loginForm.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            loginForm.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            loginForm.emptySpaceItem1.AllowHotTrack = false;
            loginForm.emptySpaceItem1.Location = new System.Drawing.Point(0, 121);
            loginForm.emptySpaceItem1.Name = "emptySpaceItem1";
            loginForm.emptySpaceItem1.Size = new System.Drawing.Size(213, 139);
            loginForm.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            loginForm.emptySpaceItem2.AllowHotTrack = false;
            loginForm.emptySpaceItem2.Location = new System.Drawing.Point(213, 121);
            loginForm.emptySpaceItem2.Name = "emptySpaceItem2";
            loginForm.emptySpaceItem2.Size = new System.Drawing.Size(214, 139);
            loginForm.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // LoginForm
            // 
            loginForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            loginForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            loginForm.ClientSize = new System.Drawing.Size(475, 348);
            loginForm.Controls.Add(loginForm.layoutControl1);
            loginForm.Name = "LoginForm";
            loginForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            loginForm.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControl1).EndInit();
            loginForm.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loginForm.txtUsername.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.txtPassword.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.simpleSeparator1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.WrongUserPassContainer).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.layoutControlItem6).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginForm.emptySpaceItem2).EndInit();
            loginForm.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.Label WrongUserPassLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton OkBtn;
        private DevExpress.XtraEditors.SimpleButton CancelBtn;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraLayout.LayoutControlItem WrongUserPassContainer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
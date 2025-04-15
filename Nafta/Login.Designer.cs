namespace Nafta
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.MiniApp = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.CloseApp = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.EmailLoginText = new ZBobb.AlphaBlendTextBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.LoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelForgot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPictureBox3 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCheckBox1 = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordLoginText = new ZBobb.AlphaBlendTextBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 75;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.MiniApp);
            this.bunifuGradientPanel1.Controls.Add(this.CloseApp);
            this.bunifuGradientPanel1.Controls.Add(this.EmailLoginText);
            this.bunifuGradientPanel1.Controls.Add(this.labelRegister);
            this.bunifuGradientPanel1.Controls.Add(this.LoginButton);
            this.bunifuGradientPanel1.Controls.Add(this.labelForgot);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCheckBox1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.panel2);
            this.bunifuGradientPanel1.Controls.Add(this.PasswordLoginText);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-4, -4);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(338, 505);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // MiniApp
            // 
            this.MiniApp.AllowFocused = false;
            this.MiniApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MiniApp.AutoSizeHeight = true;
            this.MiniApp.BorderRadius = 14;
            this.MiniApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiniApp.Image = global::Nafta.Properties.Resources.minimize_solid;
            this.MiniApp.IsCircle = true;
            this.MiniApp.Location = new System.Drawing.Point(252, 19);
            this.MiniApp.Margin = new System.Windows.Forms.Padding(2);
            this.MiniApp.Name = "MiniApp";
            this.MiniApp.Size = new System.Drawing.Size(28, 28);
            this.MiniApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MiniApp.TabIndex = 16;
            this.MiniApp.TabStop = false;
            this.MiniApp.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.MiniApp.Click += new System.EventHandler(this.MiniApp_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.AllowFocused = false;
            this.CloseApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseApp.AutoSizeHeight = true;
            this.CloseApp.BorderRadius = 14;
            this.CloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApp.Image = global::Nafta.Properties.Resources.circle_xmark_regular;
            this.CloseApp.IsCircle = true;
            this.CloseApp.Location = new System.Drawing.Point(284, 19);
            this.CloseApp.Margin = new System.Windows.Forms.Padding(2);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(28, 28);
            this.CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseApp.TabIndex = 15;
            this.CloseApp.TabStop = false;
            this.CloseApp.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // EmailLoginText
            // 
            this.EmailLoginText.BackAlpha = 0;
            this.EmailLoginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmailLoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailLoginText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLoginText.ForeColor = System.Drawing.Color.White;
            this.EmailLoginText.Location = new System.Drawing.Point(62, 178);
            this.EmailLoginText.Margin = new System.Windows.Forms.Padding(2);
            this.EmailLoginText.Name = "EmailLoginText";
            this.EmailLoginText.Size = new System.Drawing.Size(250, 20);
            this.EmailLoginText.TabIndex = 0;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.White;
            this.labelRegister.Location = new System.Drawing.Point(137, 440);
            this.labelRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(72, 21);
            this.labelRegister.TabIndex = 14;
            this.labelRegister.Text = "Register";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.ActiveBorderThickness = 1;
            this.LoginButton.ActiveCornerRadius = 37;
            this.LoginButton.ActiveFillColor = System.Drawing.Color.Purple;
            this.LoginButton.ActiveForecolor = System.Drawing.Color.White;
            this.LoginButton.ActiveLineColor = System.Drawing.Color.Black;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "Login";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleCornerRadius = 37;
            this.LoginButton.IdleFillColor = System.Drawing.Color.White;
            this.LoginButton.IdleForecolor = System.Drawing.Color.Black;
            this.LoginButton.IdleLineColor = System.Drawing.Color.Purple;
            this.LoginButton.Location = new System.Drawing.Point(88, 378);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(162, 50);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // labelForgot
            // 
            this.labelForgot.AutoSize = true;
            this.labelForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelForgot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgot.ForeColor = System.Drawing.Color.White;
            this.labelForgot.Location = new System.Drawing.Point(105, 467);
            this.labelForgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForgot.Name = "labelForgot";
            this.labelForgot.Size = new System.Drawing.Size(137, 21);
            this.labelForgot.TabIndex = 12;
            this.labelForgot.Text = "Forgot Password";
            this.labelForgot.Click += new System.EventHandler(this.labelForgot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "LOG IN";
            // 
            // bunifuPictureBox3
            // 
            this.bunifuPictureBox3.AllowFocused = false;
            this.bunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox3.AutoSizeHeight = true;
            this.bunifuPictureBox3.BorderRadius = 39;
            this.bunifuPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox3.Image")));
            this.bunifuPictureBox3.IsCircle = false;
            this.bunifuPictureBox3.Location = new System.Drawing.Point(130, 19);
            this.bunifuPictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPictureBox3.Name = "bunifuPictureBox3";
            this.bunifuPictureBox3.Size = new System.Drawing.Size(79, 79);
            this.bunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox3.TabIndex = 9;
            this.bunifuPictureBox3.TabStop = false;
            this.bunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remember me";
            // 
            // bunifuCheckBox1
            // 
            this.bunifuCheckBox1.AllowBindingControlAnimation = true;
            this.bunifuCheckBox1.AllowBindingControlColorChanges = false;
            this.bunifuCheckBox1.AllowBindingControlLocation = true;
            this.bunifuCheckBox1.AllowCheckBoxAnimation = false;
            this.bunifuCheckBox1.AllowCheckmarkAnimation = true;
            this.bunifuCheckBox1.AllowOnHoverStates = true;
            this.bunifuCheckBox1.AutoCheck = true;
            this.bunifuCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCheckBox1.BackgroundImage")));
            this.bunifuCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuCheckBox1.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.bunifuCheckBox1.BorderRadius = 12;
            this.bunifuCheckBox1.Checked = true;
            this.bunifuCheckBox1.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.bunifuCheckBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCheckBox1.CustomCheckmarkImage = null;
            this.bunifuCheckBox1.Location = new System.Drawing.Point(31, 293);
            this.bunifuCheckBox1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuCheckBox1.MinimumSize = new System.Drawing.Size(13, 14);
            this.bunifuCheckBox1.Name = "bunifuCheckBox1";
            this.bunifuCheckBox1.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnCheck.BorderThickness = 2;
            this.bunifuCheckBox1.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCheckBox1.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnCheck.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.BorderRadius = 12;
            this.bunifuCheckBox1.OnDisable.BorderThickness = 2;
            this.bunifuCheckBox1.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.bunifuCheckBox1.OnDisable.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverChecked.BorderThickness = 2;
            this.bunifuCheckBox1.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.bunifuCheckBox1.OnHoverChecked.CheckmarkThickness = 2;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuCheckBox1.OnHoverUnchecked.BorderRadius = 12;
            this.bunifuCheckBox1.OnHoverUnchecked.BorderThickness = 1;
            this.bunifuCheckBox1.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuCheckBox1.OnUncheck.BorderRadius = 12;
            this.bunifuCheckBox1.OnUncheck.BorderThickness = 1;
            this.bunifuCheckBox1.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.bunifuCheckBox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckBox1.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.bunifuCheckBox1.TabIndex = 7;
            this.bunifuCheckBox1.ThreeState = false;
            this.bunifuCheckBox1.ToolTipText = null;
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 14;
            this.bunifuPictureBox2.Image = global::Nafta.Properties.Resources.lock_solid;
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(32, 233);
            this.bunifuPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(28, 28);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 6;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(26, 266);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 2);
            this.panel2.TabIndex = 5;
            // 
            // PasswordLoginText
            // 
            this.PasswordLoginText.BackAlpha = 0;
            this.PasswordLoginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLoginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordLoginText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLoginText.ForeColor = System.Drawing.Color.White;
            this.PasswordLoginText.Location = new System.Drawing.Point(64, 241);
            this.PasswordLoginText.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordLoginText.Name = "PasswordLoginText";
            this.PasswordLoginText.Size = new System.Drawing.Size(250, 20);
            this.PasswordLoginText.TabIndex = 4;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 14;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(30, 170);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(28, 28);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 3;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(24, 203);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 2);
            this.panel1.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 500);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private ZBobb.AlphaBlendTextBox EmailLoginText;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuCheckBox bunifuCheckBox1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private System.Windows.Forms.Panel panel2;
        private ZBobb.AlphaBlendTextBox PasswordLoginText;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelForgot;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginButton;
        private System.Windows.Forms.Label labelRegister;
        private Bunifu.UI.WinForms.BunifuPictureBox MiniApp;
        private Bunifu.UI.WinForms.BunifuPictureBox CloseApp;
    }
}


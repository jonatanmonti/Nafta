namespace Nafta
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.BackButton = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.MiniApp = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.CloseApp = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.SendButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.labelForgot = new System.Windows.Forms.Label();
            this.bunifuPictureBox3 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmailForgotText = new ZBobb.AlphaBlendTextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.BackButton);
            this.bunifuGradientPanel1.Controls.Add(this.MiniApp);
            this.bunifuGradientPanel1.Controls.Add(this.CloseApp);
            this.bunifuGradientPanel1.Controls.Add(this.SendButton);
            this.bunifuGradientPanel1.Controls.Add(this.labelForgot);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.EmailForgotText);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-7, -2);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(451, 622);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // BackButton
            // 
            this.BackButton.AllowFocused = false;
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButton.AutoSizeHeight = true;
            this.BackButton.BorderRadius = 18;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Image = global::Nafta.Properties.Resources.backward_solid;
            this.BackButton.IsCircle = true;
            this.BackButton.Location = new System.Drawing.Point(33, 23);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(37, 37);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackButton.TabIndex = 21;
            this.BackButton.TabStop = false;
            this.BackButton.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MiniApp
            // 
            this.MiniApp.AllowFocused = false;
            this.MiniApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MiniApp.AutoSizeHeight = true;
            this.MiniApp.BorderRadius = 18;
            this.MiniApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiniApp.Image = global::Nafta.Properties.Resources.minimize_solid;
            this.MiniApp.IsCircle = true;
            this.MiniApp.Location = new System.Drawing.Point(337, 23);
            this.MiniApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MiniApp.Name = "MiniApp";
            this.MiniApp.Size = new System.Drawing.Size(37, 37);
            this.MiniApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MiniApp.TabIndex = 18;
            this.MiniApp.TabStop = false;
            this.MiniApp.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.MiniApp.Click += new System.EventHandler(this.MiniApp_Click);
            // 
            // CloseApp
            // 
            this.CloseApp.AllowFocused = false;
            this.CloseApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseApp.AutoSizeHeight = true;
            this.CloseApp.BorderRadius = 18;
            this.CloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApp.Image = global::Nafta.Properties.Resources.circle_xmark_regular;
            this.CloseApp.IsCircle = true;
            this.CloseApp.Location = new System.Drawing.Point(380, 23);
            this.CloseApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(37, 37);
            this.CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseApp.TabIndex = 17;
            this.CloseApp.TabStop = false;
            this.CloseApp.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // SendButton
            // 
            this.SendButton.ActiveBorderThickness = 1;
            this.SendButton.ActiveCornerRadius = 37;
            this.SendButton.ActiveFillColor = System.Drawing.Color.Purple;
            this.SendButton.ActiveForecolor = System.Drawing.Color.White;
            this.SendButton.ActiveLineColor = System.Drawing.Color.Black;
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendButton.BackgroundImage")));
            this.SendButton.ButtonText = "Send";
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.Black;
            this.SendButton.IdleBorderThickness = 1;
            this.SendButton.IdleCornerRadius = 37;
            this.SendButton.IdleFillColor = System.Drawing.Color.White;
            this.SendButton.IdleForecolor = System.Drawing.Color.Black;
            this.SendButton.IdleLineColor = System.Drawing.Color.Purple;
            this.SendButton.Location = new System.Drawing.Point(117, 540);
            this.SendButton.Margin = new System.Windows.Forms.Padding(5);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(216, 62);
            this.SendButton.TabIndex = 13;
            this.SendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelForgot
            // 
            this.labelForgot.AutoSize = true;
            this.labelForgot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgot.ForeColor = System.Drawing.Color.White;
            this.labelForgot.Location = new System.Drawing.Point(119, 138);
            this.labelForgot.Name = "labelForgot";
            this.labelForgot.Size = new System.Drawing.Size(204, 23);
            this.labelForgot.TabIndex = 10;
            this.labelForgot.Text = "FORGOT PASSWORD";
            // 
            // bunifuPictureBox3
            // 
            this.bunifuPictureBox3.AllowFocused = false;
            this.bunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox3.AutoSizeHeight = true;
            this.bunifuPictureBox3.BorderRadius = 52;
            this.bunifuPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox3.Image")));
            this.bunifuPictureBox3.IsCircle = false;
            this.bunifuPictureBox3.Location = new System.Drawing.Point(173, 23);
            this.bunifuPictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPictureBox3.Name = "bunifuPictureBox3";
            this.bunifuPictureBox3.Size = new System.Drawing.Size(105, 105);
            this.bunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox3.TabIndex = 9;
            this.bunifuPictureBox3.TabStop = false;
            this.bunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 18;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(41, 289);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(37, 37);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 3;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(33, 330);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 2);
            this.panel1.TabIndex = 1;
            // 
            // EmailForgotText
            // 
            this.EmailForgotText.BackAlpha = 0;
            this.EmailForgotText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmailForgotText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailForgotText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailForgotText.ForeColor = System.Drawing.Color.White;
            this.EmailForgotText.Location = new System.Drawing.Point(84, 299);
            this.EmailForgotText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailForgotText.Name = "EmailForgotText";
            this.EmailForgotText.Size = new System.Drawing.Size(333, 25);
            this.EmailForgotText.TabIndex = 0;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 615);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPasswordForm";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox BackButton;
        private Bunifu.UI.WinForms.BunifuPictureBox MiniApp;
        private Bunifu.UI.WinForms.BunifuPictureBox CloseApp;
        private Bunifu.Framework.UI.BunifuThinButton2 SendButton;
        private System.Windows.Forms.Label labelForgot;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox3;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private ZBobb.AlphaBlendTextBox EmailForgotText;
    }
}
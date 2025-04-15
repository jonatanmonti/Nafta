namespace Nafta
{
    partial class FormRegisterCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterCode));
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.labelCode = new System.Windows.Forms.Label();
            this.MiniApp = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.CloseApp = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.SendButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuPictureBox3 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CodeRegisterText = new ZBobb.AlphaBlendTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.labelCode);
            this.bunifuGradientPanel1.Controls.Add(this.MiniApp);
            this.bunifuGradientPanel1.Controls.Add(this.CloseApp);
            this.bunifuGradientPanel1.Controls.Add(this.SendButton);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.CodeRegisterText);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-5, -2);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(338, 505);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.ForeColor = System.Drawing.Color.White;
            this.labelCode.Location = new System.Drawing.Point(128, 193);
            this.labelCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(87, 28);
            this.labelCode.TabIndex = 22;
            this.labelCode.Text = "CODE:";
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
            this.MiniApp.Location = new System.Drawing.Point(253, 19);
            this.MiniApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MiniApp.Name = "MiniApp";
            this.MiniApp.Size = new System.Drawing.Size(28, 28);
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
            this.CloseApp.BorderRadius = 14;
            this.CloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseApp.Image = global::Nafta.Properties.Resources.circle_xmark_regular;
            this.CloseApp.IsCircle = true;
            this.CloseApp.Location = new System.Drawing.Point(285, 19);
            this.CloseApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(28, 28);
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
            this.SendButton.Location = new System.Drawing.Point(88, 439);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(162, 50);
            this.SendButton.TabIndex = 13;
            this.SendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
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
            this.bunifuPictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuPictureBox3.Name = "bunifuPictureBox3";
            this.bunifuPictureBox3.Size = new System.Drawing.Size(79, 79);
            this.bunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox3.TabIndex = 9;
            this.bunifuPictureBox3.TabStop = false;
            this.bunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(25, 268);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 2);
            this.panel1.TabIndex = 1;
            // 
            // CodeRegisterText
            // 
            this.CodeRegisterText.BackAlpha = 0;
            this.CodeRegisterText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CodeRegisterText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeRegisterText.ForeColor = System.Drawing.Color.White;
            this.CodeRegisterText.Location = new System.Drawing.Point(45, 237);
            this.CodeRegisterText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CodeRegisterText.Name = "CodeRegisterText";
            this.CodeRegisterText.Size = new System.Drawing.Size(251, 27);
            this.CodeRegisterText.TabIndex = 0;
            this.CodeRegisterText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 75;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormRegisterCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 500);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRegisterCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegisterCode";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiniApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox MiniApp;
        private Bunifu.UI.WinForms.BunifuPictureBox CloseApp;
        private Bunifu.Framework.UI.BunifuThinButton2 SendButton;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox3;
        private System.Windows.Forms.Panel panel1;
        private ZBobb.AlphaBlendTextBox CodeRegisterText;
        private System.Windows.Forms.Label labelCode;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
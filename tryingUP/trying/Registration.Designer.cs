namespace trying
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Driver = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Passenger = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // button1
            // 
            this.button1.ActiveBorderThickness = 1;
            this.button1.ActiveCornerRadius = 1;
            this.button1.ActiveFillColor = System.Drawing.Color.White;
            this.button1.ActiveForecolor = System.Drawing.Color.DeepSkyBlue;
            this.button1.ActiveLineColor = System.Drawing.Color.White;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ButtonText = "Back";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.IdleBorderThickness = 1;
            this.button1.IdleCornerRadius = 1;
            this.button1.IdleFillColor = System.Drawing.Color.White;
            this.button1.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.button1.IdleLineColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(169, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 42);
            this.button1.TabIndex = 31;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Driver
            // 
            this.Driver.ActiveBorderThickness = 1;
            this.Driver.ActiveCornerRadius = 10;
            this.Driver.ActiveFillColor = System.Drawing.Color.MediumVioletRed;
            this.Driver.ActiveForecolor = System.Drawing.Color.White;
            this.Driver.ActiveLineColor = System.Drawing.Color.White;
            this.Driver.BackColor = System.Drawing.SystemColors.Control;
            this.Driver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Driver.BackgroundImage")));
            this.Driver.ButtonText = "Driver";
            this.Driver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Driver.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Driver.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Driver.IdleBorderThickness = 1;
            this.Driver.IdleCornerRadius = 10;
            this.Driver.IdleFillColor = System.Drawing.Color.DeepPink;
            this.Driver.IdleForecolor = System.Drawing.Color.LightGray;
            this.Driver.IdleLineColor = System.Drawing.Color.Transparent;
            this.Driver.Location = new System.Drawing.Point(264, 147);
            this.Driver.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Driver.Name = "Driver";
            this.Driver.Size = new System.Drawing.Size(190, 69);
            this.Driver.TabIndex = 32;
            this.Driver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Driver.Click += new System.EventHandler(this.Driver_Click_1);
            // 
            // Passenger
            // 
            this.Passenger.ActiveBorderThickness = 1;
            this.Passenger.ActiveCornerRadius = 10;
            this.Passenger.ActiveFillColor = System.Drawing.Color.MediumVioletRed;
            this.Passenger.ActiveForecolor = System.Drawing.Color.White;
            this.Passenger.ActiveLineColor = System.Drawing.Color.White;
            this.Passenger.BackColor = System.Drawing.SystemColors.Control;
            this.Passenger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Passenger.BackgroundImage")));
            this.Passenger.ButtonText = "Passenger";
            this.Passenger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Passenger.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passenger.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Passenger.IdleBorderThickness = 1;
            this.Passenger.IdleCornerRadius = 10;
            this.Passenger.IdleFillColor = System.Drawing.Color.DeepPink;
            this.Passenger.IdleForecolor = System.Drawing.Color.LightGray;
            this.Passenger.IdleLineColor = System.Drawing.Color.Transparent;
            this.Passenger.Location = new System.Drawing.Point(28, 147);
            this.Passenger.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Passenger.Name = "Passenger";
            this.Passenger.Size = new System.Drawing.Size(190, 69);
            this.Passenger.TabIndex = 33;
            this.Passenger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Passenger.Click += new System.EventHandler(this.Passenger_Click_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(28, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 10);
            this.panel2.TabIndex = 34;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(154, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(149, 34);
            this.bunifuCustomLabel1.TabIndex = 47;
            this.bunifuCustomLabel1.Text = "SignUp As";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trying.Properties.Resources._15c0617c5daff3011a2055550f8b36ad__s_wallpaper_art_fractal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 337);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Passenger);
            this.Controls.Add(this.Driver);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 Passenger;
        private Bunifu.Framework.UI.BunifuThinButton2 Driver;
        private Bunifu.Framework.UI.BunifuThinButton2 button1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;

    }
}
namespace trying
{
    partial class Trip_Started
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trip_Started));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.End_trip = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.from = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.to = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // End_trip
            // 
            this.End_trip.ActiveBorderThickness = 1;
            this.End_trip.ActiveCornerRadius = 1;
            this.End_trip.ActiveFillColor = System.Drawing.Color.White;
            this.End_trip.ActiveForecolor = System.Drawing.Color.DeepSkyBlue;
            this.End_trip.ActiveLineColor = System.Drawing.Color.White;
            this.End_trip.BackColor = System.Drawing.SystemColors.Control;
            this.End_trip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("End_trip.BackgroundImage")));
            this.End_trip.ButtonText = "End Trip";
            this.End_trip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.End_trip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_trip.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.End_trip.IdleBorderThickness = 1;
            this.End_trip.IdleCornerRadius = 1;
            this.End_trip.IdleFillColor = System.Drawing.Color.White;
            this.End_trip.IdleForecolor = System.Drawing.Color.SteelBlue;
            this.End_trip.IdleLineColor = System.Drawing.Color.Transparent;
            this.End_trip.Location = new System.Drawing.Point(102, 333);
            this.End_trip.Margin = new System.Windows.Forms.Padding(5);
            this.End_trip.Name = "End_trip";
            this.End_trip.Size = new System.Drawing.Size(241, 66);
            this.End_trip.TabIndex = 31;
            this.End_trip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.End_trip.Click += new System.EventHandler(this.End_trip_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "From";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.BackColor = System.Drawing.Color.Transparent;
            this.from.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.ForeColor = System.Drawing.Color.White;
            this.from.Location = new System.Drawing.Point(117, 17);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(109, 23);
            this.from.TabIndex = 34;
            this.from.Text = "Full Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.from);
            this.panel2.Location = new System.Drawing.Point(44, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 62);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.to);
            this.panel3.Location = new System.Drawing.Point(44, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 62);
            this.panel3.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "To";
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.BackColor = System.Drawing.Color.Transparent;
            this.to.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.ForeColor = System.Drawing.Color.White;
            this.to.Location = new System.Drawing.Point(117, 20);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(109, 23);
            this.to.TabIndex = 34;
            this.to.Text = "Full Name";
            // 
            // Trip_Started
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trying.Properties.Resources.Galaxy_S5_Stock_Wallpapers_5_1920_x_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 433);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.End_trip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1000, 200);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Trip_Started";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trip_Started";
            this.Load += new System.EventHandler(this.Trip_Started_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 End_trip;
        private Bunifu.Framework.UI.BunifuCustomLabel from;
        private Bunifu.Framework.UI.BunifuCustomLabel label1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel label4;
        private Bunifu.Framework.UI.BunifuCustomLabel to;
        private System.Windows.Forms.Panel panel2;
    }
}
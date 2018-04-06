namespace trying
{
    partial class DriverData
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rating = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.color = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.carBrand = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.rating);
            this.panel1.Controls.Add(this.color);
            this.panel1.Controls.Add(this.carBrand);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(57, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 276);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.BackColor = System.Drawing.Color.Transparent;
            this.rating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rating.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.rating.ForeColor = System.Drawing.Color.White;
            this.rating.Location = new System.Drawing.Point(188, 217);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(55, 22);
            this.rating.TabIndex = 45;
            this.rating.Text = "label8";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.BackColor = System.Drawing.Color.Transparent;
            this.color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.color.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.color.ForeColor = System.Drawing.Color.White;
            this.color.Location = new System.Drawing.Point(188, 156);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(55, 22);
            this.color.TabIndex = 44;
            this.color.Text = "label7";
            // 
            // carBrand
            // 
            this.carBrand.AutoSize = true;
            this.carBrand.BackColor = System.Drawing.Color.Transparent;
            this.carBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carBrand.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBrand.ForeColor = System.Drawing.Color.White;
            this.carBrand.Location = new System.Drawing.Point(188, 100);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(55, 22);
            this.carBrand.TabIndex = 43;
            this.carBrand.Text = "label6";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(188, 32);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 22);
            this.name.TabIndex = 42;
            this.name.Text = "label5";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Car Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Name";
            // 
            // DriverData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trying.Properties.Resources._15c0617c5daff3011a2055550f8b36ad__s_wallpaper_art_fractal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 356);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(200, 1000);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DriverData";
            this.Text = "DriverData";
            this.Load += new System.EventHandler(this.DriverData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel label4;
        private Bunifu.Framework.UI.BunifuCustomLabel label3;
        private Bunifu.Framework.UI.BunifuCustomLabel label2;
        private Bunifu.Framework.UI.BunifuCustomLabel label1;
        private Bunifu.Framework.UI.BunifuCustomLabel rating;
        private Bunifu.Framework.UI.BunifuCustomLabel color;
        private Bunifu.Framework.UI.BunifuCustomLabel carBrand;
        private Bunifu.Framework.UI.BunifuCustomLabel name;
    }
}
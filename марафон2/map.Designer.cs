namespace марафон2
{
    partial class map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(map));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lmedical = new System.Windows.Forms.Label();
            this.linformation = new System.Windows.Forms.Label();
            this.ltoilets = new System.Windows.Forms.Label();
            this.lenergy = new System.Windows.Forms.Label();
            this.ldrinks = new System.Windows.Forms.Label();
            this.medical = new System.Windows.Forms.PictureBox();
            this.information = new System.Windows.Forms.PictureBox();
            this.toilets = new System.Windows.Forms.PictureBox();
            this.energy = new System.Windows.Forms.PictureBox();
            this.drinks = new System.Windows.Forms.PictureBox();
            this.services = new System.Windows.Forms.Label();
            this.landmarkN = new System.Windows.Forms.Label();
            this.landmark = new System.Windows.Forms.Label();
            this.check1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.fullrace = new System.Windows.Forms.PictureBox();
            this.halfrace = new System.Windows.Forms.PictureBox();
            this.funrace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toilets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.energy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.halfrace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funrace)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(326, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "MARATHON SKILLS 2020";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(143, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Интерактивная карта";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(206, 464);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(207, 16);
            this.time.TabIndex = 29;
            this.time.Text = "0 дней 0 часов и 0 минут до марафона!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(-6, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(640, 417);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-32, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lmedical);
            this.panel1.Controls.Add(this.linformation);
            this.panel1.Controls.Add(this.ltoilets);
            this.panel1.Controls.Add(this.lenergy);
            this.panel1.Controls.Add(this.ldrinks);
            this.panel1.Controls.Add(this.medical);
            this.panel1.Controls.Add(this.information);
            this.panel1.Controls.Add(this.toilets);
            this.panel1.Controls.Add(this.energy);
            this.panel1.Controls.Add(this.drinks);
            this.panel1.Controls.Add(this.services);
            this.panel1.Controls.Add(this.landmarkN);
            this.panel1.Controls.Add(this.landmark);
            this.panel1.Controls.Add(this.check1);
            this.panel1.Location = new System.Drawing.Point(438, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 371);
            this.panel1.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(138, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 26);
            this.button2.TabIndex = 14;
            this.button2.Text = "Х\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lmedical
            // 
            this.lmedical.AutoSize = true;
            this.lmedical.Cursor = System.Windows.Forms.Cursors.Default;
            this.lmedical.Location = new System.Drawing.Point(79, 318);
            this.lmedical.Name = "lmedical";
            this.lmedical.Size = new System.Drawing.Size(44, 16);
            this.lmedical.TabIndex = 13;
            this.lmedical.Text = "Medical";
            // 
            // linformation
            // 
            this.linformation.AutoSize = true;
            this.linformation.Cursor = System.Windows.Forms.Cursors.Default;
            this.linformation.Location = new System.Drawing.Point(79, 274);
            this.linformation.Name = "linformation";
            this.linformation.Size = new System.Drawing.Size(59, 16);
            this.linformation.TabIndex = 12;
            this.linformation.Text = "Information";
            // 
            // ltoilets
            // 
            this.ltoilets.AutoSize = true;
            this.ltoilets.Cursor = System.Windows.Forms.Cursors.Default;
            this.ltoilets.Location = new System.Drawing.Point(79, 223);
            this.ltoilets.Name = "ltoilets";
            this.ltoilets.Size = new System.Drawing.Size(38, 16);
            this.ltoilets.TabIndex = 11;
            this.ltoilets.Text = "Toilets";
            this.ltoilets.Click += new System.EventHandler(this.label9_Click);
            // 
            // lenergy
            // 
            this.lenergy.AutoSize = true;
            this.lenergy.Cursor = System.Windows.Forms.Cursors.Default;
            this.lenergy.Location = new System.Drawing.Point(73, 174);
            this.lenergy.Name = "lenergy";
            this.lenergy.Size = new System.Drawing.Size(68, 16);
            this.lenergy.TabIndex = 10;
            this.lenergy.Text = "Energy Bars";
            // 
            // ldrinks
            // 
            this.ldrinks.AutoSize = true;
            this.ldrinks.Cursor = System.Windows.Forms.Cursors.Default;
            this.ldrinks.Location = new System.Drawing.Point(79, 130);
            this.ldrinks.Name = "ldrinks";
            this.ldrinks.Size = new System.Drawing.Size(38, 16);
            this.ldrinks.TabIndex = 9;
            this.ldrinks.Text = "Drinks";
            // 
            // medical
            // 
            this.medical.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.medical.Image = global::марафон2.Properties.Resources.map_icon_medical;
            this.medical.Location = new System.Drawing.Point(14, 310);
            this.medical.Name = "medical";
            this.medical.Size = new System.Drawing.Size(47, 43);
            this.medical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medical.TabIndex = 8;
            this.medical.TabStop = false;
            // 
            // information
            // 
            this.information.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.information.Image = global::марафон2.Properties.Resources.map_icon_information;
            this.information.Location = new System.Drawing.Point(14, 262);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(47, 40);
            this.information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.information.TabIndex = 7;
            this.information.TabStop = false;
            // 
            // toilets
            // 
            this.toilets.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.toilets.Image = ((System.Drawing.Image)(resources.GetObject("toilets.Image")));
            this.toilets.Location = new System.Drawing.Point(14, 210);
            this.toilets.Name = "toilets";
            this.toilets.Size = new System.Drawing.Size(47, 46);
            this.toilets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toilets.TabIndex = 6;
            this.toilets.TabStop = false;
            // 
            // energy
            // 
            this.energy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.energy.Image = ((System.Drawing.Image)(resources.GetObject("energy.Image")));
            this.energy.Location = new System.Drawing.Point(14, 164);
            this.energy.Name = "energy";
            this.energy.Size = new System.Drawing.Size(47, 40);
            this.energy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.energy.TabIndex = 5;
            this.energy.TabStop = false;
            // 
            // drinks
            // 
            this.drinks.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.drinks.Image = ((System.Drawing.Image)(resources.GetObject("drinks.Image")));
            this.drinks.Location = new System.Drawing.Point(14, 114);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(47, 44);
            this.drinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drinks.TabIndex = 4;
            this.drinks.TabStop = false;
            // 
            // services
            // 
            this.services.AutoSize = true;
            this.services.Location = new System.Drawing.Point(39, 73);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(96, 16);
            this.services.TabIndex = 3;
            this.services.Text = "Services Provider:";
            // 
            // landmarkN
            // 
            this.landmarkN.AutoSize = true;
            this.landmarkN.Location = new System.Drawing.Point(39, 53);
            this.landmarkN.Name = "landmarkN";
            this.landmarkN.Size = new System.Drawing.Size(84, 16);
            this.landmarkN.TabIndex = 2;
            this.landmarkN.Text = "Landmark name";
            // 
            // landmark
            // 
            this.landmark.AutoSize = true;
            this.landmark.Location = new System.Drawing.Point(39, 33);
            this.landmark.Name = "landmark";
            this.landmark.Size = new System.Drawing.Size(58, 16);
            this.landmark.TabIndex = 1;
            this.landmark.Text = "Landmark:";
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(36, 13);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(69, 16);
            this.check1.TabIndex = 0;
            this.check1.Text = "Checkpoint 1";
            // 
            // b1
            // 
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Location = new System.Drawing.Point(341, 64);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(38, 25);
            this.b1.TabIndex = 33;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Location = new System.Drawing.Point(191, 231);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(38, 25);
            this.b2.TabIndex = 34;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Location = new System.Drawing.Point(330, 340);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(38, 27);
            this.b3.TabIndex = 35;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button4_Click);
            // 
            // b4
            // 
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Location = new System.Drawing.Point(126, 406);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(37, 31);
            this.b4.TabIndex = 36;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Location = new System.Drawing.Point(63, 186);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(38, 26);
            this.b5.TabIndex = 37;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Location = new System.Drawing.Point(21, 64);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(36, 31);
            this.b6.TabIndex = 38;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // fullrace
            // 
            this.fullrace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullrace.Image = ((System.Drawing.Image)(resources.GetObject("fullrace.Image")));
            this.fullrace.Location = new System.Drawing.Point(230, 53);
            this.fullrace.Name = "fullrace";
            this.fullrace.Size = new System.Drawing.Size(48, 42);
            this.fullrace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fullrace.TabIndex = 39;
            this.fullrace.TabStop = false;
            this.fullrace.Click += new System.EventHandler(this.fullrace_Click);
            // 
            // halfrace
            // 
            this.halfrace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.halfrace.Image = ((System.Drawing.Image)(resources.GetObject("halfrace.Image")));
            this.halfrace.Location = new System.Drawing.Point(169, 394);
            this.halfrace.Name = "halfrace";
            this.halfrace.Size = new System.Drawing.Size(48, 43);
            this.halfrace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.halfrace.TabIndex = 40;
            this.halfrace.TabStop = false;
            this.halfrace.Click += new System.EventHandler(this.halfrace_Click);
            // 
            // funrace
            // 
            this.funrace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.funrace.Image = ((System.Drawing.Image)(resources.GetObject("funrace.Image")));
            this.funrace.Location = new System.Drawing.Point(12, 165);
            this.funrace.Name = "funrace";
            this.funrace.Size = new System.Drawing.Size(45, 47);
            this.funrace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.funrace.TabIndex = 41;
            this.funrace.TabStop = false;
            this.funrace.Click += new System.EventHandler(this.funrace_Click);
            // 
            // map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(640, 489);
            this.Controls.Add(this.funrace);
            this.Controls.Add(this.halfrace);
            this.Controls.Add(this.fullrace);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "map";
            this.Text = "Marathon Skills 2020 - Interactive map";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toilets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.energy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.halfrace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funrace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lmedical;
        private System.Windows.Forms.Label linformation;
        private System.Windows.Forms.Label ltoilets;
        private System.Windows.Forms.Label lenergy;
        private System.Windows.Forms.Label ldrinks;
        private System.Windows.Forms.PictureBox medical;
        private System.Windows.Forms.PictureBox information;
        private System.Windows.Forms.PictureBox toilets;
        private System.Windows.Forms.PictureBox energy;
        private System.Windows.Forms.PictureBox drinks;
        private System.Windows.Forms.Label services;
        private System.Windows.Forms.Label landmarkN;
        private System.Windows.Forms.Label landmark;
        private System.Windows.Forms.Label check1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.PictureBox fullrace;
        private System.Windows.Forms.PictureBox halfrace;
        private System.Windows.Forms.PictureBox funrace;
        private System.Windows.Forms.Button button2;
    }
}
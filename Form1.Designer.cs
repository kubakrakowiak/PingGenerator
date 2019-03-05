namespace nauka
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.wynik = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.kolozycia = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.ipadress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pasek_count = new Bunifu.Framework.UI.BunifuRange();
            this.label2 = new System.Windows.Forms.Label();
            this.ilosc_pakietow_label = new System.Windows.Forms.Label();
            this.pasek_packet_size = new Bunifu.Framework.UI.BunifuRange();
            this.wielkosc_pakietu_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.bunifuiOSSwitch1);
            this.bunifuCards1.Controls.Add(this.wielkosc_pakietu_label);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.pasek_packet_size);
            this.bunifuCards1.Controls.Add(this.ilosc_pakietow_label);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.wynik);
            this.bunifuCards1.Controls.Add(this.bunifuThinButton21);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.kolozycia);
            this.bunifuCards1.Controls.Add(this.ipadress);
            this.bunifuCards1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards1.Controls.Add(this.pasek_count);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-4, -2);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(809, 458);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // wynik
            // 
            this.wynik.FormattingEnabled = true;
            this.wynik.Location = new System.Drawing.Point(40, 356);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(721, 69);
            this.wynik.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.85F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(131, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ping Generator by Jakub Krakowiak";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(40, 65);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(721, 35);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // kolozycia
            // 
            this.kolozycia.animated = false;
            this.kolozycia.animationIterval = 5;
            this.kolozycia.animationSpeed = 300;
            this.kolozycia.BackColor = System.Drawing.Color.White;
            this.kolozycia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kolozycia.BackgroundImage")));
            this.kolozycia.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.kolozycia.ForeColor = System.Drawing.Color.SeaGreen;
            this.kolozycia.LabelVisible = true;
            this.kolozycia.LineProgressThickness = 8;
            this.kolozycia.LineThickness = 5;
            this.kolozycia.Location = new System.Drawing.Point(40, 129);
            this.kolozycia.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.kolozycia.MaxValue = 100;
            this.kolozycia.Name = "kolozycia";
            this.kolozycia.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.kolozycia.ProgressColor = System.Drawing.Color.SeaGreen;
            this.kolozycia.Size = new System.Drawing.Size(193, 193);
            this.kolozycia.TabIndex = 6;
            this.kolozycia.Value = 0;
            // 
            // ipadress
            // 
            this.ipadress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ipadress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ipadress.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ipadress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ipadress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ipadress.HintForeColor = System.Drawing.Color.Empty;
            this.ipadress.HintText = "";
            this.ipadress.isPassword = false;
            this.ipadress.LineFocusedColor = System.Drawing.Color.Blue;
            this.ipadress.LineIdleColor = System.Drawing.Color.Gray;
            this.ipadress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ipadress.LineThickness = 3;
            this.ipadress.Location = new System.Drawing.Point(297, 159);
            this.ipadress.Margin = new System.Windows.Forms.Padding(4);
            this.ipadress.MaxLength = 32767;
            this.ipadress.Name = "ipadress";
            this.ipadress.Size = new System.Drawing.Size(415, 34);
            this.ipadress.TabIndex = 5;
            this.ipadress.Text = "Adres IP";
            this.ipadress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Wyslij Ping";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(297, 281);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(174, 41);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "Wyslij Ping";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pasek_count
            // 
            this.pasek_count.BackColor = System.Drawing.Color.Transparent;
            this.pasek_count.BackgroudColor = System.Drawing.Color.DarkGray;
            this.pasek_count.BorderRadius = 0;
            this.pasek_count.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.pasek_count.Location = new System.Drawing.Point(297, 247);
            this.pasek_count.MaximumRange = 102;
            this.pasek_count.Name = "pasek_count";
            this.pasek_count.RangeMax = 10;
            this.pasek_count.RangeMin = 0;
            this.pasek_count.Size = new System.Drawing.Size(415, 30);
            this.pasek_count.TabIndex = 3;
            this.pasek_count.RangeChanged += new System.EventHandler(this.bunifuRange1_RangeChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(294, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ilość Pakietów";
            // 
            // ilosc_pakietow_label
            // 
            this.ilosc_pakietow_label.AutoSize = true;
            this.ilosc_pakietow_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.ilosc_pakietow_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ilosc_pakietow_label.Location = new System.Drawing.Point(302, 116);
            this.ilosc_pakietow_label.Name = "ilosc_pakietow_label";
            this.ilosc_pakietow_label.Size = new System.Drawing.Size(55, 39);
            this.ilosc_pakietow_label.TabIndex = 14;
            this.ilosc_pakietow_label.Text = "10";
            // 
            // pasek_packet_size
            // 
            this.pasek_packet_size.BackColor = System.Drawing.Color.Transparent;
            this.pasek_packet_size.BackgroudColor = System.Drawing.Color.DarkGray;
            this.pasek_packet_size.BorderRadius = 0;
            this.pasek_packet_size.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.pasek_packet_size.Location = new System.Drawing.Point(297, 211);
            this.pasek_packet_size.MaximumRange = 1400;
            this.pasek_packet_size.Name = "pasek_packet_size";
            this.pasek_packet_size.RangeMax = 140;
            this.pasek_packet_size.RangeMin = 0;
            this.pasek_packet_size.Size = new System.Drawing.Size(415, 30);
            this.pasek_packet_size.TabIndex = 15;
            this.pasek_packet_size.RangeChanged += new System.EventHandler(this.pasek_packet_size_RangeChanged);
            // 
            // wielkosc_pakietu_label
            // 
            this.wielkosc_pakietu_label.AutoSize = true;
            this.wielkosc_pakietu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.wielkosc_pakietu_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wielkosc_pakietu_label.Location = new System.Drawing.Point(462, 116);
            this.wielkosc_pakietu_label.Name = "wielkosc_pakietu_label";
            this.wielkosc_pakietu_label.Size = new System.Drawing.Size(74, 39);
            this.wielkosc_pakietu_label.TabIndex = 17;
            this.wielkosc_pakietu_label.Text = "140";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(456, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Wielkość pakietu";
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(646, 129);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch1.TabIndex = 18;
            this.bunifuiOSSwitch1.Value = true;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Zamknij Aplikacje";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.Location = new System.Drawing.Point(518, 275);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(194, 50);
            this.bunifuThinButton21.TabIndex = 9;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuRange pasek_count;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar kolozycia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ipadress;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wynik;
        private System.Windows.Forms.Label ilosc_pakietow_label;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuRange pasek_packet_size;
        private System.Windows.Forms.Label wielkosc_pakietu_label;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}


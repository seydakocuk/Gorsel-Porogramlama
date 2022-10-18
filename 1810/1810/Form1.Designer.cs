namespace _1810
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sicilBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciSicilBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKimlikBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciAdresBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciBölümBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciNotBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciHarçBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programdanÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(65, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci İslemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğrenci Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sicilBilgileriToolStripMenuItem,
            this.programToolStripMenuItem,
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sicilBilgileriToolStripMenuItem
            // 
            this.sicilBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciSicilBilgileriToolStripMenuItem,
            this.öğrenciNotBilgileriToolStripMenuItem,
            this.öğrenciHarçBilgileriToolStripMenuItem});
            this.sicilBilgileriToolStripMenuItem.Name = "sicilBilgileriToolStripMenuItem";
            this.sicilBilgileriToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.sicilBilgileriToolStripMenuItem.Text = "Sicil Bilgileri";
            // 
            // öğrenciSicilBilgileriToolStripMenuItem
            // 
            this.öğrenciSicilBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKimlikBilgileriToolStripMenuItem,
            this.öğrenciAdresBilgileriToolStripMenuItem,
            this.öğrenciBölümBilgileriToolStripMenuItem});
            this.öğrenciSicilBilgileriToolStripMenuItem.Name = "öğrenciSicilBilgileriToolStripMenuItem";
            this.öğrenciSicilBilgileriToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.öğrenciSicilBilgileriToolStripMenuItem.Text = "Öğrenci &Sicil Bilgileri";
            // 
            // öğrenciKimlikBilgileriToolStripMenuItem
            // 
            this.öğrenciKimlikBilgileriToolStripMenuItem.Name = "öğrenciKimlikBilgileriToolStripMenuItem";
            this.öğrenciKimlikBilgileriToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.öğrenciKimlikBilgileriToolStripMenuItem.Text = "Öğrenci Kimlik Bilgileri";
            this.öğrenciKimlikBilgileriToolStripMenuItem.Click += new System.EventHandler(this.öğrenciKimlikBilgileriToolStripMenuItem_Click);
            // 
            // öğrenciAdresBilgileriToolStripMenuItem
            // 
            this.öğrenciAdresBilgileriToolStripMenuItem.Name = "öğrenciAdresBilgileriToolStripMenuItem";
            this.öğrenciAdresBilgileriToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.öğrenciAdresBilgileriToolStripMenuItem.Text = "Öğrenci Adres Bilgileri";
            // 
            // öğrenciBölümBilgileriToolStripMenuItem
            // 
            this.öğrenciBölümBilgileriToolStripMenuItem.Name = "öğrenciBölümBilgileriToolStripMenuItem";
            this.öğrenciBölümBilgileriToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.öğrenciBölümBilgileriToolStripMenuItem.Text = "Öğrenci Bölüm Bilgileri";
            // 
            // öğrenciNotBilgileriToolStripMenuItem
            // 
            this.öğrenciNotBilgileriToolStripMenuItem.Name = "öğrenciNotBilgileriToolStripMenuItem";
            this.öğrenciNotBilgileriToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.öğrenciNotBilgileriToolStripMenuItem.Text = "Öğrenci &Not Bilgileri";
            // 
            // öğrenciHarçBilgileriToolStripMenuItem
            // 
            this.öğrenciHarçBilgileriToolStripMenuItem.Name = "öğrenciHarçBilgileriToolStripMenuItem";
            this.öğrenciHarçBilgileriToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.öğrenciHarçBilgileriToolStripMenuItem.Text = "Öğrenci &Harç Bilgileri";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programHakkındaToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.programdanÇıkışToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // programHakkındaToolStripMenuItem
            // 
            this.programHakkındaToolStripMenuItem.Name = "programHakkındaToolStripMenuItem";
            this.programHakkındaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.programHakkındaToolStripMenuItem.Text = "Program Hakkında";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // programdanÇıkışToolStripMenuItem
            // 
            this.programdanÇıkışToolStripMenuItem.Name = "programdanÇıkışToolStripMenuItem";
            this.programdanÇıkışToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.programdanÇıkışToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.programdanÇıkışToolStripMenuItem.Text = "Programdan Çıkış";
            this.programdanÇıkışToolStripMenuItem.Click += new System.EventHandler(this.programdanÇıkışToolStripMenuItem_Click);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciKaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // öğrenciKaydetToolStripMenuItem
            // 
            this.öğrenciKaydetToolStripMenuItem.Name = "öğrenciKaydetToolStripMenuItem";
            this.öğrenciKaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.öğrenciKaydetToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.öğrenciKaydetToolStripMenuItem.Text = "Öğrenci Kaydet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sicilBilgileriToolStripMenuItem;
        private ToolStripMenuItem öğrenciSicilBilgileriToolStripMenuItem;
        private ToolStripMenuItem öğrenciKimlikBilgileriToolStripMenuItem;
        private ToolStripMenuItem öğrenciAdresBilgileriToolStripMenuItem;
        private ToolStripMenuItem öğrenciBölümBilgileriToolStripMenuItem;
        private ToolStripMenuItem öğrenciNotBilgileriToolStripMenuItem;
        private ToolStripMenuItem öğrenciHarçBilgileriToolStripMenuItem;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem programHakkındaToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem programdanÇıkışToolStripMenuItem;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem öğrenciKaydetToolStripMenuItem;
    }
}
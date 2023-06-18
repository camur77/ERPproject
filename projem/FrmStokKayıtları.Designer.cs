namespace projem
{
    partial class FrmStokKayıtları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokKayıtları));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sbtnGrupKodListesi = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnStokListesi = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKdvorani = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvorani.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(157, 42);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(125, 22);
            this.txtStokKodu.TabIndex = 2;
            this.txtStokKodu.Leave += new System.EventHandler(this.txtStokKodu_Leave);
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(157, 89);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(125, 22);
            this.txtStokAdi.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 24);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Stok Adı";
            // 
            // txtGrupKodu
            // 
            this.txtGrupKodu.Location = new System.Drawing.Point(157, 137);
            this.txtGrupKodu.Name = "txtGrupKodu";
            this.txtGrupKodu.Size = new System.Drawing.Size(59, 22);
            this.txtGrupKodu.TabIndex = 5;
            this.txtGrupKodu.EditValueChanged += new System.EventHandler(this.c);
            this.txtGrupKodu.Leave += new System.EventHandler(this.txtGrupKodu_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(93, 24);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Grup Kodu";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // sbtnGrupKodListesi
            // 
            this.sbtnGrupKodListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGrupKodListesi.ImageOptions.Image")));
            this.sbtnGrupKodListesi.Location = new System.Drawing.Point(233, 124);
            this.sbtnGrupKodListesi.Name = "sbtnGrupKodListesi";
            this.sbtnGrupKodListesi.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnGrupKodListesi.Size = new System.Drawing.Size(37, 35);
            this.sbtnGrupKodListesi.TabIndex = 6;
            this.sbtnGrupKodListesi.Click += new System.EventHandler(this.sbtnGrupKodListesi_Click);
            // 
            // sbtnStokListesi
            // 
            this.sbtnStokListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnStokListesi.ImageOptions.Image")));
            this.sbtnStokListesi.Location = new System.Drawing.Point(300, 29);
            this.sbtnStokListesi.Name = "sbtnStokListesi";
            this.sbtnStokListesi.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnStokListesi.Size = new System.Drawing.Size(37, 35);
            this.sbtnStokListesi.TabIndex = 3;
            this.sbtnStokListesi.Click += new System.EventHandler(this.sbtnStokListesi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGrupAdi);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.sbtnStokListesi);
            this.groupBox1.Controls.Add(this.txtStokKodu);
            this.groupBox1.Controls.Add(this.sbtnGrupKodListesi);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtGrupKodu);
            this.groupBox1.Controls.Add(this.txtStokAdi);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Enabled = false;
            this.txtGrupAdi.Location = new System.Drawing.Point(289, 137);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Size = new System.Drawing.Size(107, 22);
            this.txtGrupAdi.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(14, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(43, 24);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.EditValue = "";
            this.txtFiyat.Location = new System.Drawing.Point(147, 41);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(112, 22);
            this.txtFiyat.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(14, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 24);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "KDV Oranı";
            // 
            // txtKdvorani
            // 
            this.txtKdvorani.Location = new System.Drawing.Point(147, 80);
            this.txtKdvorani.Name = "txtKdvorani";
            this.txtKdvorani.Size = new System.Drawing.Size(112, 22);
            this.txtKdvorani.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtKdvorani);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Location = new System.Drawing.Point(24, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 137);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Bilgisi";
            // 
            // sbtnKaydet
            // 
            this.sbtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnKaydet.ImageOptions.Image")));
            this.sbtnKaydet.Location = new System.Drawing.Point(350, 271);
            this.sbtnKaydet.Name = "sbtnKaydet";
            this.sbtnKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnKaydet.Size = new System.Drawing.Size(107, 35);
            this.sbtnKaydet.TabIndex = 11;
            this.sbtnKaydet.Text = "Kaydet";
            this.sbtnKaydet.Click += new System.EventHandler(this.sbtnKaydet_Click);
            // 
            // sbtnSil
            // 
            this.sbtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSil.ImageOptions.Image")));
            this.sbtnSil.Location = new System.Drawing.Point(350, 321);
            this.sbtnSil.Name = "sbtnSil";
            this.sbtnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnSil.Size = new System.Drawing.Size(107, 35);
            this.sbtnSil.TabIndex = 12;
            this.sbtnSil.Text = "Sil";
            this.sbtnSil.Click += new System.EventHandler(this.sbtnSil_Click);
            // 
            // FrmStokKayıtları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 408);
            this.Controls.Add(this.sbtnSil);
            this.Controls.Add(this.sbtnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmStokKayıtları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Kartı Kayıtları";
            this.Activated += new System.EventHandler(this.FrmStokKayıtları_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStokKayıtları_FormClosed);
            this.Load += new System.EventHandler(this.FrmStokKayıtları_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStokKayıtları_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvorani.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGrupKodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbtnGrupKodListesi;
        private DevExpress.XtraEditors.SimpleButton sbtnStokListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtKdvorani;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbtnKaydet;
        private DevExpress.XtraEditors.SimpleButton sbtnSil;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
    }
}
namespace projem
{
    partial class FrmIsEmriListesi
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Si = new System.Windows.Forms.GroupBox();
            this.txtSiparisNumarasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIsEmriNumarasi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.Si.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisNumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmriNumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(6, 29);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(814, 299);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 661;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Si
            // 
            this.Si.Controls.Add(this.gridControl1);
            this.Si.Location = new System.Drawing.Point(15, 15);
            this.Si.Margin = new System.Windows.Forms.Padding(6);
            this.Si.Name = "Si";
            this.Si.Padding = new System.Windows.Forms.Padding(6);
            this.Si.Size = new System.Drawing.Size(826, 334);
            this.Si.TabIndex = 18;
            this.Si.TabStop = false;
            this.Si.Text = "İş Emri Listesi";
            // 
            // txtSiparisNumarasi
            // 
            this.txtSiparisNumarasi.Location = new System.Drawing.Point(555, 44);
            this.txtSiparisNumarasi.Margin = new System.Windows.Forms.Padding(6);
            this.txtSiparisNumarasi.Name = "txtSiparisNumarasi";
            this.txtSiparisNumarasi.Size = new System.Drawing.Size(236, 22);
            this.txtSiparisNumarasi.TabIndex = 3;
            this.txtSiparisNumarasi.TextChanged += new System.EventHandler(this.txtSiparisNumarasi_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(394, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(149, 24);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Sipariş Numarası";
            // 
            // txtIsEmriNumarasi
            // 
            this.txtIsEmriNumarasi.Location = new System.Drawing.Point(186, 44);
            this.txtIsEmriNumarasi.Margin = new System.Windows.Forms.Padding(6);
            this.txtIsEmriNumarasi.Name = "txtIsEmriNumarasi";
            this.txtIsEmriNumarasi.Size = new System.Drawing.Size(176, 22);
            this.txtIsEmriNumarasi.TabIndex = 2;
            this.txtIsEmriNumarasi.TextChanged += new System.EventHandler(this.txtIsEmriNumarasi_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(152, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İş Emri Numarası";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(555, 96);
            this.txtStokAdi.Margin = new System.Windows.Forms.Padding(6);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(236, 22);
            this.txtStokAdi.TabIndex = 7;
            this.txtStokAdi.TextChanged += new System.EventHandler(this.txtStokAdi_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(394, 94);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 24);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Stok Adı";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(186, 96);
            this.txtStokKodu.Margin = new System.Windows.Forms.Padding(6);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(176, 22);
            this.txtStokKodu.TabIndex = 6;
            this.txtStokKodu.TextChanged += new System.EventHandler(this.txtStokKodu_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 94);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 24);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Stok Kodu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.txtStokKodu);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txtStokAdi);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtIsEmriNumarasi);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtSiparisNumarasi);
            this.groupBox1.Location = new System.Drawing.Point(559, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(10, 10);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İş Emri Bilgileri";
            this.groupBox1.Visible = false;
            // 
            // FrmIsEmriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 361);
            this.Controls.Add(this.Si);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmIsEmriListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İş Emri Listesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIsEmriListesi_FormClosed);
            this.Load += new System.EventHandler(this.FrmIsEmriListesi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmIsEmriListesi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.Si.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparisNumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsEmriNumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox Si;
        private DevExpress.XtraEditors.TextEdit txtSiparisNumarasi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIsEmriNumarasi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
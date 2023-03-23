namespace projem
{
    partial class FrmMusteriListesi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIlce = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIl = new DevExpress.XtraEditors.TextEdit();
            this.txtMusteriAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).BeginInit();
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
            this.gridControl1.Size = new System.Drawing.Size(841, 329);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(481, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(853, 364);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stok Listesi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIlce);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtMusteriKodu);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtIl);
            this.groupBox1.Controls.Add(this.txtMusteriAdi);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Location = new System.Drawing.Point(14, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(455, 364);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(189, 262);
            this.txtIlce.Margin = new System.Windows.Forms.Padding(6);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(176, 22);
            this.txtIlce.TabIndex = 7;
            this.txtIlce.TextChanged += new System.EventHandler(this.txtIlce_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(45, 258);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 24);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "İlçe";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 85);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Müşteri Kodu";
            // 
            // txtMusteriKodu
            // 
            this.txtMusteriKodu.Location = new System.Drawing.Point(189, 87);
            this.txtMusteriKodu.Margin = new System.Windows.Forms.Padding(6);
            this.txtMusteriKodu.Name = "txtMusteriKodu";
            this.txtMusteriKodu.Size = new System.Drawing.Size(236, 22);
            this.txtMusteriKodu.TabIndex = 2;
            this.txtMusteriKodu.TextChanged += new System.EventHandler(this.txtMusteriKodu_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 140);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 24);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Müşteri Adı";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(189, 203);
            this.txtIl.Margin = new System.Windows.Forms.Padding(6);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(176, 22);
            this.txtIl.TabIndex = 4;
            this.txtIl.TextChanged += new System.EventHandler(this.txtIl_TextChanged);
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(189, 144);
            this.txtMusteriAdi.Margin = new System.Windows.Forms.Padding(6);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(236, 22);
            this.txtMusteriAdi.TabIndex = 3;
            this.txtMusteriAdi.TextChanged += new System.EventHandler(this.txtMusteriAdi_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 199);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 24);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "İl";
            // 
            // FrmMusteriListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteriListesi";
            this.Text = "Müşteri Listesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMusteriListesi_FormClosed);
            this.Load += new System.EventHandler(this.FrmMusteriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMusteriKodu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIl;
        private DevExpress.XtraEditors.TextEdit txtMusteriAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtIlce;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
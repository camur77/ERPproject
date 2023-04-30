namespace projem
{
    partial class FrmSiparisSevk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparisSevk));
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Si = new System.Windows.Forms.GroupBox();
            this.gridsiparislistesi = new DevExpress.XtraGrid.GridControl();
            this.gridviewsiparis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridsiparisicerik = new DevExpress.XtraGrid.GridControl();
            this.gridviewsiparisiceri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.Si.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridsiparislistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewsiparis)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridsiparisicerik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewsiparisiceri)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(23, 29);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(414, 28);
            this.searchLookUpEdit1.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(473, 21);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Size = new System.Drawing.Size(260, 45);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Müşteri Sipariş Raporunu Getir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Si
            // 
            this.Si.Controls.Add(this.gridsiparislistesi);
            this.Si.Location = new System.Drawing.Point(23, 91);
            this.Si.Margin = new System.Windows.Forms.Padding(6);
            this.Si.Name = "Si";
            this.Si.Padding = new System.Windows.Forms.Padding(6);
            this.Si.Size = new System.Drawing.Size(734, 192);
            this.Si.TabIndex = 17;
            this.Si.TabStop = false;
            this.Si.Text = "Sevke Hazır Sipariş Listesi";
            // 
            // gridsiparislistesi
            // 
            this.gridsiparislistesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridsiparislistesi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridsiparislistesi.Location = new System.Drawing.Point(6, 29);
            this.gridsiparislistesi.MainView = this.gridviewsiparis;
            this.gridsiparislistesi.Margin = new System.Windows.Forms.Padding(6);
            this.gridsiparislistesi.Name = "gridsiparislistesi";
            this.gridsiparislistesi.Size = new System.Drawing.Size(722, 157);
            this.gridsiparislistesi.TabIndex = 0;
            this.gridsiparislistesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewsiparis});
            // 
            // gridviewsiparis
            // 
            this.gridviewsiparis.DetailHeight = 661;
            this.gridviewsiparis.GridControl = this.gridsiparislistesi;
            this.gridviewsiparis.Name = "gridviewsiparis";
            this.gridviewsiparis.OptionsView.ShowGroupPanel = false;
            this.gridviewsiparis.Click += new System.EventHandler(this.gridviewsiparis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridsiparisicerik);
            this.groupBox1.Location = new System.Drawing.Point(23, 295);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(734, 274);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçili Siparişin İçeriği";
            // 
            // gridsiparisicerik
            // 
            this.gridsiparisicerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridsiparisicerik.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridsiparisicerik.Location = new System.Drawing.Point(6, 29);
            this.gridsiparisicerik.MainView = this.gridviewsiparisiceri;
            this.gridsiparisicerik.Margin = new System.Windows.Forms.Padding(6);
            this.gridsiparisicerik.Name = "gridsiparisicerik";
            this.gridsiparisicerik.Size = new System.Drawing.Size(722, 239);
            this.gridsiparisicerik.TabIndex = 0;
            this.gridsiparisicerik.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewsiparisiceri});
            // 
            // gridviewsiparisiceri
            // 
            this.gridviewsiparisiceri.DetailHeight = 661;
            this.gridviewsiparisiceri.GridControl = this.gridsiparisicerik;
            this.gridviewsiparisiceri.Name = "gridviewsiparisiceri";
            this.gridviewsiparisiceri.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(497, 578);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(260, 45);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "Siparişi Sevk Et";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmSiparisSevk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 645);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Si);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSiparisSevk";
            this.Text = "Sipariş Sevk";
            this.Load += new System.EventHandler(this.FrmSiparisSevk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.Si.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridsiparislistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewsiparis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridsiparisicerik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewsiparisiceri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.GroupBox Si;
        private DevExpress.XtraGrid.GridControl gridsiparislistesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewsiparis;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridsiparisicerik;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewsiparisiceri;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
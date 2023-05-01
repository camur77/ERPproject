namespace projem
{
    partial class FrmUretilecekIsEmirleri
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUretilecekIsEmirleri));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colISEMRI_NUMARASI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOK_KODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOK_ADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISEMRI_ACIKLAMASI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliŞEMRİTARİHİ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTESLİMTARİHİ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIPARIS_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIPKALEM_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "halil.ERP.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = "SELECT ISEMRI_NUMARASI, STOK_KODU, STOK_ADI, ISEMRI_ACIKLAMASI,SUBSTRING(ISEMRI_T" +
    "ARIHI,0,10),SUBSTRING(TESLIM_TARIHI,0,10),SIPARIS_NO,MIKTAR,SIPKALEM_ID FROM TBL" +
    "_ISEMRI WHERE DURUM = \'A\'";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "halil.ERP.dbo";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery4.Name = "Query";
            customSqlQuery4.Sql = resources.GetString("customSqlQuery4.Sql");
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery4});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Query";
            this.gridControl1.DataSource = this.sqlDataSource2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1538, 618);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colISEMRI_NUMARASI,
            this.colSTOK_KODU,
            this.colSTOK_ADI,
            this.colISEMRI_ACIKLAMASI,
            this.coliŞEMRİTARİHİ,
            this.colTESLİMTARİHİ,
            this.colSIPARIS_NO,
            this.colMIKTAR,
            this.colSIPKALEM_ID,
            this.gridColumn1});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colISEMRI_NUMARASI
            // 
            this.colISEMRI_NUMARASI.Caption = "İŞ EMRİ NUMARASI";
            this.colISEMRI_NUMARASI.FieldName = "ISEMRI_NUMARASI";
            this.colISEMRI_NUMARASI.MinWidth = 39;
            this.colISEMRI_NUMARASI.Name = "colISEMRI_NUMARASI";
            this.colISEMRI_NUMARASI.Visible = true;
            this.colISEMRI_NUMARASI.VisibleIndex = 1;
            this.colISEMRI_NUMARASI.Width = 146;
            // 
            // colSTOK_KODU
            // 
            this.colSTOK_KODU.Caption = "STOK KODU";
            this.colSTOK_KODU.FieldName = "STOK_KODU";
            this.colSTOK_KODU.MinWidth = 39;
            this.colSTOK_KODU.Name = "colSTOK_KODU";
            this.colSTOK_KODU.Visible = true;
            this.colSTOK_KODU.VisibleIndex = 2;
            this.colSTOK_KODU.Width = 146;
            // 
            // colSTOK_ADI
            // 
            this.colSTOK_ADI.Caption = "STOK ADI";
            this.colSTOK_ADI.FieldName = "STOK_ADI";
            this.colSTOK_ADI.MinWidth = 39;
            this.colSTOK_ADI.Name = "colSTOK_ADI";
            this.colSTOK_ADI.Visible = true;
            this.colSTOK_ADI.VisibleIndex = 3;
            this.colSTOK_ADI.Width = 146;
            // 
            // colISEMRI_ACIKLAMASI
            // 
            this.colISEMRI_ACIKLAMASI.Caption = "AÇIKLAMA";
            this.colISEMRI_ACIKLAMASI.FieldName = "ISEMRI_ACIKLAMASI";
            this.colISEMRI_ACIKLAMASI.MinWidth = 39;
            this.colISEMRI_ACIKLAMASI.Name = "colISEMRI_ACIKLAMASI";
            this.colISEMRI_ACIKLAMASI.Visible = true;
            this.colISEMRI_ACIKLAMASI.VisibleIndex = 4;
            this.colISEMRI_ACIKLAMASI.Width = 146;
            // 
            // coliŞEMRİTARİHİ
            // 
            this.coliŞEMRİTARİHİ.Caption = "İŞ EMRİ TARİHİ";
            this.coliŞEMRİTARİHİ.FieldName = "iŞ EMRİ TARİHİ";
            this.coliŞEMRİTARİHİ.MinWidth = 39;
            this.coliŞEMRİTARİHİ.Name = "coliŞEMRİTARİHİ";
            this.coliŞEMRİTARİHİ.Visible = true;
            this.coliŞEMRİTARİHİ.VisibleIndex = 5;
            this.coliŞEMRİTARİHİ.Width = 146;
            // 
            // colTESLİMTARİHİ
            // 
            this.colTESLİMTARİHİ.Caption = "TESLIM TARIHI";
            this.colTESLİMTARİHİ.FieldName = "TESLİM TARİHİ";
            this.colTESLİMTARİHİ.MinWidth = 39;
            this.colTESLİMTARİHİ.Name = "colTESLİMTARİHİ";
            this.colTESLİMTARİHİ.Visible = true;
            this.colTESLİMTARİHİ.VisibleIndex = 6;
            this.colTESLİMTARİHİ.Width = 146;
            // 
            // colSIPARIS_NO
            // 
            this.colSIPARIS_NO.Caption = "SIPARIS NUMARASI";
            this.colSIPARIS_NO.FieldName = "SIPARIS_NO";
            this.colSIPARIS_NO.MinWidth = 39;
            this.colSIPARIS_NO.Name = "colSIPARIS_NO";
            this.colSIPARIS_NO.Visible = true;
            this.colSIPARIS_NO.VisibleIndex = 7;
            this.colSIPARIS_NO.Width = 146;
            // 
            // colMIKTAR
            // 
            this.colMIKTAR.Caption = "MIKTAR";
            this.colMIKTAR.FieldName = "MIKTAR";
            this.colMIKTAR.MinWidth = 39;
            this.colMIKTAR.Name = "colMIKTAR";
            this.colMIKTAR.Visible = true;
            this.colMIKTAR.VisibleIndex = 8;
            this.colMIKTAR.Width = 146;
            // 
            // colSIPKALEM_ID
            // 
            this.colSIPKALEM_ID.Caption = "Kalem ID";
            this.colSIPKALEM_ID.FieldName = "SIPKALEM_ID";
            this.colSIPKALEM_ID.MinWidth = 39;
            this.colSIPKALEM_ID.Name = "colSIPKALEM_ID";
            this.colSIPKALEM_ID.Visible = true;
            this.colSIPKALEM_ID.VisibleIndex = 9;
            this.colSIPKALEM_ID.Width = 146;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Üretim";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn1.MinWidth = 39;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 146;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            editorButtonImageOptions2.Location = DevExpress.XtraEditors.ImageLocation.Default;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Üretimi Yap", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // FrmUretilecekIsEmirleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 618);
            this.Controls.Add(this.gridControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUretilecekIsEmirleri";
            this.Text = "Yönetim Üretim";
            this.Load += new System.EventHandler(this.FrmUretilecekIsEmirleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colISEMRI_NUMARASI;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOK_KODU;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOK_ADI;
        private DevExpress.XtraGrid.Columns.GridColumn colISEMRI_ACIKLAMASI;
        private DevExpress.XtraGrid.Columns.GridColumn coliŞEMRİTARİHİ;
        private DevExpress.XtraGrid.Columns.GridColumn colTESLİMTARİHİ;
        private DevExpress.XtraGrid.Columns.GridColumn colSIPARIS_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colSIPKALEM_ID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
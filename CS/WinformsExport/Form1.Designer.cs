
namespace WinFormsExport
{
    partial class Form1
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo10 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chartControl1
            // 
            this.chartControl1.AutoLayout = false;
            this.chartControl1.DataSource = this.pivotGridControl1;
            xyDiagram1.AxisX.Title.Text = "Category Name";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Extended Price";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl1.Location = new System.Drawing.Point(0, 248);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            this.chartControl1.SeriesTemplate.SeriesDataMember = "Series";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.Size = new System.Drawing.Size(917, 200);
            this.chartControl1.TabIndex = 1;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.excelDataSource1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldCountry,
            this.fieldExtendedPrice});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 24);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.SelectionOnly = false;
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(917, 224);
            this.pivotGridControl1.TabIndex = 2;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "..\\..\\Data\\SalesPerson.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = "PFZpZXc+PEZpZWxkIE5hbWU9IkNhdGVnb3J5TmFtZSIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lP" +
    "SJDb3VudHJ5IiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IkV4dGVuZGVkIFByaWNlIiBUeXBlP" +
    "SJEb3VibGUiIC8+PC9WaWV3Pg==";
            fieldInfo1.Name = "CategoryName";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "Country";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "ProductName";
            fieldInfo3.Selected = false;
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "Sales Person";
            fieldInfo4.Selected = false;
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "OrderDate";
            fieldInfo5.Selected = false;
            fieldInfo5.Type = typeof(System.DateTime);
            fieldInfo6.Name = "OrderID";
            fieldInfo6.Selected = false;
            fieldInfo6.Type = typeof(double);
            fieldInfo7.Name = "Quantity";
            fieldInfo7.Selected = false;
            fieldInfo7.Type = typeof(double);
            fieldInfo8.Name = "Discount";
            fieldInfo8.Selected = false;
            fieldInfo8.Type = typeof(double);
            fieldInfo9.Name = "Extended Price";
            fieldInfo9.Type = typeof(double);
            fieldInfo10.Name = "UnitPrice";
            fieldInfo10.Selected = false;
            fieldInfo10.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8,
            fieldInfo9,
            fieldInfo10});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetIndex = null;
            excelWorksheetSettings1.WorksheetName = "Data";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.excelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            dataSourceColumnBinding1.ColumnName = "CategoryName";
            this.fieldCategoryName.DataBinding = dataSourceColumnBinding1;
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            dataSourceColumnBinding2.ColumnName = "Country";
            this.fieldCountry.DataBinding = dataSourceColumnBinding2;
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Extended Price";
            dataSourceColumnBinding3.ColumnName = "Extended Price";
            this.fieldExtendedPrice.DataBinding = dataSourceColumnBinding3;
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 448);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCountry;
        private DevExpress.XtraPivotGrid.PivotGridField fieldExtendedPrice;
    }
}


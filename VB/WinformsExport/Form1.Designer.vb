Namespace WinFormsExport

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim fieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo6 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo7 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo8 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo9 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo10 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim excelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim excelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' menuStrip1
            ' 
            Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.Size = New System.Drawing.Size(917, 24)
            Me.menuStrip1.TabIndex = 0
            Me.menuStrip1.Text = "menuStrip1"
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.AutoLayout = False
            Me.chartControl1.DataSource = Me.pivotGridControl1
            xyDiagram1.AxisX.Title.Text = "Category Name"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Title.Text = "Extended Price"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.chartControl1.Legend.MaxHorizontalPercentage = 30R
            Me.chartControl1.Location = New System.Drawing.Point(0, 248)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesDataMember = "Series"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
            Me.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Me.chartControl1.SeriesTemplate.SeriesDataMember = "Series"
            Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chartControl1.Size = New System.Drawing.Size(917, 200)
            Me.chartControl1.TabIndex = 1
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.excelDataSource1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName, Me.fieldCountry, Me.fieldExtendedPrice})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 24)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsChartDataSource.SelectionOnly = False
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(917, 224)
            Me.pivotGridControl1.TabIndex = 2
            ' 
            ' excelDataSource1
            ' 
            Me.excelDataSource1.FileName = "..\..\Data\SalesPerson.xlsx"
            Me.excelDataSource1.Name = "excelDataSource1"
            Me.excelDataSource1.ResultSchemaSerializable = "PFZpZXc+PEZpZWxkIE5hbWU9IkNhdGVnb3J5TmFtZSIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lP" & "SJDb3VudHJ5IiBUeXBlPSJTdHJpbmciIC8+PEZpZWxkIE5hbWU9IkV4dGVuZGVkIFByaWNlIiBUeXBlP" & "SJEb3VibGUiIC8+PC9WaWV3Pg=="
            fieldInfo1.Name = "CategoryName"
            fieldInfo1.Type = GetType(String)
            fieldInfo2.Name = "Country"
            fieldInfo2.Type = GetType(String)
            fieldInfo3.Name = "ProductName"
            fieldInfo3.Selected = False
            fieldInfo3.Type = GetType(String)
            fieldInfo4.Name = "Sales Person"
            fieldInfo4.Selected = False
            fieldInfo4.Type = GetType(String)
            fieldInfo5.Name = "OrderDate"
            fieldInfo5.Selected = False
            fieldInfo5.Type = GetType(System.DateTime)
            fieldInfo6.Name = "OrderID"
            fieldInfo6.Selected = False
            fieldInfo6.Type = GetType(Double)
            fieldInfo7.Name = "Quantity"
            fieldInfo7.Selected = False
            fieldInfo7.Type = GetType(Double)
            fieldInfo8.Name = "Discount"
            fieldInfo8.Selected = False
            fieldInfo8.Type = GetType(Double)
            fieldInfo9.Name = "Extended Price"
            fieldInfo9.Type = GetType(Double)
            fieldInfo10.Name = "UnitPrice"
            fieldInfo10.Selected = False
            fieldInfo10.Type = GetType(Double)
            Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9, fieldInfo10})
            excelWorksheetSettings1.CellRange = Nothing
            excelWorksheetSettings1.WorksheetIndex = Nothing
            excelWorksheetSettings1.WorksheetName = "Data"
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1
            Me.excelDataSource1.SourceOptions = excelSourceOptions1
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            dataSourceColumnBinding1.ColumnName = "CategoryName"
            Me.fieldCategoryName.DataBinding = dataSourceColumnBinding1
            Me.fieldCategoryName.Name = "fieldCategoryName"
            ' 
            ' fieldCountry
            ' 
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCountry.AreaIndex = 0
            Me.fieldCountry.Caption = "Country"
            dataSourceColumnBinding2.ColumnName = "Country"
            Me.fieldCountry.DataBinding = dataSourceColumnBinding2
            Me.fieldCountry.Name = "fieldCountry"
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            dataSourceColumnBinding3.ColumnName = "Extended Price"
            Me.fieldExtendedPrice.DataBinding = dataSourceColumnBinding3
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(917, 448)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.menuStrip1)
            Me.MainMenuStrip = Me.menuStrip1
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

'#End Region
        Private menuStrip1 As System.Windows.Forms.MenuStrip

        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace

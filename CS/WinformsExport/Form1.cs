﻿using DevExpress.XtraCharts;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System;
using System.Windows.Forms;

namespace WinFormsExport {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
            ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                toolStripMenuItem1,
                toolStripMenuItem2 });
            toolStripMenuItem1.Name = "Print Preview";
            toolStripMenuItem1.Text = "Print Preview";
            toolStripMenuItem2.Name = "Export to XLSX";
            toolStripMenuItem2.Text = "Export to XLSX";

            toolStripMenuItem1.Click += toolsToolStripMenuItem2_Click;
            toolStripMenuItem2.Click += toolsToolStripMenuItem_Click;

            // This line of code is generated by Data Source Configuration Wizard
            // Fill the ExcelDataSource asynchronously
            excelDataSource1.FillAsync();
        }

        private CompositeLink CreateCompositeLink(PivotGridControl pivotGridControl1, ChartControl chartControl1)
        {
            PrintableComponentLink pivotLink = new PrintableComponentLink();
            pivotLink.Component = pivotGridControl1;
            PrintableComponentLink chartLink = new PrintableComponentLink();
            chartLink.Component = chartControl1;
            CompositeLink compositeLink = new CompositeLink(new PrintingSystem());
            compositeLink.Links.AddRange(new object[] { pivotLink, chartLink });
            return compositeLink;
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Workbook|*.xlsx";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") {
                CompositeLink compositeLink = CreateCompositeLink(pivotGridControl1, chartControl1);
                compositeLink.ExportToXlsx(saveFileDialog1.FileName);
            }
        }
        private void toolsToolStripMenuItem2_Click(object sender, EventArgs e) {
            CompositeLink compositeLink = CreateCompositeLink(pivotGridControl1, chartControl1);
            compositeLink.ShowPreview();
        }

    }
}

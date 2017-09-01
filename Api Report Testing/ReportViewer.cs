using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace YBInterface.Support
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
          
        }

        private void Btn_B010003_Click(object sender, EventArgs e)
        {
            string responseXmlDoc = @"D:\XML\门诊结算单.B010003.RESPONSE.xml";
            Response<YBInterface.Support.B010003.responseBody> response
                = XmlSerializer.LoadFromXml<Response<YBInterface.Support.B010003.responseBody>, YBInterface.Support.B010003.responseBody>(responseXmlDoc);

            if (response != null)
            {
                response.status = (response.head.stateCode == Constants.OK_STATE_CODE) ? Status.OK : Status.ERROR;

                ReportDocument rptDoc = new ReportDocument();
                string rptFile = @"D:\projects\Api Report Testing\Api Report Testing\B010003\B010003.rpt";
                rptDoc.Load(rptFile);

                List<YBInterface.Support.B010003.responseBodyBaseInfo> lstBaseInfo = new List<YBInterface.Support.B010003.responseBodyBaseInfo>();
                lstBaseInfo.Add(response.body.baseInfo);
                rptDoc.Database.Tables[0].SetDataSource(lstBaseInfo);

                List<YBInterface.Support.B010003.responseBodyFeeInfoAllFeeSubentry> lstAllFeeSubentry = new List<YBInterface.Support.B010003.responseBodyFeeInfoAllFeeSubentry>();
                lstAllFeeSubentry.Add(response.body.feeInfo.allFeeSubentry);
                rptDoc.Database.Tables[1].SetDataSource(lstAllFeeSubentry);

                List<YBInterface.Support.B010003.responseBodyFeeInfoComputeTypeFee> lstComputeTypeFee = new List<YBInterface.Support.B010003.responseBodyFeeInfoComputeTypeFee>();
                lstComputeTypeFee.Add(response.body.feeInfo.computeTypeFee);
                rptDoc.Database.Tables[2].SetDataSource(lstComputeTypeFee);
            
                this.crystalReportViewer1.ReportSource = rptDoc;
                this.crystalReportViewer1.Refresh();
            }

        }

        private void Btn_C010003_Click(object sender, EventArgs e)
        {
            string responseXmlDoc = @"D:\XML\门诊补偿公示表.C010003.RESPONSE.xml";
            Response<YBInterface.Support.C010003.responseBody> response
                = XmlSerializer.LoadFromXml<Response<YBInterface.Support.C010003.responseBody>, YBInterface.Support.C010003.responseBody>(responseXmlDoc);

            if (response != null)
            {
                response.status = (response.head.stateCode == Constants.OK_STATE_CODE) ? Status.OK : Status.ERROR;

                ReportDocument rptDoc = new ReportDocument();
                string rptFile = @"D:\projects\Api Report Testing\Api Report Testing\C010003\C010003.rpt";
                rptDoc.Load(rptFile);
                
                rptDoc.Database.Tables[0].SetDataSource(response.body.item);

                YBInterface.Support.C010003.requestBody requestBody = new YBInterface.Support.C010003.requestBody() 
                { 
                    D501_11 = "aaa", 
                    D503_15 = "bbb",
                    D503_34 = "ccc",
                    D503_35 = DateTime.Now.AddDays(-10).ToString(),
                    D503_36 = DateTime.Now.ToString()
                };
                var lstRequestBody = new List<YBInterface.Support.C010003.requestBody>();
                lstRequestBody.Add(requestBody);
                rptDoc.Database.Tables[1].SetDataSource(lstRequestBody);
                this.crystalReportViewer1.ReportSource = rptDoc;
                this.crystalReportViewer1.Refresh();
            }
        }

        private void SetToolbar(CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer, string reportName)
        {
            foreach (Control control in crystalReportViewer.Controls)
            {
                if (control is CrystalDecisions.Windows.Forms.PageView)
                {
                    foreach (TabControl tab in control.Controls)
                    {
                        foreach (TabPage tabPage in tab.TabPages)
                        {
                            if (tabPage.Text == "主报表" || tabPage.Text == "Main Report")
                            {
                                tabPage.Text = reportName;
                                break;
                            }
                        }
                    }
                }

                if (control is ToolStrip)
                {                    
                    ToolStrip toolStrip = (ToolStrip)control;
                    ToolStripButton exportReportButton = (ToolStripButton)toolStrip.Items[0];
                    Image image = exportReportButton.Image;
                    string toolTipText = exportReportButton.ToolTipText;
                     
                //    Image image = ((ToolStripButton)(((ToolStrip)control).Items[0])).Image;
                //    string toopTip = ((ToolStripButton)(((ToolStrip)control).Items[0])).ToolTipText;
                //    // 移除自带导出按钮
                //    ((ToolStrip)control).Items.Remove(((ToolStrip)control).Items[0]);

                //    // 新建一个工具栏按钮
                //    ToolStripButton myExportTool = new ToolStripButton();

                //    // 把刚才保留的外观属性赋给刚刚新建的工具栏按钮
                //    myExportTool.ToolTipText = toopTip;
                //    myExportTool.Image = image;
                //    myExportTool.ImageScaling = ToolStripItemImageScaling.None;

                //    // 给新建的工具栏按钮添加事件
                //    //myExportTool.Click += new EventHandler(myExportTool_Click);

                //    // 把新建的工具栏按钮插入到原先自带导出按钮的位置（第一个位置）
                //    ((ToolStrip)control).Items.Insert(0, myExportTool);
                }
            }
        }        

        //void myExportTool_Click(object sender, EventArgs e)
        //{
        //    string FileName = string.Empty;
        //    SaveFileDialog sf = new SaveFileDialog();

        //    sf.Filter = "Microsoft Excel(仅限数据)(*.xls)|*.xls|" +
        //                "Crystal Reports(*.rpt)|*.rpt|" +
        //                "Adobe Acrobat(*.pdf)|*.pdf|" +
        //                "Microsoft Excel(*.xls)|*.xls|" +
        //                "Microsoft Word(*.doc)|*.doc|" +
        //                "RTF 格式(*.rtf)|*.rtf|" +
        //                "HTML 4.0 格式(*.htm)|*.htm";
        //    // ……

        //    /* sf.DefaultExt = "rtf";
        //     * 这么设起不了作用，还不知道原因何在，还请路人甲、路人乙指教一二
        //     * 所以只好手动调整顺序 */

        //    //用sf.FilterIndex调整

        //    if (DialogResult.OK == sf.ShowDialog())
        //    {
        //        FileName = sf.FileName;

        //        switch (sf.FilterIndex)
        //        {
        //            // 注意这边的顺序要和前面的sf.Filter保持一致，否则会因格式不匹配导致打不开导出文件
        //            case 1: myReport.ExportToDisk(ExportFormatType.ExcelRecord, FileName); break;
        //            case 2: myReport.ExportToDisk(ExportFormatType.CrystalReport, FileName); break;
        //            case 3: myReport.ExportToDisk(ExportFormatType.PortableDocFormat, FileName); break;
        //            case 4: myReport.ExportToDisk(ExportFormatType.Excel, FileName); break;
        //            case 5: myReport.ExportToDisk(ExportFormatType.WordForWindows, FileName); break;
        //            case 6: myReport.ExportToDisk(ExportFormatType.RichText, FileName); break;
        //            case 7: myReport.ExportToDisk(ExportFormatType.HTML40, FileName); break;
        //            // ……
        //            default: break;
        //        }
        //    }
        //}
    }
}

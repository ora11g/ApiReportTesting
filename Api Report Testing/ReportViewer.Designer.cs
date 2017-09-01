namespace YBInterface.Support
{
    partial class ReportViewer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Btn_B010003 = new System.Windows.Forms.Button();
            this.Btn_C010003 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(731, 512);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // Btn_B010003
            // 
            this.Btn_B010003.Location = new System.Drawing.Point(383, 0);
            this.Btn_B010003.Name = "Btn_B010003";
            this.Btn_B010003.Size = new System.Drawing.Size(153, 23);
            this.Btn_B010003.TabIndex = 1;
            this.Btn_B010003.Text = "门诊结算单B010003";
            this.Btn_B010003.UseVisualStyleBackColor = true;
            this.Btn_B010003.Click += new System.EventHandler(this.Btn_B010003_Click);
            // 
            // Btn_C010003
            // 
            this.Btn_C010003.Location = new System.Drawing.Point(542, 0);
            this.Btn_C010003.Name = "Btn_C010003";
            this.Btn_C010003.Size = new System.Drawing.Size(153, 23);
            this.Btn_C010003.TabIndex = 1;
            this.Btn_C010003.Text = "门诊补偿公示表C010003";
            this.Btn_C010003.UseVisualStyleBackColor = true;
            this.Btn_C010003.Click += new System.EventHandler(this.Btn_C010003_Click);
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 512);
            this.Controls.Add(this.Btn_C010003);
            this.Controls.Add(this.Btn_B010003);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button Btn_B010003;
        private System.Windows.Forms.Button Btn_C010003;
    }
}


// Developer Express Code Central Example:
// How to convert an XtraGrid to an XtraReport at runtime
// 
// This example demonstrates how to dynamically create a report based upon the
// GridControl at runtime. This means that all filtering and sorting conditions
// selected in the grid are also applied in a report. To accomplish this task, it
// is necessary to create a report with all the necessary bands, bind it to a data
// source and adjust all the necessary options.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E108

namespace dxKB17175
{
    partial class XtraReport1
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Height = 21;
            this.Detail.Name = "Detail";
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 23;
            this.PageHeader.Name = "PageHeader";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageHeader});
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
    }
}

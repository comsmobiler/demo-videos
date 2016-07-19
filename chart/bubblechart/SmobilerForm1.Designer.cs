using Smobiler.Core;

namespace bubblechart
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        public SmobilerForm1()
            : base()
        {
            //This call is required by the SmobilerForm Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //VTForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bubbleChart1 = new Smobiler.Core.Controls.BubbleChart();
            this.tblProfitInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smobilerChartDemoDataSet = new bubblechart.SmobilerChartDemoDataSet();
            this.tblProfitInfoTableAdapter = new bubblechart.SmobilerChartDemoDataSetTableAdapters.tblProfitInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblProfitInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerChartDemoDataSet)).BeginInit();
            // 
            // bubbleChart1
            // 
            this.bubbleChart1.DataSource = this.tblProfitInfoBindingSource;
            this.bubbleChart1.Location = new Smobiler.Core.PointS(5F, 10F);
            this.bubbleChart1.Name = "bubbleChart1";
            this.bubbleChart1.SeriesMember = "Customer";
            this.bubbleChart1.Size = new System.Drawing.SizeF(108F, 102F);
            this.bubbleChart1.TabIndex = 2;
            this.bubbleChart1.XAxisLabelMember = "Year";
            this.bubbleChart1.YAxisValueMember = "Amount";
            // 
            // tblProfitInfoBindingSource
            // 
            this.tblProfitInfoBindingSource.DataMember = "tblProfitInfo";
            this.tblProfitInfoBindingSource.DataSource = this.smobilerChartDemoDataSet;
            // 
            // smobilerChartDemoDataSet
            // 
            this.smobilerChartDemoDataSet.DataSetName = "SmobilerChartDemoDataSet";
            this.smobilerChartDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProfitInfoTableAdapter
            // 
            this.tblProfitInfoTableAdapter.ClearBeforeFill = true;
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.bubbleChart1});
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            this.Name = "SmobilerForm1";
            ((System.ComponentModel.ISupportInitialize)(this.tblProfitInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerChartDemoDataSet)).EndInit();

        }
        #endregion

        private Smobiler.Core.Controls.BubbleChart bubbleChart1;
        private System.Windows.Forms.BindingSource tblProfitInfoBindingSource;
        private System.ComponentModel.IContainer components;
        private SmobilerChartDemoDataSet smobilerChartDemoDataSet;
        private SmobilerChartDemoDataSetTableAdapters.tblProfitInfoTableAdapter tblProfitInfoTableAdapter;

    }
}
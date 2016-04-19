using Smobiler.Core;

namespace linechart
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
            this.smobilerChartDemoDataSet = new linechart.SmobilerChartDemoDataSet();
            this.tblDOMAYSalesInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDOMAYSalesInfoTableAdapter = new linechart.SmobilerChartDemoDataSetTableAdapters.tblDOMAYSalesInfoTableAdapter();
            this.lineChart1 = new Smobiler.Core.Controls.LineChart();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerChartDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDOMAYSalesInfoBindingSource)).BeginInit();
            // 
            // smobilerChartDemoDataSet
            // 
            this.smobilerChartDemoDataSet.DataSetName = "SmobilerChartDemoDataSet";
            this.smobilerChartDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDOMAYSalesInfoBindingSource
            // 
            this.tblDOMAYSalesInfoBindingSource.DataMember = "tblDOMAYSalesInfo";
            this.tblDOMAYSalesInfoBindingSource.DataSource = this.smobilerChartDemoDataSet;
            // 
            // tblDOMAYSalesInfoTableAdapter
            // 
            this.tblDOMAYSalesInfoTableAdapter.ClearBeforeFill = true;
            // 
            // lineChart1
            // 
            this.lineChart1.DataSource = this.tblDOMAYSalesInfoBindingSource;
            this.lineChart1.Location = new Smobiler.Core.PointS(3F, 4F);
            this.lineChart1.Name = "lineChart1";
            this.lineChart1.SeriesMember = "Customer";
            this.lineChart1.Size = new System.Drawing.SizeF(114F, 107F);
            this.lineChart1.TabIndex = 2;
            this.lineChart1.XAxisLabelMember = "Month";
            this.lineChart1.YAxisValueMember = "Amount";
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lineChart1});
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smobilerChartDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDOMAYSalesInfoBindingSource)).EndInit();

        }
        #endregion

        private System.Windows.Forms.BindingSource tblDOMAYSalesInfoBindingSource;
        private System.ComponentModel.IContainer components;
        private SmobilerChartDemoDataSet smobilerChartDemoDataSet;
        private SmobilerChartDemoDataSetTableAdapters.tblDOMAYSalesInfoTableAdapter tblDOMAYSalesInfoTableAdapter;
        private Smobiler.Core.Controls.LineChart lineChart1;

    }
}
using Smobiler.Core;

namespace piechart
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
            this.pieChart1 = new Smobiler.Core.Controls.PieChart();
            this.salesInfoTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smobilerChartDemoDataSet = new piechart.SmobilerChartDemoDataSet();
            this.salesInfoTotalTableAdapter = new piechart.SmobilerChartDemoDataSetTableAdapters.SalesInfoTotalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salesInfoTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerChartDemoDataSet)).BeginInit();
            // 
            // pieChart1
            // 
            this.pieChart1.DataSource = this.salesInfoTotalBindingSource;
            this.pieChart1.Location = new System.Drawing.Point(10, 12);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(216, 208);
            this.pieChart1.TabIndex = 2;
            this.pieChart1.XAxisLabelMember = "Customer";
            this.pieChart1.YAxisValueMember = "AmountTotal";
            // 
            // salesInfoTotalBindingSource
            // 
            this.salesInfoTotalBindingSource.DataMember = "SalesInfoTotal";
            this.salesInfoTotalBindingSource.DataSource = this.smobilerChartDemoDataSet;
            // 
            // smobilerChartDemoDataSet
            // 
            this.smobilerChartDemoDataSet.DataSetName = "SmobilerChartDemoDataSet";
            this.smobilerChartDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesInfoTotalTableAdapter
            // 
            this.salesInfoTotalTableAdapter.ClearBeforeFill = true;
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.pieChart1});
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            this.Name = "SmobilerForm1";
            ((System.ComponentModel.ISupportInitialize)(this.salesInfoTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerChartDemoDataSet)).EndInit();

        }
        #endregion

        private Smobiler.Core.Controls.PieChart pieChart1;
        private System.Windows.Forms.BindingSource salesInfoTotalBindingSource;
        private System.ComponentModel.IContainer components;
        private SmobilerChartDemoDataSet smobilerChartDemoDataSet;
        private SmobilerChartDemoDataSetTableAdapters.SalesInfoTotalTableAdapter salesInfoTotalTableAdapter;

    }
}

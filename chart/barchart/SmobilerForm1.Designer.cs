using Smobiler.Core;

namespace barchart
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
            this.barChart1 = new Smobiler.Core.Controls.BarChart();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.smobilerChartDemoDataSet = new barchart.SmobilerChartDemoDataSet();
            this.tblSalesInfoTableAdapter = new barchart.SmobilerChartDemoDataSetTableAdapters.tblSalesInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerChartDemoDataSet)).BeginInit();
            // 
            // barChart1
            // 
            this.barChart1.DataSource = this.bindingSource1;
            this.barChart1.Location = new Smobiler.Core.PointS(3F, 4F);
            this.barChart1.Name = "barChart1";
            this.barChart1.SeriesMember = "Customer";
            this.barChart1.Size = new System.Drawing.SizeF(115F, 98F);
            this.barChart1.TabIndex = 2;
            this.barChart1.XAxisLabelMember = "Month";
            this.barChart1.YAxisValueMember = "Amount";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tblSalesInfo";
            this.bindingSource1.DataSource = this.smobilerChartDemoDataSet;
            // 
            // smobilerChartDemoDataSet
            // 
            this.smobilerChartDemoDataSet.DataSetName = "SmobilerChartDemoDataSet";
            this.smobilerChartDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSalesInfoTableAdapter
            // 
            this.tblSalesInfoTableAdapter.ClearBeforeFill = true;
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.barChart1});
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            this.Name = "SmobilerForm1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerChartDemoDataSet)).EndInit();

        }
        #endregion

        private Smobiler.Core.Controls.BarChart barChart1;
        private System.Windows.Forms.BindingSource tblSalesInfoBindingSource;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SmobilerChartDemoDataSet smobilerChartDemoDataSet;
        private SmobilerChartDemoDataSetTableAdapters.tblSalesInfoTableAdapter tblSalesInfoTableAdapter;
    }
}
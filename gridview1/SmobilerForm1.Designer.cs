using Smobiler.Core;

namespace gridview1
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

        //SmobilerForm overrides dispose to clean up the component list.
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
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            this.tblDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smobilerDemoCostDataSet = new gridview1.SmobilerDemoCostDataSet();
            this.tblDataTableAdapter = new gridview1.SmobilerDemoCostDataSetTableAdapters.tblDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerDemoCostDataSet)).BeginInit();
            // 
            // gridView1
            // 
            this.gridView1.DataSource = this.tblDataBindingSource;
            this.gridView1.Layout = "SmobilerLayout1";
            this.gridView1.Name = "gridView1";
            this.gridView1.Size = new System.Drawing.SizeF(120F, 200F);
            this.gridView1.TabIndex = 2;
            // 
            // tblDataBindingSource
            // 
            this.tblDataBindingSource.DataMember = "tblData";
            this.tblDataBindingSource.DataSource = this.smobilerDemoCostDataSet;
            // 
            // smobilerDemoCostDataSet
            // 
            this.smobilerDemoCostDataSet.DataSetName = "SmobilerDemoCostDataSet";
            this.smobilerDemoCostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDataTableAdapter
            // 
            this.tblDataTableAdapter.ClearBeforeFill = true;
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.gridView1});
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerDemoCostDataSet)).EndInit();

        }
        #endregion

        private Smobiler.Core.Controls.GridView gridView1;
        private System.Windows.Forms.BindingSource tblDataBindingSource;
        private System.ComponentModel.IContainer components;
        private SmobilerDemoCostDataSet smobilerDemoCostDataSet;
        private SmobilerDemoCostDataSetTableAdapters.tblDataTableAdapter tblDataTableAdapter;
    }
}
using System;
using Smobiler.Core;
namespace CandleStickChartDemo
{
    partial class frmCandle : Smobiler.Core.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmCandle()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CandleStickChart1 = new Smobiler.Core.Controls.CandleStickChart();
            this.smobilerDemoDataSet = new CandleStickChartDemo.SmobilerDemoDataSet();
            this.tblDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDataTableAdapter = new CandleStickChartDemo.SmobilerDemoDataSetTableAdapters.tblDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBindingSource)).BeginInit();
            // 
            // CandleStickChart1
            // 
            this.CandleStickChart1.DataSource = this.tblDataBindingSource;
            this.CandleStickChart1.Location = new System.Drawing.Point(6, 0);
            this.CandleStickChart1.Name = "CandleStickChart1";
            this.CandleStickChart1.SeriesMember = "Type";
            this.CandleStickChart1.Size = new System.Drawing.Size(234, 256);
            this.CandleStickChart1.TabIndex = 2;
            this.CandleStickChart1.ValueCloseMember = "Close";
            this.CandleStickChart1.ValueHighMember = "Height";
            this.CandleStickChart1.ValueLowMember = "Low";
            this.CandleStickChart1.ValueOpenMember = "Open";
            this.CandleStickChart1.XAxisLabelMember = "ID";
            // 
            // smobilerDemoDataSet
            // 
            this.smobilerDemoDataSet.DataSetName = "SmobilerDemoDataSet";
            this.smobilerDemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDataBindingSource
            // 
            this.tblDataBindingSource.DataMember = "tblData";
            this.tblDataBindingSource.DataSource = this.smobilerDemoDataSet;
            // 
            // tblDataTableAdapter
            // 
            this.tblDataTableAdapter.ClearBeforeFill = true;
            // 
            // frmCandle
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.CandleStickChart1});
            this.TitleText = "CandleStickChart";
            this.Load += new System.EventHandler(this.frmCandle_Load);
            this.Name = "frmCandle";
            ((System.ComponentModel.ISupportInitialize)(this.smobilerDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBindingSource)).EndInit();

        }
        #endregion

        internal Smobiler.Core.Controls.CandleStickChart CandleStickChart1;
        private System.Windows.Forms.BindingSource tblDataBindingSource;
        private System.ComponentModel.IContainer components;
        private SmobilerDemoDataSet smobilerDemoDataSet;
        private SmobilerDemoDataSetTableAdapters.tblDataTableAdapter tblDataTableAdapter;
    }
}
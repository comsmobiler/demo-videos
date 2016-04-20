using Smobiler.Core;

namespace gridview2
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            this.tblDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smobilerDemoCostDataSet = new gridview2.SmobilerDemoCostDataSet();
            this.tblDataTableAdapter = new gridview2.SmobilerDemoCostDataSetTableAdapters.tblDataTableAdapter();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerDemoCostDataSet)).BeginInit();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.FontSize = 10F;
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.SizeF(60F, 15F);
            this.label1.TabIndex = 2;
            this.label1.Text = "金额合计：";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.FontSize = 12F;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new Smobiler.Core.PointS(60F, 0F);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.SizeF(60F, 15F);
            this.label2.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.DataSource = this.tblDataBindingSource;
            this.gridView1.Layout = "SmobilerLayout2";
            this.gridView1.Location = new Smobiler.Core.PointS(0F, 15F);
            this.gridView1.Name = "gridView1";
            this.gridView1.Size = new System.Drawing.SizeF(120F, 185F);
            this.gridView1.TabIndex = 4;
            this.gridView1.ItemClick += new Smobiler.Core.Controls.GridViewItemClickEventHandler(this.gridView1_ItemClick);
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
            // save
            // 
            this.save.IconID = "save";
            this.save.Name = "save";
            this.save.Text = "保存";
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.gridView1});
            this.TitleBackColor = System.Drawing.Color.GhostWhite;
            this.TitleText = "偏转器费用";
            this.TitleTextColor = System.Drawing.Color.Black;
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.SmobilerForm1_ToolbarItemClick);
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerDemoCostDataSet)).EndInit();

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        private Smobiler.Core.Controls.GridView gridView1;
        private System.Windows.Forms.BindingSource tblDataBindingSource;
        private System.ComponentModel.IContainer components;
        private SmobilerDemoCostDataSet smobilerDemoCostDataSet;
        private SmobilerDemoCostDataSetTableAdapters.tblDataTableAdapter tblDataTableAdapter;
        private Smobiler.Core.Controls.ToolbarItem save;
    }
}
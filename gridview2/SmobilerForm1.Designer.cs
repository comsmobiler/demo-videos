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
            Smobiler.Core.Controls.ContextMenuItem contextMenuItem1 = new Smobiler.Core.Controls.ContextMenuItem();
            Smobiler.Core.Controls.ContextMenuItem contextMenuItem2 = new Smobiler.Core.Controls.ContextMenuItem();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.gridView1 = new Smobiler.Core.Controls.GridView();
            this.tblDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smobilerDemoCostDataSet = new gridview2.SmobilerDemoCostDataSet();
            this.tblDataTableAdapter = new gridview2.SmobilerDemoCostDataSetTableAdapters.tblDataTableAdapter();
            this.save = new Smobiler.Core.Controls.ToolbarItem();
            this.contextMenu1 = new Smobiler.Core.Controls.ContextMenu();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smobilerDemoCostDataSet)).BeginInit();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.FontSize = 20F;
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.HorizontalAlignment = Smobiler.Core.HorizontalAlignment.Center;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "金额合计：";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.FontSize = 24F;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(120, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 30);
            this.label2.TabIndex = 3;
            // 
            // gridView1
            // 
            this.gridView1.DataSource = this.tblDataBindingSource;
            this.gridView1.Layout = "SmobilerLayout2";
            this.gridView1.Location = new System.Drawing.Point(0, 30);
            this.gridView1.Name = "gridView1";
            this.gridView1.Size = new System.Drawing.Size(240, 370);
            this.gridView1.TabIndex = 4;
            this.gridView1.CellLongClick += new Smobiler.Core.Controls.GridViewCellLongClickEventHandler(this.gridView1_CellLongClick);
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
            // contextMenu1
            // 
            this.contextMenu1.BackColor = System.Drawing.Color.White;
            contextMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            contextMenuItem1.Icon = null;
            contextMenuItem1.Text = "编辑";
            contextMenuItem2.ForeColor = System.Drawing.Color.Red;
            contextMenuItem2.Icon = null;
            contextMenuItem2.Text = "删除";
            this.contextMenu1.Items.AddRange(new Smobiler.Core.Controls.ContextMenuItem[] {
            contextMenuItem1,
            contextMenuItem2});
            this.contextMenu1.Name = "contextMenu1";
            // 
            // SmobilerForm1
            // 
            this.ComponentControls.AddRange(new Smobiler.Core.ComponentBase[] {
            this.contextMenu1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.label2,
            this.gridView1});
            this.TitleStyle = new Smobiler.Core.MobileFormTitleStyle("", System.Drawing.Color.GhostWhite, System.Drawing.Color.Black);
            this.TitleText = "偏转器费用";
            this.Toolbar.AddRange(new Smobiler.Core.Controls.ToolbarItem[] {
            this.save});
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            this.ToolbarItemClick += new Smobiler.Core.ToolbarItemClickEventHandler(this.SmobilerForm1_ToolbarItemClick);
            this.Name = "SmobilerForm1";
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
        private Smobiler.Core.Controls.ContextMenu contextMenu1;
    }
}

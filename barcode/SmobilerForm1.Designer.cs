using Smobiler.Core;

namespace barcode
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
            this.barcodeButton1 = new Smobiler.Core.Controls.BarcodeButton();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // barcodeButton1
            // 
            this.barcodeButton1.FontSize = 4F;
            this.barcodeButton1.Location = new Smobiler.Core.PointS(3F, 6F);
            this.barcodeButton1.Name = "barcodeButton1";
            this.barcodeButton1.Size = new System.Drawing.SizeF(19F, 20F);
            this.barcodeButton1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.barcodeButton1.TabIndex = 2;
            this.barcodeButton1.BarcodeScanned += new Smobiler.Core.BarcodeScannerCallBackHandler(this.barcodeButton1_BarcodeScanned);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new Smobiler.Core.PointS(28F, 7F);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.SizeF(85F, 18F);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.barcodeButton1,
            this.label1});

        }
        #endregion

        private Smobiler.Core.Controls.BarcodeButton barcodeButton1;
        private Smobiler.Core.Controls.Label label1;
    }
}
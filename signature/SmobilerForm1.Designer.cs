using Smobiler.Core;

namespace signature
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
            this.signatureButton1 = new Smobiler.Core.Controls.SignatureButton();
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // signatureButton1
            // 
            this.signatureButton1.FontSize = 4F;
            this.signatureButton1.Location = new Smobiler.Core.PointS(49F, 9F);
            this.signatureButton1.Name = "signatureButton1";
            this.signatureButton1.ResourceID = "Signaturebutton";
            this.signatureButton1.SignatureBackColor = System.Drawing.Color.Black;
            this.signatureButton1.SignatureForeColor = System.Drawing.Color.Aqua;
            this.signatureButton1.Size = new System.Drawing.SizeF(21F, 21F);
            this.signatureButton1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.signatureButton1.TabIndex = 2;
            this.signatureButton1.SignatureCompleted += new Smobiler.Core.SignatureCompletedCallBackHandler(this.signatureButton1_SignatureCompleted);
            // 
            // image1
            // 
            this.image1.BackColor = System.Drawing.Color.Black;
            this.image1.BorderRadius = 3;
            this.image1.DefaultImageVisible = false;
            this.image1.Location = new Smobiler.Core.PointS(4F, 34F);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.SizeF(112F, 57F);
            this.image1.TabIndex = 3;
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.signatureButton1,
            this.image1});

        }
        #endregion

        private Smobiler.Core.Controls.SignatureButton signatureButton1;
        private Smobiler.Core.Controls.Image image1;
    }
}
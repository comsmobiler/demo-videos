using Smobiler.Core;

namespace camera
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
            this.cameraButton1 = new Smobiler.Core.Controls.CameraButton();
            this.image1 = new Smobiler.Core.Controls.Image();
            // 
            // cameraButton1
            // 
            this.cameraButton1.FontSize = 4F;
            this.cameraButton1.Location = new Smobiler.Core.PointS(75F, 45F);
            this.cameraButton1.Name = "cameraButton1";
            this.cameraButton1.ResourceID = "Camera";
            this.cameraButton1.Size = new System.Drawing.SizeF(40F, 30F);
            this.cameraButton1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.cameraButton1.TabIndex = 2;
            this.cameraButton1.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.cameraButton1_ImageCaptured);
            // 
            // image1
            // 
            this.image1.Location = new Smobiler.Core.PointS(4F, 30F);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.SizeF(67F, 120F);
            this.image1.TabIndex = 3;
            // 
            // SmobilerForm1
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.cameraButton1,
            this.image1});

        }
        #endregion

        private Smobiler.Core.Controls.CameraButton cameraButton1;
        private Smobiler.Core.Controls.Image image1;

    }
}
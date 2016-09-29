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
            this.cameraButton1.FontSize = 8;
            this.cameraButton1.Location = new System.Drawing.Point(150,90);
            this.cameraButton1.Name = "cameraButton1";
            this.cameraButton1.ResourceID = "Camera";
            this.cameraButton1.Size = new System.Drawing.Size(80,60);
            this.cameraButton1.Style = Smobiler.Core.Controls.ButtonStyle.custom;
            this.cameraButton1.TabIndex = 2;
            this.cameraButton1.ImageCaptured += new Smobiler.Core.CameraOnlineCallBackHandler(this.cameraButton1_ImageCaptured);
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(8,60);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(134,240);
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

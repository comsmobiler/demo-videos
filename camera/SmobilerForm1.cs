using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace camera
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private string curdir = System.AppDomain.CurrentDomain.BaseDirectory;
        private void cameraButton1_ImageCaptured(object sender, BinaryData e)
        {
            string filename = "test" + System.DateTime.Now.ToString("yyyyMMddHHmmss");
            e.SaveFile(filename + ".jpg", curdir + "Image");
            this.image1.ResourceID = filename;
        }
    }
}
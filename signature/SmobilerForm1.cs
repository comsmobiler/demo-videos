using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace signature
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private void signatureButton1_SignatureCompleted(object sender, BinaryData e)
        {
            if (e.ErrorInfo.Trim().ToString().Length<=0)
            {
                e.SaveFile();
                image1.ResourceID = e.ResourceID;
            }
        }
    }
}
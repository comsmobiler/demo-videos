using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace barcode
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private void barcodeButton1_BarcodeScanned(object sender, BarcodeData e)
        {
            if (e.Barcode.Length > 0)
            {
                if (e.Barcode.ToUpper().StartsWith("HTTP"))
                {
                    this.RedirectUrl("", e.Barcode);
                }
            }
            this.label1.Text = e.Barcode;
        }
    }
}
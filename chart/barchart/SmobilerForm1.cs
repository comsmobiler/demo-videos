using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace barchart
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            this.tblSalesInfoTableAdapter.Fill(smobilerChartDemoDataSet.tblSalesInfo);
            this.barChart1.DataBind();
        }
    }
}
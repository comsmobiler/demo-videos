using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace CandleStickChartDemo
{
    partial class frmCandle : Smobiler.Core.MobileForm
    {
        private void frmCandle_Load(object sender, EventArgs e)
        {
            tblDataTableAdapter.Fill(smobilerDemoDataSet.tblData);
           CandleStickChart1.DataBind();
        }
    }
}
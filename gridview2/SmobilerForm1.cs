using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace gridview2
{
    partial class SmobilerForm1 : Smobiler.Core.MobileForm
    {
        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
            tblDataTableAdapter.Fill(smobilerDemoCostDataSet.tblData);
            gridView1.DataBind();
        }

        private void SmobilerForm1_ToolbarItemClick(object sender, ToolbarClickEventArgs e)
        {
            foreach (GridViewRow item in gridView1.Rows)
            {
                smobilerDemoCostDataSet.tblData.Rows[item.Index]["Money"] = item.Cell.Items["textBox1"].DefaultValue;
                smobilerDemoCostDataSet.tblData.Rows[item.Index]["Date"] = item.Cell.Items["datePicker1"].DefaultValue;
                smobilerDemoCostDataSet.tblData.Rows[item.Index]["Memo"] = item.Cell.Items["textBox2"].DefaultValue;
            }
            tblDataTableAdapter.Update(smobilerDemoCostDataSet.tblData);
        }

        private void gridView1_ItemClick(object sender, GridViewCellItemEventArgs e)
        {
            decimal totalamount = 0;

            foreach (GridViewRow item in gridView1.Rows)
            {
                bool bo = Convert.ToBoolean(item.Cell.Items["checkBox1"].DefaultValue);
                if (bo == true)
                {
                    string str = Convert.ToString(item.Cell.Items["textBox1"].DefaultValue);
                    totalamount = totalamount + Convert.ToDecimal(str);
                }
            }
            label2.Text = totalamount.ToString();
            contextMenu1.Show();
        }

        private void gridView1_CellLongClick(object sender, GridViewCellEventArgs e)
        {
            contextMenu1.Show();
        }
    }
}
using Smobiler.Utility.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmobilerUtilityDemo
{
    public partial class PushForm : Form
    {
        public PushForm()
        {
            InitializeComponent();
        }
        string tokenstr;
        /// <summary>
        /// 令牌验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntoken_Click(object sender, EventArgs e)
        {
            //在推送前必须先进行令牌验证
            string ServiceKey = this.txtServiceKey.Text;//推送key
            string SecurityKey = this.txtSecurityKey.Text;//推送安全key
            if ((System.String.IsNullOrEmpty(ServiceKey) == false) && (System.String.IsNullOrEmpty(SecurityKey) == false))
            {

                Smobiler.Utility.API.PushClient client = new Smobiler.Utility.API.PushClient(ServiceKey, SecurityKey);
                APIToken token = client.GetToken();//令牌验证
                if (token.status == 0)
                {
                    this.lbltoken.Text = token.token;
                    tokenstr = token.token;
                }
                else
                {
                    this.lbltoken.Text = token.error;
                }
                this.lblresult.Text = token.ToString();
            }
            else
            {
                if (System.String.IsNullOrEmpty(ServiceKey) == true)
                {
                    this.lblresult.Text = "请输入ServiceKey！";
                }
                if (System.String.IsNullOrEmpty(SecurityKey) == true)
                {
                    this.lblresult.Text = "请输入SecurityKey！";
                }
            }
        }

        /// <summary>
        /// 推送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPush_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string ServiceKey = this.txtServiceKey.Text;//获取推送key
            string SecurityKey = this.txtSecurityKey.Text;//获取推送安全key
             if ((System.String.IsNullOrEmpty(ServiceKey) == false) && (System.String.IsNullOrEmpty(SecurityKey) == false))
            {
            Smobiler.Utility.API.PushClient client = new Smobiler.Utility.API.PushClient(ServiceKey, SecurityKey);
            string deviceid = this.txtDevice.Text;//获取推送设备号
            string pushContent = this.txtpushContent.Text;//获取推送内容
            APIMessageResult result;
            //调用Push方法推送到设备
            if (System.String.IsNullOrEmpty(deviceid) == true)
                result = client.Push(pushContent, tokenstr);
            else
            {
                string[] devices = deviceid.Split(',');//推送设备号
                if (devices.Length == 1)
                {
                    result = client.Push(deviceid, pushContent, tokenstr);
                }
                else
                {
                    result = client.Push(devices, pushContent, tokenstr);
                }
            }

            if (result is PushMessageResult)
            {
                if (result.status != 0)
                    sb.AppendLine("Error: " + result.error);
                else
                    sb.AppendLine("Result: " + result.ToString());
            }
            else if (result is PushBatchMessageResult)
            {
                foreach (KeyValuePair<string, PushMessageResult> item in ((PushBatchMessageResult)result).results)
                {
                    sb.Append(item.Key + ":");
                    if (item.Value.status == 0)
                        sb.AppendLine("Result: " + result.ToString());
                    else
                        sb.AppendLine("Error: " + result.error);
                }
            }
            this.lblresult.Text = sb.ToString();
            }
             else
             {
                 if (System.String.IsNullOrEmpty(ServiceKey) == true)
                 {
                     this.lblresult.Text = "请输入ServiceKey！";
                 }
                 if (System.String.IsNullOrEmpty(SecurityKey) == true)
                 {
                     this.lblresult.Text = "请输入SecurityKey！";
                 }
             }
        }
    }
}

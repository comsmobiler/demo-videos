namespace SmobilerUtilityDemo
{
    partial class PushForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         
            this.SuspendLayout();
            this.btntoken = new System.Windows.Forms.Button();
            this.txtpushContent = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.txtSecurityKey = new System.Windows.Forms.TextBox();
            this.txtServiceKey = new System.Windows.Forms.TextBox();
            this.lbltoken = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();

            // 
            // btntoken
            // 
            this.btntoken.Location = new System.Drawing.Point(234, 178);
            this.btntoken.Name = "btntoken";
            this.btntoken.Size = new System.Drawing.Size(75, 23);
            this.btntoken.TabIndex = 7;
            this.btntoken.Text = "token";
            this.btntoken.UseVisualStyleBackColor = true;
            this.btntoken.Click += new System.EventHandler(this.btntoken_Click);
            // 
            // txtpushContent
            // 
            this.txtpushContent.Location = new System.Drawing.Point(90, 68);
            this.txtpushContent.Name = "txtpushContent";
            this.txtpushContent.Size = new System.Drawing.Size(219, 21);
            this.txtpushContent.TabIndex = 8;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(90, 178);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 9;
            this.btnPush.Text = "push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtSecurityKey
            // 
            this.txtSecurityKey.Location = new System.Drawing.Point(90, 41);
            this.txtSecurityKey.Name = "txtSecurityKey";
            this.txtSecurityKey.Size = new System.Drawing.Size(219, 21);
            this.txtSecurityKey.TabIndex = 8;
            // 
            // txtServiceKey
            // 
            this.txtServiceKey.Location = new System.Drawing.Point(90, 14);
            this.txtServiceKey.Name = "txtServiceKey";
            this.txtServiceKey.Size = new System.Drawing.Size(219, 21);
            this.txtServiceKey.TabIndex = 8;
            // 
            // lbltoken
            // 
            this.lbltoken.AutoSize = true;
            this.lbltoken.Location = new System.Drawing.Point(90, 204);
            this.lbltoken.Name = "lbltoken";
            this.lbltoken.Size = new System.Drawing.Size(47, 12);
            this.lbltoken.TabIndex = 10;
            this.lbltoken.Text = "[token]";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(90, 95);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(219, 21);
            this.txtDevice.TabIndex = 8;
            // 
            // lblresult
            // 
            this.lblresult.Location = new System.Drawing.Point(14, 230);
            this.lblresult.Multiline = true;
            this.lblresult.Name = "lblresult";
            this.lblresult.ReadOnly = true;
            this.lblresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblresult.Size = new System.Drawing.Size(295, 253);
            this.lblresult.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "ServiceKey";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "SecurityKey";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "推送内容";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "设备号";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 47);
            this.label6.TabIndex = 12;
            this.label6.Text = "说明：先点击Token获取，输入推送内容，设备号为空时代表推送所有，支持多设备推送，中间加英文的逗号隔开";
            // 
            // PushForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbltoken);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtServiceKey);
            this.Controls.Add(this.txtSecurityKey);
            this.Controls.Add(this.txtDevice);
            this.Controls.Add(this.txtpushContent);
            this.Controls.Add(this.btntoken);
            this.Name = "PushForm";
            this.Text = "Smobiler Push Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btntoken;
        private System.Windows.Forms.TextBox txtpushContent;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox txtSecurityKey;
        private System.Windows.Forms.TextBox txtServiceKey;
        private System.Windows.Forms.Label lbltoken;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.TextBox lblresult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
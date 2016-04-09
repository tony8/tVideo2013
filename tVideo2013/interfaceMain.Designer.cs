namespace tVideo2013
{
    partial class interfaceMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_GetPic = new System.Windows.Forms.Button();
            this.btn_Settle = new System.Windows.Forms.Button();
            this.btn_StopPic = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxStepMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GetPic
            // 
            this.btn_GetPic.Location = new System.Drawing.Point(345, 20);
            this.btn_GetPic.Name = "btn_GetPic";
            this.btn_GetPic.Size = new System.Drawing.Size(61, 24);
            this.btn_GetPic.TabIndex = 0;
            this.btn_GetPic.Text = "开始抓图";
            this.btn_GetPic.UseVisualStyleBackColor = true;
            this.btn_GetPic.Click += new System.EventHandler(this.btn_GetPic_Click);
            // 
            // btn_Settle
            // 
            this.btn_Settle.Location = new System.Drawing.Point(431, 20);
            this.btn_Settle.Name = "btn_Settle";
            this.btn_Settle.Size = new System.Drawing.Size(61, 24);
            this.btn_Settle.TabIndex = 1;
            this.btn_Settle.Text = "整理统计";
            this.btn_Settle.UseVisualStyleBackColor = true;
            this.btn_Settle.Click += new System.EventHandler(this.btn_Settle_Click);
            // 
            // btn_StopPic
            // 
            this.btn_StopPic.Location = new System.Drawing.Point(345, 59);
            this.btn_StopPic.Name = "btn_StopPic";
            this.btn_StopPic.Size = new System.Drawing.Size(61, 24);
            this.btn_StopPic.TabIndex = 2;
            this.btn_StopPic.Text = "停止抓图";
            this.btn_StopPic.UseVisualStyleBackColor = true;
            this.btn_StopPic.Click += new System.EventHandler(this.btn_StopPic_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(431, 59);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(61, 24);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "查看日志";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tVideo2013.Properties.Resources.logo2013;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxStepMin
            // 
            this.textBoxStepMin.Location = new System.Drawing.Point(415, 89);
            this.textBoxStepMin.Name = "textBoxStepMin";
            this.textBoxStepMin.Size = new System.Drawing.Size(31, 21);
            this.textBoxStepMin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "抓图间隔为";
            // 
            // interfaceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStepMin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btn_StopPic);
            this.Controls.Add(this.btn_Settle);
            this.Controls.Add(this.btn_GetPic);
            this.Name = "interfaceMain";
            this.Text = "视频监控自动抓图统计软件V1.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetPic;
        private System.Windows.Forms.Button btn_Settle;
        private System.Windows.Forms.Button btn_StopPic;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxStepMin;
        private System.Windows.Forms.Label label1;
    }
}


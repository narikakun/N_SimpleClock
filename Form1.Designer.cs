namespace N_SimpleClock
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.l_date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.l_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_date
            // 
            this.l_date.AutoSize = true;
            this.l_date.Font = new System.Drawing.Font("ＭＳ ゴシック", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.l_date.Location = new System.Drawing.Point(12, 9);
            this.l_date.Name = "l_date";
            this.l_date.Size = new System.Drawing.Size(156, 64);
            this.l_date.TabIndex = 0;
            this.l_date.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Font = new System.Drawing.Font("ＭＳ ゴシック", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.l_time.Location = new System.Drawing.Point(12, 73);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(238, 97);
            this.l_time.TabIndex = 1;
            this.l_time.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 177);
            this.Controls.Add(this.l_time);
            this.Controls.Add(this.l_date);
            this.Name = "Form1";
            this.Text = "N_SimpleClock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label l_time;
    }
}


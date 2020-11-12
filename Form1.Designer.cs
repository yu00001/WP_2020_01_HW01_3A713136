namespace WP_2020_01_HW01_3A713136
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.But1 = new System.Windows.Forms.Button();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.rTB1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // But1
            // 
            this.But1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.But1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.But1.Location = new System.Drawing.Point(203, 80);
            this.But1.Name = "But1";
            this.But1.Size = new System.Drawing.Size(75, 23);
            this.But1.TabIndex = 0;
            this.But1.Text = "確認";
            this.But1.UseVisualStyleBackColor = true;
            this.But1.Click += new System.EventHandler(this.But1_Click);
            // 
            // tB1
            // 
            this.tB1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tB1.Location = new System.Drawing.Point(59, 68);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(121, 35);
            this.tB1.TabIndex = 1;
            // 
            // rTB1
            // 
            this.rTB1.BackColor = System.Drawing.Color.Lavender;
            this.rTB1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rTB1.Location = new System.Drawing.Point(21, 282);
            this.rTB1.Name = "rTB1";
            this.rTB1.Size = new System.Drawing.Size(212, 96);
            this.rTB1.TabIndex = 2;
            this.rTB1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸入名字 ...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTB1);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.But1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But1;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.RichTextBox rTB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


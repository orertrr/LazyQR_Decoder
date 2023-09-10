namespace LazyQR_Decoder
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
            this.txt_information = new System.Windows.Forms.TextBox();
            this.btn_excute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_information
            // 
            this.txt_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_information.Location = new System.Drawing.Point(12, 83);
            this.txt_information.Multiline = true;
            this.txt_information.Name = "txt_information";
            this.txt_information.ReadOnly = true;
            this.txt_information.Size = new System.Drawing.Size(636, 355);
            this.txt_information.TabIndex = 0;
            // 
            // btn_excute
            // 
            this.btn_excute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_excute.Location = new System.Drawing.Point(12, 12);
            this.btn_excute.Name = "btn_excute";
            this.btn_excute.Size = new System.Drawing.Size(636, 65);
            this.btn_excute.TabIndex = 1;
            this.btn_excute.Text = "Get and Decode";
            this.btn_excute.UseVisualStyleBackColor = true;
            this.btn_excute.Click += new System.EventHandler(this.btn_excute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.btn_excute);
            this.Controls.Add(this.txt_information);
            this.Name = "Form1";
            this.Text = "Lazy QR Decoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_information;
        private System.Windows.Forms.Button btn_excute;
    }
}


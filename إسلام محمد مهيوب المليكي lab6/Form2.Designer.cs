namespace إسلام_محمد_مهيوب_المليكي_lab6
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnViewImage = new System.Windows.Forms.Button();
            this.ClearImageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(546, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "مسار الصورة";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 30);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(528, 30);
            this.textBoxPath.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(164, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 202);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnViewImage
            // 
            this.BtnViewImage.BackColor = System.Drawing.Color.LightGreen;
            this.BtnViewImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnViewImage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewImage.Location = new System.Drawing.Point(338, 316);
            this.BtnViewImage.Name = "BtnViewImage";
            this.BtnViewImage.Size = new System.Drawing.Size(117, 37);
            this.BtnViewImage.TabIndex = 3;
            this.BtnViewImage.Text = "عرض";
            this.BtnViewImage.UseVisualStyleBackColor = false;
            this.BtnViewImage.Click += new System.EventHandler(this.BtnViewImage_Click);
            // 
            // ClearImageBtn
            // 
            this.ClearImageBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClearImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearImageBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearImageBtn.Location = new System.Drawing.Point(164, 316);
            this.ClearImageBtn.Name = "ClearImageBtn";
            this.ClearImageBtn.Size = new System.Drawing.Size(117, 37);
            this.ClearImageBtn.TabIndex = 4;
            this.ClearImageBtn.Text = "مسح ";
            this.ClearImageBtn.UseVisualStyleBackColor = false;
            this.ClearImageBtn.Click += new System.EventHandler(this.ClearImageBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 379);
            this.Controls.Add(this.ClearImageBtn);
            this.Controls.Add(this.BtnViewImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnViewImage;
        private System.Windows.Forms.Button ClearImageBtn;
    }
}
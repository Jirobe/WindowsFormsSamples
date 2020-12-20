
namespace WindowsFormsScreenCap
{
    partial class MainForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.capImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.screenCap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.capImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(-1, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 19);
            this.textBox1.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Maroon;
            this.textBox6.Location = new System.Drawing.Point(496, 339);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(14, 19);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Maroon;
            this.textBox7.Location = new System.Drawing.Point(496, 298);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(14, 19);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Maroon;
            this.textBox8.Location = new System.Drawing.Point(496, 255);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(14, 19);
            this.textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Maroon;
            this.textBox9.Location = new System.Drawing.Point(496, 217);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(14, 19);
            this.textBox9.TabIndex = 8;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Maroon;
            this.textBox10.Location = new System.Drawing.Point(496, 168);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(14, 19);
            this.textBox10.TabIndex = 9;
            // 
            // capImage
            // 
            this.capImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.capImage.Location = new System.Drawing.Point(557, 0);
            this.capImage.Name = "capImage";
            this.capImage.Size = new System.Drawing.Size(490, 380);
            this.capImage.TabIndex = 10;
            this.capImage.TabStop = false;
            this.capImage.Click += new System.EventHandler(this.CapImage_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsScreenCap.Properties.Resources.check_icon;
            this.button1.Location = new System.Drawing.Point(557, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 74);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsScreenCap.Properties.Resources.ng_icon;
            this.button2.Location = new System.Drawing.Point(648, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 74);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // screenCap
            // 
            this.screenCap.Image = global::WindowsFormsScreenCap.Properties.Resources.screen;
            this.screenCap.Location = new System.Drawing.Point(38, 419);
            this.screenCap.Name = "screenCap";
            this.screenCap.Size = new System.Drawing.Size(85, 74);
            this.screenCap.TabIndex = 13;
            this.screenCap.UseVisualStyleBackColor = true;
            this.screenCap.Click += new System.EventHandler(this.ScreenCap_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 506);
            this.Controls.Add(this.screenCap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.capImage);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "WindowsFormsScreenCap";
            ((System.ComponentModel.ISupportInitialize)(this.capImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.PictureBox capImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button screenCap;
    }
}


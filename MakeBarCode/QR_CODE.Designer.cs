namespace MakeBarCode
{
    partial class QR_CODE
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
            this.Encoder_textbox = new System.Windows.Forms.TextBox();
            this.QR_Code_generate = new System.Windows.Forms.Button();
            this.encoder_image = new System.Windows.Forms.PictureBox();
            this.load_file = new System.Windows.Forms.Button();
            this.Loadfile_PictureBox = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Decode_btn = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.encoder_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loadfile_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Encoder_textbox
            // 
            this.Encoder_textbox.Location = new System.Drawing.Point(13, 13);
            this.Encoder_textbox.Name = "Encoder_textbox";
            this.Encoder_textbox.Size = new System.Drawing.Size(243, 20);
            this.Encoder_textbox.TabIndex = 0;
            // 
            // QR_Code_generate
            // 
            this.QR_Code_generate.Location = new System.Drawing.Point(263, 13);
            this.QR_Code_generate.Name = "QR_Code_generate";
            this.QR_Code_generate.Size = new System.Drawing.Size(122, 23);
            this.QR_Code_generate.TabIndex = 1;
            this.QR_Code_generate.Text = "Generate";
            this.QR_Code_generate.UseVisualStyleBackColor = true;
            this.QR_Code_generate.Click += new System.EventHandler(this.QR_Code_generate_Click);
            // 
            // encoder_image
            // 
            this.encoder_image.BackColor = System.Drawing.SystemColors.Window;
            this.encoder_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.encoder_image.Location = new System.Drawing.Point(13, 39);
            this.encoder_image.Name = "encoder_image";
            this.encoder_image.Size = new System.Drawing.Size(372, 303);
            this.encoder_image.TabIndex = 2;
            this.encoder_image.TabStop = false;
            // 
            // load_file
            // 
            this.load_file.Location = new System.Drawing.Point(411, 13);
            this.load_file.Name = "load_file";
            this.load_file.Size = new System.Drawing.Size(75, 23);
            this.load_file.TabIndex = 3;
            this.load_file.Text = "Load File";
            this.load_file.UseVisualStyleBackColor = true;
            this.load_file.Click += new System.EventHandler(this.load_file_Click);
            // 
            // Loadfile_PictureBox
            // 
            this.Loadfile_PictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.Loadfile_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Loadfile_PictureBox.Location = new System.Drawing.Point(411, 39);
            this.Loadfile_PictureBox.Name = "Loadfile_PictureBox";
            this.Loadfile_PictureBox.Size = new System.Drawing.Size(372, 303);
            this.Loadfile_PictureBox.TabIndex = 4;
            this.Loadfile_PictureBox.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(812, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 303);
            this.textBox2.TabIndex = 5;
            // 
            // Decode_btn
            // 
            this.Decode_btn.Location = new System.Drawing.Point(812, 8);
            this.Decode_btn.Name = "Decode_btn";
            this.Decode_btn.Size = new System.Drawing.Size(75, 23);
            this.Decode_btn.TabIndex = 6;
            this.Decode_btn.Text = "Decode";
            this.Decode_btn.UseVisualStyleBackColor = true;
            this.Decode_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(13, 349);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(161, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // QR_CODE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 442);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.Decode_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Loadfile_PictureBox);
            this.Controls.Add(this.load_file);
            this.Controls.Add(this.encoder_image);
            this.Controls.Add(this.QR_Code_generate);
            this.Controls.Add(this.Encoder_textbox);
            this.Name = "QR_CODE";
            this.Text = "QR_CODE";
            ((System.ComponentModel.ISupportInitialize)(this.encoder_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loadfile_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Encoder_textbox;
        private System.Windows.Forms.Button QR_Code_generate;
        private System.Windows.Forms.PictureBox encoder_image;
        private System.Windows.Forms.Button load_file;
        private System.Windows.Forms.PictureBox Loadfile_PictureBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Decode_btn;
        private System.Windows.Forms.Button btn_save;
    }
}
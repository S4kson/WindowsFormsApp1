namespace WindowsFormsApp1
{
    partial class FormPolibii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPolibii));
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.ButtonEncoder = new System.Windows.Forms.Button();
            this.ButtonDecoder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(41, 132);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(262, 127);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.Text = "Ввод";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(41, 269);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(262, 134);
            this.textBoxOutput.TabIndex = 3;
            this.textBoxOutput.Text = "Вывод";
            // 
            // ButtonEncoder
            // 
            this.ButtonEncoder.Location = new System.Drawing.Point(525, 128);
            this.ButtonEncoder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonEncoder.Name = "ButtonEncoder";
            this.ButtonEncoder.Size = new System.Drawing.Size(262, 35);
            this.ButtonEncoder.TabIndex = 4;
            this.ButtonEncoder.Text = "Зашифровать";
            this.ButtonEncoder.UseVisualStyleBackColor = true;
            this.ButtonEncoder.Click += new System.EventHandler(this.ButtonEncoder_Click);
            // 
            // ButtonDecoder
            // 
            this.ButtonDecoder.Location = new System.Drawing.Point(525, 224);
            this.ButtonDecoder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDecoder.Name = "ButtonDecoder";
            this.ButtonDecoder.Size = new System.Drawing.Size(262, 35);
            this.ButtonDecoder.TabIndex = 5;
            this.ButtonDecoder.Text = "Расшифровать";
            this.ButtonDecoder.UseVisualStyleBackColor = true;
            this.ButtonDecoder.Click += new System.EventHandler(this.ButtonDecoder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(41, 14);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(262, 35);
            this.buttonOpenFile.TabIndex = 6;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(41, 59);
            this.buttonSaveFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(262, 35);
            this.buttonSaveFile.TabIndex = 7;
            this.buttonSaveFile.Text = "Сохранить файл";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(313, 321);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(475, 82);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "                                              Памятка:\n При расшифровке: Можно вв" +
    "одить только цифры.\n\n";
            // 
            // FormPolibii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.ButtonDecoder);
            this.Controls.Add(this.ButtonEncoder);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.DoubleBuffered = true;
            this.Name = "FormPolibii";
            this.Text = "Шифрование квадратом Полибия";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button ButtonEncoder;
        private System.Windows.Forms.Button ButtonDecoder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
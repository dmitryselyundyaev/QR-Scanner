namespace QR_Scanner
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxOfAllCodes = new System.Windows.Forms.ListBox();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.BtnDeleteItem = new System.Windows.Forms.Button();
            this.BtnSaveQR = new System.Windows.Forms.Button();
            this.TextBoxNewItemName = new System.Windows.Forms.TextBox();
            this.pictureBoxWebCam = new System.Windows.Forms.PictureBox();
            this.BtnScanning = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxOfAllCodes
            // 
            this.ListBoxOfAllCodes.FormattingEnabled = true;
            this.ListBoxOfAllCodes.ItemHeight = 16;
            this.ListBoxOfAllCodes.Location = new System.Drawing.Point(51, 126);
            this.ListBoxOfAllCodes.Name = "ListBoxOfAllCodes";
            this.ListBoxOfAllCodes.Size = new System.Drawing.Size(198, 260);
            this.ListBoxOfAllCodes.TabIndex = 0;
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.Location = new System.Drawing.Point(51, 41);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(94, 51);
            this.BtnAddItem.TabIndex = 1;
            this.BtnAddItem.Text = "Добавить";
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // BtnDeleteItem
            // 
            this.BtnDeleteItem.Location = new System.Drawing.Point(151, 41);
            this.BtnDeleteItem.Name = "BtnDeleteItem";
            this.BtnDeleteItem.Size = new System.Drawing.Size(98, 51);
            this.BtnDeleteItem.TabIndex = 2;
            this.BtnDeleteItem.Text = "Удалить";
            this.BtnDeleteItem.UseVisualStyleBackColor = true;
            this.BtnDeleteItem.Click += new System.EventHandler(this.BtnDeleteItem_Click);
            // 
            // BtnSaveQR
            // 
            this.BtnSaveQR.Location = new System.Drawing.Point(51, 392);
            this.BtnSaveQR.Name = "BtnSaveQR";
            this.BtnSaveQR.Size = new System.Drawing.Size(198, 57);
            this.BtnSaveQR.TabIndex = 3;
            this.BtnSaveQR.Text = "Сохранить QR-CODE";
            this.BtnSaveQR.UseVisualStyleBackColor = true;
            this.BtnSaveQR.Click += new System.EventHandler(this.BtnSaveQR_Click);
            // 
            // TextBoxNewItemName
            // 
            this.TextBoxNewItemName.Location = new System.Drawing.Point(51, 98);
            this.TextBoxNewItemName.Name = "TextBoxNewItemName";
            this.TextBoxNewItemName.Size = new System.Drawing.Size(198, 22);
            this.TextBoxNewItemName.TabIndex = 4;
            // 
            // pictureBoxWebCam
            // 
            this.pictureBoxWebCam.Location = new System.Drawing.Point(296, 12);
            this.pictureBoxWebCam.Name = "pictureBoxWebCam";
            this.pictureBoxWebCam.Size = new System.Drawing.Size(775, 590);
            this.pictureBoxWebCam.TabIndex = 5;
            this.pictureBoxWebCam.TabStop = false;
            // 
            // BtnScanning
            // 
            this.BtnScanning.Location = new System.Drawing.Point(92, 545);
            this.BtnScanning.Name = "BtnScanning";
            this.BtnScanning.Size = new System.Drawing.Size(198, 57);
            this.BtnScanning.TabIndex = 6;
            this.BtnScanning.Text = "Прочитать код";
            this.BtnScanning.UseVisualStyleBackColor = true;
            this.BtnScanning.Click += new System.EventHandler(this.BtnScanning_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 640);
            this.Controls.Add(this.BtnScanning);
            this.Controls.Add(this.pictureBoxWebCam);
            this.Controls.Add(this.TextBoxNewItemName);
            this.Controls.Add(this.BtnSaveQR);
            this.Controls.Add(this.BtnDeleteItem);
            this.Controls.Add(this.BtnAddItem);
            this.Controls.Add(this.ListBoxOfAllCodes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxOfAllCodes;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Button BtnDeleteItem;
        private System.Windows.Forms.Button BtnSaveQR;
        private System.Windows.Forms.TextBox TextBoxNewItemName;
        private System.Windows.Forms.PictureBox pictureBoxWebCam;
        private System.Windows.Forms.Button BtnScanning;
    }
}


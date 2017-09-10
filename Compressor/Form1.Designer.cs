namespace Compressor
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.labelRoute = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.labelFolderForSave = new System.Windows.Forms.Label();
            this.labelSaved = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.Location = new System.Drawing.Point(13, 74);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(0, 13);
            this.labelRoute.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(16, 36);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(256, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Открыть папку с изображениями";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // labelFolderForSave
            // 
            this.labelFolderForSave.AutoSize = true;
            this.labelFolderForSave.Location = new System.Drawing.Point(13, 166);
            this.labelFolderForSave.Name = "labelFolderForSave";
            this.labelFolderForSave.Size = new System.Drawing.Size(0, 13);
            this.labelFolderForSave.TabIndex = 4;
            // 
            // labelSaved
            // 
            this.labelSaved.AutoSize = true;
            this.labelSaved.Location = new System.Drawing.Point(12, 144);
            this.labelSaved.Name = "labelSaved";
            this.labelSaved.Size = new System.Drawing.Size(239, 13);
            this.labelSaved.TabIndex = 5;
            this.labelSaved.Text = "Изображения сохранены в папку compressed:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(256, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Запустить сжатие изображений";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(19, 210);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(253, 23);
            this.progressBar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelSaved);
            this.Controls.Add(this.labelFolderForSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.labelRoute);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Compressor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label labelFolderForSave;
        private System.Windows.Forms.Label labelSaved;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar;

    }
}


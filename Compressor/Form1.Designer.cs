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
            this.trackBarQuality = new System.Windows.Forms.TrackBar();
            this.numericUDQuality = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUDSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDSize)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.Location = new System.Drawing.Point(15, 80);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(0, 13);
            this.labelRoute.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 50);
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
            this.labelFolderForSave.Location = new System.Drawing.Point(13, 30);
            this.labelFolderForSave.Name = "labelFolderForSave";
            this.labelFolderForSave.Size = new System.Drawing.Size(0, 13);
            this.labelFolderForSave.TabIndex = 4;
            // 
            // labelSaved
            // 
            this.labelSaved.AutoSize = true;
            this.labelSaved.Location = new System.Drawing.Point(13, 15);
            this.labelSaved.Name = "labelSaved";
            this.labelSaved.Size = new System.Drawing.Size(239, 13);
            this.labelSaved.TabIndex = 5;
            this.labelSaved.Text = "Изображения сохранены в папку compressed:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(16, 224);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(256, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Запустить сжатие изображений";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-1, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(284, 10);
            this.progressBar.TabIndex = 7;
            // 
            // trackBarQuality
            // 
            this.trackBarQuality.Location = new System.Drawing.Point(13, 118);
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Size = new System.Drawing.Size(203, 45);
            this.trackBarQuality.TabIndex = 8;
            this.trackBarQuality.TickFrequency = 10;
            this.trackBarQuality.Scroll += new System.EventHandler(this.trackBarQuality_Scroll);
            // 
            // numericUDQuality
            // 
            this.numericUDQuality.Location = new System.Drawing.Point(223, 120);
            this.numericUDQuality.Name = "numericUDQuality";
            this.numericUDQuality.Size = new System.Drawing.Size(49, 20);
            this.numericUDQuality.TabIndex = 9;
            this.numericUDQuality.ValueChanged += new System.EventHandler(this.numericUDQuality_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "качество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Размер наибольшей стороны ( pix ) :";
            // 
            // numericUDSize
            // 
            this.numericUDSize.Location = new System.Drawing.Point(223, 176);
            this.numericUDSize.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numericUDSize.Name = "numericUDSize";
            this.numericUDSize.Size = new System.Drawing.Size(49, 20);
            this.numericUDSize.TabIndex = 12;
            this.numericUDSize.ValueChanged += new System.EventHandler(this.numericUDSize_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.numericUDSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUDQuality);
            this.Controls.Add(this.trackBarQuality);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelSaved);
            this.Controls.Add(this.labelFolderForSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.labelRoute);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Compressor";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDSize)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBarQuality;
        private System.Windows.Forms.NumericUpDown numericUDQuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUDSize;

    }
}


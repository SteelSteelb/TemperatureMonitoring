
namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.tbFishType = new System.Windows.Forms.TextBox();
            this.labelFishType = new System.Windows.Forms.Label();
            this.tbMaxT = new System.Windows.Forms.TextBox();
            this.labelMaxT = new System.Windows.Forms.Label();
            this.tbExceedingTime = new System.Windows.Forms.TextBox();
            this.labelExceedingTime = new System.Windows.Forms.Label();
            this.tbMinT = new System.Windows.Forms.TextBox();
            this.labelMinT = new System.Windows.Forms.Label();
            this.tbDescentTime = new System.Windows.Forms.TextBox();
            this.labelDescentTime = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbTempMeasurement = new System.Windows.Forms.TextBox();
            this.labelTempMeasurement = new System.Windows.Forms.Label();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFishType
            // 
            this.tbFishType.Location = new System.Drawing.Point(433, 25);
            this.tbFishType.Name = "tbFishType";
            this.tbFishType.Size = new System.Drawing.Size(152, 20);
            this.tbFishType.TabIndex = 0;
            // 
            // labelFishType
            // 
            this.labelFishType.AutoSize = true;
            this.labelFishType.Location = new System.Drawing.Point(430, 9);
            this.labelFishType.Name = "labelFishType";
            this.labelFishType.Size = new System.Drawing.Size(52, 13);
            this.labelFishType.TabIndex = 1;
            this.labelFishType.Text = "Fish type:";
            // 
            // tbMaxT
            // 
            this.tbMaxT.Location = new System.Drawing.Point(433, 85);
            this.tbMaxT.Name = "tbMaxT";
            this.tbMaxT.Size = new System.Drawing.Size(86, 20);
            this.tbMaxT.TabIndex = 2;
            // 
            // labelMaxT
            // 
            this.labelMaxT.AutoSize = true;
            this.labelMaxT.Location = new System.Drawing.Point(431, 69);
            this.labelMaxT.Name = "labelMaxT";
            this.labelMaxT.Size = new System.Drawing.Size(89, 13);
            this.labelMaxT.TabIndex = 3;
            this.labelMaxT.Text = "Max temperatute:";
            // 
            // tbExceedingTime
            // 
            this.tbExceedingTime.Location = new System.Drawing.Point(547, 85);
            this.tbExceedingTime.Name = "tbExceedingTime";
            this.tbExceedingTime.Size = new System.Drawing.Size(87, 20);
            this.tbExceedingTime.TabIndex = 4;
            // 
            // labelExceedingTime
            // 
            this.labelExceedingTime.AutoSize = true;
            this.labelExceedingTime.Location = new System.Drawing.Point(544, 69);
            this.labelExceedingTime.Name = "labelExceedingTime";
            this.labelExceedingTime.Size = new System.Drawing.Size(79, 13);
            this.labelExceedingTime.TabIndex = 5;
            this.labelExceedingTime.Text = "Exceeding time";
            // 
            // tbMinT
            // 
            this.tbMinT.Location = new System.Drawing.Point(434, 140);
            this.tbMinT.Name = "tbMinT";
            this.tbMinT.Size = new System.Drawing.Size(85, 20);
            this.tbMinT.TabIndex = 6;
            // 
            // labelMinT
            // 
            this.labelMinT.AutoSize = true;
            this.labelMinT.Location = new System.Drawing.Point(431, 124);
            this.labelMinT.Name = "labelMinT";
            this.labelMinT.Size = new System.Drawing.Size(83, 13);
            this.labelMinT.TabIndex = 7;
            this.labelMinT.Text = "Min temperature";
            // 
            // tbDescentTime
            // 
            this.tbDescentTime.Location = new System.Drawing.Point(547, 139);
            this.tbDescentTime.Name = "tbDescentTime";
            this.tbDescentTime.Size = new System.Drawing.Size(87, 20);
            this.tbDescentTime.TabIndex = 8;
            // 
            // labelDescentTime
            // 
            this.labelDescentTime.AutoSize = true;
            this.labelDescentTime.Location = new System.Drawing.Point(544, 123);
            this.labelDescentTime.Name = "labelDescentTime";
            this.labelDescentTime.Size = new System.Drawing.Size(69, 13);
            this.labelDescentTime.TabIndex = 9;
            this.labelDescentTime.Text = "Descent time";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(433, 185);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(143, 20);
            this.tbDate.TabIndex = 10;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(434, 167);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "Date";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(633, 183);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // tbTempMeasurement
            // 
            this.tbTempMeasurement.Location = new System.Drawing.Point(433, 242);
            this.tbTempMeasurement.Name = "tbTempMeasurement";
            this.tbTempMeasurement.Size = new System.Drawing.Size(355, 20);
            this.tbTempMeasurement.TabIndex = 13;
            // 
            // labelTempMeasurement
            // 
            this.labelTempMeasurement.AutoSize = true;
            this.labelTempMeasurement.Location = new System.Drawing.Point(437, 223);
            this.labelTempMeasurement.Name = "labelTempMeasurement";
            this.labelTempMeasurement.Size = new System.Drawing.Size(133, 13);
            this.labelTempMeasurement.TabIndex = 14;
            this.labelTempMeasurement.Text = "Temperature measurement";
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(12, 24);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(392, 343);
            this.tbMain.TabIndex = 15;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(433, 297);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(355, 23);
            this.btnGenerateReport.TabIndex = 16;
            this.btnGenerateReport.Text = "Generate a report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.labelTempMeasurement);
            this.Controls.Add(this.tbTempMeasurement);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.labelDescentTime);
            this.Controls.Add(this.tbDescentTime);
            this.Controls.Add(this.labelMinT);
            this.Controls.Add(this.tbMinT);
            this.Controls.Add(this.labelExceedingTime);
            this.Controls.Add(this.tbExceedingTime);
            this.Controls.Add(this.labelMaxT);
            this.Controls.Add(this.tbMaxT);
            this.Controls.Add(this.labelFishType);
            this.Controls.Add(this.tbFishType);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFishType;
        private System.Windows.Forms.Label labelFishType;
        private System.Windows.Forms.TextBox tbMaxT;
        private System.Windows.Forms.Label labelMaxT;
        private System.Windows.Forms.TextBox tbExceedingTime;
        private System.Windows.Forms.Label labelExceedingTime;
        private System.Windows.Forms.TextBox tbMinT;
        private System.Windows.Forms.Label labelMinT;
        private System.Windows.Forms.TextBox tbDescentTime;
        private System.Windows.Forms.Label labelDescentTime;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbTempMeasurement;
        private System.Windows.Forms.Label labelTempMeasurement;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}


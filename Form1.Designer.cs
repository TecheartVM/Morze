
namespace Morze
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
            this.inputDisplay = new System.Windows.Forms.Label();
            this.outputDisplay = new System.Windows.Forms.Label();
            this.questionDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputDisplay
            // 
            this.inputDisplay.Font = new System.Drawing.Font("Times New Roman", 128.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputDisplay.Location = new System.Drawing.Point(12, 9);
            this.inputDisplay.Name = "inputDisplay";
            this.inputDisplay.Size = new System.Drawing.Size(204, 204);
            this.inputDisplay.TabIndex = 3;
            this.inputDisplay.Text = "A";
            this.inputDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDisplay
            // 
            this.outputDisplay.Font = new System.Drawing.Font("Times New Roman", 128.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputDisplay.ForeColor = System.Drawing.Color.Green;
            this.outputDisplay.Location = new System.Drawing.Point(247, 9);
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.Size = new System.Drawing.Size(204, 204);
            this.outputDisplay.TabIndex = 4;
            this.outputDisplay.Text = "A";
            this.outputDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionDisplay
            // 
            this.questionDisplay.Font = new System.Drawing.Font("Times New Roman", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionDisplay.Location = new System.Drawing.Point(12, 213);
            this.questionDisplay.Name = "questionDisplay";
            this.questionDisplay.Size = new System.Drawing.Size(439, 144);
            this.questionDisplay.TabIndex = 5;
            this.questionDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 366);
            this.Controls.Add(this.questionDisplay);
            this.Controls.Add(this.outputDisplay);
            this.Controls.Add(this.inputDisplay);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(479, 405);
            this.MinimumSize = new System.Drawing.Size(479, 405);
            this.Name = "AppForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morze";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label inputDisplay;
        private System.Windows.Forms.Label outputDisplay;
        private System.Windows.Forms.Label questionDisplay;
    }
}


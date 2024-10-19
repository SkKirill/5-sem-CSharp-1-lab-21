
namespace Lb6.Forms
{
    partial class TaskForm
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
			this.labelTask = new System.Windows.Forms.Label();
			this.labelAnswerTask = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.labelAnswer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelTask
			// 
			this.labelTask.AutoSize = true;
			this.labelTask.Location = new System.Drawing.Point(10, 2);
			this.labelTask.Name = "labelTask";
			this.labelTask.Size = new System.Drawing.Size(380, 80);
			this.labelTask.TabIndex = 3;
			this.labelTask.Text = "Задание 21:\r\nНайти группы, в которых обучаются только студенты \r\nбюджетной формы " +
    "обучения.\r\n\r\n\r\n";
			// 
			// labelAnswerTask
			// 
			this.labelAnswerTask.AutoSize = true;
			this.labelAnswerTask.Location = new System.Drawing.Point(10, 66);
			this.labelAnswerTask.Name = "labelAnswerTask";
			this.labelAnswerTask.Size = new System.Drawing.Size(107, 16);
			this.labelAnswerTask.TabIndex = 5;
			this.labelAnswerTask.Text = "Номера Групп:";
			// 
			// buttonOk
			// 
			this.buttonOk.BackColor = System.Drawing.Color.CornflowerBlue;
			this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.buttonOk.FlatAppearance.BorderSize = 0;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonOk.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOk.Location = new System.Drawing.Point(12, 85);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(106, 31);
			this.buttonOk.TabIndex = 28;
			this.buttonOk.Text = "Выбрать";
			this.buttonOk.UseVisualStyleBackColor = false;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// labelAnswer
			// 
			this.labelAnswer.AutoSize = true;
			this.labelAnswer.Location = new System.Drawing.Point(123, 66);
			this.labelAnswer.Name = "labelAnswer";
			this.labelAnswer.Size = new System.Drawing.Size(284, 16);
			this.labelAnswer.TabIndex = 29;
			this.labelAnswer.Text = "Нажмите выбрать для получения ответа";
			// 
			// TaskForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(557, 120);
			this.Controls.Add(this.labelAnswer);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.labelAnswerTask);
			this.Controls.Add(this.labelTask);
			this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "TaskForm";
			this.Text = "Задание";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelAnswerTask;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelAnswer;
    }
}
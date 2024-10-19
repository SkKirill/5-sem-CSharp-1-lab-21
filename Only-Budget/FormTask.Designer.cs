
namespace Lb6
{
    partial class FormTask
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
            this.labelNumCoursStud = new System.Windows.Forms.Label();
            this.numericUpDownNumberStudent = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(10, 9);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(507, 34);
            this.labelTask.TabIndex = 3;
            this.labelTask.Text = "Задание 10:\r\nНайти номера групп на заданном курсе, в которых есть отличники:";
            // 
            // labelAnswerTask
            // 
            this.labelAnswerTask.AutoSize = true;
            this.labelAnswerTask.Location = new System.Drawing.Point(10, 75);
            this.labelAnswerTask.Name = "labelAnswerTask";
            this.labelAnswerTask.Size = new System.Drawing.Size(116, 17);
            this.labelAnswerTask.TabIndex = 5;
            this.labelAnswerTask.Text = "Номера Групп:";
            // 
            // labelNumCoursStud
            // 
            this.labelNumCoursStud.AutoSize = true;
            this.labelNumCoursStud.Location = new System.Drawing.Point(10, 50);
            this.labelNumCoursStud.Name = "labelNumCoursStud";
            this.labelNumCoursStud.Size = new System.Drawing.Size(111, 17);
            this.labelNumCoursStud.TabIndex = 6;
            this.labelNumCoursStud.Text = "Введите курс:";
            // 
            // numericUpDownNumberStudent
            // 
            this.numericUpDownNumberStudent.BackColor = System.Drawing.Color.LightSteelBlue;
            this.numericUpDownNumberStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownNumberStudent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownNumberStudent.Location = new System.Drawing.Point(129, 50);
            this.numericUpDownNumberStudent.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownNumberStudent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberStudent.Name = "numericUpDownNumberStudent";
            this.numericUpDownNumberStudent.Size = new System.Drawing.Size(45, 19);
            this.numericUpDownNumberStudent.TabIndex = 7;
            this.numericUpDownNumberStudent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(12, 95);
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
            this.labelAnswer.Location = new System.Drawing.Point(124, 75);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(301, 17);
            this.labelAnswer.TabIndex = 29;
            this.labelAnswer.Text = "Нажмите выбрать для получения ответа";
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(557, 131);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownNumberStudent);
            this.Controls.Add(this.labelNumCoursStud);
            this.Controls.Add(this.labelAnswerTask);
            this.Controls.Add(this.labelTask);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormTask";
            this.Text = "Задание";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelAnswerTask;
        private System.Windows.Forms.Label labelNumCoursStud;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberStudent;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelAnswer;
    }
}
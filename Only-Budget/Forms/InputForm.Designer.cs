
namespace Lb6.Forms
{
    partial class InputForm
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
            this.labelNumStudent = new System.Windows.Forms.Label();
            this.numericUpDownNumberStudent = new System.Windows.Forms.NumericUpDown();
            this.buttonEnterNumStud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumStudent
            // 
            this.labelNumStudent.AutoSize = true;
            this.labelNumStudent.Location = new System.Drawing.Point(47, 21);
            this.labelNumStudent.Name = "labelNumStudent";
            this.labelNumStudent.Size = new System.Drawing.Size(129, 17);
            this.labelNumStudent.TabIndex = 0;
            this.labelNumStudent.Text = "Номер студента:";
            // 
            // numericUpDownNumberStudent
            // 
            this.numericUpDownNumberStudent.BackColor = System.Drawing.Color.SkyBlue;
            this.numericUpDownNumberStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownNumberStudent.Cursor = System.Windows.Forms.Cursors.Default;
            this.numericUpDownNumberStudent.Location = new System.Drawing.Point(182, 21);
            this.numericUpDownNumberStudent.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownNumberStudent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberStudent.Name = "numericUpDownNumberStudent";
            this.numericUpDownNumberStudent.Size = new System.Drawing.Size(45, 23);
            this.numericUpDownNumberStudent.TabIndex = 1;
            this.numericUpDownNumberStudent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonEnterNumStud
            // 
            this.buttonEnterNumStud.AutoSize = true;
            this.buttonEnterNumStud.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEnterNumStud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterNumStud.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEnterNumStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterNumStud.Location = new System.Drawing.Point(50, 50);
            this.buttonEnterNumStud.Name = "buttonEnterNumStud";
            this.buttonEnterNumStud.Size = new System.Drawing.Size(175, 30);
            this.buttonEnterNumStud.TabIndex = 2;
            this.buttonEnterNumStud.Text = "Ввод";
            this.buttonEnterNumStud.UseVisualStyleBackColor = false;
            this.buttonEnterNumStud.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(282, 88);
            this.Controls.Add(this.buttonEnterNumStud);
            this.Controls.Add(this.numericUpDownNumberStudent);
            this.Controls.Add(this.labelNumStudent);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormInput";
            this.Text = "Номер";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumStudent;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberStudent;
        private System.Windows.Forms.Button buttonEnterNumStud;
    }
}
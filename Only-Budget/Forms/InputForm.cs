using System;
using System.Windows.Forms;

namespace Lb6.Forms
{
	public partial class InputForm : Form
    {
        private State ValState;
        public InputForm(State valState)
        {
            InitializeComponent();
            ValState = valState;
            numericUpDownNumberStudent.Maximum = MainDataForm.Students.Count-1;
		}
        private void button1_Click(object sender, EventArgs e)
        {
            int inputVal = (int)numericUpDownNumberStudent.Value;
            if (MainDataForm.Students.Count >= inputVal)
            {
                if (ValState == State.edit)
                {
                    EditStudentForm addForm = new EditStudentForm(MainDataForm.Students[inputVal - 1]);
                    addForm.ShowDialog();
                }
                MainDataForm.Students.Remove(MainDataForm.Students[inputVal - 1]);
                Close();
            }
            else MessageBox.Show("Не существует такого студента", "Ошибка!");
        }
    }
}

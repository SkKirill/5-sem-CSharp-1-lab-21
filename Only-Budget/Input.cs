using System;
using System.Windows.Forms;

namespace Lb6
{
    public partial class FormInput : Form
    {
        public enum State
        {
            delete,
            edit
        }
        private State ValState;
        public FormInput(State valState)
        {
            InitializeComponent();
            ValState = valState;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int inputVal = (int)numericUpDownNumberStudent.Value;
            if (FormData.Students.Count >= inputVal)
            {
                if (ValState == State.edit)
                {
                    FormAddStudent addForm = new FormAddStudent(FormData.Students[inputVal - 1]);
                    addForm.ShowDialog();
                }
                FormData.Students.Remove(FormData.Students[inputVal - 1]);
                Close();
            }
            else MessageBox.Show("Не существует такого студента", "Ошибка!");
        }
    }
}

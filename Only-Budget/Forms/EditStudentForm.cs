using Lb6.Models;
using System;
using System.Windows.Forms;

namespace Lb6.Forms
{
    public partial class EditStudentForm : Form
    {
        public Students editStudent;
        public EditStudentForm()
        {
            InitializeComponent();
        }
        public void FildGrid(DataGridView grid, Session session)
        {
            grid.Visible = true;
            for (int i = 0; i < Session.countExamsInSesson; i++)
            {
                grid.Rows.Add(session.Exams[i].Name, session.Exams[i].Mark);
            }
        }
        public EditStudentForm(Students student)
        {
            editStudent = student;
            InitializeComponent();
            textBoxFIO.Text = student.FIO;
            numericUpDownCours.Value = student.Cours;
            numericUpDownGroup.Value = student.Group;
            if (student.FormЕducation == FormЕducat.Agreement)
            {
                checkBoxAgreement.Checked = true;
            }
            else
            {
                checkBoxAgreement.Checked = false;
            }
            switch (student.Cours)
            {
                case 4:
                    FildGrid(dataGridViewSessia8, student.Sessions[7]);
                    FildGrid(dataGridViewSessia7, student.Sessions[6]);
                    goto case 3;
                case 3:
                    FildGrid(dataGridViewSessia6, student.Sessions[5]);
                    FildGrid(dataGridViewSessia5, student.Sessions[4]);
                    goto case 2;
                case 2:
                    FildGrid(dataGridViewSessia4, student.Sessions[3]);
                    FildGrid(dataGridViewSessia3, student.Sessions[2]);
                    goto case 1;
                case 1:
                    FildGrid(dataGridViewSessia2, student.Sessions[1]);
                    FildGrid(dataGridViewSessia1, student.Sessions[0]);
                    break;
            }
        }
        private void EditStudent_Load(object sender, EventArgs e)
        {
            dataGridViewSessia1.RowCount = 4;
            dataGridViewSessia2.RowCount = 4;
            dataGridViewSessia3.RowCount = 4;
            dataGridViewSessia4.RowCount = 4;
            dataGridViewSessia5.RowCount = 4;
            dataGridViewSessia6.RowCount = 4;
            dataGridViewSessia7.RowCount = 4;
            dataGridViewSessia8.RowCount = 4;
        }
        private void checkBoxAgreement_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAgreement.Checked == true)
            {
                checkBoxBudget.Checked = false;
            }
            else checkBoxBudget.Checked = true;
        }
        private void checkBoxBudget_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBudget.Checked == true)
            {
                checkBoxAgreement.Checked = false;
            }
            else checkBoxAgreement.Checked = true;
        }
        // Функция isFilledGrid принимает DataGridView и проверяет, что в нем заполнены все значения в 1 столбце (проверка, что внесли все названия экзаменов)
        static bool isFilledGrid(DataGridView grid)
        {
            bool ok = true;
            if (grid.Enabled == true)
            {
                for (int i = 0; i < Session.countExamsInSesson && ok; i++)
                {
                    ok = grid[0, i].Value != null;
                    if (grid[1, i].Value != null)
                    {
                        if (int.TryParse(grid[1, i].Value.ToString(), out int markExam))
                        {
                            ok = markExam >= 2 && markExam <= 5;
                        }
                        else ok = false;
                        
                    }
                }
            }
            return ok;
        }
        Session createSessia(int cours, DataGridView grid)
        {
            Session session = new Session();
            for (int i = 0; i < Session.countExamsInSesson; i++)
            {
                session.Exams[i].Name = grid[0, i].Value.ToString();
                if (grid[1, i].Value == null || grid[1, i].Value.ToString() == "")
                {
                    session.Exams[i].Mark = null;
                }
                else session.Exams[i].Mark = Convert.ToInt32(grid[1, i].Value);
            }
            return session;
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxFIO.Text != "" && isFilledGrid(dataGridViewSessia1) && isFilledGrid(dataGridViewSessia2) && isFilledGrid(dataGridViewSessia3)
                && isFilledGrid(dataGridViewSessia4) && isFilledGrid(dataGridViewSessia5) && isFilledGrid(dataGridViewSessia6) && isFilledGrid(dataGridViewSessia7)
                && isFilledGrid(dataGridViewSessia8))
            {
                FormЕducat formEducation;
                if (checkBoxBudget.Checked == true)
                {
                    formEducation = FormЕducat.Budget;
                }
                else
                {
                    formEducation = FormЕducat.Agreement;
                }
                Session[] session = new Session[Students.countSessions];
                switch (Convert.ToInt32(numericUpDownCours.Value))
                {
                    case 4:
                        session[7] = createSessia(4, dataGridViewSessia8);
                        session[6] = createSessia(4, dataGridViewSessia7);
                        goto case 3;
                    case 3:
                        session[5] = createSessia(3, dataGridViewSessia6);
                        session[4] = createSessia(3, dataGridViewSessia5);
                        goto case 2;
                    case 2:
                        session[3] = createSessia(2, dataGridViewSessia4);
                        session[2] = createSessia(2, dataGridViewSessia3);
                        goto case 1;
                    case 1:
                        session[1] = createSessia(1, dataGridViewSessia2);
                        session[0] = createSessia(1, dataGridViewSessia1);
                        break;
                }
                Students student = new Students(textBoxFIO.Text, Convert.ToInt32(numericUpDownCours.Value), Convert.ToInt32(numericUpDownGroup.Value), session, formEducation);
                MainDataForm.Students.Add(student);
                editStudent = null;
                Close();
            }
            else
            {
                MessageBox.Show("Вы не до конца или неверно указали данные!", "Ошибка!");
            }
        }
        private void numericUpDownCours_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewSessia8.Enabled = false;
            dataGridViewSessia7.Enabled = false;
            dataGridViewSessia6.Enabled = false;
            dataGridViewSessia5.Enabled = false;
            dataGridViewSessia4.Enabled = false;
            dataGridViewSessia3.Enabled = false;
            switch (numericUpDownCours.Value)
            {
                case 4:
                    dataGridViewSessia8.Enabled = true;
                    dataGridViewSessia7.Enabled = true;
                    goto case 3;
                case 3:
                    dataGridViewSessia6.Enabled = true;
                    dataGridViewSessia5.Enabled = true;
                    goto case 2;
                case 2:
                    dataGridViewSessia4.Enabled = true;
                    dataGridViewSessia3.Enabled = true;
                    break;
            }
        }

        private void FormAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (editStudent != null)
            {
                MainDataForm.Students.Add(editStudent);
            }
        }
    }
}

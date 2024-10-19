using Lb6.FileProcessor;
using Lb6.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lb6.Forms
{
	public partial class MainDataForm : Form
    {
        public static List<Students> Students { get; set; }
        private string FilePash = "";
        public MainDataForm()
        {
            InitializeComponent();
            Students = new List<Students>();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStudentForm addForm = new EditStudentForm();
            addForm.ShowDialog();
            RedrawGridData();
        }
        private void RedrawGridData()
        {
            dataGridViewData.RowCount = 0;
            foreach (Students student in Students)
            {
                if (student.FormЕducation == FormЕducat.Agreement)
                {
                    dataGridViewData.Rows.Add(dataGridViewData.RowCount + 1, student.FIO, student.Group, student.Cours, "Договор");
                }
                else
                {
                    dataGridViewData.Rows.Add(dataGridViewData.RowCount + 1, student.FIO, student.Group, student.Cours, "Бюджет");
                }
            }

        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FilePash.Length == 0 || !File.Exists(FilePash))
            {
                SaveAsToolStripMenuItem_Click(sender, e);
                return;
            }
			if (FilePash.EndsWith(".txt"))
			{
				IFileProcessor processor = new FileProcessorTxt();
				processor.Save(FilePash, Students);
			}
			if (FilePash.EndsWith(".dat"))
            {
                IFileProcessor processor = new FileProcessorDat();
                processor.Save(FilePash, Students);
            }
            if (FilePash.EndsWith(".xml"))
            {
                IFileProcessor processor = new FileProcessorXML();
                processor.Save(FilePash, Students);
            }
            return;
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePash = openFileDialog.FileName;
                if (FilePash.EndsWith(".xml"))
                {
                    IFileProcessor processorXML = new FileProcessorXML();
                    Students = processorXML.Load(FilePash);
                }
                else if (FilePash.EndsWith(".dat"))
                {
                    IFileProcessor processorBin = new FileProcessorDat();
                    Students = processorBin.Load(FilePash);
                }
				else if (FilePash.EndsWith(".txt"))
				{
					IFileProcessor processorTxt = new FileProcessorTxt();
					Students = processorTxt.Load(FilePash);
				}
				else MessageBox.Show("Неверно введено название файла", "Ошибка!");
                RedrawGridData();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePash = saveFileDialog.FileName;
                if (FilePash.EndsWith(".xml"))
                {
                    IFileProcessor processorXML = new FileProcessorXML();
                    processorXML.Save(FilePash, Students);
                }
                else if (FilePash.EndsWith(".dat"))
                {
                    IFileProcessor processorBin = new FileProcessorDat();
                    processorBin.Save(FilePash, Students);
                }
				else if (FilePash.EndsWith(".txt"))
				{
					IFileProcessor processorTxt = new FileProcessorTxt();
					processorTxt.Save(FilePash, Students);
				}
				else MessageBox.Show("Неверно введено название файла", "Ошибка!");
            }
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FilePash != "")
            {
                DialogResult result = MessageBox.Show("У вас есть открытый файл в данном окне! Соранить измененные данные?", "Изменение",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(sender, e);
                }
            }
            DeleteTableToolStripMenuItem_Click(sender, e);
            FilePash = "";
        }

        public void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm(State.delete);
            inputForm.ShowDialog();
            RedrawGridData();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm(State.edit);
            inputForm.ShowDialog();
            RedrawGridData();
        }

        private void DeleteTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students.Clear();
            RedrawGridData();
        }
        // 10. Найти номера групп на заданном курсе, в которых есть отличники
        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm();
            taskForm.Show();
        }

        private void FormData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FilePash != "")
            {
                DialogResult result = MessageBox.Show("У вас есть открытый файл в данном окне!\nСоранить измененные данные?", "Выход",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void FormData_Load(object sender, EventArgs e)
        {
            dataGridViewData.ClearSelection();
        }

        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
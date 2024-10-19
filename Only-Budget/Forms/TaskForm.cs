using Lb6.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lb6.Forms
{
	public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

		// 21. Найти группы, в которых обучаются только студенты бюджетной формы обучения.
		private void buttonOk_Click(object sender, EventArgs e)
        {
            HashSet<int> setNumGroupAgerment = new HashSet<int>();
            HashSet<int> setNumGroupAnswer = new HashSet<int>();
            string answer = "";

            foreach(Students stud in MainDataForm.Students)
            {
                if (stud.FormЕducation == FormЕducat.Agreement)
                {
					setNumGroupAgerment.Add(stud.Group);
                }
				setNumGroupAnswer.Add(stud.Group);
			}

            setNumGroupAnswer.ExceptWith(setNumGroupAgerment);

			foreach (int numGroup in setNumGroupAnswer)
            {
                answer = answer + numGroup.ToString() + " ";
            }
            labelAnswer.Text = answer.Trim();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb6
{
    public partial class FormTask : Form
    {
        public FormTask()
        {
            InitializeComponent();
        }

        public bool is_ExecellentExams(Session[] sessions)
        {
            foreach(Session sess in sessions)
            {
                if (sess != null)
                {
                    foreach (Exam exs in sess.Exams)
                    {
                        if (exs.Mark != null)
                        {
                            if (exs.Mark != 5)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
        // 10. Найти номера групп на заданном курсе, в которых есть отличники
        private void buttonOk_Click(object sender, EventArgs e)
        {
            int valCourc = Convert.ToInt32(numericUpDownNumberStudent.Value);
            HashSet<int> setNumGroup = new HashSet<int>();
            string answer = "";
            foreach(Students stud in FormData.Students)
            {
                if (stud.Cours == valCourc && is_ExecellentExams(stud.Sessions))
                {
                    setNumGroup.Add(stud.Group);
                }
            }
            foreach(int numGroup in setNumGroup)
            {
                answer = answer + numGroup.ToString() + " ";
            }
            labelAnswer.Text = answer.Trim();
        }
    }
}

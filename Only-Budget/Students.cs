using System;

namespace Lb6
{
    [Serializable]
    public class Session
    {
        public const int countExamsInSesson = 4;
        public Exam[] Exams { get; set; }
        public Session()
        {
            Exams = new Exam[countExamsInSesson];
        }
    }
    [Serializable]
    public struct Exam
    {
        public string Name;
        public int? Mark;
    }
    [Serializable]
    public enum FormЕducat
    {
        Agreement,
        Budget
    }
    [Serializable]
    public class Students
    {
        public const int countSessions = 8;
        public string FIO { get; set; }
        public int Cours { get; set; }
        public int Group { get; set; }
        public Session[] Sessions { get; set; } = new Session[countSessions];
        public FormЕducat FormЕducation { get; set; }
        public Students(string fio, int cours, int group, Session[] sessiya, FormЕducat formeducate)
        {
            FIO = fio;
            Cours = cours;
            Group = group;
            Sessions = sessiya;
            FormЕducation = formeducate;
        }
        public Students()
        {
            FIO = "";
            Cours = 1;
            Group = 1;
            Sessions = new Session[countSessions];
            FormЕducation = FormЕducat.Budget;
        }
    }
}

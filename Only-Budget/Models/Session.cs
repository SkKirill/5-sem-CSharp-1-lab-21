using System;

namespace Lb6.Models
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
}

using System;

namespace Lb6.Models
{
	[Serializable]
    public struct Exam
    {
        public string Name { get; set; }
        public int? Mark {  get; set; }
    }
}

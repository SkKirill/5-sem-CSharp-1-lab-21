using Lb6.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lb6.FileProcessor
{
	class FileProcessorTxt : IFileProcessor
	{
		public List<Students> Load(string filename)
		{
			List<Students> students = new List<Students>();
			using (StreamReader reader = new StreamReader(filename))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					Students student = new Students();

					string[] parts = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

					student.FIO = parts[0];
					student.Cours = Convert.ToInt32(parts[1]);
					student.Group = Convert.ToInt32(parts[2]);
					student.FormЕducation = parts[3] == "Budget" ? FormЕducat.Budget : FormЕducat.Agreement;

					for (int position = 4, count = 0; position < parts.Length && count < Students.countSessions; count++)
					{
						student.Sessions[count] = new Session();
						Session session = student.Sessions[count];
						for (int i = 0; i < Session.countExamsInSesson; i++, position = position + 2)
						{
							session.Exams[i].Name = parts[position];
							session.Exams[i].Mark = Convert.ToInt32(parts[position+1]);
						}
					}
					students.Add(student);
				}
			}
			return students;
		}

		public void Save(string filename, List<Students> students)
		{
			using (StreamWriter writer = new StreamWriter(filename))
			{
				foreach (Students student in students)
				{
					string line = $"{student.FIO};{student.Cours};{student.Group};{student.FormЕducation};";

					foreach (Session session in student.Sessions)
					{
						if (session is null)
						{
							break;
						}
						foreach (Exam exam in session.Exams)
						{
							line += $"{exam.Name};{exam.Mark};";
						}
					}
					writer.WriteLine(line);
				}
			}
		}
	}
}

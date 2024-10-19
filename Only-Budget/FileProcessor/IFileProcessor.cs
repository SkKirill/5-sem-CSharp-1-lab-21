using Lb6.Models;
using System.Collections.Generic;

namespace Lb6.FileProcessor
{
    public interface IFileProcessor
    {
        List<Students> Load(string filename);
        void Save(string filename, List<Students> students);
    }
}

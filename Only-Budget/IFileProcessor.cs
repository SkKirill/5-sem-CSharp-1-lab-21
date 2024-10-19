using System.Collections.Generic;

namespace Lb6
{
    public interface IFileProcessor
    {
        List<Students> Load(string filename);
        void Save(string filename, List<Students> students);
    }
}

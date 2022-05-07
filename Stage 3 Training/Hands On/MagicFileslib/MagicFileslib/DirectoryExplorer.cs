using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MagicFileslib
{
    public interface IDirectoryExplorer
    {
        ICollection<string> GetFiles(string path);
    }

    public class DirectoryExplorer
    {
        private IDirectoryExplorer _directory;
        public DirectoryExplorer()
        {
        }

        public virtual ICollection<string> GetFiles(string path)
        {
            string[] files = Directory.GetFiles(path);

            return files;
        }
    }
}

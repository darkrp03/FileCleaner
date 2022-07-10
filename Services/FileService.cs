using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileCleaner.Services
{
    internal class FileService
    {
        #region Methods     
        private void DeleteFilesInSubFolders(string path, List<string> extensions)
        {
            var directories = Directory.GetDirectories(path);

            foreach (var directory in directories)
            {
                var files = Directory.GetFiles(directory);

                foreach (var extension in extensions)
                {
                    foreach (var file in files)
                    {
                        var fileExtension = Path.GetExtension(file);

                        if (extension.Equals(extensions))
                        {
                            File.Delete(file);
                        }
                    }
                }
            }
        }

        public void DeleteFiles(string path, List<string> extensions)
        {
            var files = Directory.GetFiles(path);

            foreach (var extension in extensions)
            {
                foreach (var file in files)
                {
                    var fileExtension = Path.GetExtension(file);

                    if (fileExtension.Equals(extension))
                    {
                        File.Delete(file);
                    }
                }
            }

            DeleteFilesInSubFolders(path, extensions);                                
        }
        #endregion
    }
}

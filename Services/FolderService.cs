using System.Windows.Forms;

namespace FileCleaner.Services
{
    internal class FolderService
    {
        #region Methods    
        public string GetPath()
        {
            string path = string.Empty;

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderDialog.SelectedPath;
                }
            }

            return path;
        }
        #endregion
    }
}

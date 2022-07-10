using FileCleaner.Services;
using System;
using System.Collections.Generic;

namespace FileCleaner.Models
{
    internal class Cleaner
    {
        #region Fields      
        private string firstPath = string.Empty;
        private string secondPath = string.Empty;
        private List<string> extensions;
        #endregion

        #region Ctor       
        public Cleaner()
        {
            extensions = new List<string>();
        }
        #endregion

        #region Properties       
        public string FirstPath
        {
            get => firstPath;
            set => firstPath = value;
        }

        public string SecondPath
        {
            get => secondPath;
            set => secondPath = value;
        } 

        public List<string> Extensions
        {
            get => extensions;
        }
        #endregion

        #region Methods      
        public void Run()
        {
            FileService fileService = new FileService();
            
            if (String.IsNullOrEmpty(SecondPath))
            {
                fileService.DeleteFiles(FirstPath, extensions);               
            }
            else
            {
                fileService.DeleteFiles(FirstPath, extensions);
                fileService.DeleteFiles(SecondPath, extensions);
            }
        }
        #endregion
    }
}

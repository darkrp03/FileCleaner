using FileCleaner.Interfaces;
using FileCleaner.Models;
using FileCleaner.Services;
using System;
using System.Threading.Tasks;

namespace FileCleaner.Controllers
{
    internal class MainFormController
    {
        #region Fields   
        private readonly Cleaner _cleaner; //Business logic object
        private readonly IView _view; //Object for change components on form
        #endregion

        #region Ctor     
        public MainFormController(IView view, Cleaner cleaner)
        {
            _cleaner = cleaner;

            _view = view;
            _view.FirstPathButtonClickHandler = FirstPathButtonClick;
            _view.SecondPathButtonClickHandler = SecondPathButtonClick;
            _view.StartButtonClickHandler = StartButtonClick;
        }
        #endregion

        #region Methods     
        private void GetExtensions()
        {
            string[] extensions = _view.Extensions.Split(' ');

            foreach(var extension in extensions)
            {
                _cleaner.Extensions.Add(extension);
            }
        }

        private string GetPath()
        {
            FolderService folderService = new FolderService();

            return folderService.GetPath();
        }

        private void FirstPathButtonClick(object? sender, EventArgs e) //Event method when user click on first "Choose" button 
        {
            _view.FirstPath = GetPath();
        }

        private void SecondPathButtonClick(object? sender, EventArgs e) //Event method when user click on second "Choose" button 
        {
            _view.SecondPath = GetPath();
        }

        public void StartButtonClick(object? sender, EventArgs e) //Event method when user click on "Start" button
        {
            _view.WarningLabelVisible = false;
            _view.InfoLabelVisible = false;

            if (String.IsNullOrEmpty(_view.FirstPath) || String.IsNullOrEmpty(_view.Extensions))
            {
                _view.WarningLabelVisible = true;
                return;
            }

            _cleaner.FirstPath = _view.FirstPath;
            _cleaner.SecondPath = _view.SecondPath;

            GetExtensions();

            Task.Run(new Action(_cleaner.Run));

            _view.InfoLabelVisible = true;
        }
        #endregion
    }
}

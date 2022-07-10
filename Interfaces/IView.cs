using System;
using System.Windows.Forms;

namespace FileCleaner.Interfaces
{
    internal interface IView //Interface for controller
    {
        EventHandler FirstPathButtonClickHandler { set; }

        EventHandler SecondPathButtonClickHandler { set; }

        EventHandler StartButtonClickHandler { set; }

        string FirstPath { get; set; }

        string SecondPath { get; set; }

        string Extensions { get; set; }

        bool WarningLabelVisible { set; }

        bool InfoLabelVisible { set; }
    }
}

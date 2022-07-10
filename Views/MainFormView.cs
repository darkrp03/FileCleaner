using FileCleaner.Controllers;
using FileCleaner.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FileCleaner.Views
{
    public partial class MainFormView : Form, IView
    {
        #region Ctor        
        public MainFormView()
        {
            InitializeComponent();

            BackColor = ColorTranslator.FromHtml("#303030");

            programNameLabel.ForeColor = ColorTranslator.FromHtml("#C03131");

            firstPathLabel.ForeColor = ColorTranslator.FromHtml("#C03131");

            secondPathLabel.ForeColor = ColorTranslator.FromHtml("#C03131");

            fileExtensionsLabel.ForeColor = ColorTranslator.FromHtml("#C03131");

            firstPathButton.BackColor = ColorTranslator.FromHtml("#C03131");
            firstPathButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#C03131");

            secondPathButton.BackColor = ColorTranslator.FromHtml("#C03131");
            secondPathButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#C03131");

            startButton.BackColor = ColorTranslator.FromHtml("#C03131");
            startButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#C03131");

            infoLabel.ForeColor = ColorTranslator.FromHtml("#23AD42");
        }
        #endregion

        #region Properties
        public EventHandler FirstPathButtonClickHandler
        {
            set => firstPathButton.Click += value;
        }

        public EventHandler SecondPathButtonClickHandler
        {
            set => secondPathButton.Click += value;
        }

        public EventHandler StartButtonClickHandler
        {
            set => startButton.Click += value;
        }

        public string FirstPath
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public string SecondPath
        {
            get => textBox2.Text;
            set => textBox2.Text = value;
        }

        public string Extensions
        {
            get => textBox3.Text;
            set => textBox3.Text = value;
        }

        public bool WarningLabelVisible
        {
            set => warningLabel.Visible = value;
        }

        public bool InfoLabelVisible
        {
            set => infoLabel.Visible = value;
        }
        #endregion
    }
}

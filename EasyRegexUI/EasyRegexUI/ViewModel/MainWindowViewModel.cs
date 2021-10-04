using EasyRegexUI.Models;
using EasyRegexUI.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace EasyRegexUI
{
    public class MainWindowViewModel : ObservableObject
    {
        public RegexServices Services { get; set; }

        public SessionModel Session { get; set; }

        public MainWindowViewModel()
        {
            Services = new RegexServices();
            Session = new SessionModel();
          

            UpdateSelectedFileCommand = new RelayCommand(UpdateSelectedFile);
            ExtractFromFileCommand = new RelayCommand(ExtractFromFile);
            CopySelectedTextCommand = new RelayCommand(CopySelected);
            CopyAllResultsCommand = new RelayCommand(CopyAllResults);
        }


        public ICommand UpdateSelectedFileCommand { get; }

        public ICommand ExtractFromFileCommand { get; }

        public ICommand CopySelectedTextCommand { get; }

        public ICommand CopyAllResultsCommand { get; set; }

        public void UpdateSelectedFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            bool? result = fileDialog.ShowDialog();
            if (result == true)
            {
                Session.FilePath = fileDialog.FileName;
            }
        }

        public async void ExtractFromFile()
        {
            try
            {
                Session.Results = await RegexServices.CallRegexMethod(Session.FilePath, Session.SelectedMethod.SearchMethod);
                if(Session.FilePath.Length > 0)     
                {
                    Session.ButtonVisibility = "Visible";
                }

            }
            catch(ArgumentNullException)
            {




            }
           

            
        }

        public void CopySelected()
        {
            Clipboard.SetText(Session.SelectedItem);
        }

        public void CopyAllResults()
        {
            var sb = new StringBuilder();
        
            foreach (var item in Session.Results)
            {
                sb.Append(item);
            }
            Clipboard.SetData("Text", sb.ToString());

        }
    }
}

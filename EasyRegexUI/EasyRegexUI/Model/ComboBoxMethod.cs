using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Text.RegularExpressions;

namespace EasyRegexUI.Model
{
    public class ComboBoxMethod : ObservableObject
    {
        private string searchMethodNameText;

        private Func<string, MatchCollection> searchMethod;

        public string SearchMethodNameText
        {
            get => searchMethodNameText;
            set => SetProperty(ref searchMethodNameText, value);
        }

        public Func<string, MatchCollection> SearchMethod
        {
            get => searchMethod;
            set => SetProperty(ref searchMethod, value);

        }

        public override string ToString()
        {
            return SearchMethodNameText;
        }

    }
}

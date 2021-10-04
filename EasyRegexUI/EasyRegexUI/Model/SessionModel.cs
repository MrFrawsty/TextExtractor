using EasyRegexLibrary;
using EasyRegexUI.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace EasyRegexUI.Models
{
    public class SessionModel : ObservableObject
    {

        private string filePath;
        public string FilePath
        {
            get => filePath;
            set => SetProperty(ref filePath, value);

        }

        private string selectedItem;
        public string SelectedItem
        {
            get => selectedItem;
            set => SetProperty(ref selectedItem, value);
        }

        private string buttonVisibility = "Hidden";
        public string ButtonVisibility
        {
            get => buttonVisibility;
            set => SetProperty(ref buttonVisibility, value);
        }

        private List<ComboBoxMethod> comboBoxMethods;
        public List<ComboBoxMethod> ComboBoxMethods
        {
            get => comboBoxMethods;
            set => SetProperty(ref comboBoxMethods, value);
        }

        private ComboBoxMethod selectedMethod;
        public ComboBoxMethod SelectedMethod
        {
            get => selectedMethod;
            set => SetProperty(ref selectedMethod, value);
        }

        private List<string> results;
        public List<string> Results
        {
            get => results;
            set => SetProperty(ref results, value);
        }

        public SessionModel()
        {
            comboBoxMethods = new List<ComboBoxMethod>()
            {
                new ComboBoxMethod {SearchMethod = EasyRegex.FindCreditCardNumbers, SearchMethodNameText = "Find Credit Card Numbers"},
                new ComboBoxMethod {SearchMethod = EasyRegex.FindDates, SearchMethodNameText = "Find Dates"},
                new ComboBoxMethod {SearchMethod = EasyRegex.FindEmailAddresses, SearchMethodNameText = "Find Email Adresses"},
                new ComboBoxMethod {SearchMethod = EasyRegex.FindIPAddresses, SearchMethodNameText = "Find IP Adresses"},
                new ComboBoxMethod {SearchMethod = EasyRegex.FindUSCurrency, SearchMethodNameText = "Find US Curreny"},
                new ComboBoxMethod {SearchMethod = EasyRegex.FindPhoneNumbers, SearchMethodNameText = "Find Phone Numbers"},
                new ComboBoxMethod {SearchMethod = EasyRegex.FindStreetNames, SearchMethodNameText = "Find Street Names"},
                new ComboBoxMethod {SearchMethod = EasyRegex.FindTimes, SearchMethodNameText = "Find Times"},
                new ComboBoxMethod {SearchMethod = EasyRegex.FindURLs, SearchMethodNameText = "Find URLs"}

            };
        }


   }
}

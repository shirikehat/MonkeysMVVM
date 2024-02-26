using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MonkeysMVVM.Models;
using MonkeysMVVM.Services;

namespace MonkeysMVVM.ViewModels
{
    public class FindMonkeyByLocationPageViewModel : ViewModel
    {
        MonkeysService service;
        private string country;
        private int count;
        public string Country { get { return country; } set { country = value; OnPropertyChanged(); ((Command)SearchByCountryCommand).ChangeCanExecute(); } }
        public int Count { get { return count; } set { count = value; OnPropertyChanged(); } }
        public ICommand SearchByCountryCommand { get; set; }

        private Monkey monkey;
        public string Name { get { return monkey.Name; } }
        public string ImageUrl { get { return monkey.ImageUrl; } }

        public FindMonkeyByLocationPageViewModel(MonkeysService s)
        {
            this.service = s;
            monkey = new Monkey() { Name = "אין קופים כרגע" };
            SearchByCountryCommand = new Command(FindMonkeys, () => Country != null || !String.IsNullOrEmpty(Country));
        }

        private void FindMonkeys()
        {
             
            List<Monkey> lst = service.FindMonkeyByLocation(Country);
            if (lst.Count > 0)
                monkey = lst[0];
            else
                monkey = new Monkey() { Name = "אין קופים להצגה" };
            Count = lst.Count;
            Refreshdata();
            Country = null;
        }

        private void Refreshdata()
        {
            OnPropertyChanged(nameof(ImageUrl));
        }

    }
}

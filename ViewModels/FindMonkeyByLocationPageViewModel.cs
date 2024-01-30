﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MonkeysMVVM.Models;

namespace MonkeysMVVM.ViewModels
{
    public class FindMonkeyByLocationPageViewModel:ViewModel
    {
        private string country;
        private int count;
        public string Country {  get { return country; } set {  country = value; OnPropertyChanged(); } }
        public int Count { get { return count; } set { count = value; OnPropertyChanged(); } }
        public ICommand SearchByCountryCommand { get; set; }

        private Monkey monkey;
        public string Name { get {  return monkey.Name; } }
        public string ImageUrl { get { return monkey.ImageUrl; } }
    }
}

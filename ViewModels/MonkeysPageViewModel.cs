﻿using MonkeysMVVM.Models;
using MonkeysMVVM.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MonkeysMVVM.ViewModels
{
    public class MonkeysPageViewModel : ViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }

        public ICommand LoadMonkeysCommand { get; private set; }

        public MonkeysPageViewModel()
        {
            Monkeys= new ObservableCollection<Monkey>();

            LoadMonkeysCommand = new Command(async () => await LoadMonkeys());
        }

        private Task LoadMonkeys()
        {
            MonkeysService service= new MonkeysService();
            var List= service.GetMonkeys();
            for(int i = 0; i < List.Count; i++)
            {
                Monkeys.Add(List[i]);
            }
            return Task.FromResult(0);
        }
    }
}
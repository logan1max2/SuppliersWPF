﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SuppliersWPF.Models
{
    public class Product : INotifyPropertyChanged
    {
        public int id { get; set; }
        public int id_suppliers { get; set; }
        public double weight { get; set; }
        public double price { get; set; }
        public DateTime date_price { get; set; }
        public string name { get; set; }
        public string sup_name { get; set; }
        public string address { get; set; }
        public double phone { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

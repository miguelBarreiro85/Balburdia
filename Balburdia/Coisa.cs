using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balburdia
{
    internal class Coisa: INotifyPropertyChanged
    {
        string nome;
        List<int> valores;
        int totalValores;

        public event PropertyChangedEventHandler PropertyChanged;

        public int TotalValores
        {
            get { return totalValores; }
            set
            {
                totalValores = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValores"));
            }
        }

        public Coisa(string nome)
        {
            this.nome = nome;
            valores = new List<int>();
            totalValores = 0;
        }

        public void inventarValor() 
        {
            //add random int value to valores
            valores.Add(new Random().Next(100));
            //update totalValores
            TotalValores = valores.Sum();
        }

        public override string ToString()
        {
            return nome + " -> valores = " + TotalValores;
        }
    }
}

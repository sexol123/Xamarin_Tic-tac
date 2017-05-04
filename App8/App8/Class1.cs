using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App8.Annotations;

namespace App8
{
    
    class Class1:INotifyPropertyChanged
    {
        private string ddd;
        public event PropertyChangedEventHandler PropertyChanged;

        public string Ddd
        {
            get { return ddd; }
            set
            {
                ddd = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

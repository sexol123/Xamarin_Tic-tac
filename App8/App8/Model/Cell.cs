using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App8.Annotations;
using Xamarin.Forms;

namespace App8.Model
{
   public class Cell:INotifyPropertyChanged
    {
        private State _state;

        public enum State
        {
          Empty,
          X,
          O
        }

        private string ss;
        public State state
        {
            get { return _state; }
            set
            {
                if (_state == State.Empty)
                {
                    _state = value;
                    OnPropertyChanged(nameof(state));
                }
               
            }
        }

        public string Ss
        {
            get { return ss; }
            set
            {
                ss = value;
                OnPropertyChanged("Ss");
            }
        }

        public Cell(State state,string s)
        {
            this.state = state;
            this.Ss = s;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

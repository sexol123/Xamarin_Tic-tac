using System.ComponentModel;
using System.Runtime.CompilerServices;
using App8.Annotations;

namespace App8.M
{
   public class CEL:INotifyPropertyChanged
   {
       private string _state = "";
        //private string _state2;
        //private string _state3;
        //private string _state4;
        //private string _state5;
        //private string _state6;
        //private string _state7;
        //private string _state8;
        //private string _state9;

        public string state
        {
            get { return _state; }
            set
            {
                _state = value;
                OnPropertyChanged("state");
            }
        }
        //public string state2
        //{
        //    get { return _state2; }
        //    set
        //    {
        //        _state2 = value;
        //        OnPropertyChanged("state2");
        //    }
        //}
        //public string state3
        //{
        //    get { return _state3; }
        //    set
        //    {
        //        _state1 = value;
        //        OnPropertyChanged("state3");
        //    }
        //}
        //public string state4
        //{
        //    get { return _state4; }
        //    set
        //    {
        //        _state1 = value;
        //        OnPropertyChanged("state4");
        //    }
        //}

        //public string state5
        //{
        //    get { return _state5; }
        //    set
        //    {
        //        _state1 = value;
        //        OnPropertyChanged("state5");
        //    }
        //}
        //public string state6
        //{
        //    get { return _state6; }
        //    set
        //    {
        //        _state2 = value;
        //        OnPropertyChanged("state6");
        //    }
        //}
        //public string state7
        //{
        //    get { return _state7; }
        //    set
        //    {
        //        _state1 = value;
        //        OnPropertyChanged("state7");
        //    }
        //}
        //public string state8
        //{
        //    get { return _state8; }
        //    set
        //    {
        //        _state1 = value;
        //        OnPropertyChanged("state8");
        //    }
        //}
        //public string state9
        //{
        //    get { return _state9 }
        //    set
        //    {
        //        _state1 = value;
        //        OnPropertyChanged("state9");
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

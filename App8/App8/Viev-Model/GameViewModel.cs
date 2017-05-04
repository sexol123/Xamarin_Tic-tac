using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App8.Viev_Model
{
    class GameViewModel:INotifyPropertyChanged
    {
        private int c = 0;
        private List<string> cells; 

            public event PropertyChangedEventHandler PropertyChanged;

            public GameViewModel()
            {
                this.cells = new List<string>(10);
                for (int i = 0; i < 10; i++)
                {
                    cells.Add("");
                }
              
            }

        #region BadCodeProperty

         public string Cells1
            {

                set
                {
                    c = 0;
                if ( cells[c] =="")
                    {
                       cells[c] = value;

                        PropertyChanged?.Invoke(this,
                            new PropertyChangedEventArgs("Cells1"));
                    }
                }
                get
                {
                    c = 0;
                    if (cells[c] != null)
                    {
                        return cells[c];
                    }
                    return "";
                }
            }
             public string Cells2
        {
            
            set
            {
                c = 1;
                if (cells[c] == "")
                {
                    cells[c] = value;

                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("Cells2"));
                }
            }
            get
            {
                c = 1;
                if (cells[c] != null)
                {
                    return cells[c];
                }
                return "";
            }
        }
             public string Cells3
        {

            set
            {
                c = 2;
                if (cells[c] == "")
                {
                    cells[c] = value;

                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("Cells3"));
                }
            }
            get
            {
                c = 2;
                if (cells[c] != null)
                {
                    return cells[c];
                }
                return "";
            }
        }
             public string Cells4
        {

            set
            {
                c = 3;
                if (cells[c] == "")
                {
                    cells[c] = value;

                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("Cells4"));
                }
            }
            get
            {
                c = 3;
                if (cells[c] != null)
                {
                    return cells[c];
                }
                return "";
            }
        }
             public string Cells5
        {

            set
            {
                c = 4;
                if (cells[c] == "")
                {
                    cells[c] = value;

                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("Cells5"));
                }
            }
            get
            {
                c = 4;
                if (cells[c] != null)
                {
                    return cells[c];
                }
                return "";
            }
        }
             public string Cells6
        {

            set
            {
                c = 5;
                if (cells[c] == "")
                {
                    cells[c] = value;

                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("Cells6"));
                }
            }
            get
            {
                c = 5;
                if (cells[c] != null)
                {
                    return cells[c];
                }
                return "";
            }
        }
             public string Cells7
        {

            set
            {
                c = 6;
                if (cells[c] == "")
                {
                    cells[c] = value;

                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("Cells7"));
                }
            }
            get
            {
                c = 6;
                if (cells[c] != null)
                {
                    return cells[c];
                }
                return "";
            }
        }
             public string Cells8
        {

            set
            {
                c = 7;
                if (cells[c] == "")
                {
                    cells[c] = value;

                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("Cells8"));
                }
            }
            get
            {
                c = 7;
                if (cells[c] != null)
                {
                    return cells[c];
                }
                return "";
            }
        }
             public string Cells9
        {

            set
            {
                c = 8;
                if (cells[c] == "")
                {
                    cells[c] = value;

                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("Cells9"));
                }
            }
            get
            {
                c = 8;
                if (cells[c] != null)
                {
                    return cells[c];
                }
                return "";
            }
        }
             public string Cells10
        {

            set
            {
                c = 9;
                if (cells[c] == "")
                {
                    cells[c] = value;

                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs("Cells10"));
                }
            }
            get
            {
                c = 9;
                if (cells[c] != null)
                {
                    return cells[c];
                }
                return "";
            }
        }

        #endregion
       
    }
    }


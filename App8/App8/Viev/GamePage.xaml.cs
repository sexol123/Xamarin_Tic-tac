using System;
using System.ComponentModel;
using Windows.UI.Composition;
using Windows.UI.Popups;
using App8;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Windows.UI.Xaml;

namespace App8.Viev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        public byte step = 0;
       
       
        
        public GamePage()
        {
            InitializeComponent();
            NulableCell();
            Slider.Value = 100;

        }
        
        private void NulableCell()
        {
            cell1.Text = "";
            cell2.Text = "";
            cell3.Text = "";
            cell4.Text = "";
            cell5.Text = "";
            cell6.Text = "";
            cell7.Text = "";
            cell8.Text = "";
            cell9.Text = "";
            current_s.Text = "X";
            step = 0;
        }
        async void GameLogic()
        {
            if (cell1.Text == cell2.Text && cell2.Text == cell3.Text && cell3.Text != "" ||
                cell4.Text == cell5.Text && cell5.Text == cell6.Text && cell6.Text != "" ||
                cell7.Text == cell8.Text && cell8.Text == cell9.Text && cell9.Text != "" ||                      
                cell1.Text == cell5.Text && cell5.Text == cell9.Text && cell9.Text != "" ||
                cell7.Text == cell5.Text && cell5.Text == cell3.Text && cell3.Text != "" ||                      
                cell1.Text == cell4.Text && cell4.Text == cell7.Text && cell7.Text != "" ||
                cell2.Text == cell5.Text && cell5.Text == cell8.Text && cell8.Text != "" ||
                cell3.Text == cell6.Text && cell6.Text == cell9.Text && cell9.Text != ""
            )
            {
                string win = current_s.Text = current_s.Text == "O" ? "X" : "O";
                
               var a = await DisplayAlert($"Поздравляем, победа, продолжить?", $"Победитель: {win} по-новой?","Ок","Нет");

                if (a)
                {
                    NulableCell();
                }
                else
                {
                    //await DisplayAlert("Пипец", "Ты пипец", "Я знаю");
                  await Navigation.PopAsync(true);
                }
            }
            else if (step >= 9)
            {
              var a =  await DisplayAlert($"Ничья, продолжить?", "Ничья", "Заново","В меню");
                if (a)
                {
                    NulableCell();
                }
                else
                {
                    await Navigation.PopAsync(true);
                    //await DisplayAlert("Пипец", "Ты пипец", "Я знаю");
                }
            }


        }
        private void Cell1_OnClick(object sender, EventArgs eventArgs)
        {
            var s = sender as Button;

            if (s.Text == "")
            {
                if (current_s.Text == "O")
                {
                    s.Text = current_s.Text;
                   // s.Image = zeroimg;
                    current_s.Text = "X";
                }
                else
                {
                    s.Text = current_s.Text;
                   // s.Image = crosimg;
                    current_s.Text = "O";
                }
                step++;
                
            }
            
            GameLogic();

        }

        private void Current_s_OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var a = sender as Button;
            a.BorderColor = Color.White;

        }

       
    }
}

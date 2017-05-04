using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Graphics.Display;
using App8.Data;
using Xamarin.Forms;

//using Grid = Windows.UI.Xaml.Controls.Grid;


//using Xamarin.Forms;

namespace App8
{

    public class Game100:ContentPage
    {
        public byte step = 0;
        private Grid Field { get; set; }
        private ClickedImage current_s { get; set; }
        private ClickedImage[,] ImcelList { get; set; }
        private string crosimg, zeroimg;
        private ClickedImage cross, zero;
        private byte size = 10;
       
        public Game100(byte ssize = 5)
        {
            this.size = ssize;
            //crosimg = Device.OnPlatform<string>(null, "@drawable/cross.jpg", "Assets/cross.jpg");
            //zeroimg = Device.OnPlatform<string>(null, "@drawable/zero.jpg", "Assets/zero.jpg");
            cross = new ClickedImage {image = new Image {Source = "cross.png"}};
            zero = new ClickedImage {image = new Image {Source = "zero.png" } };
            Content = CreateField();
        }

       
      public  Grid  CreateField()
        {
            //add field
            Field = new Grid
            {
                ColumnSpacing = 2,
                RowSpacing = 2,
                BackgroundColor = Color.Transparent,
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,
                
            };
            for (byte i = 0; i < size; i++)
            {
                Field.RowDefinitions.Add(new RowDefinition{Height = new GridLength(2,GridUnitType.Star)});
                Field.ColumnDefinitions.Add(new ColumnDefinition{Width = new GridLength(2,GridUnitType.Star)});
               
            }
            
           
            //create cells
            ImcelList = new ClickedImage[size+3,size+3];
            for (int i = 0; i < size+3; i++)//fix exception
            {
                for (int j = 0; j < size+3; j++)//fix exception
                {
                    ImcelList[i, j] = new ClickedImage();
                    ImcelList[i, j].TtapGesture.Tapped += StepOnClick;
                }
            }
            //add cells to field
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Field.Children.Add(ImcelList[i,j].image,i,j);
                    
                }
            }

            ////create state info
            ////add state row
            Field.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            current_s = new ClickedImage
            {
                image = new Image
                {
                    Source = cross.image.Source,
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                },
                TtapGesture = new TapGestureRecognizer()
            }; //curent player
            current_s.TtapGesture.Tapped += (sender, args) =>
            {
                if (step != 0) return;
                current_s.image.Source = current_s.image.Source == zero.image.Source ? cross.image.Source : zero.image.Source;
            };
            current_s.image.GestureRecognizers.Add(current_s.TtapGesture);
            Field.Children.Add(current_s.image, 1, size);//add current player image to row inf

            //var btnRestart = new Button
            //{
            //    Text = "Restart",
            //};

            //Field.Children.Add(btnRestart,2,size);
          
            //Grid.SetColumnSpan(btnRestart,2);

            return Field;

        }

        void StepOnClick(object sender, EventArgs eventArgs)
        {
            var s = (Image)sender;

            if (s.Source == null || s.Source != cross.image.Source || s.Source != zero.image.Source)
            {
                if (current_s.image.Source == zero.image.Source )
            {
                    s.Source = current_s.image.Source;
                    s.BackgroundColor = Color.White;
                    current_s.image.Source = cross.image.Source;
                }
                else
                {
                    s.Source = current_s.image.Source;
                    // s.Image = crosimg;
                    s.BackgroundColor = Color.White;
                    current_s.image.Source = zero.image.Source;
                }
                step++;
               

            }
            GameLogic();



        }

        private async void GameLogic()
        {

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    if (ImcelList[0 + i, j + 0].image.Source == ImcelList[0 + i, j + 1].image.Source &&
                        ImcelList[0 + i, j + 1].image.Source == ImcelList[0 + i, j + 2].image.Source &&
                        ImcelList[0 + i, j + 2].image.Source == ImcelList[0 + i, j + 3].image.Source &&
                        ImcelList[0 + i, j + 3].image.Source != null ||//horizontal axis
                        ImcelList[0 + i, j + 0].image.Source == ImcelList[i + 1, j + 0].image.Source &&
                        ImcelList[i + 1, j + 0].image.Source == ImcelList[2 + i, j + 0].image.Source &&
                        ImcelList[i + 2, j + 0].image.Source == ImcelList[i + 3, j + 0].image.Source &&
                        ImcelList[i + 3, j + 0].image.Source != null ||//vertical axis
                        ImcelList[0 + i, j + 0].image.Source == ImcelList[i + 1, j + 1].image.Source &&
                        ImcelList[i + 1, j + 1].image.Source == ImcelList[i + 2, j + 2].image.Source &&
                        ImcelList[i + 2, j + 2].image.Source == ImcelList[i + 3, j + 3].image.Source &&
                        ImcelList[i + 3, j + 3].image.Source != null ||//diagonal
                        ImcelList[0 + i, j + 2].image.Source == ImcelList[1 + i, j + 1].image.Source &&
                        ImcelList[1 + i, j + 1].image.Source == ImcelList[2 + i, j + 0].image.Source &&
                        ImcelList[i + 2, j + 0].image.Source == ImcelList[i + 3, j + 0].image.Source &&
                        ImcelList[i + 3, j + 0].image.Source != null)//diagonal

                    {
                        
                        var a = current_s.image.Source == cross.image.Source ? "O" : "X";
                        // var a = current_s.image.Source == cross.image.Source ? "X" : "O";
                       var end = await DisplayAlert("Winner", $"Winner{a}", "ok", "again");
                        if (end)
                        {
                           await Navigation.PopModalAsync(true);
                            return;
                        }
                        else
                        {
                            await Navigation.PopModalAsync(true);

                            await Navigation.PushModalAsync(new Game100(size), true);
                            
                            return;
                        }


                    }
                    else if (step >= size*size)
                    {
                       var end = await DisplayAlert("No winner", "ok", "ok","again");
                        if (end)
                        {
                           await Navigation.PopModalAsync(true);
                            return;
                        }
                        else
                        {
                            await Navigation.PopModalAsync(true);
                            await Navigation.PushModalAsync(new Game100(), true);
                            return;
                        }


                    }


                }
            }
        }
    }
}


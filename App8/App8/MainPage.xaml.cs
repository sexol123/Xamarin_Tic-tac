using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App8.Viev;
using Xamarin.Forms;

namespace App8
{
    public partial class MainPage : ContentPage
    {
       //private Picker sizepPicker;
        private byte sizeforgame100 = 4;
        public MainPage()
        {
            //siPicker = InitPicker();
            InitializeComponent();
           
           StackLayoutM.Children.Add(InitPicker());
        }

        private async void ButtonStart_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage(),true);
        }

        private async void ButtonResume_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Game100(sizeforgame100), true);
        }

        Picker InitPicker()
        {
            Picker picker = new Picker();
            picker.Title = "Size tic-tac";
            for (int i = 4; i < 10; i++)
            {
                 picker.Items.Add(i.ToString());
            }
            picker.SelectedIndexChanged += (sender, args) =>
            {
                sizeforgame100 = Convert.ToByte(picker.Items[picker.SelectedIndex]);
            };
            return picker;
        }

        
    }
}

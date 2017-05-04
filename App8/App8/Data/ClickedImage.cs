using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App8.Data;

namespace App8.Data
{
  public  class ClickedImage
    {
        private Image _image;
        public int I { get; set; }
        public int J { get; set; }
        public string ss;
        public Image image
        {
            get { return _image; }
            set { _image = value; }
        }

        public TapGestureRecognizer TtapGesture { get; set; }

        //public ClickedImage(int I,int J)
        //{
        //    this.I = I;
        //    this.J = J;
        //}
        public ClickedImage()
        {
            _image = new Image
            {
                Source = null,
                BackgroundColor = Color.Teal,
                Aspect = Aspect.Fill
            };

            TtapGesture = new TapGestureRecognizer();
            

            image.GestureRecognizers.Add(TtapGesture);
        }

        
    }
}

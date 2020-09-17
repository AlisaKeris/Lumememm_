using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lumememm_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            f1.Opacity = 0;
            f2.Opacity = 0;
            f3.Opacity = 0;
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            f1.Opacity = 1;
            f2.Opacity = 1;
            f3.Opacity = 1;
        }

        private void btnrnd_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);
            
            Color randomColor = Color.FromRgb(r, g, b);
            f1.BackgroundColor = randomColor;
        }

        private async void btn3_Clicked(object sender, EventArgs e)
        {
            f1.Opacity = 0.75;
            f2.Opacity = 0.75;
            f3.Opacity = 0.75;
            await Task.Run(() => Thread.Sleep(100));
            f1.Opacity = 0.50;
            f2.Opacity = 0.50;
            f3.Opacity = 0.50;
            await Task.Run(() => Thread.Sleep(100));
            f1.Opacity = 0.25;
            f2.Opacity = 0.25;
            f3.Opacity = 0.25;
            await Task.Run(() => Thread.Sleep(100));
            f1.Opacity = 0;
            f2.Opacity = 0;
            f3.Opacity = 0;
            await Task.Run(() => Thread.Sleep(100));
        }
    }
}

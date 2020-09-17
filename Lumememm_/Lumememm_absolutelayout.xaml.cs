using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;
using Xamarin.Forms.Xaml;

namespace Lumememm_
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lumememm_absolutelayout : ContentPage
    {
        Frame f1, f2, f3;
        Button btn1, btn2, btnrgb, btn3;
        public Lumememm_absolutelayout()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            f1 = new Frame () { Opacity = 1, BackgroundColor = Color.Black };
            AbsoluteLayout.SetLayoutBounds(f1, new Rectangle(150, 40, 70, 50));
            f2 = new Frame (){ Opacity = 1, BorderColor = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(f2, new Rectangle(110, 90, 150, 120));
            f3 = new Frame (){ Opacity = 1, BorderColor = Color.Black, CornerRadius = 90 };
            AbsoluteLayout.SetLayoutBounds(f3, new Rectangle(110, 210, 150, 120));
            btn1 = new Button (){ BackgroundColor = Color.Black , TextColor = Color.White, Text = "Спрятать снеговика" };
            AbsoluteLayout.SetLayoutBounds(btn1, new Rectangle(20, 350, 120, 70));
            btn2 = new Button () { BackgroundColor = Color.Black, TextColor = Color.White, Text = "Отобразить снеговика" };
            AbsoluteLayout.SetLayoutBounds(btn2, new Rectangle(150, 350, 120, 70));
            btnrgb = new Button (){ BackgroundColor = Color.Black, TextColor = Color.White, Text = "Random color" };
            AbsoluteLayout.SetLayoutBounds(btnrgb, new Rectangle(20, 450, 120, 70));
            btn3 = new Button (){ BackgroundColor = Color.Black, TextColor = Color.White, Text = "Растопить снеговика" };
            AbsoluteLayout.SetLayoutBounds(btn3, new Rectangle(150, 450, 120, 70));
            absoluteLayout.Children.Add(f1);
            absoluteLayout.Children.Add(f2);
            absoluteLayout.Children.Add(f3);
            absoluteLayout.Children.Add(btn1);
            absoluteLayout.Children.Add(btn2);
            absoluteLayout.Children.Add(btnrgb);
            absoluteLayout.Children.Add(btn3);
            Content = absoluteLayout;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btnrgb.Clicked += Btnrgb_Clicked;

        }

        private void Btnrgb_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int r = rnd.Next(256);
            int g = rnd.Next(256);
            int b = rnd.Next(256);

            Color randomColor = Color.FromRgb(r, g, b);
            f1.BackgroundColor = randomColor;
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
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

        private void Btn2_Clicked(object sender, EventArgs e)
        {
            f1.Opacity = 1;
            f2.Opacity = 1;
            f3.Opacity = 1;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            f1.Opacity = 0;
            f2.Opacity = 0;
            f3.Opacity = 0;
        }
    }
}
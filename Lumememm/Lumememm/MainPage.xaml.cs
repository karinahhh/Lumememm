using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lumememm
{
    public partial class MainPage : ContentPage
    {
        Frame f1, f2, f3;
        Button btn1, btn2, btn3, btnrnd;
        public MainPage()
        {
            f1 = new Frame();
            {
                BackgroundColor = Color.Red;
                HeightRequest = 100;
                Opacity = 1;
                Padding = 30;
            };


            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btnrnd.Clicked += Btnrnd_Clicked;
        }

        private void Btnrnd_Clicked(object sender, EventArgs e)
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
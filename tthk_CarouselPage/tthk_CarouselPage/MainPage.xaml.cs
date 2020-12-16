using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace tthk_CarouselPage
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            Button btn = new Button
            {
                Text = "Корпуса"
            };
            Button btn1 = new Button
            {
                Text = "Материнские Платы"
            };
            Button btn2 = new Button
            {
                Text = "Видеокарты"
            };
            Button btn3 = new Button
            {
                Text = "Процессоры"
            };
            Button btn4 = new Button
            {
                Text = "ОЗУ"
            };
            Button btn5 = new Button
            {
                Text = "HDD"
            };

            btn.Clicked += Btn_Clicked;
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            btn3.Clicked += Btn3_Clicked;
            btn4.Clicked += Btn4_Clicked;
            btn5.Clicked += Btn5_Clicked;

            var Case = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="Корпуса",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="pccase.jpg",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand
                    },
                    btn }

                }
            };
            var mobo = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="Материнские Платы",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="mobo.png",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand
                    },

                    btn1 }

                }
            };
            var gpu = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="Видеокарта",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="gpu.jpg",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand },
                   btn2 }

                }
            };
            var cpu = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="Процессоры",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="cpu.jpg",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand },
                    btn3}

                }
            };
            var ram = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="ОЗУ",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="ram.jpg",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand },
                    btn4}

                }
            };
            var HDD = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text="HDD",
                        FontSize = Device.GetNamedSize(NamedSize.Medium,typeof(Label)),
                        HorizontalOptions=LayoutOptions.Center },
                    new Image
                    {
                        Source="hdd.jpg",
                        WidthRequest=200,
                        HeightRequest=200,
                        HorizontalOptions=LayoutOptions.Center,
                        VerticalOptions=LayoutOptions.CenterAndExpand },
                    btn5}

                }
            };
            Children.Add(Case);
            Children.Add(mobo);
            Children.Add(gpu);
            Children.Add(cpu);
            Children.Add(ram);
            Children.Add(HDD);
        }

        private async void Btn5_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=hdd");
            await Browser.OpenAsync(uri);
        }

        private async void Btn4_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=%D0%BE%D0%BF%D0%B5%D1%80%D0%B0%D1%82%D0%B8%D0%B2%D0%BD%D0%B0%D1%8F+%D0%BF%D0%B0%D0%BC%D1%8F%D1%82%D1%8C");
            await Browser.OpenAsync(uri);
        }

        private async void Btn3_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=%D0%BF%D1%80%D0%BE%D1%86%D0%B5%D1%81%D1%81%D0%BE%D1%80%D1%8B");
            await Browser.OpenAsync(uri);
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=%D0%B2%D0%B8%D0%B4%D0%B5%D0%BE%D0%BA%D0%B0%D1%80%D1%82%D1%8B");
            await Browser.OpenAsync(uri);
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=%D0%BC%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%BD%D1%81%D0%BA%D0%B8%D0%B5+%D0%BF%D0%BB%D0%B0%D1%82%D1%8B");
            await Browser.OpenAsync(uri);
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://www.1a.ee/ru/otsing/?q=korpused");
            await Browser.OpenAsync(uri);
        }
    }
};
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App01_LayoutXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Stack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }

        private void Grid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }

        private void Absolute_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }

        private void Relative_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }

        private void Scroll_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }
    }
}

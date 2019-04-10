using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchBarPage : ContentPage
	{
        private List<string> empresaTi;
		public SearchBarPage ()
		{
			InitializeComponent ();

            empresaTi = new List<string>();
            empresaTi.Add("Microsoft");
            empresaTi.Add("Apple");
            empresaTi.Add("Oracle");
            empresaTi.Add("IBM");
            empresaTi.Add("SAP");
            empresaTi.Add("Uber");
            empresaTi.Add("99Taxi");

            PreencherLista(empresaTi);
		}

        //private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var resultado = empresaTi.Where(a => a.Contains(e.NewTextValue)).ToList<string>();
        //    PreencherLista(resultado);
        //}

        private void PreencherLista(List<string> empresaTi)
        {
            ListResult.Children.Clear();

            foreach (var item in empresaTi)
            {
                ListResult.Children.Add(new Label { Text = item });
            }
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var resultado = empresaTi.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<string>();
            PreencherLista(resultado);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
    {
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoActivityIndicatorPage(object sender, EventArgs e)
        {
            Detail = new Controles.ActivityIndicatorPage();
        }

        private void GoProgressBarPage(object sender, EventArgs e)
        {
            Detail = new Controles.ProgressBarPage();
        }

        private void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new Controles.BoxViewPage();
        }

        private void GoLabelPage(object sender, EventArgs e)
        {
            Detail = new Controles.LabelPage();
            IsPresented = false;
        }

        private void GoButtonPage(object sender, EventArgs e)
        {
            Detail = new Controles.ButtonPage();
            IsPresented = false;
        }

        private void GoEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new Controles.EntryEditorPage();
            IsPresented = false;
        }

        private void GoDatePickerPage(object sender, EventArgs e)
        {
            Detail = new Controles.DatePickerPage();
            IsPresented = false;
        }

        private void GoTimerPickerPage(object sender, EventArgs e)
        {
            Detail = new Controles.TimerPickerPage();
            IsPresented = false;
        }
        private void GoPickerPage(object sender, EventArgs e)
        {
            Detail = new Controles.PickerPage();
            IsPresented = false;
        }

        private void GoSearchPage(object sender, EventArgs e)
        {
            Detail = new Controles.SearchBarPage();
            IsPresented = false;
        }

        private void GoSliderStepperPage(object sender, EventArgs e)
        {
            Detail = new Controles.SliderStepperPage();
            IsPresented = false;
        }

        private void GoSwitchPage(object sender, EventArgs e)
        {
            Detail = new Controles.SwitchPage();
            IsPresented = false;
        }

        private void GoImagePage(object sender, EventArgs e)
        {
            Detail = new Controles.ImagePage();
            IsPresented = false;
        }

        private void GoListViewPage(object sender, EventArgs e)
        {
            Detail = new Controles.ListViewPage();
            IsPresented = false;
        }
    }
}
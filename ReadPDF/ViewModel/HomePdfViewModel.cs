using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Plugin.PdfRasterizer;
using ReadPDF.View;
using Xamarin.Forms;

namespace ReadPDF.ViewModel
{
    public class HomePdfViewModel : ViewModelBase
    {
        public HomePdfViewModel()
        {
            this.OpenPdfFileExternalCommand = new Command(this.OpenPdfFileExternal);
            this.OpenPdfFileWebViewCommand = new Command(this.OpenPdfFileWebView);
        }


        public ICommand OpenPdfFileExternalCommand
        {
            get;
            set;
        }

        private async void OpenPdfFileExternal()
        {
            
            Device.OpenUri(new Uri("http://www.johnsarmygym.com.br/xamarin.pdf"));

        }

        public ICommand OpenPdfFileWebViewCommand
        {
            get;
            set;
        }

        private async void OpenPdfFileWebView()
        {

            await Application.Current.MainPage.Navigation.PushAsync(new OpenPdfWebView());
        }

    }
}

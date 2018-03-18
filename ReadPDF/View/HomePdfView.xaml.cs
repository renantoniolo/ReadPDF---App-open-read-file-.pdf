using System;
using System.Collections.Generic;
using ReadPDF.ViewModel;
using Xamarin.Forms;

namespace ReadPDF.View
{
    public partial class HomePdfView : ContentPage
    {
        public HomePdfView()
        {
            InitializeComponent();

            this.BindingContext = new HomePdfViewModel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace InspectApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void inspectionNoBtn_Clicked(object sender,EventArgs e)
        {
            var scan = new ZXingScannerPage();
            await Navigation.PushAsync(scan);
            scan.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    inspectionNumber.Text = result.Text;
                });
            };
        }

        private async void productNoBtn_Clicked(object sender,EventArgs e)
        {
            var scan = new ZXingScannerPage();
            await Navigation.PushAsync(scan);
            scan.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    productNumber.Text = result.Text;
                });
            };
        }

        private void SaveBtn_Clicked(object sender,EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            
        }

       

    }
}

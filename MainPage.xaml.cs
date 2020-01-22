using CatApp.DataProvider;
using CatApp.Processor;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CatApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ApiHelper.InitializeClient();

        }

        private async void ButtonGetCatfact_Click(object sender, RoutedEventArgs e)
        {
            var result = await CatProcessor.LoadFact();
            Result.Text = result.Text;
            // Result and Text needs to refer to names in the xaml
        }

        private async void ButtonGetCatImg_Click(object sender, RoutedEventArgs e)
        {
            var result = await ImgProcessor.LoadImg();
            GetImage.Source = new BitmapImage(new Uri(result.file.ToString(), UriKind.Absolute));
        }
    }
}

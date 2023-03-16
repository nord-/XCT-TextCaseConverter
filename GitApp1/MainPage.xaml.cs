using Xamarin.Forms;

namespace GitApp1
{
	public partial class MainPage : ContentPage
	{
		public MainPageViewModel ViewModel { get; private set; }
		public MainPage()
		{
			InitializeComponent();

			BindingContext = ViewModel = new MainPageViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			ViewModel.LicensePlate = "ABC123";
		}
	}
}

using Xamarin.Forms;

namespace TesteAPP
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//MainPage = new TesteAPPPage();
			//MainPage = new About();
			//MainPage = new Order();
			//MainPage = new SignUp();
			MainPage = new NavigationPage(new HomeScreen());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

using System;

using Xamarin.Forms;

namespace TesteAPP
{
	public class HomeScreen : ContentPage
	{
		public HomeScreen()
		{
			BackgroundColor = Color.FromHex("#000000");


			//var backgroundImage = new Image()
			//{
			//	Source = ImageSource.FromFile("background.jpg")
			//};

			//this.BackgroundImage = backgroundImage;
			this.BackgroundImage = "images/background.jpg";
			//var relativeLayout = new RelativeLayout();

			//relativeLayout.Children.Add(backgroundImage,
			//	Constraint.Constant(0),
			//	Constraint.Constant(0),
			//	Constraint.RelativeToParent((parent) => { return parent.Width; }),
			//	Constraint.RelativeToParent((parent) => { return parent.Height; }));

			var bgImage = new Image { Aspect = Aspect.AspectFit };

			bgImage.Source = Device.OnPlatform(
				iOS: ImageSource.FromFile("/images/logoDeR.png"),
				Android: ImageSource.FromFile("logoDeR.png"),
				WinPhone: ImageSource.FromFile("images/logoDeR.png"));


			var title = new Label
			{
				Text = "Defesas e Recursos",
				TextColor = Color.FromHex("#FFD740"),
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			var aboutButton = new Button
			{
				
				Text = "Sobre"
					
			};

			var signupButton = new Button
			{
				Text = "Cadastrar"
			};


			var cadastroLabel = new Label
			{
				Text = "Ainda não se cadastrou? Cadastre-se",
				TextColor = Color.FromHex("#FFFFFF"),
				//FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

			var cadastroLabel_tap = new TapGestureRecognizer();
			cadastroLabel_tap.Tapped += (s, e) =>
			{
				Navigation.PushAsync(new SignUp());
			};
			cadastroLabel.GestureRecognizers.Add(cadastroLabel_tap);



			// Here we are implementing a click event using lambda expressions
			// when a user clicks the `aboutButton` they will navigate to the
			// About Us page.
			aboutButton.Clicked += (object sender, EventArgs e) =>
			{
				Navigation.PushAsync(new About());
			};

			// Navigation to the Signup Page (Note: We haven't created this page yet)
			signupButton.Clicked += (object sender, EventArgs e) =>
			{
				Navigation.PushAsync(new SignUp());
			};

			var email = new Entry
			{
				Placeholder = "CPF",
				PlaceholderColor = Color.FromHex("#FFFFFF"),
				TextColor = Color.FromHex("#FFFFFF"),
			};

			var password = new Entry
			{
				Placeholder = "Senha",
				PlaceholderColor = Color.FromHex("#FFFFFF"),
				TextColor = Color.FromHex("#FFFFFF"),
				IsPassword = true
			};

			var login = new Button
			{
				BorderColor = Color.FromHex("#F2CC2B"),
				BackgroundColor = Color.FromHex("#F2CC2B"),
				Text = "Entrar"
			};

			// With the `PushModalAsync` method we navigate the user
			// the the orders page and do not give them an option to
			// navigate back to the Homepage by clicking the back button
			login.Clicked += (sender, e) =>
			{
				//Navigation.PushModalAsync(new Order());
				Navigation.PushAsync(new Order());
			};

			Content = new StackLayout
			{
				Padding = 50,
				Spacing = 10,
				Children = { bgImage, email, password, login, cadastroLabel}
			};
		}
	}
}


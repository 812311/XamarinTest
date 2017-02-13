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

			//var relativeLayout = new RelativeLayout();

			//relativeLayout.Children.Add(backgroundImage,
			//	Constraint.Constant(0),
			//	Constraint.Constant(0),
			//	Constraint.RelativeToParent((parent) => { return parent.Width; }),
			//	Constraint.RelativeToParent((parent) => { return parent.Height; }));

			var bgImage = new Image { Aspect = Aspect.AspectFit };
			bgImage.Source = ImageSource.FromFile("background.jpg");

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
				Text = "Cadastro"
			};

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
				Placeholder = "E-Mail",
			};

			var password = new Entry
			{
				Placeholder = "Password",
				IsPassword = true
			};

			var login = new Button
			{
				Text = "Login"
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
				Padding = 30,
				Spacing = 10,
				Children = { title, email, password, login, signupButton, aboutButton }
			};
		}
	}
}


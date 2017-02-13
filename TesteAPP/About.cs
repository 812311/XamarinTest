using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TesteAPP
{
	public class About : ContentPage
	{
		public About()
		{
			{
				var title = new Label
				{
					Text = "About Him",
					FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				};
				var description = new Label
				{
					Text = "Aqui vou contar sobre Ian"
				};

				var blogTitle = new Label
				{
					Text = "In The News",
					HorizontalOptions = LayoutOptions.CenterAndExpand
				};

				List<string> articles = new List<string> {
		"Ian é:",
		"Viado",
		"Da a bunda"
	  };

				ListView articlesView = new ListView
				{
					ItemsSource = articles
				};

				Content = new StackLayout
				{
					Padding = 30,
					Spacing = 10,
					Children = { title, description, blogTitle, articlesView }
				};
			}
			//Content = new StackLayout
			//{
			//	Children = {
			//		new Label { Text = "Hello ContentPage" }
			//	}
			//};
		}
	}
}


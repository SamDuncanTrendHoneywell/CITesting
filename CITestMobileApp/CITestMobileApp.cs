using System;

using Xamarin.Forms;

namespace CITestMobileApp
{
	public class App : Application
	{
		public App ()
		{
			Book book = new Book("a", "b");

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "IQVision CI Test Application [4]!"
						}
					}
				}
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
	public class Book
	{
		public string title;
		public string author;

		public Book(string _title, string _author)
		{
			title = _title;
			author = _author;
		}
		
	}
}


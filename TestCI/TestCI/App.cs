using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TestCI
{
	public class App : Application
	{
        private int count = 0;
        public App ()
		{

            Button countButton = new Button { Text = "0 clicks!", AutomationId="CountButton" };
            countButton.Clicked += CountButton_Clicked;

            // The root page of your application
            MainPage = new ContentPage {
                Content = new StackLayout {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms4!"
                        },
                        countButton
					}
				}
			};
        }

        private void CountButton_Clicked(object sender, EventArgs e)
        {
            ((sender) as Button).Text = string.Format("{0} clicks!", count++);
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
}

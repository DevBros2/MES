using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;

namespace MES
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
            
            // Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_main);

            var bottomNavigation = FindViewById<BottomNavigationView>(Resource.Id.bottom_navigation);
            bottomNavigation.NavigationItemSelected += (s, e) =>
            {
                switch (e.Item.ItemId)
                {
                    case Resource.Id.action_add:
                        Toast.MakeText(this, "Action add Clicked", ToastLength.Short).Show();
                        break;

                    case Resource.Id.action_edit:
                        Toast.MakeText(this, "Action edit Clicked", ToastLength.Short).Show();
                        break;

                    case Resource.Id.action_remove:
                        Toast.MakeText(this, "Action remove Clicked", ToastLength.Short).Show();
                        break;

                }
            };

			
		}

	}
}


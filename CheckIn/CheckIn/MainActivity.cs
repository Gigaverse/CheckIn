﻿using System;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CheckIn
{
	[Activity (Label = "CheckIn", MainLauncher = true, Icon = "@drawable/checkIn_small")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			ImageView splash = FindViewById<ImageView> (Resource.Id.imageView1);
			Thread.Sleep (2000);
			var login = new Intent(this, typeof(SignIn));
			StartActivity(login);
		}
	}
}



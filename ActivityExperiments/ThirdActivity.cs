using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace ActivityExperiments
{
	[Activity (Label = "ThirdActivity")]			
	public class ThirdActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
		}

		protected override void OnResume()	
		{
			base.OnResume ();
			Log.Debug(GetType().FullName, "In OnResume");
		}

		protected override void OnRestart()	
		{
			base.OnRestart ();
			Log.Debug(GetType().FullName, "In OnRestart");
		}

		protected override void OnPause()
		{
			base.OnPause ();
			Log.Debug(GetType().FullName, "In OnPause");
		}

		protected override void OnStop()
		{
			base.OnStop ();
			Log.Debug(GetType().FullName, "In OnStop");
		}

		protected override void OnDestroy()
		{
			base.OnDestroy ();
			Log.Debug(GetType().FullName, "In OnDestroy");
		}
	}
}


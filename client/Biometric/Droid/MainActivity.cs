using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Hardware;
using Biometric.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(MainActivity))]
namespace Biometric.Droid
{
	[Activity (Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity, MySensors
    {
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}

        public string GetToast()
        {
            //SensorManager _sensorManager;
            //_sensorManager = (SensorManager)GetSystemService(Context.SensorService);
            return "Hello from MainActivity";
        }

        public string GetSensorsList()
        {
            SensorManager _sensorManager;
            _sensorManager = (SensorManager)GetSystemService(Context.SensorService);
            return _sensorManager.ToString();
        }
    }
}


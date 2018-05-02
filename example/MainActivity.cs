using Android.App;
using Android.OS;

namespace UCEHandlerApp
{
    [Activity(Label = "UCEHandlerApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

           
            throw new Java.Lang.RuntimeException("XXXXXXX!!!");
        }
    }
}


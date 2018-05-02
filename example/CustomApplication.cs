using System;
using Android.App;
using Android.Runtime;

using Com.Rohitss.Uceh;

namespace UCEHandlerApp
{
    [Application]
    public class CustomApplication : Application
    {
        public CustomApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            new UCEHandler.Builder(this)
                .SetUCEHEnabled(true)
                .SetTrackActivitiesEnabled(true)
                .SetBackgroundModeEnabled(true)
                .AddCommaSeparatedEmailAddresses("test@gmail.com")
                .Build();
        }
    }
}
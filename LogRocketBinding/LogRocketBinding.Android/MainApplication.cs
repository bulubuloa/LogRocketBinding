using System;
using System.Collections.Generic;
using Android.App;
using Android.Runtime;
using Com.Logrocket.Core;

namespace LogRocketBinding.Droid
{
    
    [Application(LargeHeap = true)]
    public class MainApplication : Application
    {
        class CustomConfig : Java.Lang.Object, SDK.IOptionsConfiguration
        {
            public void Configure(Configuration configuration)
            {
                configuration.AppID = "koh7g6/ewn-mobile-dev";
            }
        }

        static MainApplication()
		{
		}

        public MainApplication(IntPtr handle, JniHandleOwnership transer)
          : base(handle, transer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            SDK.Init(this, ApplicationContext, new CustomConfig());

            var userIdentity = new Dictionary<string, string>();
            userIdentity.Add($"name", $"Quach Hoang");
            userIdentity.Add($"email",  $"hoangquach@kms-technology.com");
            SDK.Identify("HoangQuach-KMS", userIdentity);
        }
    }
}

 
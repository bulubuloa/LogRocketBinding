using ARKit;
using Foundation;
using UIKit;
using NativeLibrary;
using Xamarin.Forms;

namespace LogRocketBinding.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            Xamarin.Forms.Internals.Registrar.Registered.Register(typeof(ContentPage), typeof(ContentPageRenderer));

            LoadApplication(new App());
            LROSDK.InitializeWithConfiguration(new LROConfiguration(new NSString("koh7g6/ewn-mobile-dev")));
            var userIdentity = new NSMutableDictionary<NSString, NSObject>();
            userIdentity.Add(new NSString($"name"), new NSString($"Quach Hoang"));
            userIdentity.Add(new NSString($"email"), new NSString($"hoangquach@kms-technology.com"));
            LROSDK.IdentifyWithUserID("HoangQuach-KMS", userIdentity);

            // LROSDK.TagPage("FirstPage");

            LROLogger.DebugWithMessage("Finished FinishedLaunching");

            


            return base.FinishedLaunching(app, options);
        }
    }
}

    
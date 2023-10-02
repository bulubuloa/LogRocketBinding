using System;
using System.Diagnostics;
using Foundation;
using NativeLibrary;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace LogRocketBinding.iOS
{
	public class ContentPageRenderer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            try
            {
                base.ViewWillAppear(animated);
                if (Element is Page page)
                {
                    LROSDK.TagPage(page.GetType().Name);
                    var eventF = new LROCustomEventBuilder(new NSString("ViewWillAppear"));
                    eventF.PutString("PageName", page.GetType().Name);
                    LROSDK.Track(eventF);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            try
            {
                if (Element is Page page)
                {
                    var eventF = new LROCustomEventBuilder(new NSString("ViewDidDisappear"));
                    eventF.PutString("PageName", page.GetType().Name);
                    LROSDK.Track(eventF);
                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}


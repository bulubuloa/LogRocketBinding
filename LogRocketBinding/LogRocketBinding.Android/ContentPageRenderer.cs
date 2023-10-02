using System;
using Android.Content;
using Com.Logrocket.Core;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace LogRocketBinding.Droid
{
	public class ContentPageRenderer : PageRenderer
    {
        public ContentPageRenderer(Context context)
           : base(context)
        {
        }

        protected override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            if (Element is Page page)
            {
                SDK.TagPage(page.GetType().Name);
                var eventF = new CustomEventBuilder("OnAttachedToWindow");
                eventF.Put("PageName", page.GetType().Name);
                SDK.Track(eventF);
            }
        }

        protected override void OnDetachedFromWindow()
        {
            base.OnDetachedFromWindow();
            if (Element is Page page)
            {
                var eventF = new CustomEventBuilder("OnDetachedFromWindow");
                eventF.Put("PageName", page.GetType().Name);
                SDK.Track(eventF);
            }
        }
    }
}


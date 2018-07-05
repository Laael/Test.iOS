using System;
using Foundation;
using UIKit;

namespace ViatorisTestTask.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            UIWebView webView = new UIWebView(View.Bounds);
            View.AddSubview(webView);
            string url = "https://tero.fund";
            webView.LoadRequest(new NSUrlRequest(new NSUrl(url)));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

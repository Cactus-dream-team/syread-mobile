using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace CACTUSHACKDREAMAPP
{
    [Activity(Label = "CACTUSHACKDREAMAPP", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private WebView web_view;
         
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
          
            web_view = FindViewById<WebView>(Resource.Id.bookWindow);
            web_view.Settings.JavaScriptEnabled = true;
            web_view.LoadUrl("http://www.google.com");
            web_view.SetWebViewClient(new HelloWebViewClient());
        }
    }
    public class HelloWebViewClient : WebViewClient
    {
        public override bool ShouldOverrideUrlLoading(WebView view, string url)
        {
            view.LoadUrl(url);
            return true;
        }
    }
}


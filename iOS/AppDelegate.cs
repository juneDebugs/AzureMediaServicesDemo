﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Plugin.MediaManager.Forms.iOS;
using UIKit;

namespace AzureMediaServicesDemo.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            VideoViewRenderer.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

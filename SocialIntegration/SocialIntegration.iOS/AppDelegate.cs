﻿using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SocialIntegration.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        UIWindow window;
        public static UIStoryboard Storyboard = UIStoryboard.FromName("Social", null);
        public static UIViewController initialViewController;

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            try
            {
                // create a new window instance based on the screen size
                window = new UIWindow(UIScreen.MainScreen.Bounds);

                // If you have defined a view, add it here:
                initialViewController = Storyboard.InstantiateInitialViewController() as UIViewController;

                window.RootViewController = initialViewController;

                // make the window visible
                window.MakeKeyAndVisible();

                return true;
            }
            catch (Exception ex)
            {
                var x = ex.StackTrace;
                int a = 1;
                a++;
            }
            return false;
        }
    }
}
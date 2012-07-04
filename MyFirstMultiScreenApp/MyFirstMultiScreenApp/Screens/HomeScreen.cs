
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MyFirstMultiScreenApp
{
	public partial class HomeScreen : UIViewController
	{
		HelloWorldScreen helloWorldScreen;
		HelloUniverseScreen helloUniverseScreen;

		public HomeScreen () : base ("HomeScreen", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			this.NavigationController.SetNavigationBarHidden(true, animated);
		}


		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.SetNavigationBarHidden(false, animated);
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			btnHelloWorld.TouchUpInside += (sender, e) => {
				if (this.helloWorldScreen == null)
					this.helloWorldScreen = new HelloWorldScreen ();
				this.NavigationController.PushViewController (this.helloWorldScreen, true);
			};

			btnHelloUniverse.TouchUpInside += (sender, e) => {
				if (this.helloUniverseScreen == null)
					this.helloUniverseScreen = new HelloUniverseScreen ();
				this.NavigationController.PushViewController (this.helloUniverseScreen, true);
			};
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}


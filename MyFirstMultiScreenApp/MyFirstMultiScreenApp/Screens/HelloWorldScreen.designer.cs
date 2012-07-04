// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MyFirstMultiScreenApp
{
	[Register ("HelloWorldScreen")]
	partial class HelloWorldScreen
	{
		[Outlet]
		MonoTouch.UIKit.UILabel lblHelloWorld { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblHelloWorld != null) {
				lblHelloWorld.Dispose ();
				lblHelloWorld = null;
			}
		}
	}
}

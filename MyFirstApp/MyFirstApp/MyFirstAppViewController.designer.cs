// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MyFirstApp
{
	[Register ("MyFirstAppViewController")]
	partial class MyFirstAppViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnAction { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblOutput { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnClickMe { get; set; }

		[Action ("btnAction_Click:")]
		partial void btnAction_Click (MonoTouch.Foundation.NSObject sender);

		partial void btnAction_Click (NSObject sender)
		{
			lblOutput.Text = "You Clicked the 'Action' Button!"; 
		}
		
		void ReleaseDesignerOutlets ()
		{
			if (btnAction != null) {
				btnAction.Dispose ();
				btnAction = null;
			}

			if (lblOutput != null) {
				lblOutput.Dispose ();
				lblOutput = null;
			}

			if (btnClickMe != null) {
				btnClickMe.Dispose ();
				btnClickMe = null;
			}
		}
	}
}

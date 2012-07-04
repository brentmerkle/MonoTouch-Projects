// WARNING
// This file has been generated automatically by MonoDevelop to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import "MyFirstiOSAppViewController.h"

@implementation MyFirstiOSAppViewController
@synthesize btnClickMe;
@synthesize btnAction1;
@synthesize btnAction2;
@synthesize lblOutput;
@synthesize btnAction1_Click;

@synthesize btnClickMe = _btnClickMe;
@synthesize lblOutput = _lblOutput;
@synthesize btnAction1 = _btnAction1;
@synthesize btnAction2 = _btnAction2;
@synthesize btnAction1_Outlet = _btnAction1_Outlet;
@synthesize btnAction2_Click = _btnAction2_Click;

- (IBAction)btnClick_Click:(id)sender {
}

- (IBAction)btnAction1_Click:(id)sender {
}

- (void)dealloc {
    [_btnAction1_Outlet release];
    [_btnAction1 release];
    [_btnAction2 release];
    [btnClickMe release];
    [btnAction1 release];
    [btnAction2 release];
    [lblOutput release];
    [btnAction1_Click release];
    [super dealloc];
}
- (void)viewDidUnload {
    [self setBtnAction1_Outlet:nil];
    [self setBtnAction1:nil];
    [self setBtnAction2:nil];
    [self setBtnClickMe:nil];
    [self setBtnAction1:nil];
    [self setBtnAction2:nil];
    [self setLblOutput:nil];
    [self setBtnAction1_Click:nil];
    [super viewDidUnload];
}
@end

using System;
using CoreGraphics;
using Cosmos;
using UIKit;

namespace Cosmos.Sample
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

			var frame = new CGRect(0, 100, 500, 100);
			var cosmos = new CosmosView(frame);
			CosmosSettingsObjCBridge.SetEmptyBorderColor(UIColor.Red, cosmos);
			CosmosSettingsObjCBridge.SetFilledColor(UIColor.Red, cosmos);
			CosmosSettingsObjCBridge.SetStarSize(50, cosmos);
			cosmos.DidFinishTouchingCosmos += (v) => { cosmos.Text = v.ToString(); };
			this.View.AddSubview(cosmos);
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

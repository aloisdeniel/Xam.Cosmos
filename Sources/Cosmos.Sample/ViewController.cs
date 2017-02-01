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

			// Initialization
			var cosmos = new CosmosView()
			{
				Frame = CGRect.Inflate(this.View.Frame, -10, -10),
				AutoresizingMask = UIViewAutoresizing.FlexibleDimensions,
				BackgroundColor = UIColor.LightGray,
			};

			// Settings
			cosmos.Settings().FillMode = FillMode.Precise;
			cosmos.Settings().UpdateOnTouch = true;
			cosmos.Settings().EmptyBorderColor = UIColor.DarkGray;
			cosmos.Settings().EmptyBorderWidth = 2;
			cosmos.Settings().FilledColor = UIColor.Purple;
			cosmos.Settings().FilledBorderColor = UIColor.Purple;
			cosmos.Settings().StarSize = 50;
			cosmos.Settings().StarMargin = 8;

			// Events
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

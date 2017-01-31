using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

// @interface CosmosView : UIView
[BaseType(typeof(UIView), Name = "_TtC6Cosmos10CosmosView")]
interface CosmosView 
{
	// @property (nonatomic) double rating;
	[Export("rating")]
	double Rating { get; set; }

	// @property (copy, nonatomic) NSString * _Nullable text;
	[NullAllowed, Export("text")]
	string Text { get; set; }

	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
	[Export("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor(CGRect frame);

	// @property (copy, nonatomic) void (^ _Nullable)(double) didTouchCosmos;
	[NullAllowed, Export("didTouchCosmos", ArgumentSemantic.Copy)]
	Action<double> DidTouchCosmos { get; set; }

	// @property (copy, nonatomic) void (^ _Nullable)(double) didFinishTouchingCosmos;
	[NullAllowed, Export("didFinishTouchingCosmos", ArgumentSemantic.Copy)]
	Action<double> DidFinishTouchingCosmos { get; set; }

}

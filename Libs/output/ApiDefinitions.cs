using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

// @interface CosmosView : UIView
[BaseType (typeof(UIView))]
interface CosmosView
{
	// @property (nonatomic) double rating;
	[Export ("rating")]
	double Rating { get; set; }

	// @property (copy, nonatomic) NSString * _Nullable text;
	[NullAllowed, Export ("text")]
	string Text { get; set; }

	// -(void)awakeFromNib __attribute__((objc_requires_super));
	[Export ("awakeFromNib")]
	[RequiresSuper]
	void AwakeFromNib ();

	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	IntPtr Constructor (CGRect frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)update;
	[Export ("update")]
	void Update ();

	// @property (readonly, nonatomic) CGSize intrinsicContentSize;
	[Export ("intrinsicContentSize")]
	CGSize IntrinsicContentSize { get; }

	// -(void)accessibilityIncrement;
	[Export ("accessibilityIncrement")]
	void AccessibilityIncrement ();

	// -(void)accessibilityDecrement;
	[Export ("accessibilityDecrement")]
	void AccessibilityDecrement ();

	// @property (copy, nonatomic) void (^ _Nullable)(double) didTouchCosmos;
	[NullAllowed, Export ("didTouchCosmos", ArgumentSemantic.Copy)]
	Action<double> DidTouchCosmos { get; set; }

	// @property (copy, nonatomic) void (^ _Nullable)(double) didFinishTouchingCosmos;
	[NullAllowed, Export ("didFinishTouchingCosmos", ArgumentSemantic.Copy)]
	Action<double> DidFinishTouchingCosmos { get; set; }

	// -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
	[Export ("touchesBegan:withEvent:")]
	void TouchesBegan (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

	// -(void)touchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
	[Export ("touchesMoved:withEvent:")]
	void TouchesMoved (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

	// -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
	[Export ("touchesEnded:withEvent:")]
	void TouchesEnded (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

	// -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event;
	[Export ("pointInside:withEvent:")]
	bool PointInside (CGPoint point, [NullAllowed] UIEvent @event);

	// -(void)prepareForInterfaceBuilder;
	[Export ("prepareForInterfaceBuilder")]
	void PrepareForInterfaceBuilder ();
}

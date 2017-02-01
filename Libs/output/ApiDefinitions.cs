using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

// @interface CosmosSettingsObjCBridge : NSObject
[BaseType (typeof(NSObject))]
interface CosmosSettingsObjCBridge
{
	// +(void)setFillMode:(NSInteger)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setFillMode:inCosmosView:")]
	void SetFillMode (nint value, CosmosView cosmosView);

	// +(NSInteger)getFillMode:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getFillMode:")]
	nint GetFillMode (CosmosView cosmosView);

	// +(void)setUpdateOnTouch:(BOOL)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setUpdateOnTouch:inCosmosView:")]
	void SetUpdateOnTouch (bool value, CosmosView cosmosView);

	// +(BOOL)getUpdateOnTouch:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getUpdateOnTouch:")]
	bool GetUpdateOnTouch (CosmosView cosmosView);

	// +(void)setStarSize:(double)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setStarSize:inCosmosView:")]
	void SetStarSize (double value, CosmosView cosmosView);

	// +(double)getStarSize:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getStarSize:")]
	double GetStarSize (CosmosView cosmosView);

	// +(void)setTotalStars:(NSInteger)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setTotalStars:inCosmosView:")]
	void SetTotalStars (nint value, CosmosView cosmosView);

	// +(NSInteger)getTotalStars:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getTotalStars:")]
	nint GetTotalStars (CosmosView cosmosView);

	// +(void)setStarMargin:(double)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setStarMargin:inCosmosView:")]
	void SetStarMargin (double value, CosmosView cosmosView);

	// +(double)getStarMargin:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getStarMargin:")]
	double GetStarMargin (CosmosView cosmosView);

	// +(void)setFilledColor:(UIColor * _Nonnull)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setFilledColor:inCosmosView:")]
	void SetFilledColor (UIColor value, CosmosView cosmosView);

	// +(UIColor * _Nonnull)getFilledColor:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getFilledColor:")]
	UIColor GetFilledColor (CosmosView cosmosView);

	// +(void)setEmptyColor:(UIColor * _Nonnull)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setEmptyColor:inCosmosView:")]
	void SetEmptyColor (UIColor value, CosmosView cosmosView);

	// +(UIColor * _Nonnull)getEmptyColor:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getEmptyColor:")]
	UIColor GetEmptyColor (CosmosView cosmosView);

	// +(void)setFilledBorderWidth:(double)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setFilledBorderWidth:inCosmosView:")]
	void SetFilledBorderWidth (double value, CosmosView cosmosView);

	// +(double)getFilledBorderWidth:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getFilledBorderWidth:")]
	double GetFilledBorderWidth (CosmosView cosmosView);

	// +(void)setFilledBorderColor:(UIColor * _Nonnull)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setFilledBorderColor:inCosmosView:")]
	void SetFilledBorderColor (UIColor value, CosmosView cosmosView);

	// +(UIColor * _Nonnull)getFilledBorderColor:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getFilledBorderColor:")]
	UIColor GetFilledBorderColor (CosmosView cosmosView);

	// +(void)setEmptyBorderWidth:(double)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setEmptyBorderWidth:inCosmosView:")]
	void SetEmptyBorderWidth (double value, CosmosView cosmosView);

	// +(double)getEmptyBorderWidth:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getEmptyBorderWidth:")]
	double GetEmptyBorderWidth (CosmosView cosmosView);

	// +(void)setEmptyBorderColor:(UIColor * _Nonnull)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setEmptyBorderColor:inCosmosView:")]
	void SetEmptyBorderColor (UIColor value, CosmosView cosmosView);

	// +(UIColor * _Nonnull)getEmptyBorderColor:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getEmptyBorderColor:")]
	UIColor GetEmptyBorderColor (CosmosView cosmosView);

	// +(void)setTextColor:(UIColor * _Nonnull)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setTextColor:inCosmosView:")]
	void SetTextColor (UIColor value, CosmosView cosmosView);

	// +(UIColor * _Nonnull)getTextColor:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getTextColor:")]
	UIColor GetTextColor (CosmosView cosmosView);

	// +(void)setTextFont:(UIFont * _Nonnull)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setTextFont:inCosmosView:")]
	void SetTextFont (UIFont value, CosmosView cosmosView);

	// +(UIFont * _Nonnull)getTextFont:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getTextFont:")]
	UIFont GetTextFont (CosmosView cosmosView);

	// +(void)setTextMargin:(double)value inCosmosView:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("setTextMargin:inCosmosView:")]
	void SetTextMargin (double value, CosmosView cosmosView);

	// +(double)getTextMargin:(CosmosView * _Nonnull)cosmosView;
	[Static]
	[Export ("getTextMargin:")]
	double GetTextMargin (CosmosView cosmosView);
}

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

# Cosmos

Xamarin.iOS bindings for [Cosmos swift library](https://github.com/marketplacer/Cosmos).

## Install

Available on NuGet

[![NuGet](https://img.shields.io/nuget/v/Xam.Cosmos.svg?label=NuGet)](https://www.nuget.org/packages/Xam.Cosmos/)

## Quickstart

```csharp
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
```

## Build

The bindings have been made thanks to [Lucas Teixeira](https://github.com/Flash3001) unofficial Swift3 bindings for Xamarion.iOS.

All the instruction are on [StackOverflow](http://stackoverflow.com/documentation/xamarin.ios/6091/binding-swift-libraries), but I created a `Libs/build.sh` script that takes care of all the main steps.

You only have to rebuild the modified `Libs\xcode\Cosmos` XCode project, for iPhone & Simulator (by running `Product > Build for Running`, and copy the two `Release-iphoneos` and `Release-iphonesimulator` into `Libs\input` prior to the build script.

The original project have been modified to add `CosmosSettingsObjCBridge.swift` file to build phase, to have access to customization settings.

Several extensions methods and classes were also added to have more similar api to the original swift one, so adaptations from generated api definition should be added.

## Packaging IPA & Troubleshooting

When creating the IPA for publish you might get the following error:

<i>"Invalid Swift Support - The SwiftSupport folder is missing. Rebuild your app using the current public (GM) version of Xcode and resubmit it."</i>

When using Xcode 7 you might need use this script: [https://github.com/jamesbar2/auto-ipa-packager](https://github.com/jamesbar2/auto-ipa-packager) or [https://github.com/bq/ipa-packager](https://github.com/bq/ipa-packager)

When using Xcode 8 (which updated Swift to 2.3 and 3.0) you should use this: [https://github.com/Flash3001/ipa-packager](https://github.com/Flash3001/ipa-packager)

## Contributions

Contributions are welcome! If you find a bug please report it and if you want a feature please report it.

If you want to contribute code please file an issue and create a branch off of the current dev branch and file a pull request.

## License

MIT © [Aloïs Deniel](http://aloisdeniel.github.io)
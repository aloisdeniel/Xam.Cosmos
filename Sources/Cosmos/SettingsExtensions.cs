namespace Cosmos
{
	using System;
	using UIKit;

	public enum FillMode
	{
		Full = 0,
		Half = 1,
		Precise = 2,
	}

	public class Settings
	{
		public Settings(CosmosView view)
		{
			this.cosmosView = view;
		}

		readonly CosmosView cosmosView;

		public FillMode FillMode
		{
			get { return (FillMode)(int)CosmosSettingsObjCBridge.GetFillMode(cosmosView); }
			set { CosmosSettingsObjCBridge.SetFillMode((int)value, cosmosView); }
		}

		public bool UpdateOnTouch
		{
			get { return CosmosSettingsObjCBridge.GetUpdateOnTouch(cosmosView); }
			set { CosmosSettingsObjCBridge.SetUpdateOnTouch(value, cosmosView); }
		}

		public double StarSize
		{
			get { return CosmosSettingsObjCBridge.GetStarSize(cosmosView); }
			set { CosmosSettingsObjCBridge.SetStarSize(value, cosmosView); }
		}

		public nint TotalStars
		{
			get { return CosmosSettingsObjCBridge.GetTotalStars(cosmosView); }
			set { CosmosSettingsObjCBridge.SetTotalStars(value, cosmosView); }
		}

		public double StarMargin
		{
			get { return CosmosSettingsObjCBridge.GetStarMargin(cosmosView); }
			set { CosmosSettingsObjCBridge.SetStarMargin(value, cosmosView); }
		}

		public UIColor FilledColor
		{
			get { return CosmosSettingsObjCBridge.GetFilledColor(cosmosView); }
			set { CosmosSettingsObjCBridge.SetFilledColor(value, cosmosView); }
		}

		public UIColor EmptyColor
		{
			get { return CosmosSettingsObjCBridge.GetEmptyColor(cosmosView); }
			set { CosmosSettingsObjCBridge.SetEmptyColor(value, cosmosView); }
		}

		public double BorderWidth
		{
			get { return CosmosSettingsObjCBridge.GetFilledBorderWidth(cosmosView); }
			set { CosmosSettingsObjCBridge.SetFilledBorderWidth(value, cosmosView); }
		}

		public UIColor FilledBorderColor
		{
			get { return CosmosSettingsObjCBridge.GetFilledBorderColor(cosmosView); }
			set { CosmosSettingsObjCBridge.SetFilledBorderColor(value, cosmosView); }
		}

		public double EmptyBorderWidth
		{
			get { return CosmosSettingsObjCBridge.GetEmptyBorderWidth(cosmosView); }
			set { CosmosSettingsObjCBridge.SetEmptyBorderWidth(value, cosmosView); }
		}

		public UIColor EmptyBorderColor
		{
			get { return CosmosSettingsObjCBridge.GetEmptyBorderColor(cosmosView); }
			set { CosmosSettingsObjCBridge.SetEmptyBorderColor(value, cosmosView); }
		}

		public UIColor TextColor
		{
			get { return CosmosSettingsObjCBridge.GetTextColor(cosmosView); }
			set { CosmosSettingsObjCBridge.SetTextColor(value, cosmosView); }
		}

		public UIFont TextFont
		{
			get { return CosmosSettingsObjCBridge.GetTextFont(cosmosView); }
			set { CosmosSettingsObjCBridge.SetTextFont(value, cosmosView); }
		}

		public double TextMargin
		{
			get { return CosmosSettingsObjCBridge.GetTextMargin(cosmosView); }
			set { CosmosSettingsObjCBridge.SetTextMargin(value, cosmosView); }
		}
	}

	public static class SettingsExtensions
	{
		public static Settings Settings(this CosmosView cosmosView) => new Settings(cosmosView);
	
	}
}

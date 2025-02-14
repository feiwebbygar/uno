#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class RatingControl : global::Windows.UI.Xaml.Controls.Control
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double Value
		{
			get
			{
				return (double)this.GetValue(ValueProperty);
			}
			set
			{
				this.SetValue(ValueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double PlaceholderValue
		{
			get
			{
				return (double)this.GetValue(PlaceholderValueProperty);
			}
			set
			{
				this.SetValue(PlaceholderValueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int MaxRating
		{
			get
			{
				return (int)this.GetValue(MaxRatingProperty);
			}
			set
			{
				this.SetValue(MaxRatingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.RatingItemInfo ItemInfo
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.RatingItemInfo)this.GetValue(ItemInfoProperty);
			}
			set
			{
				this.SetValue(ItemInfoProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsReadOnly
		{
			get
			{
				return (bool)this.GetValue(IsReadOnlyProperty);
			}
			set
			{
				this.SetValue(IsReadOnlyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsClearEnabled
		{
			get
			{
				return (bool)this.GetValue(IsClearEnabledProperty);
			}
			set
			{
				this.SetValue(IsClearEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int InitialSetValue
		{
			get
			{
				return (int)this.GetValue(InitialSetValueProperty);
			}
			set
			{
				this.SetValue(InitialSetValueProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Caption
		{
			get
			{
				return (string)this.GetValue(CaptionProperty);
			}
			set
			{
				this.SetValue(CaptionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CaptionProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Caption), typeof(string), 
			typeof(global::Windows.UI.Xaml.Controls.RatingControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty InitialSetValueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(InitialSetValue), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.RatingControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsClearEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsClearEnabled), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.RatingControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsReadOnlyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsReadOnly), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.RatingControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ItemInfoProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ItemInfo), typeof(global::Windows.UI.Xaml.Controls.RatingItemInfo), 
			typeof(global::Windows.UI.Xaml.Controls.RatingControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.RatingItemInfo)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty MaxRatingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(MaxRating), typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.RatingControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PlaceholderValueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(PlaceholderValue), typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.RatingControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ValueProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Value), typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.RatingControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.RatingControl.RatingControl()
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.RatingControl()
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.Caption.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.Caption.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.InitialSetValue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.InitialSetValue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.IsClearEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.IsClearEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.IsReadOnly.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.IsReadOnly.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.MaxRating.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.MaxRating.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.PlaceholderValue.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.PlaceholderValue.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.ItemInfo.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.ItemInfo.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.Value.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.Value.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.ValueChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.ValueChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.CaptionProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.InitialSetValueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.IsClearEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.IsReadOnlyProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.MaxRatingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.PlaceholderValueProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.ItemInfoProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RatingControl.ValueProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.RatingControl, object> ValueChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RatingControl", "event TypedEventHandler<RatingControl, object> RatingControl.ValueChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RatingControl", "event TypedEventHandler<RatingControl, object> RatingControl.ValueChanged");
			}
		}
		#endif
	}
}

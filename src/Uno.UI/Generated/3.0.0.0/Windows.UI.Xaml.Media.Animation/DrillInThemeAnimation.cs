#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DrillInThemeAnimation : global::Windows.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ExitTargetName
		{
			get
			{
				return (string)this.GetValue(ExitTargetNameProperty);
			}
			set
			{
				this.SetValue(ExitTargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.DependencyObject ExitTarget
		{
			get
			{
				return (global::Windows.UI.Xaml.DependencyObject)this.GetValue(ExitTargetProperty);
			}
			set
			{
				this.SetValue(ExitTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string EntranceTargetName
		{
			get
			{
				return (string)this.GetValue(EntranceTargetNameProperty);
			}
			set
			{
				this.SetValue(EntranceTargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.DependencyObject EntranceTarget
		{
			get
			{
				return (global::Windows.UI.Xaml.DependencyObject)this.GetValue(EntranceTargetProperty);
			}
			set
			{
				this.SetValue(EntranceTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty EntranceTargetNameProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(EntranceTargetName), typeof(string), 
			typeof(global::Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty EntranceTargetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(EntranceTarget), typeof(global::Windows.UI.Xaml.DependencyObject), 
			typeof(global::Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ExitTargetNameProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ExitTargetName), typeof(string), 
			typeof(global::Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ExitTargetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ExitTarget), typeof(global::Windows.UI.Xaml.DependencyObject), 
			typeof(global::Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public DrillInThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation", "DrillInThemeAnimation.DrillInThemeAnimation()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.DrillInThemeAnimation()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.EntranceTargetName.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.EntranceTargetName.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.EntranceTarget.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.EntranceTarget.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.ExitTargetName.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.ExitTargetName.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.ExitTarget.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.ExitTarget.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.EntranceTargetNameProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.EntranceTargetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.ExitTargetNameProperty.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DrillInThemeAnimation.ExitTargetProperty.get
	}
}

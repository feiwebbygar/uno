#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class RefreshContainer : global::Windows.UI.Xaml.Controls.ContentControl
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.RefreshVisualizer Visualizer
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.RefreshVisualizer)this.GetValue(VisualizerProperty);
			}
			set
			{
				this.SetValue(VisualizerProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.RefreshPullDirection PullDirection
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.RefreshPullDirection)this.GetValue(PullDirectionProperty);
			}
			set
			{
				this.SetValue(PullDirectionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PullDirectionProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(PullDirection), typeof(global::Windows.UI.Xaml.Controls.RefreshPullDirection), 
			typeof(global::Windows.UI.Xaml.Controls.RefreshContainer), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.RefreshPullDirection)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty VisualizerProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Visualizer), typeof(global::Windows.UI.Xaml.Controls.RefreshVisualizer), 
			typeof(global::Windows.UI.Xaml.Controls.RefreshContainer), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Controls.RefreshVisualizer)));
		#endif
		// Skipping already declared method Windows.UI.Xaml.Controls.RefreshContainer.RefreshContainer()
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshContainer.RefreshContainer()
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshContainer.Visualizer.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshContainer.Visualizer.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshContainer.PullDirection.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshContainer.PullDirection.set
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshContainer.RefreshRequested.add
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshContainer.RefreshRequested.remove
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void RequestRefresh()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RefreshContainer", "void RefreshContainer.RequestRefresh()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshContainer.VisualizerProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.RefreshContainer.PullDirectionProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.RefreshContainer, global::Windows.UI.Xaml.Controls.RefreshRequestedEventArgs> RefreshRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RefreshContainer", "event TypedEventHandler<RefreshContainer, RefreshRequestedEventArgs> RefreshContainer.RefreshRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.RefreshContainer", "event TypedEventHandler<RefreshContainer, RefreshRequestedEventArgs> RefreshContainer.RefreshRequested");
			}
		}
		#endif
	}
}

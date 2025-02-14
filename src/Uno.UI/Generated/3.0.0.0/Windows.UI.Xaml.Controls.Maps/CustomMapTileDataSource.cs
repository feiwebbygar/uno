#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CustomMapTileDataSource : global::Windows.UI.Xaml.Controls.Maps.MapTileDataSource
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public CustomMapTileDataSource() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.CustomMapTileDataSource", "CustomMapTileDataSource.CustomMapTileDataSource()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.CustomMapTileDataSource.CustomMapTileDataSource()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.CustomMapTileDataSource.BitmapRequested.add
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.CustomMapTileDataSource.BitmapRequested.remove
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.Maps.CustomMapTileDataSource, global::Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequestedEventArgs> BitmapRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.CustomMapTileDataSource", "event TypedEventHandler<CustomMapTileDataSource, MapTileBitmapRequestedEventArgs> CustomMapTileDataSource.BitmapRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.CustomMapTileDataSource", "event TypedEventHandler<CustomMapTileDataSource, MapTileBitmapRequestedEventArgs> CustomMapTileDataSource.BitmapRequested");
			}
		}
		#endif
	}
}

#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ColorChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Color NewColor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color ColorChangedEventArgs.NewColor is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Color%20ColorChangedEventArgs.NewColor");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Color OldColor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color ColorChangedEventArgs.OldColor is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Color%20ColorChangedEventArgs.OldColor");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorChangedEventArgs.OldColor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.ColorChangedEventArgs.NewColor.get
	}
}

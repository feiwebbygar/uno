#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InkToolbarToggleButton : global::Windows.UI.Xaml.Controls.CheckBox
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.InkToolbarToggle ToggleKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member InkToolbarToggle InkToolbarToggleButton.ToggleKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=InkToolbarToggle%20InkToolbarToggleButton.ToggleKind");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.InkToolbarToggleButton.ToggleKind.get
	}
}

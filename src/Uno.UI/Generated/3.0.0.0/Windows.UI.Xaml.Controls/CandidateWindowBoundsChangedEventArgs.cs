#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CandidateWindowBoundsChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect Bounds
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect CandidateWindowBoundsChangedEventArgs.Bounds is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Rect%20CandidateWindowBoundsChangedEventArgs.Bounds");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs.Bounds.get
	}
}

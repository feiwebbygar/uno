#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TreeViewExpandingEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Controls.TreeViewNode Node
		{
			get
			{
				throw new global::System.NotImplementedException("The member TreeViewNode TreeViewExpandingEventArgs.Node is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TreeViewNode%20TreeViewExpandingEventArgs.Node");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object Item
		{
			get
			{
				throw new global::System.NotImplementedException("The member object TreeViewExpandingEventArgs.Item is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=object%20TreeViewExpandingEventArgs.Item");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewExpandingEventArgs.Node.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewExpandingEventArgs.Item.get
	}
}

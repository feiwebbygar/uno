#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TreeViewItemInvokedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool Handled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool TreeViewItemInvokedEventArgs.Handled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20TreeViewItemInvokedEventArgs.Handled");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.TreeViewItemInvokedEventArgs", "bool TreeViewItemInvokedEventArgs.Handled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object InvokedItem
		{
			get
			{
				throw new global::System.NotImplementedException("The member object TreeViewItemInvokedEventArgs.InvokedItem is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=object%20TreeViewItemInvokedEventArgs.InvokedItem");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItemInvokedEventArgs.InvokedItem.get
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItemInvokedEventArgs.Handled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.TreeViewItemInvokedEventArgs.Handled.get
	}
}

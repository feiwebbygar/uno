#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SelectorAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.ISelectionProvider
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanSelectMultiple
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SelectorAutomationPeer.CanSelectMultiple is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20SelectorAutomationPeer.CanSelectMultiple");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsSelectionRequired
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool SelectorAutomationPeer.IsSelectionRequired is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20SelectorAutomationPeer.IsSelectionRequired");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public SelectorAutomationPeer( global::Windows.UI.Xaml.Controls.Primitives.Selector owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer", "SelectorAutomationPeer.SelectorAutomationPeer(Selector owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer.SelectorAutomationPeer(Windows.UI.Xaml.Controls.Primitives.Selector)
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer.CanSelectMultiple.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer.IsSelectionRequired.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Automation.Provider.IRawElementProviderSimple[] GetSelection()
		{
			throw new global::System.NotImplementedException("The member IRawElementProviderSimple[] SelectorAutomationPeer.GetSelection() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IRawElementProviderSimple%5B%5D%20SelectorAutomationPeer.GetSelection%28%29");
		}
		#endif
		// Processing: Windows.UI.Xaml.Automation.Provider.ISelectionProvider
	}
}

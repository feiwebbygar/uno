#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
	#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("IS_UNIT_TESTS", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial interface IProtocolActivatedEventArgs : global::Windows.ApplicationModel.Activation.IActivatedEventArgs
	{
		#if false || false || IS_UNIT_TESTS || false || __SKIA__ || __NETSTD_REFERENCE__ || false
		global::System.Uri Uri
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs.Uri.get
	}
}

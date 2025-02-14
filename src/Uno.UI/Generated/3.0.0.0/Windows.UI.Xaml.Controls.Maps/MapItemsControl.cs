#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	[global::Windows.UI.Xaml.Markup.ContentPropertyAttribute(Name = "Items")]
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapItemsControl : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object ItemsSource
		{
			get
			{
				return (object)this.GetValue(ItemsSourceProperty);
			}
			set
			{
				this.SetValue(ItemsSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.DataTemplate ItemTemplate
		{
			get
			{
				return (global::Windows.UI.Xaml.DataTemplate)this.GetValue(ItemTemplateProperty);
			}
			set
			{
				this.SetValue(ItemTemplateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.DependencyObject> Items
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Windows.UI.Xaml.DependencyObject>)this.GetValue(ItemsProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ItemTemplateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ItemTemplate), typeof(global::Windows.UI.Xaml.DataTemplate), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapItemsControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DataTemplate)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ItemsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Items), typeof(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.DependencyObject>), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapItemsControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.DependencyObject>)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ItemsSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ItemsSource), typeof(object), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapItemsControl), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(object)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MapItemsControl() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapItemsControl", "MapItemsControl.MapItemsControl()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapItemsControl.MapItemsControl()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapItemsControl.ItemsSource.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapItemsControl.ItemsSource.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapItemsControl.Items.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapItemsControl.ItemTemplate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapItemsControl.ItemTemplate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapItemsControl.ItemsSourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapItemsControl.ItemsProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapItemsControl.ItemTemplateProperty.get
	}
}

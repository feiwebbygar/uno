#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MapPolygon : global::Windows.UI.Xaml.Controls.Maps.MapElement
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double StrokeThickness
		{
			get
			{
				return (double)this.GetValue(StrokeThicknessProperty);
			}
			set
			{
				this.SetValue(StrokeThicknessProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool StrokeDashed
		{
			get
			{
				return (bool)this.GetValue(StrokeDashedProperty);
			}
			set
			{
				this.SetValue(StrokeDashedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Color StrokeColor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color MapPolygon.StrokeColor is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Color%20MapPolygon.StrokeColor");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapPolygon", "Color MapPolygon.StrokeColor");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Geolocation.Geopath Path
		{
			get
			{
				return (global::Windows.Devices.Geolocation.Geopath)this.GetValue(PathProperty);
			}
			set
			{
				this.SetValue(PathProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Color FillColor
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color MapPolygon.FillColor is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Color%20MapPolygon.FillColor");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapPolygon", "Color MapPolygon.FillColor");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.Devices.Geolocation.Geopath> Paths
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<Geopath> MapPolygon.Paths is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CGeopath%3E%20MapPolygon.Paths");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty PathProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Path), typeof(global::Windows.Devices.Geolocation.Geopath), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapPolygon), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.Devices.Geolocation.Geopath)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeDashedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(StrokeDashed), typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapPolygon), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeThicknessProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(StrokeThickness), typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.Maps.MapPolygon), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MapPolygon() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.Maps.MapPolygon", "MapPolygon.MapPolygon()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.MapPolygon()
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.Path.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.Path.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.StrokeColor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.StrokeColor.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.StrokeThickness.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.StrokeThickness.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.StrokeDashed.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.StrokeDashed.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.FillColor.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.FillColor.set
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.Paths.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.PathProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.StrokeThicknessProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.MapPolygon.StrokeDashedProperty.get
	}
}

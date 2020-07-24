using System;
using GLib;
using SkiaSharp;
using Gtk;
using Uno.Foundation.Extensibility;
using System.Threading;
using Uno.UI.Runtime.Skia;

namespace SkiaSharpExample
{
	class MainClass
	{
		[STAThread]
		public static void Main(string[] args)
		{
			ExceptionManager.UnhandledException += delegate (UnhandledExceptionArgs expArgs)
			{
				Console.WriteLine("GLIB UNHANDLED EXCEPTION" + expArgs.ExceptionObject.ToString());
				expArgs.ExitApplication = true;
			};

			Windows.UI.Xaml.FrameworkElement.TagProperty

			var host = new GtkHost(() => new SamplesApp.App(), args);

			host.Run();
		}
	}
}

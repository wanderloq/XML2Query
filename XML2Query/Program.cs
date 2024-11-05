using System;
using System.Windows.Forms;

namespace XML2Query
{ 
	internal static class Program
	{ 
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new XML2Query());
		}
	}
}

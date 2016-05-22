using System;
using Pinta.Core;

namespace PsdAddin
{
	[Mono.Addins.Extension]
	public class PintaPsdExtension: IExtension
	{
		public void Initialize ()
		{
			System.Console.Out.WriteLine ("Initializing PSD addin.");
		}

		public void Uninitialize ()
		{
			System.Console.Out.WriteLine ("Uninitializing PSD addin.");
		}
	}
}
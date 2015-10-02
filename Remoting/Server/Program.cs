
#region usings

using System;
using System.Runtime.Remoting;
using Common;
using Leafing.Core;

#endregion

namespace Server
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
            RemotingHelper.EventModeServerRegister();
            RemotingHelper.Marshal(new DataLayer(), typeof(IDataLayer));
            Console.WriteLine("Press any key to end...");
            Console.ReadLine();
        }
	}
}

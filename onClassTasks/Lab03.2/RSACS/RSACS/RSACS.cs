using System;
using System.Runtime.InteropServices;//import dll

class Program
{
	[DllImport("RSADLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet =  CharSet.Ansi, EntryPoint = "GenerateAndSaveRSAKeys")]
	public static extern void GenerateAndSaveRSAKeys(int keySize, string format, string privateKeyFile, string publicKeyFile);

	[DllImport("RSADLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet =  CharSet.Ansi, EntryPoint = "RSAencrypt")]
	public static extern void RSAencrypt(string format, string publicKeyFile, string PlaintextFile, string CiphertFile);

	[DllImport("RSADLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet =  CharSet.Ansi, EntryPoint = "RSAdecrypt")]
	public static extern void RSAdecrypt(string format, string privateKeyFile, string CiphertextFile, string PlaintextFile);

	static void Main(string[] args)
	{
		// Set console to UTF-8 for Windows environments
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.InputEncoding = System.Text.Encoding.UTF8;
		}
		// Check if there are enough arguments provided
		if (args.Length < 2)
		{
			Console.Error.WriteLine("Usage: ");
			Console.Error.WriteLine("  {0} genkey <keysize> <format> <privateKeyFile> <publicKeyFile>", Environment.GetCommandLineArgs()[0]);
			Console.Error.WriteLine("  {0} encrypt <format> <publicKeyFile> <plaintextFile> <cipherFile>", Environment.GetCommandLineArgs()[0]);
			Console.Error.WriteLine("  {0} decrypt <format> <privateKeyFile> <cipherFile> <plaintextFile>", Environment.GetCommandLineArgs()[0]);
			Environment.Exit(-1);
		}

		string mode = args[0];
		// call functions
		try
		{
			if (mode.Equals("genkey") && args.Length == 5)
			{
				int keySize = int.Parse(args[1]);
				GenerateAndSaveRSAKeys(keySize, args[2], args[3], args[4]);


			}
			else if (mode.Equals("encrypt") && args.Length == 5)
			{
				RSAencrypt(args[1], args[2], args[3], args[4]);
			}
			else if (mode.Equals("decrypt") && args.Length == 5)
			{
				RSAdecrypt(args[1], args[2], args[3], args[4]);
			}
			else
			{
				Console.Error.WriteLine("Invalid mode");
				Environment.Exit(-1);
			}
		}
		catch (Exception e)
		{
			Console.Error.WriteLine("!!! Error !!!");
			Console.Error.WriteLine(e);

			Environment.Exit(-1);
		}
		Console.Error.WriteLine("Done");
	}
}
using System;
using System.Runtime.InteropServices;//import dll

class Program
{
	[DllImport("RSADLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "GenerateAndSaveRSAKeys")]
	public static extern void GenerateAndSaveRSAKeys(int keySize, const char *format, const char *privateKeyFile, const char *publicKeyFile);
	
	[DllImport("RSADLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "RSAencrypt")]
	public static extern void RSAencrypt(const char *format, const char *publicKeyFile, const char *PlaintextFile, const char *CipherFile);

	[DllImport("RSADLL.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode, EntryPoint = "RSAdecrypt")]
	public static extern void RSAdecrypt(const char *format, const char *privateKeyFile, const char *CipherTextFile, const char *PlainTextFile);

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

		string mode=args[0];
		// call functions
		try{
			if (mode.Equals("genkey") && args.Length == 5)
			{
				int keySize = int.Parse(args[1]);
				GenerateAndSaveRSAKeys(keySize, args[2], args[3], args[4]);
			}
			else if (mode.Equals("encrypt") && args.Length == 5)
			{
				int keySize = int.Parse(args[1]);
				RSAencrypt(keySize, args[2], args[3], args[4]);
			} else if (mode.Equals("encrypt") && args.Length == 5)
			{
				int keySize = int.Parse(args[1]);
				RSAdecrypt(keySize, args[2], args[3], args[4]);
			}
			else
			{
			Console.Error.WriteLine("Invalid mode");
						Environment.Exit(-1);	
			}
		}
		catch(Exception ex)
		{
			Console.Error.WriteLine("Erroe");
						Environment.Exit(-1);

		}
		Console.Error.WriteLine("  {0} decrypt <format> <privateKeyFile> <cipherFile> <plaintextFile>");
	}
}
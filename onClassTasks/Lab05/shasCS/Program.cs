using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


class Program
{
    [DllImport("shas.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl, EntryPoint = "_Z6hashesPKcS0_S0_")]
    public static extern void hashes(string algo, string inputFilename, string outputFilename);

    static void Main(string[] args)
        {
            if(args.Length != 3)
            {
            Console.WriteLine("Usage: {0} <hash-algorithm> <input-file> <output-file>", Environment.GetCommandLineArgs()[0]);
            return;
            }
        string algo = args[0];
        string inputFilename = args[1];
        string outputFilename = args[2];

        try
        {
            hashes(algo, inputFilename, outputFilename);
            Console.WriteLine("Hashes output saved to {0}", outputFilename);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"An error accour: {ex.Message}");
        }
        }
    
}

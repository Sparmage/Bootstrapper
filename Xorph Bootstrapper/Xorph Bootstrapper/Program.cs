using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.IO.Compression;
using System.Threading;
using bootstrapping;
using System.Runtime.InteropServices;
using System.IO;
using System.ComponentModel;

namespace Xorph_Bootstrapper
{
    class Program
    {
        //if pipe if created connected(x)
        //delete files that might cause problems(x)
        // download files (x)
        // xtract the files (x)
        // open the files (x)


        private static MyConsole console = new MyConsole(); // DO NOT DELETE IF YOU WANT THE SMOOTHWRITE


        public static void removetheshittyproblems()
        {
            string wcaboutissues = @".\Release"; // if problems are found (Release.zip) before they reinstall it will delete it
            if (Directory.Exists(wcaboutissues))
                try
                {
                    Directory.Delete(wcaboutissues, true);

                    Thread.Sleep(500);
                }
                catch (Exception sexv2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Program.console.smoothWrite($"Something went wrong " + sexv2.ToString()); // shows a error log
                    Thread.Sleep(60);
                    System.Environment.Exit(0);
                }
        }

        public static void check()
        {
            {


                if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
                {
                    foreach (Process pc in Process.GetProcessesByName("RobloxPlayerBeta")) // gets the process by name
                        try
                        {
                            pc.Kill(); // if the named pipe is found it will kill roblox
                        }
                        catch (Exception sex)
                        {
                            Console.WriteLine($"Something went wrong " + sex.ToString()); // error message will show
                            Thread.Sleep(60);
                            System.Environment.Exit(0);
                        }
                }

            }


        }

        public static void shittydownload()
        {
            WebClient wdcaboutshit = new WebClient();
            wdcaboutshit.DownloadFileAsync(new Uri(""), @".\Release.zip"); // this will download it in the current directory MAKE SURE ITS A ZIP FILE!!!!!!
            Thread.Sleep(9000);
        }

        public static void lazyextract() // extracts the .zip files 
        {
            string zippath = @".\Release.zip";
            ZipFile.ExtractToDirectory(zippath, @".\Release");
            Thread.Sleep(9000); // you can change this it might cause problems tho


            string shittyzip = @".\Release.zip"; // create's a string 
            if (File.Exists(shittyzip))
                try
                {
                    File.Delete(shittyzip); // delete's the zip when finished
                    Thread.Sleep(60);
                }
                catch (Exception sexv3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Program.console.smoothWrite($"Something went wrong " + sexv3.ToString()); // error log
                    Console.ReadKey();
                    Thread.Sleep(60);
                    System.Environment.Exit(0);
                    return;
                }

        }


        public static void Starttheshittyexploit()
        {
            string executepath = @".\Release\Xorph.exe"; // it will start the process called "Xorph.exe", you can change the process name if you want
            Process.Start(executepath);
        }

        static void Main(string[] args)
        {

    
 
            if (Environment.OSVersion.Version < new Version(6, 2))
            {
                Console.Title = "Xorph - Windows 7 Has Been Detected"; // we hate windows 7
                Program.console.setColor(ConsoleColor.Cyan);
                Program.console.smoothWrite("Hello, " + Environment.UserName);
                Program.console.setColor(ConsoleColor.Red);
                Program.console.smoothWrite("Windows 7 is not supported, Consider upgrading to windows 10 since its now free!"); // its free!
                Program.console.setColor(ConsoleColor.Green);
                Console.WriteLine("Press Enter to continue..");
                Console.ReadKey();
            }
            else
            {
                
                Console.Title = "Starting...";
                Program.console.setColor(ConsoleColor.Cyan);
                Program.console.smoothWrite("Hello " + Environment.UserName); // prints out "Hello (environment username here)"
                Program.console.setColor(ConsoleColor.Green);
                Program.console.smoothWrite("Starting..");

                removetheshittyproblems(); // starts the removetheshittyproblem
                Console.Title = "Detecting Problems..";
                Console.ForegroundColor = ConsoleColor.Green;
                Program.console.smoothWrite("Checking for extracting problems...");
                Program.console.smoothWrite("Problems fullfilled!");
                Thread.Sleep(60);
                
                check(); // starts the check
                Console.Title = "Detecting Issues..";
                Console.ForegroundColor = ConsoleColor.Green;
                Program.console.smoothWrite("Checking for issues...");
                Program.console.smoothWrite("No issues!");
                Thread.Sleep(60);


                shittydownload();// will start downloading it
                Console.Title = "Downloading..";
                WebClient webClient = new WebClient();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Program.console.smoothWrite("Downloading ...");
                Console.Title = "Download complete!";
                Program.console.smoothWrite("Download completed!");
                Thread.Sleep(60);

                lazyextract(); // extracts the zip
                Console.Title = "Extracting...";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Program.console.smoothWrite("Extracting ...");
                Console.Title = "Extracting completed!";
                Program.console.smoothWrite("Extracting completed!");
                Thread.Sleep(60);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Program.console.smoothWrite("Starting Xorph!");
                string executepath = @".\Release\Xorph.exe"; // starts the exe
                Process.Start(executepath);
                Thread.Sleep(30);


                Console.ForegroundColor = ConsoleColor.Green;
                Program.console.smoothWrite("Everything worked fine! Enjoy exploting and remember to turn of your antivirus! :)");
                Thread.Sleep(1000);
                System.Environment.Exit(0); // exits

                Console.ReadKey();
            }
        }



           


        }

    }



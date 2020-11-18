using System;
using System.IO.MemoryMappedFiles;
using System.Threading;

public enum ClientProgramType { FIFO, queue, mappedMemory }

namespace ClientServer_ClientApp_latest
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChouseInt = -2;
            string userChouseStr = "";

                Console.WriteLine("Ievadiet skaitli no -1 lidz 2 - savienojuma tipu...");
                Console.WriteLine("0. - FIFO apstrade");
                Console.WriteLine("1. - MSMQ privatas rindas apstrade");
                Console.WriteLine("2. - daltas atminas apstrade (faila nolasisana)");
                Console.WriteLine("-1. - iziet no programmas");

            userChouseStr = Console.ReadLine();
            userChouseInt = Convert.ToInt32(userChouseStr);

            ClientProgramType c = (ClientProgramType)(int)userChouseInt;
                // Create a new instance of the class.
                MyMSMQ myNewQueue_0 = new MyMSMQ();

                // Send a message to a queue.
                myNewQueue_0.SendMessage(userChouseStr);
            // press any key to exit
            Console.WriteLine("Saglabats, nospiediet jebkuru taustinu, lai turpinatu");
            Console.ReadLine();

            switch (c)
                {
                    case ClientProgramType.FIFO: // 0

                        Console.WriteLine("FIFO klients");

                        MyFIFO ClientFIFO = new MyFIFO();


                        Thread ClientThread = new Thread(ClientFIFO.ThreadStartClient);


                        ClientThread.Start();
                        break;


                    case ClientProgramType.queue: // 1

                        Console.WriteLine("MSMQ Queuen klients");

                        // Create a new instance of the class.
                        MyMSMQ myNewQueue = new MyMSMQ();

                        // Send a message to a queue.
                        myNewQueue.SendMessage();
                        // press any key to exit
                        Console.WriteLine("Nospiediet jebkuru taustinu, lai izietu");
                        Console.ReadLine();

                    break;

                    case ClientProgramType.mappedMemory: // 2
                                                         //Atver un nolasa no servera rakstīto failu

                        Console.WriteLine("Memory mapped failu lasītājs");

                        using (var file = MemoryMappedFile.OpenExisting("myFile"))
                        {
                            using (var reader = file.CreateViewAccessor(0, 34))
                            {
                                var bytes = new byte[34];
                                reader.ReadArray<byte>(0, bytes, 0, bytes.Length);

                                Console.WriteLine("Lasa baitus");
                                for (var i = 0; i < bytes.Length; i++)
                                    Console.Write((char)bytes[i] + " ");

                                Console.WriteLine(string.Empty);
                            }
                        }
                        Console.WriteLine("Nospiediet jebkuru taustiņu, lai izietu ...");
                        Console.ReadLine();

                        break;

                    default:
                        Console.WriteLine("Wrong client type.");
                        break;
                }
        }
    }
}

using System;
using System.Messaging;

namespace ClientServer_ClientApp_latest
{
    class MyMSMQ
    {
        //**************************************************
        // Sends an Order to a queue.
        //**************************************************

        public void SendMessage()
        {

            // Value to sent.
            string sendedVal = "new good message coming.";

            // Connect to a queue on the local computer.
            MessageQueue myQueue = new MessageQueue(".\\private$\\new");

            Message mgs = new Message(sendedVal);

            Console.WriteLine("sending: " + sendedVal);
            // Sending message.
            myQueue.Send(mgs);
            myQueue.DefaultPropertiesToSend.Label = "sending any text plz...";

            // press any key to exit
            Console.ReadLine();

            return;
        }
    }
}

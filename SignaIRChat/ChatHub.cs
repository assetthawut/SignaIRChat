using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Collections;
using System.Threading.Tasks;

namespace SignaIRChat
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }

        public void NewMessage(string name, string message) {
            Clients.All.addNewMessageToPage(name, message);
        }

        public void test(string name, string message) {
            Clients.All.jook(name, message);
        }

        public void test2(string name, string to, string message)
        {
            Clients.All.jook2(name, to, message);
            // Clients.Client(Context.ConnectionId).jook2(name, message);
        }


        public void countnumber(int number) {
            Clients.All.counter(number);
        }


        /*
        public async Task<string> DoLongRunningThing(int progress) {
            for (int i = 0; i <= 100; i++) {
                   await Task.Delay(1);
            }
            return "Job done";
        }
        */

        public string DoLongRunningThing(int progress) {
            for (int i = 0; i <= 100; i++)
            {

            }
            return "Short Run";
        }

        /*
        public class username {

            public string Username { get; set; }
            public string Lastname { get; set; }
        }

        public void SendMessage(string name, string message) {
            Clients.All.addContosoChatMessageToPage(new username() {
                Username = "Joe",
                Lastname = "Sett"
            });
        }
        */

        

        public class ContosoChatMessage
        {
            public string UserName { get; set; }
            public string Message { get; set; }
        }

        public void SendMessage(string name, string message)
        {
            Clients.All.addContosoChatMessageToPage(new ContosoChatMessage() { UserName = name, Message = message });
        }


    }
}
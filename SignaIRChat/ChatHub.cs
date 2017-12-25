using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Collections;

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

        public void NewMessage(string name,string message) {
            Clients.All.addNewMessageToPage(name, message);   
        }

        public void test(string name, string message) {
            Clients.All.jook(name, message);
        }

        public void test2(string name,string to, string message)
        {
             Clients.All.jook2(name, to,message);
           // Clients.Client(Context.ConnectionId).jook2(name, message);
        }


        public void countnumber(int number) {
            Clients.All.counter(number);
        }



    }
}
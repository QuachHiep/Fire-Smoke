using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace DemoFire.Class
{
    public class WebSocketClient
    {
        private WebSocket _ws;
        public string ServerResponse { get; private set; }

        public WebSocketClient(string url)
        {
            _ws = new WebSocket(url);

            _ws.OnMessage += (sender, e) =>
            {
                ServerResponse = e.Data;
                Console.WriteLine("Received from server: " + ServerResponse);
            };

            _ws.OnOpen += (sender, e) =>
            {
                Console.WriteLine("Connected to WebSocket server.");
            };

            _ws.OnError += (sender, e) =>
            {
                Console.WriteLine("Error: " + e.Message);
            };

            _ws.OnClose += (sender, e) =>
            {
                Console.WriteLine("Connection closed.");
            };
        }

        public void SendMessage(string message)
        {
            _ws.Send(message);
            Console.WriteLine("Sent to server: " + message);
        }

        public void Connect()
        {
            _ws.Connect();
        }

        public void Close()
        {
            _ws.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IoccDemo
{
    public class ChatService
    {
        private IMessageHandler _messagehandler;

        public ChatService(IMessageHandler handler)
        {
            _messagehandler = handler;
        }

        public void SendMessageTo(string name, string message)
        {
            _messagehandler.SendMessage($"To {name}: {message}");
            
        }

        public string RecieveMessageFrom(string name)
        {
            string message = _messagehandler.GetMessage();
            return $"{name} says {message}";
        }
    }
}

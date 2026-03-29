using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTurnGame.Core.Systems.Chat.Model
{
    public class ChatMessage
    {
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime MessageDate { get; set; }
    }
}

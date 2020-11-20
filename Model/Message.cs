using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Model
{
    public class Message
    {
        public long MessageID { get; set; }
        public long UserID { get; set; }
        public long ChatID { get; set; }
        public DateTime TimeOfMessange { get; set; }
        public string ContentOfMessage { get; set; }
        public bool IsChecked { get; set; } 
        public string Style { get; set; }
        public int NumberOfLikes { get; set; }
    }
}

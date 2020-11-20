using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Model
{   
    [Keyless]  // ??????????????????
    public class GroupChat 
    {
        public long ChatID { get; set; } 
        public IEnumerable<User> Users { get; set; } 
        public IEnumerable<Message> Messages { get; set; }
    }
}

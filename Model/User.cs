using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Model
{
    public class User
    {
        public long UserID { get; set; }
        public string NickName { get; set; }
        [NotMapped]
        public object Avatar { get; set; }                       //? ТИП ДАННЫX
        public bool? IsOnline { get; set; }
        public IEnumerable<Chat> Chats { get; set; }
        [NotMapped]
        public IEnumerable<GroupChat> GroupChats { get; set; }
    }
}

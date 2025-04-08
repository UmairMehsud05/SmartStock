using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.BLL
{
    public static class Session
    {
        public static int UserId{ get; set; }
        public static string Name { get; set; }
        public static string Email { get; set; }
        public static string ProfilePic { get; set; }
        public static int RoleId { get; set; }
        public static bool IsSecurityQuestionsCompleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.DAL
{
    public enum DbAction
    {
        Insert=1,
        Update,
        Delete,
        Select,
        UpdateSecurityQuestions,
        ResetPassword,
        UpdateProfile
    }
}

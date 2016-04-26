using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools.Classes
{
    public class MSrvType
    {
        public enum MSrvDepartment :short
        {
            Sales = 1,
            Logistics = 2
        }
        public enum ActionType : int
        {
            Request_Action = 1,
            Ticket_Created = 2,
            Visit_Added = 3,
            Action_Close = 4,
            Chat_Added = 5,
            Custom_Action = 6,
        }
        public enum TypeCondition
        {
            Open_Ticket = 1,
            Close_Ticket = 2,
            RequestAction = 3,
        }
    }
}

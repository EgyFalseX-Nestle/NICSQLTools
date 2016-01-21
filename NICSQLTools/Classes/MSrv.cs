using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NICSQLTools.Classes
{
    public static class MSrv
    {
        public static NICSQLTools.Data.dsMSrcTableAdapters.MSrv_TicketActionTableAdapter adpAction = new Data.dsMSrcTableAdapters.MSrv_TicketActionTableAdapter();

        public static int CreateAction(Classes.MSrvType.ActionType ActionType, int TicketId, string ActionComment)
        {
            int MSrv_TicketActionId = (int)adpAction.NewId();
            DateTime ServerDatetime = Classes.Managers.DataManager.defaultInstance.ServerDateTime;
            adpAction.Insert(MSrv_TicketActionId, (int)ActionType, TicketId, ServerDatetime, ActionComment, Managers.UserManager.defaultInstance.User.UserId
                , ServerDatetime, Convert.ToInt16(Managers.UserManager.defaultInstance.User.MSrvDepartmentId));
            return MSrv_TicketActionId;
        }
    }
}

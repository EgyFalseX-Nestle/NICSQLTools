using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NICSQLTools.Views.Data.MSrv.Ticket
{
    public partial class MSrv_TicketTypeDlg : DevExpress.XtraEditors.XtraForm
    {
        public MSrv_TicketTypeDlg(int ticketId)
        {
            InitializeComponent();
            ticketTypeInfoTableAdapter.Fill(dsMSrc.TicketTypeInfo, ticketId);
        }
    }
}
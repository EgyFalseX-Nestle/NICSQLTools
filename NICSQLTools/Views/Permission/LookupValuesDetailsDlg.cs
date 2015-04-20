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

namespace NICSQLTools.Views.Permission
{
    public partial class LookupValuesDetailsDlg : DevExpress.XtraEditors.XtraForm
    {
        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(LookupValuesDetailsDlg));
        NICSQLTools.Data.dsQryTableAdapters.LookupFroRuleDetailsTableAdapter adp = new NICSQLTools.Data.dsQryTableAdapters.LookupFroRuleDetailsTableAdapter();
        NICSQLTools.Data.dsDataTableAdapters.AppRuleLookupValueTableAdapter adpEdit = new NICSQLTools.Data.dsDataTableAdapters.AppRuleLookupValueTableAdapter();
        NICSQLTools.Data.dsQry dsQry = new NICSQLTools.Data.dsQry();
        int m_RuleID, m_LookupID;
        public LookupValuesDetailsDlg(int RuleID, int LookupID)
        {
            InitializeComponent();

            m_RuleID = RuleID; m_LookupID = LookupID;
            
            adp.Fill(dsQry.LookupFroRuleDetails, RuleID, LookupID);

            List<object> dataList = Classes.Managers.DataManager.ExeDSLookup(LookupID);
            //clbc.DataSource = (DataTable)dataList[0];
            //clbc.DisplayMember = dataList[1].ToString();
            //clbc.ValueMember = dataList[2].ToString();
            foreach (DataRow row in ((DataTable)dataList[0]).Rows)
	        {
                string display = row[dataList[1].ToString()].ToString();
                string value = row[dataList[2].ToString()].ToString();
                if (dsQry.LookupFroRuleDetails.FindByValueName(value) != null)
                    clbc.Items.Add(value, display, CheckState.Checked, true);
                else
                    clbc.Items.Add(value, display, CheckState.Unchecked, true);    
	        }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < clbc.Items.Count; i++)
                {
                    NICSQLTools.Data.dsQry.LookupFroRuleDetailsRow row = dsQry.LookupFroRuleDetails.FindByValueName(clbc.Items[i].Value.ToString());
                    if (row == null && clbc.Items[i].CheckState == CheckState.Checked)
                        adpEdit.Insert(m_RuleID, m_LookupID, clbc.Items[i].ToString());
                    else if (row != null && clbc.Items[i].CheckState == CheckState.Unchecked)
                        adpEdit.DeleteQueryByValue(m_RuleID, m_LookupID, clbc.Items[i].Value.ToString());
                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MsgDlg.Show(ex.Message, MsgDlg.MessageType.Error, ex);
                Classes.Core.LogException(Logger, ex, Classes.Core.ExceptionLevelEnum.General, Classes.Managers.UserManager.defaultInstance.User.UserId);
            }
            
        }
    }
}
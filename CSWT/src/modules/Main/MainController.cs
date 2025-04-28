using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.form;
using CSWT.src.modules.SignIn;
using CSWT.src.modules.SignUp;
using CSWT.src.shared.utils;
using System.Windows.Forms;
using CSWT.src.modules.CreateTicket;
using CSWT.src.modules.MyTickets;
using CSWT.src.modules.AllTickets;
using CSWT.src.modules.AssignedTickets;
using CSWT.src.modules.Entities;
using CSWT.src.modules.UpdateUser;
using CSWT.src.core;
using CSWT.src.core.db;
using CSWT.src.modules.CreateReport;
using CSWT.src.modules.MyReports;
using CSWT.src.modules.AllReports;

namespace CSWT.src.modules.Main
{
    public class MainController
    {
        FormManager _formManager;
        FormContext _formContext;
        SessionContext _sessionContext;
        UserContext _userContext;
        public MainController(FormManager formManager, FormContext formContext, SessionContext sessionContext, UserContext userContext)
        {
            _formManager = formManager;
            _formContext = formContext;
            _sessionContext = sessionContext;
            _userContext = userContext;
        }

        public void InitRoles(GroupBox ticketBox, GroupBox reportBox, GroupBox adminBox, Button newTicketButton, Button assignedTicketButton)
        {
            var role = _userContext.CurrentUser.role_name;

            switch (role)
            {
                case "Client":
                    ticketBox.Visible = true;
                    reportBox.Visible = false;
                    adminBox.Visible = false;
                    newTicketButton.Visible = false;
                    assignedTicketButton.Visible = false;
                    break;

                case "ASU_staff":
                    ticketBox.Visible = true;
                    reportBox.Visible = true;
                    adminBox.Visible = false;
                    newTicketButton.Visible = true;
                    assignedTicketButton.Visible = true;
                    break;

                case "Admin":
                    ticketBox.Visible = true;
                    reportBox.Visible = true;
                    adminBox.Visible = true;
                    newTicketButton.Visible = true;
                    assignedTicketButton.Visible = true;
                    break;
            }
        }
        public void InitChildrenPanel(Panel childrenPanel)
        {
            _formContext.childrenPanel = childrenPanel;
        }

        public void DrugForm(Panel panel, Form form)
        {
            AddDragControl.EnableDrag(panel, form);
        }

        public void OpenCreateTicker(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<CreateTicketForm>(childrenPanel);
        }
        public void OpenMyTickets(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<MyTicketsForm>(childrenPanel);
        }

        public void OpenAllTickets(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<AllTicketsForm>(childrenPanel);
        }

        public void OpenAssignedTickets(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<AssignedTicketsForm>(childrenPanel);
        }

        public void OpenEntities(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<EntitiesForm>(childrenPanel);
        }

        public void OpenCreateReports(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<CreateReportForm>(childrenPanel);
        }

        public void OpenMyReports(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<MyReportsForm>(childrenPanel);
        }
        public void OpenAllReports(Panel childrenPanel)
        {
            _formManager.OpenChidrenForm<AllReportsForm>(childrenPanel);
        }

        public void OpenProfile(Panel childrenPanel)
        {
            _sessionContext.user_id = _userContext.CurrentUser.ID;
            _sessionContext.is_admin = false;
            _formManager.OpenChidrenForm<UpdateUserForm>(childrenPanel);
        }


    }
}

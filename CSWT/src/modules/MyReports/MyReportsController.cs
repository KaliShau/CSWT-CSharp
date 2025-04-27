using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.shared.dto;
using System.Windows.Forms;
using CSWT.src.core.db;
using CSWT.src.shared.services.report;
using CSWT.src.core.form;
using CSWT.src.core;
using CSWT.src.modules.Report;

namespace CSWT.src.modules.MyReports
{
    public class MyReportsController
    {
        MyReportsModel _model;
        UserContext _userContext;
        FormManager _formManager;
        SessionContext _sessionContext;
        FormContext _formContext;   
        public MyReportsController(MyReportsModel model, UserContext userContext, FormContext formContext, SessionContext sessionContext, FormManager formManager)
        {
            _model = model;
            _userContext = userContext;
            _formContext = formContext;
            _sessionContext = sessionContext;
            _formManager = formManager;
        }

        public void OpenReport(int id)
        {
            _sessionContext.report_id = id;
            _formManager.OpenChidrenForm<ReportForm>(_formContext.childrenPanel);
        }

        public void InitList(ListView ReportList)
        {
            ReportList.View = View.Details;
            ReportList.FullRowSelect = true;

            ReportList.Columns.Add("ID", 50);
            ReportList.Columns.Add("Дата создания", 120);
            ReportList.Columns.Add("Наименование", 200);
            ReportList.Columns.Add("Тип", 300);
        }

        public void GetReports(ListView ReportList)
        {
            var reports = _model.GetMyReporst(_userContext.CurrentUser.ID);
            DisplayReports(reports, ReportList);
        }

        public void GetReportsSearch(ListView ReportList, string searchTerm)
        {
            var reports = _model.GetMyReporstSearch(_userContext.CurrentUser.ID, searchTerm);
            DisplayReports(reports, ReportList);
        }

        public void DisplayReports(ReportDTO[] reports, ListView ReportList)
        {
            ReportList.Items.Clear();

            foreach (var report in reports)
            {
                var item = new ListViewItem(report.ID.ToString());

                item.SubItems.Add(report.created_at.ToString("dd.MM.yyyy HH:mm"));
                item.SubItems.Add(report.report_name);
                item.SubItems.Add(report.report_type);

                item.Tag = report;
                ReportList.Items.Add(item);
            }

        }
    }
}

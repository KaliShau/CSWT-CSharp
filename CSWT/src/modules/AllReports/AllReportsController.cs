using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CSWT.src.core.db;
using CSWT.src.core.form;
using CSWT.src.core;
using CSWT.src.modules.Report;

using CSWT.src.shared.services.report;
using System.Windows.Forms;
using CSWT.src.modules.MyReports;

namespace CSWT.src.modules.AllReports
{
    public class AllReportsController
    {
        AllReportsModel _model;
        UserContext _userContext;
        FormManager _formManager;
        SessionContext _sessionContext;
        FormContext _formContext;
        public AllReportsController(AllReportsModel model, UserContext userContext, FormContext formContext, SessionContext sessionContext, FormManager formManager)
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
            var reports = _model.GetAllReporst();
            DisplayReports(reports, ReportList);
        }

        public void GetReportsSearch(ListView ReportList, string searchTerm)
        {
            var reports = _model.GetAllReporstSearch(searchTerm);
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

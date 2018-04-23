using System;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel.Design;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UserDesigner;
// ...

namespace FieldList_UpdateDataSource {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        const string xmlPath = @"..\..\Cars.xml";

        private void Form1_Load(object sender, EventArgs e) {
            xrDesignPanel1.ExecCommand(ReportCommand.NewReport);
        }

        private void commandBarItem46_ItemClick(object sender, ItemClickEventArgs e) {
            BindReportToData();
        }

        #region #UpdateFieldList
        private void BindReportToData() {
            if (xrDesignPanel1.Report == null)
                return;
             // Create a data source and bind it to a report.
            xrDesignPanel1.Report.DataSource = CreateDataSource();

            // Update the Field List.
            FieldListDockPanel fieldList =
                (FieldListDockPanel)xrDesignDockManager1[DesignDockPanelType.FieldList];
            IDesignerHost host = 
                (IDesignerHost)xrDesignPanel1.GetService(typeof(IDesignerHost));
            fieldList.UpdateDataSource(host);
        }
        #endregion #UpdateFieldList

        private ArrayList CreateDataSource() {
            // Create a list.
            ArrayList list = new ArrayList();

            // Populate the list with records.
            list.Add(new Record(1, "Jane", 19));
            list.Add(new Record(2, "Joe", 30));
            list.Add(new Record(3, "Bill", 15));
            list.Add(new Record(4, "Michael", 42));

            return list;
        }

    }
}
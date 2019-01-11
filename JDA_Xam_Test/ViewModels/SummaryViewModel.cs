using System;
using System.Collections.ObjectModel;
using JDA_Xam_Test.Models;
using JDA_Xam_Test.Services;

namespace JDA_Xam_Test.ViewModels
{
    public class SummaryViewModel
    {
        public ObservableCollection<LeaveObject> LeaveList { get; set; }
        public ObservableCollection<AppliedLeave> AppliedLeaveList { get; set; }
        public SummaryViewModel()
        {
            PopulateList();

        }

        private void PopulateList()
        {
            var history = HistoryService.GetHistory();
            AppliedLeaveList = new ObservableCollection<AppliedLeave>();
            AppliedLeaveList.Clear();
            foreach (AppliedLeave leave in history)
            {
                AppliedLeaveList.Add(leave);
            }

            var summary = SummaryService.GetSummary();
            LeaveList = new ObservableCollection<LeaveObject>();
            LeaveList.Clear();
            foreach (LeaveObject leave in summary)
            {
                LeaveList.Add(leave);
            }

        }
    }
}

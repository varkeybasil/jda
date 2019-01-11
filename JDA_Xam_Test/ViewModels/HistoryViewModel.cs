using System;
using System.Collections.ObjectModel;
using JDA_Xam_Test.Models;
using JDA_Xam_Test.Services;

namespace JDA_Xam_Test.ViewModels
{
    public class HistoryViewModel
    {
        public ObservableCollection<AppliedLeave> LeaveList { get; set; }
        public HistoryViewModel()
        {
            PopulateList();
        }

        private void PopulateList()
        {

            var history = HistoryService.GetHistory();
            LeaveList = new ObservableCollection<AppliedLeave>();
            LeaveList.Clear();
            foreach (AppliedLeave leave in history)
            {
                LeaveList.Add(leave);
            }
        }
    }
}

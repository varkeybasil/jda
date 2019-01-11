using System;
using System.Collections.Generic;
using JDA_Xam_Test.Models;

namespace JDA_Xam_Test.Services
{
    public class HistoryService
    {
        public static List<AppliedLeave> GetHistory()
        {

            DateTime dt2 = DateTime.Now;
            AppliedLeave a1 = new AppliedLeave { FromDate = dt2, ToDate = dt2, Status = LeavesStatus.Approved, Type = LeaveType.Casual, NoOfLeaves = 1 };
            AppliedLeave a2 = new AppliedLeave { FromDate = dt2, ToDate = dt2, Status = LeavesStatus.Pending, Type = LeaveType.Sick, NoOfLeaves = 1};
            AppliedLeave a3 = new AppliedLeave { FromDate = dt2, ToDate = dt2, Status = LeavesStatus.Pending, Type = LeaveType.Sick, NoOfLeaves = 2 };
            AppliedLeave a4 = new AppliedLeave { FromDate = dt2, ToDate = dt2, Status = LeavesStatus.Pending, Type = LeaveType.Compoff, NoOfLeaves = 3 };
            AppliedLeave a5 = new AppliedLeave { FromDate = dt2, ToDate = dt2, Status = LeavesStatus.Rejected, Type = LeaveType.Casual, NoOfLeaves = 3 };

            List<AppliedLeave> list = new List<AppliedLeave>();
            list.Add(a1);
            list.Add(a2);
            list.Add(a3);
            list.Add(a4);
            list.Add(a5);


            return list;

        }
    }
}

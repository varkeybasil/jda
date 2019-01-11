using System;
namespace JDA_Xam_Test.Models
{
    public enum LeaveType { Compoff, Casual, Sick };
    public enum LeavesStatus { Approved, Rejected, Pending };
    public class AppliedLeave
    {
        public LeaveType Type { get; set; }
        public LeavesStatus Status { get; set; }
        public int NoOfLeaves { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
    
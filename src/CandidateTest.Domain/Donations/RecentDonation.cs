using System;

namespace CandidateTest.Domain.Donations
{
    public class RecentDonation
    {
        public string Amount { get; set; }
        public string Name { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime Date { get; set; }
    }
}
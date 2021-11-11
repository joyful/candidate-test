using System;
using CandidateTest.Domain.Donations;

namespace CandidateTest.Web.Models
{
    public class RecentDonationViewModel
    {
        public RecentDonationViewModel(RecentDonation recentDonation)
        {
            Name = recentDonation.IsAnonymous
                ? "Anonymous"
                : recentDonation.Name;
            Amount = recentDonation.Amount;
            Date = recentDonation.Date;
        }

        public string Name { get; }
        public string Amount { get; }
        public DateTime Date { get; }
    }
}
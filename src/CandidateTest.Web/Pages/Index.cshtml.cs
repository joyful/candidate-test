using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandidateTest.DataAccess;
using CandidateTest.Domain.Donations;
using CandidateTest.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateTest.Web.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<RecentDonationViewModel> RecentDonations { get; private set; }
        
        public void OnGet()
        {
            RecentDonations = new RecentDonationsRepository()
                .Get()
                .Select(x => new RecentDonationViewModel(x));
        }
    }
}

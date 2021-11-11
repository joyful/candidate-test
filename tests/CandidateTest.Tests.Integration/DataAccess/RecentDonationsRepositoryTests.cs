using System;
using System.Linq;
using CandidateTest.DataAccess;
using CandidateTest.Domain.Donations;
using NUnit.Framework;
using Shouldly;

namespace CandidateTest.Tests.Integration.DataAccess
{
    public class RecentDonationsRepositoryTests
    {
        [Test]
        public void returns_donations()
        {
            // given
            var subject = new RecentDonationsRepository();

            // when
            var result = subject.Get();

            // then
            result.Count().ShouldBe(5);
            result.First().ShouldBeEquivalentTo(new RecentDonation
            {
                Amount = "£2765",
                Name = "Carl Zeiss",
                IsAnonymous = false,
                Date = DateTime.Parse("2021-11-09T19:32:52+00:00"),
            });
        }
    }
}
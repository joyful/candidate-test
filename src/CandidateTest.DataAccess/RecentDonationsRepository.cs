using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml;
using CandidateTest.Domain.Donations;

namespace CandidateTest.DataAccess
{
    public class RecentDonationsRepository
    {
        /// <summary>
        /// TODO
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RecentDonation> Get()
        {
            var dataset = new DataSet();
            dataset.ReadXml(GetDataset());

            var i = 0;
            do
            {
                yield return new RecentDonation
                {
                    Name = dataset.Tables[0].Rows[i][0].ToString(),
                    Date = DateTime.Parse(dataset.Tables[0].Rows[i][1].ToString()),
                    IsAnonymous = bool.Parse(dataset.Tables[0].Rows[i][2].ToString()),
                    Amount = "£" + dataset.Tables[0].Rows[i][3]
                };

                i++;
            } while (i < dataset.Tables[0].Rows.Count);
        }

        protected string NullIsNull(string text)
        {
            if ("null".Equals(text, StringComparison.InvariantCultureIgnoreCase))
            {
                return null;
            }

            return text;
        }

        private static string GetDataset()
        {
            return Path.Combine(Environment.CurrentDirectory, "donations.xml");
        }
    }
}
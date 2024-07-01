using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportDataLib
{
    public class PassportData
    {
        public string SeriesAndNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuingAuthority { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime ExpiryDate { get; set; }

        public override string ToString()
        {
            return $"{SeriesAndNumber}, {IssueDate:d}, {IssuingAuthority}, {PlaceOfBirth}, {ExpiryDate:d}";
        }

        public PassportData()
        {
        }
        public PassportData(string seriesAndNumber, DateTime issueDate, string issuingAuthority, string placeOfBirth, DateTime expiryDate)
        {
            SeriesAndNumber = seriesAndNumber;
            IssueDate = issueDate;
            IssuingAuthority = issuingAuthority;
            PlaceOfBirth = placeOfBirth;
            ExpiryDate = expiryDate;
        }
    }
}

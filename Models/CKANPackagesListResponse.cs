using System.Collections.Generic;

namespace CKANDataScraper.Models
{
    public class CKANPackagesListResponse
    {
        public bool? Success { get; set; }
        public IEnumerable<string> Result { get; set; }
    }
}

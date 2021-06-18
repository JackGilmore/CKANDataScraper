using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CKANDataScraper.Models
{
    public class CKANPackageResponse
    {
        public bool? Success { get; set; }
        public CKANPackageResponseResult Result { get; set; }
    }

    public class CKANPackageResponseResult
    {
        public string Title { get; set; }
        public string Type { get; set; }
        [DataMember(Name = "metadata_created")]
        public DateTime? DateModified { get; set; }
        [DataMember(Name = "metadata_modified")]
        public DateTime? DateCreated { get; set; }
        [DataMember(Name = "notes")]
        public string Description { get; set; }
        [DataMember(Name = "license_title")]
        public string License { get; set; }
        [DataMember(Name = "tags")]
        public IEnumerable<CKANTag> Tags { get; set; }
        [DataMember(Name = "resources")]
        public IEnumerable<CKANResource> Resources { get; set; }
    }
}

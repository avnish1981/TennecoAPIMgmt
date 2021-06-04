using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennecoAPIMgmt.Repositories
{
    public class factoryRepository
    {
        public int factoryId { get; set; }
        public string factoryName { get; set; }
        public string location { get; set; }
        public string factoryType { get; set; }
    }
}
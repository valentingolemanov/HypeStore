using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetwearStore.Web.ViewModels.Collections
{
    public class CollectionReqestDTO
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool HomeDisplay { get; set; }

        public int DisplayRows { get; set; }

        public int DisplayCols { get; set; }

        public int DisplayPositionIndex { get; set; }
    }
}

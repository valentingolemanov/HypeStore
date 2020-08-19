using System;
using System.Collections.Generic;
using System.Text;

namespace StreetwearStore.Data.Common
{
    public interface IAuditInfo
    {
        DateTime CreatedOn { get; set; }

        DateTime ModifiedOn { get; set; }
    }
}

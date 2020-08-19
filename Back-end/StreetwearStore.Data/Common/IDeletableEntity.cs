using System;
using System.Collections.Generic;
using System.Text;

namespace StreetwearStore.Data.Common
{
    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}

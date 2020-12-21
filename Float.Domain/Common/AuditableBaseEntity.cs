using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Domain.Common
{
   public abstract class AuditableBaseEntity
    {
        public virtual int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedby { get; set; }
        public DateTime LastModified { get; set; }

    }
}

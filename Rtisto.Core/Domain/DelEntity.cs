using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rtisto.Core.Domain
{
    public class DelEntity
    {
        [Column("IsDeleted")]
        public bool IsDeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rtisto.Core.Domain
{
    [Table("ArtistCategory")]
    public class ArtistCategory : DelEntity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("IsActive")]
        public bool IsActive { get; set; }
    }
}

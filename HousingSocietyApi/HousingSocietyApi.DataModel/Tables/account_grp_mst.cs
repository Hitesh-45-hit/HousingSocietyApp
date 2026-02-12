using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSocietyApi.DataModel.Tables
{
    public class account_grp_mst
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int agm_id { get; set; }

        [Required]
        [StringLength(1)]
        public string account_head { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string account_group_name { get; set; } = string.Empty;

        [StringLength(100)]
        public string? account_group_desc { get; set; }

        [Required]
        public int printing_sr { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSocietyApi.DataModel.Tables
{
    public class install_mst
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int i_id { get; set; }

        [StringLength(50)]
        public string? i_name { get; set; }

        [StringLength(50)]
        public string? i_addr1 { get; set; }

        [StringLength(50)]
        public string? i_addr2 { get; set; }

        [StringLength(30)]
        public string? i_city { get; set; }

        [StringLength(30)]
        public string? i_dist { get; set; }

        [StringLength(10)]
        public string? i_pin { get; set; }

        [StringLength(20)]
        public string? i_contact_no_1 { get; set; }

        [StringLength(20)]
        public string? i_contact_no_2 { get; set; }

        [StringLength(50)]
        public string? i_email { get; set; }

        [StringLength(1)]
        public string? i_type { get; set; }

        [StringLength(50)]
        public string? i_region { get; set; }
    }
}

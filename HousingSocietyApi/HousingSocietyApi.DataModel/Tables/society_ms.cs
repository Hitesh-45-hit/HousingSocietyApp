using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSocietyApi.DataModel.Tables
{
    public class society_ms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int soc_id { get; set; }

        [Required]
        public int dealer_id { get; set; }

        [Required]
        [StringLength(100)]
        public string soc_name { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string soc_reg_no { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string soc_addr1 { get; set; } = string.Empty;

        [StringLength(50)]
        public string? soc_addr2 { get; set; } // Unchecked NN in HeidiSQL

        [Required]
        [StringLength(50)]
        public string soc_city { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string soc_dist { get; set; } = string.Empty;

        [Required]
        [StringLength(10)]
        public string soc_pin { get; set; } = string.Empty;

        [Required]
        public DateTime trial_days_end_date { get; set; }

        [Required]
        [StringLength(1)]
        public string soc_active { get; set; } = "Y";

        // --- Permissions / Flags ---
        [Required][StringLength(1)] public string allow_masters { get; set; } = "N";
        [Required][StringLength(1)] public string allow_Accounts { get; set; } = "N";
        [Required][StringLength(1)] public string allow_Billing { get; set; } = "N";
        [Required][StringLength(1)] public string allow_managerials { get; set; } = "N";
        [Required][StringLength(1)] public string allow_admins { get; set; } = "N";
        [Required][StringLength(1)] public string allow_accessoriess { get; set; } = "N";
        [Required][StringLength(1)] public string allow_mobile_app { get; set; } = "N";
        [Required][StringLength(1)] public string allow_gate_keeper_app { get; set; } = "N";

        // --- Financial Configuration ---
        [Required]
        public DateTime accounting_start_date { get; set; }

        [Required] public int no_of_members { get; set; }
        [Required] public int interest_base { get; set; }
        [Required] public int type_of_interest { get; set; }
        [Required] public int grace_period { get; set; }
        [Required] public int rate_of_interest { get; set; }
        [Required] public int interest_charge_from { get; set; }

        // --- Contact & Tax Info ---
        [Required][StringLength(30)] public string society_emailid { get; set; } = string.Empty;
        [Required][StringLength(20)] public string society_phone_no { get; set; } = string.Empty;
        [Required][StringLength(20)] public string society_gst_no { get; set; } = string.Empty;
        [Required][StringLength(20)] public string society_pan_no { get; set; } = string.Empty;

        // --- Starting Document Numbers ---
        [Required] public int start_receipt_no { get; set; }
        [Required] public int start_voucher_no { get; set; }
        [Required] public int start_contra_no { get; set; }
        [Required] public int start_jv_no { get; set; }
        [Required] public int start_supp_bill_no { get; set; }
        [Required] public int start_bill_no { get; set; }

        // --- Logic Switches (CHAR 1) ---
        [Required][StringLength(1)] public string merge_supp_and_reg_bill_no { get; set; } = "N";
        [Required][StringLength(1)] public string merge_payments_voucher_no { get; set; } = "N";
        [Required][StringLength(1)] public string merge_opening_balance_for_bill { get; set; } = "N";
        [Required][StringLength(1)] public string show_supp_bill_amount_in_reg_bill { get; set; } = "N";
        [Required][StringLength(1)] public string auto_revision_of_bill_receipt { get; set; } = "N";
        [Required][StringLength(1)] public string advance_previous_Billing { get; set; } = "N";
        [Required][StringLength(1)] public string First_adjust { get; set; } = "N";
        [Required][StringLength(1)] public string show_cr_bal { get; set; } = "N";
        [Required][StringLength(1)] public string show_zero_bal_head_in_bill { get; set; } = "N";
        [Required][StringLength(1)] public string print_dealer_info { get; set; } = "N";
        [Required][StringLength(1)] public string show_hide_receipts_in_bill { get; set; } = "N";

        // --- Billing & Capital ---
        [Required] public int billing_type { get; set; }
        [Required] public int construction_cost { get; set; }
        [Required] public int authorised_share_capital { get; set; }
        [Required] public int no_of_shares { get; set; }
        [Required] public int per_share_amt { get; set; }

        [Required] public DateTime bill_date { get; set; }
        [Required] public int bill_format { get; set; }
        [Required] public DateTime due_date { get; set; }

        [Required][StringLength(20)] public string user_type { get; set; } = string.Empty;
        [Required] public int auditor_id { get; set; }
        [Required] public int billing_report { get; set; }
    }
}

using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwBranchEntity
    {
        public Int32 branch_id { get; set; }
        public Int32 company_id { get; set; }
        public String branch_code { get; set; }
        public String branch_name { get; set; }
        public Int32 branch_type { get; set; }
        public String branch_no { get; set; }
        public String billing_address { get; set; }
        public String shipping_address { get; set; }
        public String contact_name { get; set; }
        public String phone { get; set; }
        public String email { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String branch_encrypt_id { get; set; }
    }
}
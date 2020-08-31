using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwCompanyEntity
    {
        public Int32 company_id { get; set; }
        public String company_code { get; set; }
        public String company_name { get; set; }
        public Int32 company_type { get; set; }
        public String tax_no { get; set; }
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
        public String company_encrypt_id { get; set; }
    }
}
using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwVendorEntity
    {
        public Int32 vendor_id { get; set; }
        public Int32 company_id { get; set; }
        public String vendor_code { get; set; }
        public Int32 vendor_type { get; set; }
        public String vendor_name { get; set; }
        public String vendor_phone { get; set; }
        public String vendor_email { get; set; }
        public String pickup_address { get; set; }
        public String tax_no { get; set; }
        public String billing_address { get; set; }
        public String shipping_address { get; set; }
        public String contact_name { get; set; }
        public String contact_phone { get; set; }
        public String contact_email { get; set; }
        public String partner_code { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String vendor_encrypt_id { get; set; }
    }
}
using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwClaimEntity
    {
        public Int32 claim_id { get; set; }
        public String claim_code { get; set; }
        public String claim_name { get; set; }
        public DateTime claim_date { get; set; }
        public String claim_machine_condition { get; set; }
        public String claim_repair_details { get; set; }
        public String claim_url_image { get; set; }
        public String serial { get; set; }
        public String sku { get; set; }
        public String customer_name { get; set; }
        public String customer_phone { get; set; }
        public String customer_id_cared { get; set; }
        public String customer_pickup_address { get; set; }
        public DateTime claim_start_date { get; set; }
        public DateTime claim_end_date { get; set; }
        public Int32 claim_period { get; set; }
        public Int32 claim_accessory { get; set; }
        public Boolean claim_equipment_rental { get; set; }
        public Boolean claim_delivery_product { get; set; }
        public Boolean claim_status { get; set; }
        public Int32 vendor_id { get; set; }
        public Int32 customer_id { get; set; }
        public Int32 company_id { get; set; }
        public Int32 branch_id { get; set; }
        public Int32 service_id { get; set; }
        public Int32 product_id { get; set; }
        public Int32 receipt_id { get; set; }
        public Int32 image_id { get; set; }
        public Int32 claim_check_id { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String claim_encrypt_id { get; set; }
    }
}
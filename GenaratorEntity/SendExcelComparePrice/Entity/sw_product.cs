using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwProductEntity
    {
        public Int32 product_id { get; set; }
        public Int32 company_id { get; set; }
        public Int32 model_id { get; set; }
        public Int32 brand_id { get; set; }
        public Int32 category_id { get; set; }
        public Int32 subcategory_id { get; set; }
        public String sku { get; set; }
        public String product_code { get; set; }
        public String product_name { get; set; }
        public Int32 product_type { get; set; }
        public Int32 uom { get; set; }
        public Decimal cost_price { get; set; }
        public Decimal min_price { get; set; }
        public Decimal sale_price { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_serial { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String product_encrypt_id { get; set; }
    }
}
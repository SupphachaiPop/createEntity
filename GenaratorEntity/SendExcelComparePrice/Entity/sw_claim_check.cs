using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwClaimCheckEntity
    {
        public Int32 check_id { get; set; }
        public DateTime chenk_date { get; set; }
        public String check_status { get; set; }
        public String serial { get; set; }
        public String sku { get; set; }
        public Int32 claim_id { get; set; }
        public String claim_code { get; set; }
        public Int32 product_id { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String check_encrypt_id { get; set; }
    }
}
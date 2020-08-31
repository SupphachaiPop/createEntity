using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwSubdistrictEntity
    {
        public Int32 sw_subdistrict_id { get; set; }
        public String sw_subdistrict_code { get; set; }
        public String sw_subdistrict_name { get; set; }
        public String postcode { get; set; }
        public Int32 geo_id { get; set; }
        public Int32 sw_province_id { get; set; }
        public String sw_subdistrict_encrypt_id { get; set; }
    }
}
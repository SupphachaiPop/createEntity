using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwDistrictEntity
    {
        public Int32 sw_district_id { get; set; }
        public String sw_district_code { get; set; }
        public String sw_district_name { get; set; }
        public Int32 sw_subdistrict_id { get; set; }
        public Int32 sw_province_id { get; set; }
        public Int32 geo_id { get; set; }
        public String sw_district_encrypt_id { get; set; }
    }
}
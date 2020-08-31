using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwProvinceEntity
    {
        public Int32 province_id { get; set; }
        public String province_code { get; set; }
        public String province_name { get; set; }
        public Int32 sw_geo_id { get; set; }
        public String province_encrypt_id { get; set; }
    }
}
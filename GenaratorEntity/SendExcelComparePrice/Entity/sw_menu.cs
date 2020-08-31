using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwMenuEntity
    {
        public Int32 menu_id { get; set; }
        public Int32 parent_menu_id { get; set; }
        public Int32 list_no { get; set; }
        public String menu_code { get; set; }
        public String menu_name { get; set; }
        public String menu_name_eng { get; set; }
        public Int32 menu_type { get; set; }
        public String url { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String menu_encrypt_id { get; set; }
    }
}
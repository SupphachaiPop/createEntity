using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwRoleItemEntity
    {
        public Int32 role_item_id { get; set; }
        public Int32 role_id { get; set; }
        public Int32 menu_id { get; set; }
        public Boolean is_display { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String role_item_encrypt_id { get; set; }
    }
}
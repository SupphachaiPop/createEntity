using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwSubcategoryEntity
    {
        public Int32 subcategory_id { get; set; }
        public Int32 category_id { get; set; }
        public Int32 company_id { get; set; }
        public String subcategory_code { get; set; }
        public String subcategory_name { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String subcategory_encrypt_id { get; set; }
    }
}
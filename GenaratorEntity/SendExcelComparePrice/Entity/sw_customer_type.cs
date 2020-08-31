using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwCustomerTypeEntity
    {
        public Int32 customer_type_id { get; set; }
        public String customer_type_name { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public Boolean is_referred { get; set; }
        public String customer_type_encrypt_id { get; set; }
    }
}
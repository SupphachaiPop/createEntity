using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwUserEntity
    {
        public Int32 user_id { get; set; }
        public Int32 company_id { get; set; }
        public Int32 branch_id { get; set; }
        public Int32 role_id { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String fullname { get; set; }
        public String email { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String user_encrypt_id { get; set; }
    }
}
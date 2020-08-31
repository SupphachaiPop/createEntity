using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwGoodsReturnEntity
    {
        public Int32 goods_return_id { get; set; }
        public Int32 company_id { get; set; }
        public Int32 branch_id { get; set; }
        public Int32 vendor_id { get; set; }
        public String goods_return_no { get; set; }
        public DateTime goods_return_date { get; set; }
        public String document_ref_no { get; set; }
        public DateTime document_ref_date { get; set; }
        public Int32 return_by { get; set; }
        public DateTime return_date { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String goods_return_encrypt_id { get; set; }
    }
}
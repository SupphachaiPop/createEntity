using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwGoodsReceiptEntity
    {
        public Int32 goods_receipt_id { get; set; }
        public Int32 company_id { get; set; }
        public Int32 branch_id { get; set; }
        public Int32 vendor_id { get; set; }
        public Int32 purchase_order_id { get; set; }
        public String goods_receipt_no { get; set; }
        public DateTime goods_receipt_date { get; set; }
        public String delivery_order_no { get; set; }
        public DateTime delivery_order_date { get; set; }
        public Int32 receipt_by { get; set; }
        public DateTime receipt_date { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String goods_receipt_encrypt_id { get; set; }
    }
}
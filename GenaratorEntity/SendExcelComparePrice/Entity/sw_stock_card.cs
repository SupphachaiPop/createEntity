using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwStockCardEntity
    {
        public Int32 stock_card_id { get; set; }
        public Int32 company_id { get; set; }
        public Int32 branch_id { get; set; }
        public Int32 stock_cost_id { get; set; }
        public Int32 transaction_type_id { get; set; }
        public Int32 document_id { get; set; }
        public String document_no { get; set; }
        public DateTime document_date { get; set; }
        public Int32 product_id { get; set; }
        public Decimal qty { get; set; }
        public Decimal unit_price { get; set; }
        public Decimal total_price { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String stock_card_encrypt_id { get; set; }
    }
}
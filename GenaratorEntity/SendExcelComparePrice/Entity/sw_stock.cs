using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwStockEntity
    {
        public Int32 stock_id { get; set; }
        public Int32 company_id { get; set; }
        public Int32 branch_id { get; set; }
        public Int32 stock_card_id { get; set; }
        public Int32 product_id { get; set; }
        public Decimal on_hand_qty { get; set; }
        public Decimal transfer_qty { get; set; }
        public Decimal available_qty { get; set; }
        public String serial { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String stock_encrypt_id { get; set; }
    }
}
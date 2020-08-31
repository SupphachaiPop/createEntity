using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class TransferOutItemEntity
    {
        public Int32 transfer_out_item_id { get; set; }
        public Int32 transfer_out_id { get; set; }
        public Int32 seq_no { get; set; }
        public Int32 product_id { get; set; }
        public String product_name { get; set; }
        public Boolean is_serial_control { get; set; }
        public Int32 uom_id { get; set; }
        public Decimal qty { get; set; }
        public String serial { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String transfer_out_item_encrypt_id { get; set; }
    }
}
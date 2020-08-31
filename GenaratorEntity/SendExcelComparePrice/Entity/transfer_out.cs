using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class TransferOutEntity
    {
        public Int32 transfer_out_id { get; set; }
        public Int32 company_id { get; set; }
        public Int32 branch_id { get; set; }
        public Int32 branch_dest_id { get; set; }
        public String shipping_address { get; set; }
        public Int32 logistic_id { get; set; }
        public String awb_no { get; set; }
        public String transfer_out_no { get; set; }
        public DateTime transfer_out_date { get; set; }
        public String document_ref_no { get; set; }
        public DateTime document_ref_date { get; set; }
        public Int32 document_status { get; set; }
        public DateTime document_status_date { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String transfer_out_encrypt_id { get; set; }
    }
}
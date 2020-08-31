using System;
using Entity;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class SwRunningNumberItemEntity
    {
        public Int32 running_number_item_id { get; set; }
        public Int32 running_number_id { get; set; }
        public Int32 company_id { get; set; }
        public Int32 branch_id { get; set; }
        public String prefix { get; set; }
        public String formatdate { get; set; }
        public Int32 padding { get; set; }
        public Int32 current_number { get; set; }
        public Int32 current_month { get; set; }
        public Int32 current_year { get; set; }
        public String comment { get; set; }
        public Int32 created_by { get; set; }
        public DateTime created_date { get; set; }
        public Int32 modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public Boolean is_referred { get; set; }
        public Boolean is_active { get; set; }
        public Boolean is_deleted { get; set; }
        public String running_number_item_encrypt_id { get; set; }
    }
}
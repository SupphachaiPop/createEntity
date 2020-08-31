using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenaratorEntity.Model
{
    public class RESULT_SENDGRID_EMAIL
    {
        public bool IS_SUCCESS { get; set; }
        public int STATUS_CODE { get; set; }
        public string MESSAGE { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DraftMessage
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string SenderMail { get; set; }

        [StringLength(50)]
        public string ReceiverMail { get; set; }
        [StringLength(100)]
        public string Subject { get; set; }

        public string MessageContent { get; set; }

        public DateTime SentDate { get; set; }
        public bool Deleted { get; set; }
    }
}

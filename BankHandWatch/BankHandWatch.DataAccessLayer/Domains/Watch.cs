﻿using BankHandWatch.DataAccessLayer.Domains.Common.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHandWatch.DataAccessLayer.Domains
{
    public class Watch : BaseEntityNoIdentity
    {
        public string Color { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime ExpireTime { get; set; }
    }
}

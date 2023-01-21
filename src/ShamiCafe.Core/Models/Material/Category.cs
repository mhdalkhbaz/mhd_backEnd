﻿using ShamiCafe.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamiCafe.Models.Material
{
    public class Category : AuditableEntity<int>
    {
        public string Name { get; set; }
        public ICollection<Material> Materials { get; set; }
    }
}

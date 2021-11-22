using System;
using System.Collections.Generic;

namespace Capstone_API.Models
{
    public partial class Medicine
    {
        public int MedicineId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Category_Name { get; set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StickersSystem.Models
{
    public class PrintModel
    {
        public DateTime FillDate { get; set; } = DateTime.Now;

        public DateTime ProductionDate { get; set; } = DateTime.Now;

        public DateTime ExpiryDate { get; set; } = DateTime.Now;
    }
}

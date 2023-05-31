using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenMabelProject.Entity.DtoS.Finanss
{
    public class FinanceDayDto
    {
        public int NewOrder { get; set; }
        public DateTime Date { get; set; }
        public int TotalOrder { get; set; }
        public double TotalPrice { get; set; }
    }
}

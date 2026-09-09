using System;
using System.Collections.Generic;
using System.Text;

namespace P01AplikacjaNBP_WPF.Client.Models
{
    internal class CurrencyTable
    {            
        public string Table { get; set; }
        public string No { get; set; }
        public string EffectiveDate { get; set; }
        public List<Rate> Rates { get; set; }
    }
}

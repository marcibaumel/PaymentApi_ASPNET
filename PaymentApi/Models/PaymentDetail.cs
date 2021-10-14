using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetilId { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string ExperitonDFate { get; set; }
        public string SecurityCode { get; set; }
    }
}

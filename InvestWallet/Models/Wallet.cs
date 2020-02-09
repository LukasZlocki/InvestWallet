using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InvestWallet.Models
{
    public class Wallet
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Wallet name")]
        [Required]
        public string description { get; set; }

        [Required]
        [Display(Name="Capital")]
        public double InitialCapital { get; set; }

        //reference to transactions
        [Required]
        [Display(Name="Transaction")]
        public int TransactionId { get; set; }

        [ForeignKey("TransactionId")]
        public virtual Transaction Transaction { get; set; }

    }
}

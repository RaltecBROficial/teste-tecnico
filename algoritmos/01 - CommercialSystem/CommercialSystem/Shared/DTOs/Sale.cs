using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommercialSystem.Shared.DTOs
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public decimal VlrAmount { get; set; }

        public List<string> lstProductInform { get; set; } = new List<string>();

        // Uma venda pode ter vários itens de venda
        public List<SaleItem> SaleItems { get; set; } = new List<SaleItem>();
    }
}

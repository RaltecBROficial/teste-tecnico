using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialSystem.Shared.Entitys
{
    [Table("PRD_PRODUCT")]
    public class PRD_PRODUCT
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; } = string.Empty;

        [Column("PRICE_UNIT")]
        public decimal PriceUnit { get; set; }

        // Um produto pode ser vendido em vários itens de venda
        public List<SLI_SALEITEM> SaleItems { get; set; } = new List<SLI_SALEITEM>();
    }
}

using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommercialSystem.Shared.Entitys
{
    [Table("SL_SALE")]
    public class SL_SALE
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("DT_SALE")]
        public DateTime DateSale { get; set; }

        [Column(name: "VLR_AMOUNT", TypeName = "decimal(10, 2)")]
        public decimal VlrAmount { get; set; }

        // Uma venda pode ter vários itens de venda
        public Collection<SLI_SALEITEM> SaleItems { get; set; } = new Collection<SLI_SALEITEM>();
    }
}

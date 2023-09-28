using System.ComponentModel.DataAnnotations.Schema;

namespace CommercialSystem.Shared.Entitys
{
    [Table("SLI_SALEITEM")]
    public class SLI_SALEITEM
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("SL_ID")]
        public int SaleId { get; set; }
        public SL_SALE? Sale { get; set; }


        [Column("PRD_ID")]
        public int ProductId { get; set; }
        public PRD_PRODUCT? Product { get; set; }

        [Column("QTD_PRD")]
        public int QtdProduct { get; set; }

        [Column(name: "VLR_SUB", TypeName = "decimal(10, 2)")]
        public decimal VlrSubtotal { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerApp.Model.EntityModel
{
    [Table("Models", Schema = "Pricing")]
    public class Models
    {
        [Key]
        [Column("Modelid")]
        public int ModelId { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Default value can't be set via attribute

        public bool IsActive { get; set; } = true; // Default handled in code, not via attribute

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string? ModifiedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}

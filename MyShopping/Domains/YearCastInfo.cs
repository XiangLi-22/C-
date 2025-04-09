using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Maticsoft.Model
{
    [Table("YearCastInfo")]
    public partial class YearCastInfo
    {
        public YearCastInfo()
        { }
        #region Model
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Moth { get; set; }

        [Required]
        public float Cast { get; set; }

        [Required]
        public DateTime CurrentTime { get; set; }
        #endregion Model

    }
}


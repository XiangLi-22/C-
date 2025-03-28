using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace Maticsoft.Model
{
    [Table("DayCastInfo")]
    public partial class DayCastInfo
    {
        public DayCastInfo() { }
        #region Model
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("GoodsName", TypeName = "varchar"),StringLength(20)]
        public string GoodsName { get; set; }

        [Required]
        //1. 食物
        //2. 衣服
        //3. 电器
        //4. 日用品
        //5. 出行
        public int GoodsType { get; set; }

        [Required]
        public float GoodsPrice { get; set; }

        [Required]
        public float DaysCast { get; set; }

        [Required]
        public float TotalRemain { get; set; }


        [Required]
        public DateTime CurrentTime {  get; set; }= DateTime.Now;

        public int State { get; set; } = 0;
        #endregion Model

    }
}


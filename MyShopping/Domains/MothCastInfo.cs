using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Maticsoft.Model
{
    [Table("MothCastInfo")]
    public partial class MothCastInfo
    {
        public MothCastInfo()
        { }
        #region Model
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        //下面的每一种类型的价格都可以查看具体消费的价格,时间,名字(待定) ,代码太多
        [Required]
        public float FoodPrice { get; set; }

        [Required]
        public float ClothPrice { get; set; }

        [Required]
        public float ElectricalPrice { get; set; }

        [Required]
        public float DailyPrice { get; set; }

        [Required]
        public float TravelPrice { get; set; }

        [Required]
        public float TotalRemain { get; set; }

        
        #endregion Model

    }
}


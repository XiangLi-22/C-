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
        public float FoodPrice { get; set; } = 0;  //餐饮

        [Required]
        public float ClothPrice { get; set; } = 0;   //服饰

        [Required]
        public float DailyPrice { get; set; } = 0; //日用

        [Required]
        public float ElectricalPrice { get; set; } = 0; //电器

        [Required]
        public float SkincarePrice { get; set; } = 0; // 护肤

        [Required]
        public float HousePrice { get; set; } = 0; // 住房

        [Required]
        public float TranPrice { get; set; } = 0;  // 交通

        [Required]
        public float EntertainmentPrice { get; set; } = 0; // 娱乐

        [Required]
        public float MedicalPrice { get; set; } = 0; // 医疗

        [Required]
        public float CommunicaPrice { get; set; } = 0; // 通讯

        [Required]
        public float SportPrice { get; set; } = 0; // 运动

        [Required]
        public float SocialPrice { get; set; } = 0; // 社交

        [Required]
        public float RelationshipPrice { get; set; } = 0; // 人情

        [Required]
        public float PetPrice { get; set; } = 0; // 宠物

        [Required]
        public float TravelPrice { get; set; } = 0; // 旅行

        [Required]
        public float LotteryPrice { get; set; } = 0; // 彩票

        [Required]
        public float CarPrice { get; set; } = 0; // 汽车

        [Required]
        public float ParenPrice { get; set; } = 0; // 育儿

        [Required]
        public float TotalRemain { get; set; }

        [Required]
        public DateTime CurrentTime { get; set; }

        
        #endregion Model

    }
}


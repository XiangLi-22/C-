using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepler
{
    /// <summary>
    /// 这个类用于将消费类型和每月消费映射
    /// </summary>
    public static class GoodsTypeExtensions
    {
        private static readonly Dictionary<GoodsType, string> FieldNameMap = new Dictionary<GoodsType, string> ()
        {
            { GoodsType.餐饮, "FoodPrice" },
            { GoodsType.服饰, "ClothPrice" },
            { GoodsType.日用, "DailyPrice" },
            { GoodsType.数码, "ElectricalPrice" },
            { GoodsType.护肤, "SkincarePrice" },
            { GoodsType.住房, "HousePrice" },
            { GoodsType.交通, "TranPrice" },
            { GoodsType.娱乐, "EntertainmentPrice" },
            { GoodsType.医疗, "MedicalPrice" },
            { GoodsType.通讯, "CommunicaPrice" },
            { GoodsType.运动, "SportPrice" },
            { GoodsType.社交, "SocialPrice" },
            { GoodsType.人情, "RelationshipPrice" },
            { GoodsType.宠物, "PetPrice" },
            { GoodsType.旅行, "TravelPrice" },
            { GoodsType.彩票, "LotteryPrice" },
            { GoodsType.汽车, "CarPrice" },
            { GoodsType.育儿, "ParenPrice" },
        };

        public static string GetMonthlyFieldName(this GoodsType type)
        {
            return FieldNameMap.TryGetValue(type, out var fieldName) ? fieldName : null;
        }
    }

}

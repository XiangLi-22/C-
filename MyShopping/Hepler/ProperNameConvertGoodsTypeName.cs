using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepler
{
    public static class ProperNameConvertGoodsTypeName
    {
        private static readonly Dictionary<string, string> FieldNameMap = new Dictionary<string, string>()
        {
            { "FoodPrice"," 餐饮" },
            { "ClothPrice" ,"服饰"},
            { "DailyPrice","日用" },
            { "ElectricalPrice" ,"数码"},
            { "SkincarePrice","护肤" },
            { "HousePrice" ,"住房"},
            { "TranPrice" ,"交通"},
            { "EntertainmentPrice","娱乐" },
            { "MedicalPrice","医疗" },
            { "CommunicaPrice","通讯" },
            { "SportPrice" ,"运动"},
            { "SocialPrice","社交" },
            { "RelationshipPrice","人情" },
            { "PetPrice" ,"宠物"},
            { "TravelPrice" ,"旅行"},
            { "LotteryPrice","彩票" },
            { "CarPrice" ,"汽车"},
            { "ParenPrice","育儿" },
        };

        public static string GetPropName(string propName)
        {
            return FieldNameMap.TryGetValue(propName, out var name) ? name : null;
        }
    }
}

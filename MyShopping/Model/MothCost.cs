using System;
namespace Maticsoft.Model
{
    /// <summary>
    /// MothCost:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MothCost
    {
        public MothCost()
        { }
        #region Model
        private int _id;
        private DateTime _time;
        private float _foodprice;
        private float _clothprice;
        private float _electricalprrice;
        private float _dailyprice;
        private float _travelprice;
        private float _totalremain;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Time
        {
            set { _time = value; }
            get { return _time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float FoodPrice
        {
            set { _foodprice = value; }
            get { return _foodprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float ClothPrice
        {
            set { _clothprice = value; }
            get { return _clothprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float ElectricalPrrice
        {
            set { _electricalprrice = value; }
            get { return _electricalprrice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float DailyPrice
        {
            set { _dailyprice = value; }
            get { return _dailyprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float TravelPrice
        {
            set { _travelprice = value; }
            get { return _travelprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float TotalRemain
        {
            set { _totalremain = value; }
            get { return _totalremain; }
        }
        #endregion Model

    }
}


using System;
namespace Maticsoft.Model
{
    /// <summary>
    /// DayCost:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class DayCost
    {
        public DayCost()
        { }
        #region Model
        private int _id;
        private string _goodname;
        private int _type;
        private float _price;
        private DateTime _time;
        private float _totalremain;
        private float _dayscost = 0f;
        private bool _state = false;
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
        public string GoodName
        {
            set { _goodname = value; }
            get { return _goodname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float price
        {
            set { _price = value; }
            get { return _price; }
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
        public float TotalRemain
        {
            set { _totalremain = value; }
            get { return _totalremain; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float DaysCost
        {
            set { _dayscost = value; }
            get { return _dayscost; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool state
        {
            set { _state = value; }
            get { return _state; }
        }
        #endregion Model

    }
}


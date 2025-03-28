using System;
namespace Maticsoft.Model
{
    /// <summary>
    /// YearCost:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class YearCost
    {
        public YearCost()
        { }
        #region Model
        private int _id;
        private int _moth;
        private float _cost;
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
        public int Moth
        {
            set { _moth = value; }
            get { return _moth; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float Cost
        {
            set { _cost = value; }
            get { return _cost; }
        }
        #endregion Model

    }
}


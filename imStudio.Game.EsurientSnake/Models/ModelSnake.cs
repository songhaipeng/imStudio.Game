using System.Collections.Generic;
using System.Drawing;

namespace imStudio.Game.EsurientSnake.Models
{
    /// <summary>
    /// 格子实体
    /// </summary>
    public class ModelElement
    {
        /// <summary>
        /// 横坐标
        /// </summary>
        public int Abscissa { get; set; }
        /// <summary>
        /// 纵坐标
        /// </summary>
        public int Ordinate { get; set; }
        /// <summary>
        /// 奖励属性
        /// </summary>
        public bool Bonus { get; set; }
        /// <summary>
        /// 初始化格子
        /// </summary>
        public ModelElement()
        {
            Abscissa = 0;
            Ordinate = 0;
            Bonus = false;
        }
    }

    /// <summary>
    /// 蛇身实体
    /// </summary>
    public class ModelSnake
    {
        /// <summary>
        /// 移动速度
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// 蛇身颜色
        /// </summary>
        public Color Color { get; set; }
        /// <summary>
        /// 运动方向
        /// </summary>
        public ModelEnum.Direction Direction { get; set; }
        /// <summary>
        /// 蛇身格子实体结合
        /// </summary>
        public List<ModelElement> Body { get; set; }
    }

    /// <summary>
    /// 地图格子大小属性实体
    /// </summary>
    public class ModelBox
    {
        /// <summary>
        /// 格子宽度
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// 格子高度
        /// </summary>
        public int Height { get; set; }
    }

    /// <summary>
    /// 地图视图
    /// </summary>
    public class ModelMap
    {
        /// <summary>
        /// 行数
        /// </summary>
        public int Row { get; set; }
        /// <summary>
        /// 列数
        /// </summary>
        public int Column { get; set; }
        /// <summary>
        /// 棋盘纹路颜色
        /// </summary>
        public Color Line { get; set; }
        /// <summary>
        /// 棋盘格子颜色
        /// </summary>
        public Color Color { get; set; }
        /// <summary>
        /// 棋盘格子大小
        /// </summary>
        public ModelBox Box { get; set; }
        /// <summary>
        /// 棋盘格子实体集合
        /// </summary>
        public List<ModelElement> Body { get; set; }
    }
}

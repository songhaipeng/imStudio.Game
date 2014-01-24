using System.Collections.Generic;
using System.Drawing;
using imStudio.Game.EsurientSnake.Models;

namespace imStudio.Game.EsurientSnake.Librarys
{
    public class SnakeHelper
    {
        public static ModelSnake GenSnake(int speed, Color color)
        {
            return new ModelSnake
                {
                    Color = color,
                    Speed = speed,
                    Direction = ModelEnum.Direction.Down,
                    Body = new List<ModelElement>
                        {
                            new ModelElement
                                {
                                    Abscissa = 0,
                                    Ordinate = 0
                                }
                        }
                };
        }
    }
}

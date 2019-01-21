using myGame1.Maps;
using myGame1.Characters;
using myGame1;
using System.Collections.Generic;

namespace myGame1.CheckPoints
{
    /// <summary>
    /// 关卡设置
    /// </summary>
    public class CheckPoint
    {
        // 因为Map中的x,y为最大边界
        // 所以在这个类里面,将大小减一
        // 方便在里面直接填充内容
        const int x = Map.BoundaryX - 2;
        const int y = Map.BoundaryY - 2;

        StMyPos pos;

        Dictionary<StMyPos, char> d = new Dictionary<StMyPos, char>();
        // CharacterProtagonist cp;
        // public CheckPoint(CharacterProtagonist cp)
        // {
        //     // 初始化玩家
        //     this.cp = cp;
        // }

        public Dictionary<StMyPos, char> CheckPoint1()
        {
            // cp.Pos.y = y;
            // cp.Pos.x = 5;

            for (int i = 1; i < x; i++)
            {
                for (int j = 1; j < y; j++)
                {
                    if ( i + j == 5)
                    {
                        pos.x = i;
                        pos.y = j;
                        d[pos] = '☆';
                    }
                }
            }

            return d;
        }
    }
}
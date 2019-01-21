using System;
using System.Collections.Generic;

using myGame1;
using myGame1.Characters;

namespace myGame1.Maps
{
    public class Map
    {
        /// <summary>
        /// 根据测试,这个console是按照左上角为(0, 0)点
        /// 格式为 maps[height, width]
        /// </summary>

        public const byte BoundaryX = 20;
        public const byte BoundaryY = 20;

        public char[,] maps = new char[BoundaryX, BoundaryY];
        // public ConsoleColor[,] color_buffer = new ConsoleColor[width, height];

        public void BoundaryMap()//地图边界填充
        {
            for (int i = 0; i < BoundaryX; i++)
            {
                maps[i, 0] = '█';
                maps[0, i] = '█';
                maps[BoundaryX - 1, i] = '█';
                maps[i, BoundaryX - 1] = '█';

                // maps[i, 0] = '1';
                // maps[0, i] = '2';
                // maps[BoundaryX - 1, i] = '3';
                // maps[i, BoundaryX - 1] = '4';
                
            }
        }

        public void Print()//打印地图
        {
            Console.Clear();
            for (int i = 0; i < BoundaryX; i++)
            {
                for (int j = 0; j < BoundaryY; j++)
                {
                    // 默认cmd中,字符不等宽,所以添加一个空格使之等宽
                    if (j == (BoundaryX - 1))
                    {
                        Console.Write(maps[i, j]);
                        Console.WriteLine(" ");
                        break;
                    }
                    
                    if (maps[i, j] == char.MinValue)
                        System.Console.Write("  ");
                    else
                        Console.Write(maps[i, j]);
                }
            }
        }
        
        public void Update(Dictionary<StMyPos, char> mid_d)
        {
            foreach (var i in mid_d)
            {
                maps[i.Key.x, i.Key.y] = i.Value;
            }
        }

        public void Update(StMyPos pos, CharacterProtagonist player)
        {
            if ((pos.x < (BoundaryX - 1)) && (pos.y < (BoundaryY - 1)) && ((pos.x * pos.y) != 0) )
            {
                // System.Console.WriteLine($"{pos.x}, {pos.y}");
                maps[player.Pos.x, player.Pos.y] = char.MinValue;
                player.Pos = pos;
                maps[pos.x, pos.y] = player.Name;
            }
        }

        public bool CheckNextStepStatus(StMyPos pos)
        {
            // 检查下一步的活动, 行动, 打怪, 拾取等
            var nextStep = maps[pos.x, pos.y];

            // switch(nextStep) 
            // {
                // case (char)AllTypes.road.ToString():
                    // System.Console.WriteLine("可走");
                    // break;
            // }

            if (maps[pos.x, pos.y] != char.MinValue)
                return true;
            else
                return false;
        }
    }
}
using System;

namespace myGame1.interfaces
{
    public interface IMoveBehavior
    {
         StMyPos MoveBehavior(StMyPos pos);
    }

    // 一次一格
    public class MoveOneStep : IMoveBehavior
    {
        ConsoleKeyInfo key;
        public StMyPos MoveBehavior(StMyPos pos)
        {
            key = Console.ReadKey();
            
            if (key.Key == ConsoleKey.UpArrow)//获取输入，并改变玩家的坐标
            {
                pos.x -= 1;
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                pos.x += 1;
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                pos.y -= 1;
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                pos.y += 1;
            }

            return pos;
        }
    }

    // 不移动
    public class MoveZeroStep : IMoveBehavior
    {
        public StMyPos MoveBehavior(StMyPos pos)
        {
            // throw new System.NotImplementedException();
            return pos;
        }
    }
}
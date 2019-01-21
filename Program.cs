using System;
using System.Collections.Generic;

using myGame1.Characters;
using myGame1.Maps;
using myGame1.CheckPoints;

namespace myGame1
{
    /// <summary>
    /// 一个关于控制台游戏的程序
    /// https://zhuanlan.zhihu.com/p/32462890
    /// 学习编程的好方法——控制台游戏
    /// 类型: 解谜;RPG
    /// 例子中,模仿魔塔进行开发
    /// 主要目的是熟悉Concole下的开发流程
    /// </summary>   
    class Program
    {

        // 定义场景的宽度
        const int width = 20;
        // 定义场景的宽度
        const int heigth = 20;

        // public static List<Container> element = new List<Container>();




        static void Main(string[] args)
        {

            StartGame();
            // CharacterProtagonist cp = new CharacterProtagonist();
            // Console.WriteLine("Hello World!");
            // System.Console.WriteLine(cp.Name);
            // Map maps = new Map();
            // maps.BoundaryMap();
            // maps.Print();

            

            // cps.CheckPoint1();
        }

        static void StartGame()
        {
            CharacterProtagonist player = new CharacterProtagonist();
            // 初始化玩家位置
            player.Pos.x = Map.BoundaryY - 2;
            player.Pos.y = 5;

            Map mapCheckPoint1 = new Map();
            CheckPoint cp = new CheckPoint();

            // 添加勇者位置
            mapCheckPoint1.maps[player.Pos.x, player.Pos.y] = player.Name;
            // 添加边界
            mapCheckPoint1.BoundaryMap();
            // 根据cps传递过来的结果,对map进行更新
            mapCheckPoint1.Update(cp.CheckPoint1());
            // 画出地图
            // mapCheckPoint1.Print();

            while (true)
            {
                mapCheckPoint1.Print();
                var tmpPos = player.PerformMoveBeh();
                mapCheckPoint1.Update(tmpPos, player);
            }

        }
    }
}

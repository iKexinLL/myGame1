using System.Collections.Generic;
using myGame1.interfaces;

namespace myGame1
{
    public struct StMyPos
    {
        public int x;
        public int y;
    }

    public abstract class CommonProperty
    {
        // 对象名称
        public char Name; 
        // 对象类型
        // public AllTypes MyType;
        // 对象位置
        public StMyPos Pos;
        // 对象血量
        public int HpNum;
        // 对象是否可见,用于隐藏物品
        public bool IfSee;
        // 对象防御力
        public int DefenseNum;

        // 对象的攻击行为
        public IAttackBehavior AttackBeh;

        // 对象的移动行为
        public IMoveBehavior MoveBeh;

        public abstract StMyPos PerformMoveBeh();


    }
}
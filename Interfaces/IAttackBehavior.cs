namespace myGame1.interfaces
{
    public interface IAttackBehavior
    {
         void AttackBehavior();
    }

    // 一次攻击一下
    public class AttackOneTime : IAttackBehavior
    {
        void IAttackBehavior.AttackBehavior()
        {
            throw new System.NotImplementedException();
        }
    }

    // 无法攻击
    public class AttackZeroTime : IAttackBehavior
    {
        public void AttackBehavior()
        {
            throw new System.NotImplementedException();
        }
    }
}
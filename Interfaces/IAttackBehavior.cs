namespace myGame1.interfaces
{
    public interface IAttackBehavior
    {
         void AttackBehavior();
    }

    // һ�ι���һ��
    public class AttackOneTime : IAttackBehavior
    {
        void IAttackBehavior.AttackBehavior()
        {
            throw new System.NotImplementedException();
        }
    }

    // �޷�����
    public class AttackZeroTime : IAttackBehavior
    {
        public void AttackBehavior()
        {
            throw new System.NotImplementedException();
        }
    }
}
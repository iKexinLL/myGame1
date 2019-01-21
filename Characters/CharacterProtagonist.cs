using System.Collections.Generic;
using myGame1.interfaces;

namespace myGame1.Characters
{
    public class CharacterProtagonist : CommonProperty
    {
        public CharacterProtagonist()
        {
            Name = '勇';
            // MyType = AllTypes.protagonist;
            HpNum = 500;
            IfSee = true;
            DefenseNum = 20;
            InitializePlayer();
        }

        public void InitializePlayer()
        {
            AttackBeh = new AttackOneTime();
            MoveBeh = new MoveOneStep();            
        }

        public override StMyPos PerformMoveBeh() => MoveBeh.MoveBehavior(Pos);
    }
}
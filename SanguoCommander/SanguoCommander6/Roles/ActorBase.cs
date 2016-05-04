using System.Collections.Generic;
using cocos2d;

namespace SanguoCommander.Roles
{
    class ActorBase : CCSprite
    {
        public ActorData ActorData { get; private set; }
        private CCAnimate _action_attack;
        private CCAnimate _action_attack_flip;
        private CCAnimate _action_run;
        private CCAnimate _action_run_flip;
        private CCAnimate _action_stand;
        private CCAnimate _action_stand_flip;
        private CCAnimate _action_dead;
        private CCAnimate _action_dead_flip;
        public ActorDir ActorDir { get; set; }
        public ActorBase(ActorData data)
        {
            ActorData = data;
            //������������
            List<CCSpriteFrame> _attackFrames = new List<CCSpriteFrame>();
            List<CCSpriteFrame> _attackFrames_flip = new List<CCSpriteFrame>();
            for (int i = 0; i < 4; i++)
            {
                _attackFrames.Add(CCSpriteFrameCache.sharedSpriteFrameCache().spriteFrameByName(data.ActorID + "_" + i + ".png"));
                _attackFrames_flip.Add(CCSpriteFrameCache.sharedSpriteFrameCache().spriteFrameByName(data.ActorID + "f_" + i + ".png"));
            }
            _action_attack = CCAnimate.actionWithAnimation(CCAnimation.animationWithFrames(_attackFrames, 0.1f));
            _action_attack_flip = CCAnimate.actionWithAnimation(CCAnimation.animationWithFrames(_attackFrames_flip, 0.1f));
            //�������߶���
            List<CCSpriteFrame> _runFrames = new List<CCSpriteFrame>();
            List<CCSpriteFrame> _runFrames_flip = new List<CCSpriteFrame>();
            for (int i = 4; i < 6; i++)
            {
                _runFrames.Add(CCSpriteFrameCache.sharedSpriteFrameCache().spriteFrameByName(data.ActorID + "_" + i + ".png"));
                _runFrames_flip.Add(CCSpriteFrameCache.sharedSpriteFrameCache().spriteFrameByName(data.ActorID + "f_" + i + ".png"));
            }
            _action_run = CCAnimate.actionWithAnimation(CCAnimation.animationWithFrames(_runFrames, 0.1f));
            _action_run_flip = CCAnimate.actionWithAnimation(CCAnimation.animationWithFrames(_runFrames_flip, 0.1f));
            //����վ������
            List<CCSpriteFrame> _standFrames = new List<CCSpriteFrame>();
            List<CCSpriteFrame> _standFrames_flip = new List<CCSpriteFrame>();
            for (int i = 6; i < 7; i++)
            {
                _standFrames.Add(CCSpriteFrameCache.sharedSpriteFrameCache().spriteFrameByName(data.ActorID + "_" + i + ".png"));
                _standFrames_flip.Add(CCSpriteFrameCache.sharedSpriteFrameCache().spriteFrameByName(data.ActorID + "f_" + i + ".png"));
            }
            _action_stand = CCAnimate.actionWithAnimation(CCAnimation.animationWithFrames(_standFrames, 0.2f));
            _action_stand_flip = CCAnimate.actionWithAnimation(CCAnimation.animationWithFrames(_standFrames_flip, 0.2f));
            //������������
            List<CCSpriteFrame> _deadFrames = new List<CCSpriteFrame>();
            List<CCSpriteFrame> _deadFrames_flip = new List<CCSpriteFrame>();
            for (int i = 7; i < 9; i++)
            {
                _deadFrames.Add(CCSpriteFrameCache.sharedSpriteFrameCache().spriteFrameByName(data.ActorID + "_" + i + ".png"));
                _deadFrames_flip.Add(CCSpriteFrameCache.sharedSpriteFrameCache().spriteFrameByName(data.ActorID + "f_" + i + ".png"));
            }
            _action_dead = CCAnimate.actionWithAnimation(CCAnimation.animationWithFrames(_deadFrames, 0.3f));
            _action_dead_flip = CCAnimate.actionWithAnimation(CCAnimation.animationWithFrames(_deadFrames_flip, 0.3f));
            //��ʼ��Ĭ��֡
            base.initWithSpriteFrame(_standFrames[0]);
        }
        
        CCAction _currentAnimateAction;
        public void StateToRun()
        {
            if(ActorDir == Roles.ActorDir.Left)
                RunAnimateAction_RepeatForever(_action_run);
            else
                RunAnimateAction_RepeatForever(_action_run_flip);
        }
        //����״̬
        public void StateToAttack()
        {
            currentAnimateActionStop();
            if (ActorDir == Roles.ActorDir.Left)
                RunAnimateAction_RepeatForever(_action_attack);
            else
                RunAnimateAction_RepeatForever(_action_attack_flip);
        }
        //��������
        public void StateToDead()
        {
            currentAnimateActionStop();
            if (ActorDir == Roles.ActorDir.Left)
                _currentAnimateAction = runAction(_action_dead);
            else
                _currentAnimateAction = runAction(_action_dead_flip);
        }
        //վ������
        public void StateToStand()
        {
            if (ActorDir == Roles.ActorDir.Left)
                RunAnimateAction_RepeatForever(_action_stand);
            else
                RunAnimateAction_RepeatForever(_action_stand_flip);
            
            
        }
        //ֹͣ��ǰ�Ķ���
        private void currentAnimateActionStop()
        {
            if (_currentAnimateAction != null)
                this.stopAction(_currentAnimateAction);
        }
        //����ѭ��������ͳһ����
        private void RunAnimateAction_RepeatForever(CCAnimate action)
        {
            currentAnimateActionStop();
            _currentAnimateAction = runAction(CCRepeatForever.actionWithAction(action));
        }
    }
}

using System;
using System.Collections.Generic;

using cocos2d;

namespace SanguoCommander.UI
{
    public class LayerLevels : CCLayer
    {
        public LayerLevels()
        {
            //�ؿ�ѡ���
            CCPoint offset = new CCPoint(170, 180);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //�ؿ��İ�ť
                    CCMenuItemSprite level = CCMenuItemSprite.itemFromNormalSprite(
                        CCSprite.spriteWithSpriteFrameName("btn_level1.png"),
                        CCSprite.spriteWithSpriteFrameName("btn_level2.png"),
                        this, click_level);
                    CCMenu menu = CCMenu.menuWithItems(level);
                    //λ����������ϵ�UI����
                    menu.position = CCDirector.sharedDirector().convertToUI(new CCPoint(offset.x + 160 * i, offset.y + 85 * j));
                    this.addChild(menu);
                    //����һ��MenuItem�������ı�����
                    CCMenuItem menuitem = new CCMenuItem();
                    //ָ��Arial��������������֤fonts����Arial.spritefont
                    var text = CCLabelTTF.labelWithString((j * 4 + i + 1).ToString(), "Arial", 12);
                    //����ɫָ��Ϊ��ɫ
                    text.Color = new ccColor3B();
                    menuitem.addChild(text);
                    menu.addChild(menuitem);
                }
            }
        }
        private void click_level(CCObject sender)
        {
            //���ؿ������ʱ����Զ���ת����Ϸ����
            CCDirector.sharedDirector().pushScene(GameRoot.pSceneGame);
        }
        public void Show()
        {
            //������ʾ����
            this.visible = true;
            //��λ�����õ����ұ߳���Ļ��
            this.position = new CCPoint(CCDirector.sharedDirector().getWinSize().width,0);
            //ָ���ƶ���0��0��
            CCMoveTo move = CCMoveTo.actionWithDuration(0.5f,new CCPoint(0,0));
            //�������Action
            this.runAction(move);
        }
        public void Hide()
        {
            //ָ���ƶ�������߲�������Ļ
            CCMoveTo move = CCMoveTo.actionWithDuration(0.5f,new CCPoint(-CCDirector.sharedDirector().getWinSize().width,0));
            //ִ��һ��������Ϊ�����ƶ���ɺ�ͻ����HideAniCompled
            this.runAction(CCSequence.actionOneTwo(move, CCCallFunc.actionWithTarget(this, HideAniCompled)));
        }
        void HideAniCompled()
        {
            this.visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using cocos2d;

namespace SanguoCommander.Scenes
{
    public class SceneStart : CCScene
    {
        public SceneStart()
        {
            base.init();
            //ȡ����Ļ��С
            CCSize size = CCDirector.sharedDirector().getWinSize();
            //����ͼ
            CCSprite background = CCSprite.spriteWithSpriteFrameName("bg_start.png") ;
            background.anchorPoint = new CCPoint(0, 0);
            this.addChild(background);
            //Logoͼ
            CCSprite logo = CCSprite.spriteWithSpriteFrameName("logo.png");
            //���õ������м�ƫ��
            logo.position = new CCPoint(size.width / 2, size.height / 2 + 120);
            this.addChild(logo);
            //������ť
            CCMenuItemSprite btn_start = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("btn_start1.png"),
                CCSprite.spriteWithSpriteFrameName("btn_start2.png"), 
                this, click_start);
            CCMenuItemSprite btn_setting = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("btn_setting1.png"),
                CCSprite.spriteWithSpriteFrameName("btn_setting2.png"),
                this, click_setting);
            //MenuItem��Ҫͨ��CCMenu���
            CCMenu menu = CCMenu.menuWithItems(btn_start, btn_setting);
            //һ����ֱ�������
            menu.alignItemsVerticallyWithPadding(10);
            //���õ������м�ƫ��
            menu.position = new CCPoint(size.width / 2, size.height / 2 - 120);
            this.addChild(menu);
        }
        private void click_start(CCObject sender)
        {
            var s = CCTransitionFade.transitionWithDuration(0.5f, GameRoot.pSceneSelect);
            CCDirector.sharedDirector().pushScene(s);
        }
        private void click_setting(CCObject sender)
        {
        }
    }
}

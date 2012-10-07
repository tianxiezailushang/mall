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
            //取得屏幕大小
            CCSize size = CCDirector.sharedDirector().getWinSize();
            //背景图
            CCSprite background = CCSprite.spriteWithSpriteFrameName("bg_start.png") ;
            background.anchorPoint = new CCPoint(0, 0);
            this.addChild(background);
            //Logo图
            CCSprite logo = CCSprite.spriteWithSpriteFrameName("logo.png");
            //设置到界面中间偏上
            logo.position = new CCPoint(size.width / 2, size.height / 2 + 120);
            this.addChild(logo);
            //两个按钮
            CCMenuItemSprite btn_start = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("btn_start1.png"),
                CCSprite.spriteWithSpriteFrameName("btn_start2.png"), 
                this, click_start);
            CCMenuItemSprite btn_setting = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("btn_setting1.png"),
                CCSprite.spriteWithSpriteFrameName("btn_setting2.png"),
                this, click_setting);
            //MenuItem需要通过CCMenu组合
            CCMenu menu = CCMenu.menuWithItems(btn_start, btn_setting);
            //一个垂直间隔排列
            menu.alignItemsVerticallyWithPadding(10);
            //设置到界面中间偏下
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

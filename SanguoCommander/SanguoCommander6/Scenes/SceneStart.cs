using System;
using System.Collections.Generic;
using cocos2d;
using SanguoCommander.Roles;

namespace SanguoCommander.Scenes
{
    public class SceneStart : CCScene
    {
        public SceneStart()
        {
            base.init();
            #region SanguoCommander2
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
            #endregion
            
            //测试动画的角色
            List<string> id_buff = new List<string>()
            {
                "B1","B2","B3","B4","Hero02","A1","A2","A3","A4","Hero11"
            };
            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    var actor = new ActorBase(new ActorData(id_buff[i*5 + j]));
                    actor.ActorDir = (ActorDir)(i + 1);
                    actor.position = new CCPoint(64 + i * 64, 64 + j * 64);
                    //单数为站立动作，双数为攻击动作
                    if(j % 2 ==1)
                        actor.StateToRun();
                    else
                        actor.StateToAttack();
                    //添加角色
                    this.addChild(actor);
                }
            }
            //
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

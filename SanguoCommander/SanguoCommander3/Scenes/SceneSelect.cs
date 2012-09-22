using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace SanguoCommander.Scenes
{
    public class SceneSelect : CCScene
    {
        public SceneSelect()
        {
            base.init();
            //背景图
            CCSprite background = CCSprite.spriteWithSpriteFrameName("bg_select.png");
            background.anchorPoint = new CCPoint(0, 0);
            this.addChild(background);
            //返回按钮
            CCMenuItemSprite btn_back = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("btn_back1.png"),
                CCSprite.spriteWithSpriteFrameName("btn_back2.png"),
                this, click_back);
            CCMenu menu = CCMenu.menuWithItems(btn_back);
            menu.position = new CCPoint(666, 32);
            this.addChild(menu);
            //上面的Tab按钮
            CCSprite tab1 = CCSprite.spriteWithSpriteFrameName("tab_shu1.png");
            CCSprite tab2 = CCSprite.spriteWithSpriteFrameName("tab_wu2.png");
            CCSprite tab3 = CCSprite.spriteWithSpriteFrameName("tab_wei2.png");
            tab1.position = new CCPoint(115, 430);
            tab2.position = new CCPoint(335, 430);
            tab3.position = new CCPoint(575, 430);
            this.addChild(tab1);
            this.addChild(tab2);
            this.addChild(tab3);

            CCPoint offset = new CCPoint(150, 150);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    CCMenuItemSprite level = CCMenuItemSprite.itemFromNormalSprite(
                        CCSprite.spriteWithSpriteFrameName("btn_level1.png"),
                        CCSprite.spriteWithSpriteFrameName("btn_level2.png"),
                        this, click_level);
                    menu = CCMenu.menuWithItems(level);
                    menu.position = new CCPoint(offset.x + 160 * i, offset.y + 85 * j);
                    this.addChild(menu);
                }
            }
        }
        private void click_back(CCObject s)
        {
            CCDirector.sharedDirector().popScene();
        }
        private void click_level(CCObject sender)
        {
            CCDirector.sharedDirector().pushScene(GameRoot.pSceneGame);
        }
    }
}

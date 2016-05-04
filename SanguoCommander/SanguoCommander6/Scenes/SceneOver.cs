using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace SanguoCommander.Scenes
{
    public class SceneOver : CCScene
    {
        public SceneOver()
        {
            base.init();
            //±³¾°Í¼
            CCSprite background = CCSprite.spriteWithSpriteFrameName("bg_over.png");
            background.anchorPoint = new CCPoint(0, 0);
            this.addChild(background);
            //ÎÄ×Ö
            CCSprite title = CCSprite.spriteWithSpriteFrameName("text_over.png");
            title.position = new CCPoint(CCDirector.sharedDirector().getWinSize().width / 2, CCDirector.sharedDirector().getWinSize().height / 2 + 150);
            this.addChild(title);
            //·µ»Ø°´Å¥
            CCMenuItemSprite btn_back = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("btn_back1.png"),
                CCSprite.spriteWithSpriteFrameName("btn_back2.png"),
                this, click_back);
            CCMenu menu = CCMenu.menuWithItems(btn_back);
            menu.position = new CCPoint(666, 32);
            this.addChild(menu);
        }
        private void click_back(CCObject s)
        {
            CCDirector.sharedDirector().popScene();
        }
    }
}

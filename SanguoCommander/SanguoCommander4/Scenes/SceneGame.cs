
using cocos2d;

namespace SanguoCommander.Scenes
{
    public class SceneGame : CCScene
    {
        public SceneGame()
        {
            base.init();
            //±³¾°Í¼
            CCSprite background = CCSprite.spriteWithSpriteFrameName("bg_game.png");
            background.anchorPoint = new CCPoint(0, 0);
            this.addChild(background);
            //·µ»Ø°´Å¥
            CCMenuItemSprite btn_attack = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("btn_soldierattack1.png"),
                CCSprite.spriteWithSpriteFrameName("btn_soldierattack2.png"),
                this, click_attack);
            CCMenu menu = CCMenu.menuWithItems(btn_attack);
            menu.position = new CCPoint(732, 36);
            this.addChild(menu);
        }
        private void click_attack(CCObject sender)
        {
            CCDirector.sharedDirector().replaceScene(GameRoot.pSceneOver);
        }
    }
}

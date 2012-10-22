
using cocos2d;

namespace SanguoCommander.Scenes
{
    public class SceneGame : CCScene
    {
        public SceneGame()
        {
            base.init();
            //背景图
            //CCSprite background = CCSprite.spriteWithSpriteFrameName("bg_game.png");
            //background.anchorPoint = new CCPoint(0, 0);
            //this.addChild(background);
            //地图
            CCTMXTiledMap map = CCTMXTiledMap.tiledMapWithTMXFile("TileMaps/Level0");
            //map.removeChild(map.layerNamed("units"),false);
            //取得宽高
            CCSize size = CCDirector.sharedDirector().getWinSize();
            //保证地图是居中地图显示
            map.position = new CCPoint((size.width - map.contentSize.width) / 2, (size.height - map.contentSize.height)/2);
            this.addChild(map);
            //返回按钮
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

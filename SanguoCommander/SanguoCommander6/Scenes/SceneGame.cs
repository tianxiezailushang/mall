
using cocos2d;

namespace SanguoCommander.Scenes
{
    public class SceneGame : CCScene
    {
        public SceneGame()
        {
            base.init();
            //����ͼ
            //CCSprite background = CCSprite.spriteWithSpriteFrameName("bg_game.png");
            //background.anchorPoint = new CCPoint(0, 0);
            //this.addChild(background);
            //��ͼ
            CCTMXTiledMap map = CCTMXTiledMap.tiledMapWithTMXFile("TileMaps/Level0");
            //map.removeChild(map.layerNamed("units"),false);
            //ȡ�ÿ��
            CCSize size = CCDirector.sharedDirector().getWinSize();
            //��֤��ͼ�Ǿ��е�ͼ��ʾ
            map.position = new CCPoint((size.width - map.contentSize.width) / 2, (size.height - map.contentSize.height)/2);
            this.addChild(map);
            //���ذ�ť
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

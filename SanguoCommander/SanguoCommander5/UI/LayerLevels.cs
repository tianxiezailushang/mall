using System;
using System.Collections.Generic;

using cocos2d;

namespace SanguoCommander.UI
{
    public class LayerLevels : CCLayer
    {
        public LayerLevels()
        {
            //关卡选择层
            CCPoint offset = new CCPoint(170, 180);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //关卡的按钮
                    CCMenuItemSprite level = CCMenuItemSprite.itemFromNormalSprite(
                        CCSprite.spriteWithSpriteFrameName("btn_level1.png"),
                        CCSprite.spriteWithSpriteFrameName("btn_level2.png"),
                        this, click_level);
                    CCMenu menu = CCMenu.menuWithItems(level);
                    //位置相对于左上的UI界面
                    menu.position = CCDirector.sharedDirector().convertToUI(new CCPoint(offset.x + 160 * i, offset.y + 85 * j));
                    this.addChild(menu);
                    //创建一个MenuItem，用作文本内容
                    CCMenuItem menuitem = new CCMenuItem();
                    //指定Arial的字体描述，保证fonts里有Arial.spritefont
                    var text = CCLabelTTF.labelWithString((j * 4 + i + 1).ToString(), "Arial", 12);
                    //将颜色指定为黑色
                    text.Color = new ccColor3B();
                    menuitem.addChild(text);
                    menu.addChild(menuitem);
                }
            }
        }
        private void click_level(CCObject sender)
        {
            //当关卡点击的时候会自动跳转到游戏场景
            CCDirector.sharedDirector().pushScene(GameRoot.pSceneGame);
        }
        public void Show()
        {
            //将其显示出来
            this.visible = true;
            //把位置设置到最右边出屏幕外
            this.position = new CCPoint(CCDirector.sharedDirector().getWinSize().width,0);
            //指定移动到0，0点
            CCMoveTo move = CCMoveTo.actionWithDuration(0.5f,new CCPoint(0,0));
            //运行这个Action
            this.runAction(move);
        }
        public void Hide()
        {
            //指定移动到最左边并超出屏幕
            CCMoveTo move = CCMoveTo.actionWithDuration(0.5f,new CCPoint(-CCDirector.sharedDirector().getWinSize().width,0));
            //执行一个队列行为，当移动完成后就会调用HideAniCompled
            this.runAction(CCSequence.actionOneTwo(move, CCCallFunc.actionWithTarget(this, HideAniCompled)));
        }
        void HideAniCompled()
        {
            this.visible = false;
        }
    }
}

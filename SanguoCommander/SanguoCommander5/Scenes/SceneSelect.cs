using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;
using SanguoCommander.UI;

namespace SanguoCommander.Scenes
{
    public class SceneSelect : CCScene
    {
        CCMenu story_tabs;
        Dictionary<CCMenuItem, LayerLevels> dictLayerLevels = new Dictionary<CCMenuItem, LayerLevels>();
        LayerLevels currentlayerlevers = null;
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
            //上面的Tab按钮创建
            CCMenuItemSprite tab1 = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("tab_shu2.png"), 
                CCSprite.spriteWithSpriteFrameName("tab_shu1.png"),
                CCSprite.spriteWithSpriteFrameName("tab_shu1.png"), 
                this, click_story_tab);
            CCMenuItemSprite tab2 = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("tab_wu2.png"),
                CCSprite.spriteWithSpriteFrameName("tab_wu1.png"),
                CCSprite.spriteWithSpriteFrameName("tab_wu1.png"),
                this, click_story_tab);
            CCMenuItemSprite tab3 = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("tab_wei2.png"),
                CCSprite.spriteWithSpriteFrameName("tab_wei1.png"),
                CCSprite.spriteWithSpriteFrameName("tab_wei1.png"),
                this, click_story_tab);
            story_tabs = CCMenu.menuWithItems(tab1, tab2, tab3);
            //按照水平方向10个像素间隔分割
            story_tabs.alignItemsHorizontallyWithPadding(10);
            //转换为界面UI的坐标
            story_tabs.position = CCDirector.sharedDirector().convertToUI(new CCPoint(300, 72));
            //将第一个设置为不可点击
            tab1.Enabled = false;
            this.addChild(story_tabs);
            //添加测试层
            //this.addChild(new LayerLevels());
            //将标签对应到不同的LyerLevers 类中
            dictLayerLevels.Add(tab1, new LayerLevels() { visible = false });
            dictLayerLevels.Add(tab2, new LayerLevels() { visible = false });
            dictLayerLevels.Add(tab3, new LayerLevels() { visible = false });
            //将tab1显示为当前的关卡层
            showLayerLevels(dictLayerLevels[tab1]);
            //遍历并添加到界面中
            foreach (var item in dictLayerLevels.Values)
            {
                this.addChild(item);
            }
        }
        private void click_back(CCObject s)
        {
            CCDirector.sharedDirector().popScene();
        }
        
        private void click_story_tab(CCObject sender)
        {
            //遍历story_tabs
            foreach (var item in story_tabs.children)
            {
                //判断是否为CCMenuItem，如果是的话，排除sender以外的全部设定为true
                if(item is CCMenuItem)
                    (item as CCMenuItem).Enabled = item != sender;
            }
            showLayerLevels(dictLayerLevels[sender as CCMenuItem]);
        }
        private void showLayerLevels(LayerLevels layer)
        {
            if (currentlayerlevers != null)
                currentlayerlevers.Hide();
            layer.Show();
            currentlayerlevers = layer;
        }
    }
}

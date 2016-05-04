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
            //����ͼ
            CCSprite background = CCSprite.spriteWithSpriteFrameName("bg_select.png");
            background.anchorPoint = new CCPoint(0, 0);
            this.addChild(background);
            //���ذ�ť
            CCMenuItemSprite btn_back = CCMenuItemSprite.itemFromNormalSprite(
                CCSprite.spriteWithSpriteFrameName("btn_back1.png"),
                CCSprite.spriteWithSpriteFrameName("btn_back2.png"),
                this, click_back);
            CCMenu menu = CCMenu.menuWithItems(btn_back);
            menu.position = new CCPoint(666, 32);
            this.addChild(menu);
            //�����Tab��ť����
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
            //����ˮƽ����10�����ؼ���ָ�
            story_tabs.alignItemsHorizontallyWithPadding(10);
            //ת��Ϊ����UI������
            story_tabs.position = CCDirector.sharedDirector().convertToUI(new CCPoint(300, 72));
            //����һ������Ϊ���ɵ��
            tab1.Enabled = false;
            this.addChild(story_tabs);
            //��Ӳ��Բ�
            //this.addChild(new LayerLevels());
            //����ǩ��Ӧ����ͬ��LyerLevers ����
            dictLayerLevels.Add(tab1, new LayerLevels() { visible = false });
            dictLayerLevels.Add(tab2, new LayerLevels() { visible = false });
            dictLayerLevels.Add(tab3, new LayerLevels() { visible = false });
            //��tab1��ʾΪ��ǰ�Ĺؿ���
            showLayerLevels(dictLayerLevels[tab1]);
            //��������ӵ�������
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
            //����story_tabs
            foreach (var item in story_tabs.children)
            {
                //�ж��Ƿ�ΪCCMenuItem������ǵĻ����ų�sender�����ȫ���趨Ϊtrue
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

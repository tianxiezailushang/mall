using SanguoCommander.Scenes;
using cocos2d;
using System;

namespace SanguoCommander
{
    //通过一个全局的根来管理整个游戏的所有场景实例
    public class GameRoot
    {
        public static Random RandomNumber { get; private set; }
        public static void InitializeResource()
        {
            RandomNumber = new Random((int)DateTime.Now.Ticks);
            CCSpriteFrameCache.sharedSpriteFrameCache().addSpriteFramesWithFile("GameUI01", "images/GameUI01");
            CCSpriteFrameCache.sharedSpriteFrameCache().addSpriteFramesWithFile("GameUI02", "images/GameUI02");
            CCSpriteFrameCache.sharedSpriteFrameCache().addSpriteFramesWithFile("plist/ActorsPack1");
        }

        private static SceneStart _SceneStart;
        public static SceneStart pSceneStart
        {
            get
            {
                if (_SceneStart == null)
                    _SceneStart = new SceneStart();
                return _SceneStart;
            }
        }

        private static SceneSelect _SceneSelect;
        public static SceneSelect pSceneSelect
        {
            get
            {
                if (_SceneSelect == null)
                    _SceneSelect = new SceneSelect();
                return _SceneSelect;
            }
        }
        private static SceneGame _SceneGame;
        public static SceneGame pSceneGame
        {
            get
            {
                if (_SceneGame == null)
                    _SceneGame = new SceneGame();
                return _SceneGame;
            }
        }
        private static SceneOver _SceneOver;
        public static SceneOver pSceneOver
        {
            get
            {
                if (_SceneOver == null)
                    _SceneOver = new SceneOver();
                return _SceneOver;
            }
        }
    }
}

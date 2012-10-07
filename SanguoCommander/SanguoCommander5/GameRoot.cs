using SanguoCommander.Scenes;
using cocos2d;

namespace SanguoCommander
{
    //通过一个全局的根来管理整个游戏的所有场景实例
    public class GameRoot
    {
        public static void InitializeResource()
        {
            CCSpriteFrameCache.sharedSpriteFrameCache().addSpriteFramesWithFile("GameUI01", "images/GameUI01");
            CCSpriteFrameCache.sharedSpriteFrameCache().addSpriteFramesWithFile("GameUI02", "images/GameUI02");
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

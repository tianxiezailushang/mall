using cocos2d;
using Microsoft.Xna.Framework;

namespace SanguoCommander
{
public class AppDelegate : CCApplication
{
    public AppDelegate(Game game, GraphicsDeviceManager graphics)
        : base(game, graphics)
    {
        CCApplication.sm_pSharedApplication = this;
    }
    public override bool applicationDidFinishLaunching()
    {
        //初始化CCDirector
        CCDirector pDirector = CCDirector.sharedDirector();
        pDirector.setOpenGLView();

        //是否显示FPS（每秒帧速率）
        pDirector.DisplayFPS = false;
        //用于解决一个内部bug
        CCLabelTTF a = CCLabelTTF.labelWithString("0", "Arial", 0);
        // 在这里设置Updata的间隔
        pDirector.animationInterval = 1.0 / 60;
        //载入一下资源
        GameRoot.InitializeResource();
        // 创建一个场景
        CCScene pScene = new Scenes.SceneStart();

        // 运行这个场景
        pDirector.runWithScene(pScene);

        return true;
    }
}
}

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
            //��ʼ��CCDirector
            CCDirector pDirector = CCDirector.sharedDirector();
            pDirector.setOpenGLView();

            //�Ƿ���ʾFPS��ÿ��֡���ʣ�
            pDirector.DisplayFPS = true;

            // ����������Updata�ļ��
            pDirector.animationInterval = 1.0 / 60;

            // ����һ������
            CCScene pScene = new TestScene();

            // �����������
            pDirector.runWithScene(pScene);

            return true;
        }
    }
}

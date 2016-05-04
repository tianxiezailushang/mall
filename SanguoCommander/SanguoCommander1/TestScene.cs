using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace SanguoCommander
{
    public class TestScene : CCScene
    {
        public TestScene()
        {
            base.init();
            this.addChild(CCSprite.spriteWithFile("HelloWorld"));
        }

    }
}

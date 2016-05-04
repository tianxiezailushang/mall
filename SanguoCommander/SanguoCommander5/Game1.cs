using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using cocos2d;

namespace SanguoCommander
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            this.graphics.IsFullScreen = true;

            TargetElapsedTime = TimeSpan.FromTicks(333333);

            InactiveSleepTime = TimeSpan.FromSeconds(1);
            
            CCApplication application = new AppDelegate(this, graphics);
            this.Components.Add(application);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            base.Update(gameTime);
        }
    }
}

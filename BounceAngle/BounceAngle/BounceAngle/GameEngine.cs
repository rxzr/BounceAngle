﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BounceAngle
{
    interface GameEngine
    { 
        SoundManager getSoundManager();
        UIManager getUIManager();
        MenuManager getMenuManager();
        MapManager getMapManager();
        void Draw(SpriteBatch spriteBatch);
        void Init(ContentManager Content);
        void Update(GameTime gameTime);
        
    }
}
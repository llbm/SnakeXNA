using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace LoranSnake
{
    class Pellet
    {

        Texture2D Texture;
        Color Tint;
        Vector2 Position;
        Rectangle Hitbox;
        
       
        
        public Pellet (Texture2D texture, Vector2 position, Color tint)
        {
            Texture = texture;
            Tint = tint;
            Position = position;
            Hitbox = new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height);
        }
        
        
        public void Spawn (Viewport screen, Segment head, int randomx, int randomy)
        {

            if (Hitbox.Intersects(head.Hitbox))
            {
                Position.X = randomx;
                Position.Y = randomy;
                //add another segment behind the head, maybe with a slower reaction speed to keyboard inputs, so not all of the segments (with the head) go in one direction (i.e. they follow one another sideways, but when you press up, they all do the same thing, like a line)
            }
            Hitbox.X = (int)Position.X;
            Hitbox.Y = (int)Position.Y;
            
        }
        
        
        
         public void Draw (SpriteBatch spritebatch)
         {
            spritebatch.Draw(Texture, Position, Tint);
         }


    }
}

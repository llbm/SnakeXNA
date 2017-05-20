using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoranSnake
{
    class Segment
    {
        
        public Texture2D Texture;
        public Vector2 Position;
        public Color Tint;
        public Rectangle Hitbox;
        
        Vector2 speedPHolder = new Vector2(-3, 0);   // just a beginning speed/direction
        
        public Segment(Texture2D texture, Vector2 position, Color tint)
        {
            Texture = texture;
            Position = position;
            Tint = tint;
            Hitbox = new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height);
        }



        public void Movement(int xYSpeed, Viewport screen, KeyboardState ks, Keys up, Keys down, Keys left, Keys right)
        {

            //if inside the edges of the screen
            if (Position.X > screen.X && Position.X + Texture.Width < screen.Width && Position.Y > screen.Y && Position.Y + Texture.Width < screen.Height)
            { //         left         |                     right                  |           top          |                      bot           

                if (ks.IsKeyDown(up) && speedPHolder.X != 0) // so you can't go back over yourself
                {
                    speedPHolder.Y = -xYSpeed;
                    speedPHolder.X = 0;
                }
                if (ks.IsKeyDown(down) && speedPHolder.X != 0)
                {
                    speedPHolder.Y = xYSpeed;
                    speedPHolder.X = 0;
                }
                if (ks.IsKeyDown(right) && speedPHolder.Y != 0)
                {
                    speedPHolder.X = xYSpeed;
                    speedPHolder.Y = 0;
                }
                if (ks.IsKeyDown(left) && speedPHolder.Y != 0)
                {
                    speedPHolder.X = -xYSpeed;
                    speedPHolder.Y = 0;
                }
                Position += speedPHolder;
                Hitbox.X = (int)Position.X;
                Hitbox.Y = (int)Position.Y;
            }
        }
        
        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Texture, Position, Tint);
        }


    }
}

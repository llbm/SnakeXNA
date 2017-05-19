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
        
        // make one pellet, when it's hitbox touches the snake heads, teleport it out of the screen, then teleport it to a random place on the screen, that isn't where the snake is
        
        public Pellet (Texture2D texture, Vector2 position, Color tint)
        {
            Texture = texture;
            Tint = tint;
            Position = position;
        }
        
        
        public void Spawn (Viewport screen, Pellet pel)
        {        
            if (pel.Position.X < 0 || pel.Position.Y < 0 || pel.Position.X + pel.Texture.Width > screen.Width || pel.Position.Y + pel.Texture.Height > screen.Height) //if off the screen (change when you know WHERE the pellet is going to go off the screen)
            {

            }
            
                
                //if there's less than one pellet on the screen, spawn another at a random x and y
            
        }
        
        
        
         


    }
}

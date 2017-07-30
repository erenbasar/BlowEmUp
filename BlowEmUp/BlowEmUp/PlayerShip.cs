using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;



namespace BlowEmUp
{
    public class PlayerShip
    {
        public Texture2D shipTexture;
        public Vector2 shipPosition;
        public Int32 shipSpeed;

        public Rectangle boundingBox;
        public bool isColliding;
        
        public PlayerShip()
        {
            shipTexture = null;
            shipPosition = new Vector2(200, 550);
            shipSpeed = 10;
            isColliding = false;
        }
        
        public void LoadContent(ContentManager Content)
        {
            shipTexture = Content.Load<Texture2D>("playerShip");
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(shipTexture, shipPosition, Color.White);
        }

        public void Update(GameTime gameTime)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine {
    class Cursor {
        public Cursor(ContentManager content) {
            texture = content.Load<Texture2D>("Sprites/Cursor/cursor");
        }

        Texture2D texture = null;
        Point position;
        
        public void Update(Point position) {
            this.position = position;
        }

        public void Draw(SpriteBatch batch) {
            batch.Draw(texture, new Rectangle(position.X, position.Y, texture.Width, texture.Height), Color.White);
        }
    }
}

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class ProjectileSpriteFactory
    {
        private Texture2D bombSpritesheet;
        private Texture2D useBombSpritesheet;
        private Texture2D boomerangSpritesheet;
        private Texture2D useBoomerangSpritesheet;

        private static ProjectileSpriteFactory instance;

        public static ProjectileSpriteFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProjectileSpriteFactory();
                }
                return instance;
            }
        }

        private ProjectileSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            bombSpritesheet = content.Load<Texture2D>("ProjectileSprites/Bomb");
            useBombSpritesheet = content.Load<Texture2D>("ProjectileSprites/UseBomb");
            boomerangSpritesheet = content.Load<Texture2D>("ProjectileSprites/Boomerang");
            useBoomerangSpritesheet = content.Load<Texture2D>("ProjectileSprites/UseBoomerang");
        }

        public ISprite CreateBombSprite()
        {
            return new NonAnimatedSprite(bombSpritesheet);
        }

        public ISprite CreateUseBombSprite()
        {
            return new AnimatedNonLoopSprite(useBombSpritesheet, 4, 1);
        }

        public ISprite CreateBoomerangSprite()
        {
            return new NonAnimatedSprite(boomerangSpritesheet);
        }

        public ISprite CreateUseBoomerangSprite()
        {
            return new AnimatedSprite(useBoomerangSpritesheet, 1, 3);
        }
    }
}

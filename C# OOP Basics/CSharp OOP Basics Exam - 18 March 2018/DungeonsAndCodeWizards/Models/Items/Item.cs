﻿using DungeonsAndCodeWizards.Models.Characters;
using System;

namespace DungeonsAndCodeWizards.Models
{
    public abstract class Item
    {
        protected Item(int weight)
        {
            this.Weight = weight;
        }

        public int Weight { get; }

        public virtual void AffectCharacter(Character character)
        {
            if (!character.IsAlive)
            {
            throw new InvalidOperationException(ExceptionMessages.DeadCharacter);
            }
        }
    }
}
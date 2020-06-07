using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Enums
    {
        public enum ArmorCategory 
        { 
            LightArmor, 
            MediumArmor, 
            HeavyArmor, 
            Shields 
        }
        public enum WeaponCategory
        {
            SimpleWeapons,
            MartialWeapons,
            Firearms,
            SimpleMeleeWeapons,
            SimpleRangedWeapons,
            MartialMeleeWeapons,
            MartialRangedWeapons
        }
        public enum AbilityScores 
        { 
            Strength, 
            Dexterity, 
            Constitution, 
            Intelligence, 
            Wisdom, 
            Charisma 
        }
        public enum Skills 
        { 
            Acrobatics, 
            AnimalHandling, 
            Arcana, 
            Athletics, 
            Deception, 
            History, 
            Insight,
            Intimidation,
            Investigation,
            Medicine,
            Nature,
            Perception,
            Performance,
            Persuasion,
            Religion,
            SleightOfHand,
            Stealth,
            Survival
        }
    }
}

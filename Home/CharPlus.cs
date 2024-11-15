namespace DandD.Home
{
    internal class CharPlus
    {
        public int AssasinMultStrength { get; set; } = 2;
        public int AssasinMultConstitution { get; set; } = 4;
        public int AssasinMultDexterity { get; set; } = 3;
        public int AssasinMultIntelligence { get; set; } = 1;
        public int AssasinMultWisdom { get; set; } = 2;
        public int AssasinMultCharisma { get; set; } = 0;
        public int MageMultStrength { get; set; } = 6;
        public int MageMultConstitution { get; set; } = 3;
        public int MageMultDexterity { get; set; } = 5;
        public int MageMultIntelligence { get; set; } = 3;
        public int MageMultWisdom { get; set; } = 1;
        public int MageMultCharisma { get; set; } = 7;
        public int HealerMultStrength { get; set; } = 4;
        public int HealerMultConstitution { get; set; } = 0;
        public int HealerMultDexterity { get; set; } = 5;
        public int HealerMultIntelligence { get; set; } = 1;
        public int HealerMultWisdom { get; set; } = 6;
        public int HealerMultCharisma { get; set; } = 3;
        public int TankMultStrength { get; set; } = 2;
        public int TankMultConstitution { get; set; } = 4;
        public int TankMultDexterity { get; set; } = 6;
        public int TankMultIntelligence { get; set; } = 2;
        public int TankMultWisdom { get; set; } = 1;
        public int TankMultCharisma { get; set; } = 6;
        public int WarriorMultStrength { get; set; } = 3;
        public int WarriorMultConstitution { get; set; } = 2;
        public int WarriorMultDexterity { get; set; } = 9;
        public int WarriorMultIntelligence { get; set; } = 12;
        public int WarriorMultWisdom { get; set; } = 23;
        public int WarriorMultCharisma { get; set; } = 65;
    }

    public class Calculate
    {
        public int GetCharStat(int charac, int point, string statChar, int charWeap, int charHelmet, int charChest, int charPants, int charBoots, int skill1, 
            int skill2, int skill3, int skill4, int skill5, int skill6, int skill7, int skill8, int skill9, int skill10)
        {
            var Stat = new CharPlus();
            var Item = new ItemsChar();
            switch (charac)
            {
                case 0:
                    {
                        switch (statChar)
                        {
                            case "Strength": return Stat.AssasinMultStrength * point  //Бу, испугался? Обосрался
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Constitution": return Stat.AssasinMultConstitution * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Dexterity": return Stat.AssasinMultDexterity * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Intelligence": return Stat.AssasinMultIntelligence * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Wisdom": return Stat.AssasinMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Charisma": return Stat.AssasinMultCharisma * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            default: return point;
                        }
                    };
                case 1:
                    {
                        switch (statChar)
                        {
                            case "Strength": return Stat.MageMultStrength * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Constitution": return Stat.MageMultConstitution * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Dexterity": return Stat.MageMultDexterity * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Intelligence": return Stat.MageMultIntelligence * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Wisdom": return Stat.MageMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");  
                            case "Charisma": return Stat.MageMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            default: return point;
                        }
                    };
                case 2:
                    {
                        switch (statChar)
                        {
                            case "Strength": return Stat.HealerMultStrength * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Constitution": return Stat.HealerMultConstitution * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Dexterity": return Stat.HealerMultDexterity * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Intelligence": return Stat.HealerMultIntelligence * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Wisdom": return Stat.HealerMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Charisma": return Stat.HealerMultCharisma * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            default: return point;  
                        }
                    };
                case 3:
                    {
                        switch (statChar)
                        {
                            case "Strength": return Stat.TankMultStrength * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Constitution": return Stat.TankMultConstitution * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Dexterity": return Stat.TankMultDexterity * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Intelligence": return Stat.TankMultIntelligence * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Wisdom": return Stat.TankMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Charisma": return Stat.TankMultCharisma * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            default: return point;  
                        }
                    };
                case 4:
                    {
                        switch (statChar)
                        {
                            case "Strength": return Stat.WarriorMultStrength * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Constitution": return Stat.WarriorMultConstitution * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Dexterity": return Stat.WarriorMultDexterity * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Intelligence": return Stat.WarriorMultIntelligence * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Wisdom": return Stat.WarriorMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            case "Charisma": return Stat.WarriorMultCharisma * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots");
                            default: return point;
                        }
                    };
                default: return 0;
            }
        }
    }
}

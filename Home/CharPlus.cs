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
            var Skill = new SumSkillPoints();
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
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Strength", point)
                                    + Skill.SkillCheckPoint(skill2, "Strength", point)
                                    + Skill.SkillCheckPoint(skill3, "Strength", point)
                                    + Skill.SkillCheckPoint(skill4, "Strength", point)
                                    + Skill.SkillCheckPoint(skill5, "Strength", point)
                                    + Skill.SkillCheckPoint(skill6, "Strength", point)
                                    + Skill.SkillCheckPoint(skill7, "Strength", point)
                                    + Skill.SkillCheckPoint(skill8, "Strength", point)
                                    + Skill.SkillCheckPoint(skill9, "Strength", point)
                                    + Skill.SkillCheckPoint(skill10, "Strength", point);
                            case "Constitution": return Stat.AssasinMultConstitution * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill2, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill3, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill4, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill5, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill6, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill7, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill8, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill9, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill10, "Constitution", point);
                            case "Dexterity": return Stat.AssasinMultDexterity * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill2, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill3, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill4, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill5, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill6, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill7, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill8, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill9, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill10, "Dexterity", point);
                            case "Intelligence": return Stat.AssasinMultIntelligence * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill2, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill3, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill4, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill5, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill6, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill7, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill8, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill9, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill10, "Intelligence", point);
                            case "Wisdom": return Stat.AssasinMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill2, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill3, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill4, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill5, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill6, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill7, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill8, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill9, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill10, "Wisdom", point);
                            case "Charisma": return Stat.AssasinMultCharisma * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill2, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill3, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill4, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill5, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill6, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill7, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill8, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill9, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill10, "Charisma", point);
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
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Strength", point)
                                    + Skill.SkillCheckPoint(skill2, "Strength", point)
                                    + Skill.SkillCheckPoint(skill3, "Strength", point)
                                    + Skill.SkillCheckPoint(skill4, "Strength", point)
                                    + Skill.SkillCheckPoint(skill5, "Strength", point)
                                    + Skill.SkillCheckPoint(skill6, "Strength", point)
                                    + Skill.SkillCheckPoint(skill7, "Strength", point)
                                    + Skill.SkillCheckPoint(skill8, "Strength", point)
                                    + Skill.SkillCheckPoint(skill9, "Strength", point)
                                    + Skill.SkillCheckPoint(skill10, "Strength", point);
                            case "Constitution": return Stat.MageMultConstitution * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill2, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill3, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill4, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill5, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill6, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill7, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill8, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill9, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill10, "Constitution", point);
                            case "Dexterity": return Stat.MageMultDexterity * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill2, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill3, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill4, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill5, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill6, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill7, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill8, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill9, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill10, "Dexterity", point);
                            case "Intelligence": return Stat.MageMultIntelligence * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill2, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill3, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill4, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill5, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill6, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill7, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill8, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill9, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill10, "Intelligence", point);
                            case "Wisdom": return Stat.MageMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill2, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill3, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill4, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill5, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill6, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill7, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill8, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill9, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill10, "Wisdom", point);
                            case "Charisma": return Stat.MageMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill2, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill3, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill4, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill5, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill6, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill7, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill8, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill9, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill10, "Charisma", point); 
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
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Strength", point)
                                    + Skill.SkillCheckPoint(skill2, "Strength", point)
                                    + Skill.SkillCheckPoint(skill3, "Strength", point)
                                    + Skill.SkillCheckPoint(skill4, "Strength", point)
                                    + Skill.SkillCheckPoint(skill5, "Strength", point)
                                    + Skill.SkillCheckPoint(skill6, "Strength", point)
                                    + Skill.SkillCheckPoint(skill7, "Strength", point)
                                    + Skill.SkillCheckPoint(skill8, "Strength", point)
                                    + Skill.SkillCheckPoint(skill9, "Strength", point)
                                    + Skill.SkillCheckPoint(skill10, "Strength", point); 
                            case "Constitution": return Stat.HealerMultConstitution * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill2, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill3, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill4, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill5, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill6, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill7, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill8, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill9, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill10, "Constitution", point); 
                            case "Dexterity": return Stat.HealerMultDexterity * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill2, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill3, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill4, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill5, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill6, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill7, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill8, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill9, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill10, "Dexterity", point);
                            case "Intelligence": return Stat.HealerMultIntelligence * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots") 
                                    + Skill.SkillCheckPoint(skill1, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill2, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill3, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill4, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill5, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill6, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill7, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill8, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill9, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill10, "Intelligence", point);
                            case "Wisdom": return Stat.HealerMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill2, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill3, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill4, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill5, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill6, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill7, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill8, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill9, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill10, "Wisdom", point);
                            case "Charisma": return Stat.HealerMultCharisma * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill2, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill3, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill4, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill5, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill6, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill7, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill8, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill9, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill10, "Charisma", point);
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
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Strength", point)
                                    + Skill.SkillCheckPoint(skill2, "Strength", point)
                                    + Skill.SkillCheckPoint(skill3, "Strength", point)
                                    + Skill.SkillCheckPoint(skill4, "Strength", point)
                                    + Skill.SkillCheckPoint(skill5, "Strength", point)
                                    + Skill.SkillCheckPoint(skill6, "Strength", point)
                                    + Skill.SkillCheckPoint(skill7, "Strength", point)
                                    + Skill.SkillCheckPoint(skill8, "Strength", point)
                                    + Skill.SkillCheckPoint(skill9, "Strength", point)
                                    + Skill.SkillCheckPoint(skill10, "Strength", point);
                            case "Constitution": return Stat.TankMultConstitution * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill2, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill3, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill4, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill5, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill6, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill7, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill8, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill9, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill10, "Constitution", point);
                            case "Dexterity": return Stat.TankMultDexterity * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill2, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill3, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill4, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill5, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill6, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill7, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill8, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill9, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill10, "Dexterity", point);
                            case "Intelligence": return Stat.TankMultIntelligence * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill2, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill3, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill4, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill5, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill6, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill7, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill8, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill9, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill10, "Intelligence", point);
                            case "Wisdom": return Stat.TankMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill2, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill3, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill4, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill5, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill6, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill7, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill8, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill9, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill10, "Wisdom", point);
                            case "Charisma": return Stat.TankMultCharisma * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill2, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill3, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill4, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill5, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill6, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill7, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill8, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill9, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill10, "Charisma", point);
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
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Strength", point)
                                    + Skill.SkillCheckPoint(skill2, "Strength", point)
                                    + Skill.SkillCheckPoint(skill3, "Strength", point)
                                    + Skill.SkillCheckPoint(skill4, "Strength", point)
                                    + Skill.SkillCheckPoint(skill5, "Strength", point)
                                    + Skill.SkillCheckPoint(skill6, "Strength", point)
                                    + Skill.SkillCheckPoint(skill7, "Strength", point)
                                    + Skill.SkillCheckPoint(skill8, "Strength", point)
                                    + Skill.SkillCheckPoint(skill9, "Strength", point)
                                    + Skill.SkillCheckPoint(skill10, "Strength", point);
                            case "Constitution": return Stat.WarriorMultConstitution * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill2, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill3, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill4, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill5, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill6, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill7, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill8, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill9, "Constitution", point)
                                    + Skill.SkillCheckPoint(skill10, "Constitution", point); 
                            case "Dexterity": return Stat.WarriorMultDexterity * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill2, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill3, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill4, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill5, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill6, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill7, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill8, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill9, "Dexterity", point)
                                    + Skill.SkillCheckPoint(skill10, "Dexterity", point);
                            case "Intelligence": return Stat.WarriorMultIntelligence * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots") 
                                    + Skill.SkillCheckPoint(skill1, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill2, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill3, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill4, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill5, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill6, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill7, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill8, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill9, "Intelligence", point)
                                    + Skill.SkillCheckPoint(skill10, "Intelligence", point);
                            case "Wisdom": return Stat.WarriorMultWisdom * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill2, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill3, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill4, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill5, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill6, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill7, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill8, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill9, "Wisdom", point)
                                    + Skill.SkillCheckPoint(skill10, "Wisdom", point);
                            case "Charisma": return Stat.WarriorMultCharisma * point
                                    + Item.ItemPointWeapon(point, charWeap, "Weapon")
                                    + Item.ItemPointWeapon(point, charHelmet, "Helmet")
                                    + Item.ItemPointWeapon(point, charChest, "Chest")
                                    + Item.ItemPointWeapon(point, charPants, "Pants")
                                    + Item.ItemPointWeapon(point, charBoots, "Boots")
                                    + Skill.SkillCheckPoint(skill1, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill2, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill3, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill4, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill5, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill6, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill7, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill8, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill9, "Charisma", point)
                                    + Skill.SkillCheckPoint(skill10, "Charisma", point);
                            default: return point;
                        }
                    };
                default: return 0;
            }
        }
    }
}

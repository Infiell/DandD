using System.Windows.Forms;

namespace DandD.Home
{
    internal class Items
    {
        public int Weapon1 { get; set; } = 1;
        public int Weapon2 { get; set; } = 54;
        public int Weapon3 { get; set; } = 21;
        public int Weapon4 { get; set; } = 3;
        public int Weapon5 { get; set; } = 2;
        public int Weapon6 { get; set; } = 4;
        public int Weapon7 { get; set; } = 6;
        public int Weapon8 { get; set; } = 21;
        public int Weapon9 { get; set; } = 5;
        public int Weapon10 { get; set; } = 7;
        public int Weapon11 { get; set; } = 1;
        public int Helmet1 { get; set; } = 34;
        public int Helmet2 { get; set; } = 1;
        public int Helmet3 { get; set; } = 32;
        public int Helmet4 { get; set; } = 12;
        public int Helmet5 { get; set; } = 75;
        public int Helmet6 { get; set; } = 26;
        public int Helmet7 { get; set; } = 1231;
        public int Helmet8 { get; set; } = 454;
        public int Helmet9 { get; set; } = 21;
        public int Helmet10 { get; set; } = 234;
        public int Helmet11 { get; set; } = 123;
        public int Chest1 { get; set; } = 64;
        public int Chest2 { get; set; } = 232;
        public int Chest3 { get; set; } = 64;
        public int Chest4 { get; set; } = 12;
        public int Chest5 { get; set; } = 6;
        public int Chest6 { get; set; } = 765;
        public int Chest7 { get; set; } = 32;
        public int Chest8 { get; set; } = 23;
        public int Chest9 { get; set; } = 65;
        public int Chest10 { get; set; } = 12;
        public int Chest11 { get; set; } = 12;
        public int Pants1 { get; set; } = 3;
        public int Pants2 { get; set; } = 54;
        public int Pants3 { get; set; } = 21;
        public int Pants4 { get; set; } = 76;
        public int Pants5 { get; set; } = 12;
        public int Pants6 { get; set; } = 65;
        public int Pants7 { get; set; } = 4;
        public int Pants8 { get; set; } = 6;
        public int Pants9 { get; set; } = 8;
        public int Pants10 { get; set; } = 0;
        public int Pants11 { get; set; } = 12;
        public int Boots1 { get; set; } = 64;
        public int Boots2 { get; set; } = 123;
        public int Boots3 { get; set; } = 5;
        public int Boots4 { get; set; } = 23;
        public int Boots5 { get; set; } = 54;
        public int Boots6 { get; set; } = 21;
        public int Boots7 { get; set; } = 12;
        public int Boots8 { get; set; } = 4;
        public int Boots9 { get; set; } = 5;
        public int Boots10 { get; set; } = 65;
        public int Boots11 { get; set; } = 12;
    }

    internal class ItemsChar
    {
        public int ItemPointWeapon(int point, int item, string type)
        {
            var PoPlus = new Items();
            switch (type)
            {
                case "Weapon":
                    {
                        switch (item)
                        {
                            case 0: return 0;
                            case 1: return PoPlus.Weapon1 * point;
                            case 2: return PoPlus.Weapon2 * point;
                            case 3: return PoPlus.Weapon3 * point;
                            case 4: return PoPlus.Weapon4 * point;
                            case 5: return PoPlus.Weapon5 * point;
                            case 6: return PoPlus.Weapon6 * point;
                            case 7: return PoPlus.Weapon7 * point;
                            case 8: return PoPlus.Weapon8 * point;
                            case 9: return PoPlus.Weapon9 * point;
                            case 10: return PoPlus.Weapon10 * point;
                            case 11: return PoPlus.Weapon11 * point;
                            default: return point;
                        }
                    }
                case "Helmet":
                    {
                        switch (item)
                        {
                            case 0: return 0;
                            case 1: return PoPlus.Helmet1 * point;
                            case 2: return PoPlus.Helmet2 * point;
                            case 3: return PoPlus.Helmet3 * point;
                            case 4: return PoPlus.Helmet4 * point;
                            case 5: return PoPlus.Helmet5 * point;
                            case 6: return PoPlus.Helmet6 * point;
                            case 7: return PoPlus.Helmet7 * point;
                            case 8: return PoPlus.Helmet8 * point;
                            case 9: return PoPlus.Helmet9 * point;
                            case 10: return PoPlus.Helmet10 * point;
                            case 11: return PoPlus.Helmet11 * point;
                            default: return point;
                        }
                    }
                case "Chest":
                    {
                        switch (item)
                        {
                            case 0: return 0;
                            case 1: return PoPlus.Chest1 * point;
                            case 2: return PoPlus.Chest2 * point;
                            case 3: return PoPlus.Chest3 * point;
                            case 4: return PoPlus.Chest4 * point;
                            case 5: return PoPlus.Chest5 * point;
                            case 6: return PoPlus.Chest6 * point;
                            case 7: return PoPlus.Chest7 * point;
                            case 8: return PoPlus.Chest8 * point;
                            case 9: return PoPlus.Chest9 * point;
                            case 10: return PoPlus.Chest10 * point;
                            case 11: return PoPlus.Chest11 * point;
                            default: return point;
                        }
                    }
                case "Pants":
                    {
                        switch (item)
                        {
                            case 0: return 0;
                            case 1: return PoPlus.Pants1 * point;
                            case 2: return PoPlus.Pants2 * point;
                            case 3: return PoPlus.Pants3 * point;
                            case 4: return PoPlus.Pants4 * point;
                            case 5: return PoPlus.Pants5 * point;
                            case 6: return PoPlus.Pants6 * point;
                            case 7: return PoPlus.Pants7 * point;
                            case 8: return PoPlus.Pants8 * point;
                            case 9: return PoPlus.Pants9 * point;
                            case 10: return PoPlus.Pants10 * point;
                            case 11: return PoPlus.Pants11 * point;
                            default: return point;
                        }
                    }
                case "Boots":
                    {
                        switch (item)
                        {
                            case 0: return 0;
                            case 1: return PoPlus.Boots1 * point;
                            case 2: return PoPlus.Boots2 * point;
                            case 3: return PoPlus.Boots3 * point;
                            case 4: return PoPlus.Boots4 * point;
                            case 5: return PoPlus.Boots5 * point;
                            case 6: return PoPlus.Boots6 * point;
                            case 7: return PoPlus.Boots7 * point;
                            case 8: return PoPlus.Boots8 * point;
                            case 9: return PoPlus.Boots9 * point;
                            case 10: return PoPlus.Boots10 * point;
                            case 11: return PoPlus.Boots11 * point;
                            default: return point;
                        }
                    }
                    default: return point;
            }
        }
    }
}

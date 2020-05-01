using System;

namespace ModernWarfareClassGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Class class1 = new Class(Items.primary, Items.secondary, Items.perk1, Items.perk2, Items.perk3, Items.lethal, Items.tactical);

            Console.WriteLine("Primary: " + class1.ReturnPrimary());
            Console.WriteLine("Secondary: " + class1.ReturnSecondary());
            Console.WriteLine("Perk 1: " + class1.ReturnPerk1());
            Console.WriteLine("Perk 2: " + class1.ReturnPerk2());
            Console.WriteLine("Perk 3: " + class1.ReturnPerk3());
            Console.WriteLine("Lethal: " + class1.ReturnLethal());
            Console.WriteLine("Tactical: " + class1.ReturnTactical());
        }
    }

    class Class
    {
        Random random = new Random();
        string primary;
        string secondary;
        string perk1;
        string perk2;
        string perk3;
        string lethal;
        string tactical;

        public Class(string[] primaryWeapons, string[] secondaryWeapons, string[] perk1Perks, string[] perk2Perks, string[] perk3Perks, string[] lethals, string[] tacticals)
        {
            primary = primaryWeapons[random.Next(36)];
            perk1 = perk1Perks[random.Next(6)];
            perk2 = perk2Perks[random.Next(6)];
            perk3 = perk3Perks[random.Next(6)];
            lethal = lethals[random.Next(8)];
            tactical = tacticals[random.Next(8)];

            if(perk2 == perk2Perks[2])
            {
                secondary = primaryWeapons[random.Next(36)];
            }
            else
            {
                secondary = secondaryWeapons[random.Next(11)];
            }
        }
        public string ReturnPrimary()
        {
            return primary;
        }

        public string ReturnSecondary()
        {
            return secondary;
        }

        public string ReturnPerk1()
        {
            return perk1;
        }

        public string ReturnPerk2()
        {
            return perk2;
        }

        public string ReturnPerk3()
        {
            return perk3;
        }

        public string ReturnLethal()
        {
            return lethal;
        }

        public string ReturnTactical()
        {
            return tactical;
        }
    }

    static class Items
    {
        public static string[] primary = { "Kilo 141", "FAL", "M4A1", "FR 5.56", "Oden", "M13", "FN Scar 17", "AK-47", "RAM-7", "Grau 5.56", "AUG", "P90", "MP5", "PP19 Bizon",
        "MP7", "Striker 45", "Model 680", "R9-0 Shotgun", "725","Origin 12 Shotgun", "VLK Rogue", "PKM", "SA87", "M91", "MG34", "Holger-26", "Breun MK9", "EBR-14", "MK2 Carbine",
        "Kar98K", "Crossbow", "SKS", "Dragunov", "HDR", "AX-50", "Riot Shield" };

        public static string[] secondary = { "X16", "1911", ".357", "M19", ".50 GS", "Renetti", "PILA", "Strela-P", "JOKR", "RPG-7", "Combat Kife" };

        public static string[] perk1 = { "Double Time", "E.O.D.", "Scavenger", "Cold-Blooded", "Kill Chain", "Quick Fix" };

        public static string[] perk2 = { "Restock", "Hardline", "Overkill", "High Alert", "Ghost", "Pointman" };

        public static string[] perk3 = { "Tune Up", "Amped", "Shrapnel", "Battle Hardened", "Spotter", "Tracker" };

        public static string[] lethal = { "Claymore", "Frag Grenade", "Molotov Cocktail", "C4", "Semtex", "Throwing Knife", "Proximity Mine", "Thermite" };

        public static string[] tactical = { "Flash Grenade", "Stun Grenade", "Smoke Grenade", "Snapshot Grenade", "Heartbeat Sensor", "Stim", "Decoy Grenade", "Gas Grenade" };
    }
}

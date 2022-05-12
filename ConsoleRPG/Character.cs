using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Character : IAttributes
    {
        private string armor, description, name, weapon;
        private int armorDef, gold, HP, level, MAXHP, MP, MAXMP, weaponDMG;
        private List<String> inventory = new List<string>();
        private int[] spellDMG = new int[5]; // 5 total spells to account for dmg
        private String[] spells = new String[5]; //5 total spells to account for  

        //---------------------------------------- //Character Creation// ----------------------------------------//

        public Character(String inName, String inDesc, String inStartingWeapon, int inWeaponAtk) { 
            setName(inName);
            setDescription(inDesc);
            setWeapon(inStartingWeapon);
            setWeaponAtk(inWeaponAtk);

            // -- Set all values to specified inits -- // 
            setArmorDef(0);
            setLevel(1);
            setMP(10);
            setMAXMP(10); // to be upgraded by level factor as progress is made
            setHP(100);
            setMAXHP(100); // to be upgraded by level factor as progress is made
            setGold(10); // start with 10

            // -- Set all lists to inits -- //
            List<String> tempInventory = this.inventory;
            tempInventory.Add(inStartingWeapon);
            setInventory(tempInventory);

            String[] tempSpells = this.spells;
            tempSpells[0] = "Self-heal"; // init beginner spell
            setSpells(tempSpells);

            int[] tempSpellDMG = this.spellDMG;
            tempSpellDMG[0] = -5; // adds health -> (HP - spellDMG)
            setSpellDamage(tempSpellDMG);
        }// end user defined constructor 


        //---------------------------------------- //GETTERS// ----------------------------------------//
        public string getArmor()
        {
            return this.armor;
        }

        public int getArmorDef()
        {
            return this.armorDef;
        }

        public string getDescription()
        {
            return this.description;
        }

        public int getGold()
        {
            return this.gold;
        }

        public int getHP()
        {
            return this.HP;
        }

        public List<String> getInventory()
        {
            return this.inventory;
        }

        public int getLevel()
        {
            return this.level;
        }

        public int getMAXHP()
        {
            return this.MAXHP;
        }

        public int getMAXMP()
        {
            return this.MAXMP;
        }

        public int getMP()
        {
            return this.MP;
        }

        public string getName()
        {
            return this.name;
        }

        public int[] getSpellDamage()
        {
            return this.spellDMG;
        }

        public String[] getSpells()
        {
            return this.spells;
        }

        public string getWeapon()
        {
            return this.weapon;
        }

        public int getWeaponAtk()
        {
            return this.weaponDMG;
        }

        //---------------------------------------- //SETTERS// ----------------------------------------//
        public void setArmor(string armor)
        {
            this.armor = armor;
        }

        public void setArmorDef(int armorDef)
        {
            this.armorDef = armorDef; 
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setGold(int gold)
        {
            this.gold = gold;
        }

        public void setHP(int hp)
        {
            this.HP = hp;
        }

        public void setInventory(List<String> inventory)
        {
            this.inventory = inventory;
        }

        public void setLevel(int level)
        {
            this.level = level;
        }

        public void setMAXHP(int maxhp)
        {
            this.MAXHP = maxhp;
        }

        public void setMAXMP(int maxmp)
        {
            this.MAXMP = maxmp;
        }

        public void setMP(int mp)
        {
            this.MP = mp;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setSpellDamage(int[] spellDamage)
        {
            this.spellDMG = spellDamage;
        }

        public void setSpells(String[] spells)
        {
            this.spells = spells;
        }

        public void setWeapon(string weapon)
        {
            this.weapon = weapon;
        }

        public void setWeaponAtk(int weaponAtk)
        {
            this.weaponDMG = weaponAtk;
        }
    }// end Character class -- uses attribute interface for character creation


}// end namespace


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    internal interface IAttributes
    {   // Character attribute functionality
        String getName();
        void setName(String name);
        String getDescription();
        void setDescription(String description);
        int getLevel();
        void setLevel(int level);
        int getHP();
        void setHP(int hp);
        int getMP();
        void setMP(int mp);
        int getMAXHP(); 
        void setMAXHP(int maxhp);
        int getMAXMP();
        void setMAXMP(int maxmp);
        String getWeapon();
        void setWeapon(String weapon);
        int getWeaponAtk();
        void setWeaponAtk(int weaponAtk);
        String getArmor();
        void setArmor(String armor);
        int getArmorDef();
        void setArmorDef(int armorDef);
        String[] getSpells();
        void setSpells(String[] spells);
        int[] getSpellDamage();
        void setSpellDamage(int[] spellDamage);
        int getGold();
        void setGold(int gold);
        List<String> getInventory();
        void setInventory(List<String> inventory);

    }// end attribute interface

}// end namespace

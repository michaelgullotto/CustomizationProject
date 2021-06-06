using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mystats : MonoBehaviour
{
    static public int strength ;
    static public int Dextrerity ;
    static public int constitution ;
    static public int wisdom ;
    static public int intelligence ;
    static public int charisma ;
    int poolstrength = 0;
    int poolDextrerity = 0;
    int poolconstitution = 0;
    int poolwisdom = 0;
    int poolintelligence = 0;
    int poolcharisma = 0;
    int basestrength = 0;
    int baseDextrerity = 0;
    int baseconstitution = 0;
    int basewisdom =0;
    int baseintelligence =0;
    int basecharisma =0;

    static public int level = 1;
    static public int statpool = 10;

    static public int maxhealth;
    static public int healthregen;
    static public int currenthealth;

    static public int maxMana;
    static public int manaRegen;
    static public int currentMana;

    static public string raceAblity;
    static public string raceAblityDes;
    static public string race;
    static public string playerclass;
    static public string classAblity;
    static public string classAblityDes;


    private void Update()
    {
       
        maxhealth = strength * 20;
        healthregen = strength ;
        maxMana = intelligence * 20;
        manaRegen = intelligence;

        if(currentMana > maxMana)
        {
            currentMana = maxMana;
        }

        if (currenthealth > maxhealth)
        {
            currenthealth = maxhealth;
        }


        strength = poolstrength + basestrength + 5;
        Dextrerity = poolDextrerity + baseDextrerity + 5;
        constitution = poolconstitution + baseconstitution + 5;
        wisdom = poolwisdom + basewisdom + 5;
        intelligence = poolintelligence + baseintelligence + 5;
        charisma = poolcharisma + basecharisma + 5;
    }

    public void SetOrk()
    {
        race = "Ork";
        raceAblity = "Ork Smash";
        raceAblityDes = "Smashes hands into ground doing sending out shockwaves dealing 2x strength + 100 dmg";
    }
    public void SetHuman()
    {
        race = "Human";
        raceAblity = "whimper";
        raceAblityDes = "shrieks in fear causeing ememys to be stuned by laughter for 3 seconds";
    }
    public void SetWarrior()
    {
        playerclass = "Warrior";
        classAblity = "cyclone";
        classAblityDes = "Spins weapons in circles slashing anyone who gets close dealing 1.5 x strength per second";

        basestrength = 10 +(4* level);
        baseDextrerity = 8 + (2 * level);
        baseconstitution = 7 + (1 * level);
        basewisdom = 2 + (1 * level);
        baseintelligence = 1 + (1 * level);
        basecharisma = 5 + (2 * level);
    }
    public void SetMage()
    {
        playerclass = "Mage";
        classAblity = "Fire ball";
        classAblityDes = "Shots a ballof fire. deals 2 x intel + 100 and damage has a 30% chance to ignite ememeys";

        basestrength = 5 + (2 * level);
        baseDextrerity = 3 + (1 * level);
        baseconstitution = 7 + (1 * level);
        basewisdom = 11 + (4 * level);
        baseintelligence = 11 + (6 * level);
        basecharisma = 1 + (1 * level);
    }


    public void AddStrength()
    {
        if (statpool > 0)
        {
            statpool--;
            poolstrength++;
        }

    }
    public void MinusStrength()
    {
        if (poolstrength > 0)
        {
            statpool ++;
            poolstrength --;
        }
    }
    public void AddDex()
    {
        if (statpool > 0)
        {
            statpool--;
            poolDextrerity++;
        }

    }
    public void MinusDEX()
    {
        if (poolDextrerity > 0)
        {
            statpool++;
            poolDextrerity--;
        }
    }
    public void AddConstitution()
    {
        if (statpool > 0)
        {
            statpool--;
            poolconstitution++;
        }

    }
    public void MinusConstitution()
    {
        if (poolconstitution > 0)
        {
            statpool++;
            poolconstitution--;
        }
    }
    public void AddWisdom()
    {
        if (statpool > 0)
        {
            statpool--;
            poolwisdom++;
        }

    }
    public void MinusWisdom()
    {
        if (poolwisdom > 0)
        {
            statpool++;
            poolwisdom--;
        }
    }
    public void AddIntel()
    {
        if (statpool > 0)
        {
            statpool--;
           poolintelligence++;
        }

    }
    public void MinusIntel()
    {
        if (poolintelligence > 0)
        {
            statpool++;
            poolintelligence--;
        }
    }
    public void AddCharisma()
    {
        if (statpool > 0)
        {
            statpool--;
            poolcharisma++;
        }

    }
    public void MinusCharisa()
    {
        if (poolcharisma > 0)
        {
            statpool++;
            poolcharisma--;
        }
    }

}

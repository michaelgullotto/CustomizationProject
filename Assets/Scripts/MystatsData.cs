using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MystatsData 
{
    static public int strength;
    static public int Dextrerity;
    static public int constitution;
    static public int wisdom;
    static public int intelligence;
    static public int charisma;
    public int poolstrength ;
    public int poolDextrerity ;
    public int poolconstitution ;
    public int poolwisdom ;
    public int poolintelligence ;
    public int poolcharisma ;

    static public string race;
    static public string playerclass;
  
    public int level;
    public int statspool;



    public MystatsData(MystatsData mystatsData)
    {
        strength =  Mystats.strength;
        Dextrerity = Mystats.Dextrerity;
        constitution = Mystats.constitution;
        wisdom = Mystats.wisdom;
        intelligence = Mystats.intelligence;
        charisma = Mystats.charisma;
        poolstrength = Mystats.poolstrength;
        poolDextrerity = Mystats.poolDextrerity;
        poolconstitution = Mystats.poolconstitution;
        poolwisdom = Mystats.poolwisdom;
        poolintelligence = Mystats.poolintelligence;
        poolcharisma = Mystats.poolcharisma;
        
        race = Mystats.race;
        playerclass = Mystats.playerclass;
        
        level = Mystats.level;
        statspool = Mystats.statpool;
    }

    public void LoadMyStatsData(MystatsData mystatsdata)
    {
        Mystats.strength = strength;
        Mystats.Dextrerity = Dextrerity;
        Mystats.constitution = constitution;
        Mystats.wisdom = wisdom;
        Mystats.intelligence = intelligence;
        Mystats.charisma = charisma;
        Mystats.poolstrength = poolstrength;
        Mystats.poolDextrerity = poolDextrerity;
        Mystats.poolconstitution = poolconstitution;
        Mystats.poolwisdom = poolwisdom;
        Mystats.poolintelligence = poolintelligence;
        Mystats.poolcharisma = poolcharisma;

        Mystats.race = race ;
        Mystats.playerclass = playerclass;

        Mystats.level = level;
        Mystats.statpool = statspool;



    }



}



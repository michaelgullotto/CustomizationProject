using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
//ANDREWS CODE USED FOR PROTOTYPING
public class PlayerData
{
    public int level;

    public float[] position;
    public float[] rotation;

    public int pointsPool;
    public Stats strength;        //Health + Health regen
    public Stats dexterity;      //Movement Speed
    public Stats constitution;   //Stamina + Stamina regen
    public Stats wisdom;         //Mana pool + Mana regen
    public Stats intelligence;   //Spell casting damage
    public Stats charisma;

    public PlayerData(Transform playerTransform, PlayerStats playerStats)
    {
        level = playerStats.level;

        pointsPool = playerStats.pointPool;
        strength = playerStats.strength;
        dexterity = playerStats.dexterity;
        constitution = playerStats.constitution;
        wisdom = playerStats.wisdom;
        intelligence = playerStats.intelligence;
        charisma = playerStats.charisma;
        

       // position = new float[] { playerTransform.position.x, playerTransform.position.y, playerTransform.position.z };
       //rotation = new float[] { playerTransform.rotation.x, 
       //                             playerTransform.rotation.y, 
       //                            playerTransform.rotation.z, 
       //                            playerTransform.rotation.w };
    }

    public void LoadPlayerData( Transform playerTransform, PlayerStats playerStats)
    {
        playerStats.level = level;

        playerStats.pointPool = pointsPool;
        playerStats.strength = strength;
        playerStats.dexterity = dexterity;
        playerStats.constitution = constitution;
        playerStats.wisdom = wisdom;
        playerStats.intelligence = intelligence;
        playerStats.charisma = charisma;


     //   playerTransform.position = new Vector3(position[0], position[1], position[2]);
     //   playerTransform.rotation = new Quaternion(rotation[0], rotation[1], rotation[2], rotation[3]);
    }

}

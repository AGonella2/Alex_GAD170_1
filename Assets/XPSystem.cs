using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    public int Level;
    public int CurrXP;
    public int ReqXP = 100;
    public float Health;
    public float Mana;
    public float Attack;
    public float defence;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        //Set up New Player's stats
        Level = 1;
        Health = 20f;
        Mana = 10f;
        Attack = 5f;
        defence = 5f;
        speed = 4;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            //Kill a Troglodyte worth 5xp
            CurrXP + 5;
            Debug.Log("You killed a Troglodyte!");
            Debug.Log("Current XP: " + CurrXP);
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            //kill a Yeti worth 20xp
            CurrXP + 20;
            Debug.Log("You killed a Yeti)");
            Debug.Log("Current XP: " + CurrXP);
        }
        if(Input.GetKeyDown(KeyCode.U))
        {
            //Kill a Unicorn worth 40xp
            CurrXP + 40;
            Health - 9f;
            Debug.Log("You Killed a Unicorn, You Monster!");
            Debug.Log("You are cursed! Maximum Health is reduced by 9");
            Debug.Log("Current XP: " + CurrXP);
        }
        if (CurrXP >= ReqXP)
        {
            //Level Up
            Level++;
            ReqXP *= 1.2f;
            CurrXP = 0;
            Health += 5;
            Mana += 5;
            Attack += 3;
            defence += 2;
            Debug.Log("Congratulations! You Leveled up to Level " + Level);
            Debug.Log("You have gained +5 Health and Mana, +3 Attack & +2 Defence!");
            Debug.Log("Your progress to the next level starts at 0 Hero! Good Luck!");
        }
        if(Health<=0.0f)
        {
            
        }
    }
}

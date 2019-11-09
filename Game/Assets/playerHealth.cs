using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public int health;            //will be decreased based on enemy strength
    public int numOfHearts;       //current max hearts the player has
    
    public Image[] hearts;        //images array to hold the total hearts for the player
    public Sprite fullHeart;      //full heart sprite
    public Sprite threeFourthsHeart;        //three quarter heart sprite
    public Sprite halfHeart;        //half heart sprite
    public Sprite quarterHeart;     //quarter heart sprite
    public Sprite emptyHeart;       //empty heart

    void Update()            
    {
        if (health > (numOfHearts * 4))        //if the health is greater than the total number of hearts
        {                                      //there are 4 quarters for each heart, so we need to compare to the num of hearts * 4
            health = (numOfHearts * 4);        //the health should just be equal to the total number of hearts
        }
        
        bool checkPartialHeart = true;         //bool to check if there is a heart that is not complete
        
        for (int i = 0; i < hearts.Length; i++)    //for loop to check each heart piece, runs for length of the hearts array 
        {
            if (i < (health/4))                //if i is less than health/4, then that is a full heart 
            {
                hearts[i].sprite = fullHeart;
            }
            else if (health % 4 == 0)          //then, if health is a perfect multiple of 4, that means that there are
                                               //only empty hearts left, since we already checked all full hearts
            {
                hearts[i].sprite = emptyHeart;
            }
            else
            {
                if (checkPartialHeart)        //We already checked all full hearts, so now we need to check the next heart
                                              //to see if it is a partial heart, which is why we set checkPartialHeart to false
                                              //so that this only happens once
                {
                    if (health % 4 == 1)    //If health mod 4 leaves a remainder of one, the it is a quarter heart
                    {
                        checkPartialHeart = false;
                        hearts[i].sprite = quarterHeart;
                    }

                    if (health % 4 == 2)    //If health mod 4 leaves a remainder of two, the it is a half heart
                    {
                        checkPartialHeart = false;
                        hearts[i].sprite = halfHeart;
                    }

                    if (health % 4 == 3)    //If health mod 4 leaves a remainder of three, the it is a three quarters heart
                    {
                        checkPartialHeart = false;
                        hearts[i].sprite = threeFourthsHeart;
                    }
                }
                else  //we finished checking for a partial heart, so the rest must be empty hearts
                {
                    hearts[i].sprite = emptyHeart;
                }
                
               
            }
            if (i < numOfHearts)    //now we enable all hearts up to the max number of hearts the player has for his full health
                                    //and disable the hearts he doesn't yet have for his full health
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}

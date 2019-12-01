/**
Happy Village, Scary Dungeons
KU EECS 448 project 4
TeamName: BigSegFaultEnergy
  * \Author: Chance Penner
  * \Author: Markus Becerra
  * \Author: Sarah Scott
  * \Author: Thomas Gardner
  * \Author: Haonan Hu
  * \File:	 playerHealth.cs
  * \Date:   12/01/2019
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playerHealth : MonoBehaviour
{
    static int health;            //will be decreased based on enemy strength
    static int numOfHearts;       //current max hearts the player has
    public string respawnLocation;

    public Image[] hearts;        //images array to hold the total hearts for the player
    public Sprite fullHeart;      //full heart sprite
    public Sprite threeFourthsHeart;        //three quarter heart sprite
    public Sprite halfHeart;        //half heart sprite
    public Sprite quarterHeart;     //quarter heart sprite
    public Sprite emptyHeart;       //empty heart
    private Animator anim;
    private float invincibiilityTime;
    private bool invulnerable;
    private float invCounter;    //counter for 
    public float flashLength;
    private bool flashActive;
    private float flashCounter;
    private SpriteRenderer playerSprite;

    /*
     * @ pre none
     * @ param none
     * @ post start get called when script is triggered
     * @ return none
     */
    private void Start()
    {
        anim = GetComponent<Animator>();
        invincibiilityTime = 0.4f;        //player to be invincible for 1 second
        invulnerable = false;
        invCounter = 0;
        playerSprite = GetComponent<SpriteRenderer>();
    }

    /*
     * @ pre none
     * @ param number of damage
     * @ post damage the player by certain amount
     * @ return none
     */
    public void harmPlayer(int damageAmount)
    {
        if (!invulnerable)
        {
            if ((health - damageAmount) <= 0)
            {
                health = 0;
                gameOver();
            }
            else
            {
                health = health - damageAmount;
            }
            invulnerable = true;        //take damage, but now you're invulnerable for 1 second
            flashActive = true;
            flashCounter = flashLength;
        }

    }

    /*
     * @ pre none
     * @ param none
     * @ post the game is over if player heath is less or equal than 0
     * @ return none
     */
    private void gameOver()
    {
        GetComponent<Collider2D>().enabled = false;

        gameObject.GetComponent<PlayerMovement>().speed = 0;    //player cannot move once dead
        anim.SetBool("playerDead", true);           //set the animator playerDead to true to trigger death animation
        
    }

    /*
     * @ pre none
     * @ param none
     * @ post repawn player after death in the town
     * @ return none
     */
    public void respawn()
    {
        SceneManager.LoadScene(respawnLocation);
        setHealth(numOfHearts * 4);
        GetComponent<Collider2D>().enabled = true;
    }
    
    /*
     * @ pre none
     * @ param none
     * @ post update each frame
     * @ return none
     */
    void Update()            
    {
        if (invulnerable)
        {
            invCounter += Time.deltaTime;
            if (invCounter >= invincibiilityTime)
            {
                invCounter = 0;
                invulnerable = false;
            }
        }

        if (flashActive)
        {
            if (flashCounter < 0)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b,1f );
                flashActive = false;
            } 
        }
        
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

    /*
     * @ pre none
     * @ param none
     * @ post destroy the player object
     * @ return none
     */
    private void destroyPlayer()
    {
//        Destroy(gameObject);
    }

    /*
     * @ pre none
     * @ param amount of health
     * @ post set player's health amount
     * @ return none
     */
    public void setHealth(int healthAmount)
    {
        health = healthAmount;
    }

    /*
     * @ pre none
     * @ param number of hearts
     * @ post set the number of hearts that player has
     * @ return none
     */
    public void setNumOfHearts(int numOfHeartsAmount)
    {
        numOfHearts = numOfHeartsAmount;
    }

    /*
     * @ pre none
     * @ param none
     * @ post get the player's health
     * @ return number of health
     */
    public int getHealth()
    {
        return health;
    }

    /*
     * @ pre none
     * @ param none
     * @ post get the number of hearts that player has
     * @ return number of hearts
     */
    public int getNumOfHearts()
    {
        return numOfHearts;
    }

    /*
     * @ pre none
     * @ param amount of heal
     * @ post heal player by certain amount
     * @ return none
     */
    public void giveHealth(int healthAmount)
    {
        health += healthAmount;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Health : MonoBehaviour
{
    public int health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart; 

    // Start is called before the first frame update
    void Start()
    {
    
    }//end Start

    // Update is called once per frame
    void Update()
    {   
        if (health <= 0) //player has died
        {
            //restart game??
            //respawn player at beginning?? 

        }//end if statement

        if (health > numOfHearts)
        {
            health = numOfHearts; 
        }//end if statement 
        
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart; 
            }//end if statement
            else
            {
                hearts[i].sprite = emptyHeart; 
            }//end else statement

            if (i < numOfHearts)
            {
                //show hearts equal to the number of health
                hearts[i].enabled = true; 
            }//end if statement
            else
            {
                //hide hearts if there are more than number of health 
                hearts[i].enabled = false; 

            }//end else statement

        }//end for loop

    }//end Update
    
}//end public class

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthController : MonoBehaviour
{
    public int health;
    [SerializeField] private Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart; 

    // Start is called before the first frame update
    private void Start()
    {
        UpdateHealth(); 
    }//end Start

    // Update is called once per frame
    public void UpdateHealth()
    {   
        if (health <= 0)
        {
            //character respawn??
            //main menu?? 
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
        }//end for loop
    }//end UpdateHealth
    
}//end public class

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DamageController : MonoBehaviour
{
    [SerializeField] private int dmg; 
    [SerializeField] private HealthController life; 

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage(); 
        }
    }//end OnTriggerEnter2D

    // Update is called once per frame
    void Damage()
    {
        life.health = life.health - dmg;
        life.UpdateHealth();
        gameObject.SetActive(true); 
        
    }//end Damage
}//end public class Damage

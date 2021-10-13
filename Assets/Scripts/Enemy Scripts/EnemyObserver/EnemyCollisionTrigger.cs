//Zawaad M Shah

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The collision triggers for enemies. Checks to see if collision occurs
//Equivalent to the observer from the observer pattern
public class EnemyCollisionTrigger : MonoBehaviour
{
    //Define an event. In this case its the enemydeath on collison
    public static event Action<GameObject> onEnemyDeath;

    private GameObject enemy;

    void Start()
    {
        enemy = this.gameObject;
    }

    //Collision check for when player jumps on top of enemy
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            //Destroy the enemy object
            Destroy(gameObject);

            //Invoke the death event
            onEnemyDeath?.Invoke(enemy);
        }
    }

    //Collision check for when enemy is hit by a bullet from the player
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            //Destroy the enemy object
            Destroy(gameObject);
            
            //Invoke the death event
            onEnemyDeath?.Invoke(enemy);
        }
    }
}

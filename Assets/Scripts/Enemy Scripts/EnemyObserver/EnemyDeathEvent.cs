//Zawaad M Shah

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The event or action that takes place when an enemy is destroyed
//Equivalent to the subject from the observer pattern
public class EnemyDeathEvent : MonoBehaviour
{
    //The enemy object
    private GameObject enemy;

    //The message to be printed
    private string message;

    //The singleton containing the array of enemies
    Enemies enemies;

    //The singleton scoreboard class which keeps track of all the points
    ScoreBoard scoreBoard; 

    void Awake()
    {
        //Create the enemies instance with the array of enemies
        enemies = Enemies.Instance;

        //Create the scoreboard instance for access to the points
        scoreBoard = ScoreBoard.shared;

        //Triggered when a collison event occurs. The event is added to the collision triggers actions
        //Similar to attaching an observer to a list of observers in a subject
        EnemyCollisionTrigger.onEnemyDeath += HandleEnemyDeath;
    }


    //The actual action to take place
    //Can include many other actions but for this game only 3 actions take place
    private void HandleEnemyDeath(GameObject enemy)
    {
        this.enemy = enemy;

        //Prints out that the enemy has been destroyed. Currently using a debug log to show that its working properly
        //In the future add this to an ingame message?
        message = enemy.gameObject.name + " Destroyed";
        Debug.Log(message);

        //The player gets points for killing an enemy. These points are added to the scoreboar
        AddScore();
        
        //Remove the enemy from the array
        //RemoveEnemyFromArray();
    }

    //The method for adding points. Players get 2 points for killing enemies.
    //Possibly vary the point value with the strategy pattern?
    public void AddScore()
    {
        scoreBoard.AddPoints(2);
        Debug.Log(scoreBoard.GetPoints());
    }

    //Remove the enemy from the array
    //Currently this method is commented out as its not working properly.
    //The game gets stuck in an infinite loop and freezes
    public void RemoveEnemyFromArray()
    {
        Iterator enemiesIterator = enemies.GetEnemiesList().CreateIterator();

        Enemy enemyInArray = (Enemy)enemiesIterator.First();

        while (enemyInArray != null)
        {
            if(enemyInArray.EnemyObject == enemy)
            {
                enemies.GetEnemiesList().Remove(enemyInArray);
            }
        }
    }
}

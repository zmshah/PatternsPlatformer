//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The concrete ground enemy builder class
public class SkyEnemyBuilder : EnemyBuilder
{
    private GameObject skyEnemy;

    //The name to be assigned to this enemy
    private string name = "Sky Enemy";

    //The tag to be assigned to this enemy
    private string tag = "Enemy";

    //Assigns the current sky enemy object
    public SkyEnemyBuilder(GameObject skyEnemy)
    {
        this.skyEnemy = skyEnemy;
    }

    //Assign the enemy tag and name. These are needed for differentiating behaviors between different enemy types
    public override void BuildEnemyAttributes()
    {
        skyEnemy.name = name;
        skyEnemy.tag = tag;
    }

    //Assign the movement controller script which uses the strategy pattern to decide the appropriate movement type
    public override void BuildEnemyMovement()
    {
        skyEnemy.AddComponent<EnemyMovementController>();
    }

    //Build the collision properties
    public override void BuildEnemyCollison()
    {
        //Main box collider
        colliderEnemy = skyEnemy.AddComponent<BoxCollider2D>();

        //Create the box collider to be on the enemy's head
        //This collider uses an on trigger function so it will only work if the 
        //appropriate trigger occurs
        colliderHead = skyEnemy.AddComponent<BoxCollider2D>();
        colliderHead.offset = new Vector2(0, 0.6f);
        colliderHead.size = new Vector2(0.7f, 0.1f);
        colliderHead.isTrigger = true;

        //The front collider for bullet detection
        colliderFront = skyEnemy.AddComponent<BoxCollider2D>();
        colliderFront.offset = new Vector2(-0.25f, 0);
        colliderFront.size = new Vector2(0.05f, 0.3f);

        //Add the collision trigger script to the enemy. This script is part of the observer pattern implementation
        //to handle events on collision
        skyEnemy.AddComponent<EnemyCollisionTrigger>();
    }

    public override GameObject GetEnemy()
    {
        return this.skyEnemy;
    }
}

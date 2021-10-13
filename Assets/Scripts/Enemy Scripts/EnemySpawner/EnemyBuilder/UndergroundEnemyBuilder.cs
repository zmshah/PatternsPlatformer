//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The concrete ground enemy builder class
public class UndergroundEnemyBuilder : EnemyBuilder
{
    private GameObject undergroundEnemy;

    //The name to be assigned to this enemy
    private string name = "Underground Enemy";

    //The tag to be assigned to this enemy
    private string tag = "Enemy";

    //Assigns the current underground enemy object
    public UndergroundEnemyBuilder(GameObject undergroundEnemy)
    {
        this.undergroundEnemy = undergroundEnemy;
    }

    //Assign the enemy tag and name. These are needed for differentiating behaviors between different enemy types
    public override void BuildEnemyAttributes()
    {
        undergroundEnemy.name = name;
        undergroundEnemy.tag = tag;
    }

    //Assign the movement controller script which uses the strategy pattern to decide the appropriate movement type
    public override void BuildEnemyMovement()
    {
        undergroundEnemy.AddComponent<EnemyMovementController>();
    }

    //Build the collision properties
    public override void BuildEnemyCollison()
    {
        //Main box collider
        colliderEnemy = undergroundEnemy.AddComponent<BoxCollider2D>();

        //Create the box collider to be on the enemy's head
        //This collider uses an on trigger function so it will only work if the 
        //appropriate trigger occurs
        colliderHead = undergroundEnemy.AddComponent<BoxCollider2D>();
        colliderHead.offset = new Vector2(0, 0.6f);
        colliderHead.size = new Vector2(0.7f, 0.1f);
        colliderHead.isTrigger = true;

        //The front collider for bullet detection
        colliderFront = undergroundEnemy.AddComponent<BoxCollider2D>();
        colliderFront.offset = new Vector2(-0.2f, 0);
        colliderFront.size = new Vector2(0.05f, 0.3f);

        //Add the collision trigger script to the enemy. This script is part of the observer pattern implementation
        //to handle events on collision
        undergroundEnemy.AddComponent<EnemyCollisionTrigger>();
    }

    public override GameObject GetEnemy()
    {
        return this.undergroundEnemy;
    }
}

//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The concrete ground enemy builder class
public class GroundEnemyBuilder : EnemyBuilder
{
    private GameObject groundEnemy;

    //The name to be assigned to this enemy
    private string name = "Ground Enemy";

    //The tag to be assigned to this enemy
    private string tag = "Enemy";

    //Assigns the current ground enemy object
    public GroundEnemyBuilder(GameObject groundEnemy)
    {
        this.groundEnemy = groundEnemy;
    }

    //Assign the enemy tag and name. These are needed for differentiating behaviors between different enemy types
    public override void BuildEnemyAttributes()
    {
        groundEnemy.name = name;
        groundEnemy.tag = tag;
    }

    //Assign the movement controller script which uses the strategy pattern to decide the appropriate movement type
    public override void BuildEnemyMovement()
    {
        groundEnemy.AddComponent<EnemyMovementController>();
    }

    //Build the collision properties
    public override void BuildEnemyCollison()
    {
        //Main box collider
        colliderEnemy = groundEnemy.AddComponent<BoxCollider2D>();

        //Create the box collider to be on the enemy's head
        //This collider uses an on trigger function so it will only work if the 
        //appropriate trigger occurs
        colliderHead = groundEnemy.AddComponent<BoxCollider2D>();
        colliderHead.offset = new Vector2(0, 0.2f);
        colliderHead.size = new Vector2(0.4f, 0.1f);
        colliderHead.isTrigger = true;

        //The front collider for bullet detection
        colliderFront = groundEnemy.AddComponent<BoxCollider2D>();
        colliderFront.offset = new Vector2(-0.25f, 0);
        colliderFront.size = new Vector2(0.05f, 0.3f);

        //Add the collision trigger script to the enemy. This script is part of the observer pattern implementation
        //to handle events on collision
        groundEnemy.AddComponent<EnemyCollisionTrigger>();
    }

    public override GameObject GetEnemy()
    {
        return this.groundEnemy;
    }
}

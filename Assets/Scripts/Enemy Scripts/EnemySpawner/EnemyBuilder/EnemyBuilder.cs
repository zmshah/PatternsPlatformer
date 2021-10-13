//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The abstract builder class
//Builds the enemy by component
public abstract class EnemyBuilder
{
    protected GameObject enemy;

    //Colliders

    //Collider for the enemy to detect when a player comes in contact with the enemy. The player is
    //destroyed upon contact
    public BoxCollider2D colliderEnemy;

    //Collider for the head to detect collision when the player jumps on the enemy. This is to keep
    //the collisions from different contact points seperate
    public BoxCollider2D colliderHead;

    //Collider for the front of the enemy for detecting contact with bullets
    public BoxCollider2D colliderFront;

    //Build the base attributes such as name, tag, etc
    public abstract void BuildEnemyAttributes();

    //Attach the movement script to the enemy
    public abstract void BuildEnemyMovement();

    //Build different colliders with different properties
    public abstract void BuildEnemyCollison();

    //Get the current enemy object
    public abstract GameObject GetEnemy();

}

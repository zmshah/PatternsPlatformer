//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Context class for creating enemy movementStrategy
public class ContextEnemyMovement 
{
    //Create a new movenent strategy 
    public EnemyMovementStrategy movementStrategy;

    //Assign the movement strategy
    public ContextEnemyMovement(EnemyMovementStrategy movementStrategy)
    {
        this.movementStrategy = movementStrategy;
    }

    //Execute the movement strategy based on the algorithm
    public void executeMove(GameObject enemy, float originalPosition, float speed)
    {
        movementStrategy.Move(enemy, originalPosition, speed);
    }
}

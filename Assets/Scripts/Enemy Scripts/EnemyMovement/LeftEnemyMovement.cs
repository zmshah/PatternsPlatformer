//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Left movement. Enemy moves left from original position then right
public class LeftEnemyMovement : EnemyMovementStrategy
{
    //Initial direction of movement
    private int direction = 1;

    public override void Move(GameObject enemy, float originalPosition, float speed)
    {
        //Checks to see current position. If position is 5 units left from original position the direction
        //will be swapped and enemy will move right.
        if (enemy.transform.position.x - originalPosition <= -5.0f)
        {
            direction = -1;
        }
        //Checks to see current position. If position is unchanged from original  the direction
        //will remain the same and enemy will move left.
        else if (enemy.transform.position.x - originalPosition >= 0.0f)
        {
            direction = 1;
        }
        //Enemy will move left
        enemy.transform.Translate(Vector3.left * direction * speed * Time.deltaTime);
    }
}

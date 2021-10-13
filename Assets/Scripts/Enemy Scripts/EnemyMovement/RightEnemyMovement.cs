//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Right movement. Enemy moves right from original position then left
public class RightEnemyMovement : EnemyMovementStrategy
{
    //Initial direction of movement
    private int direction = 1;

    public override void Move(GameObject enemy, float originalPosition, float speed)
    {
        //Checks to see current position. If position is 5 units right from original position the direction
        //will be swapped and enemy will move left.
        if (enemy.transform.position.x - originalPosition >= 5.0f)
        {
            direction = -1;
        }
        //Checks to see current position. If position is unchanged from original  the direction
        //will remain the same and enemy will move right.
        else if (enemy.transform.position.x - originalPosition <= 0.0f)
        {
            direction = 1;
        }
        //Enemy will move right
        enemy.transform.Translate(Vector3.right * direction * speed * Time.deltaTime);
    }
}

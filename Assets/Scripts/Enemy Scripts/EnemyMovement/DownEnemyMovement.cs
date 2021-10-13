//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Down movement. Enemy moves down from original position then up
public class DownEnemyMovement : EnemyMovementStrategy
{
    //Initial direction of movement
    private int direction = 1;

    public override void Move(GameObject enemy, float originalPosition, float speed)
    {
        //Checks to see current position. If position is 5 units below original position the direction
        //will be swapped and enemy will move up.
        if (enemy.transform.position.y - originalPosition <= -5.0f)
        {
            direction = -1;
        }
        //Checks to see current position. If position is unchanged from original  the direction
        //will remain the same and enemy will move down.
        else if (enemy.transform.position.y - originalPosition >= 0.0f)
        {
            direction = 1;
        }
        //Enemy will move down
        enemy.transform.Translate(Vector3.down * direction * speed * Time.deltaTime);
    }
}

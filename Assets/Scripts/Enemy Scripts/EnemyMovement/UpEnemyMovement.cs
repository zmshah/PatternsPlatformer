//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Up movement. Enemy moves up from original position then down
public class UpEnemyMovement : EnemyMovementStrategy
{
    //Initial direction of movement
    private int direction = 1;

    public override void Move(GameObject enemy, float originalPosition, float speed)
    {
        //Checks to see current position. If position is 5 units above original position the direction
        //will be swapped and enemy will move down.
        if (enemy.transform.position.y - originalPosition >= 5.0f)
        {
            direction = -1;
        }
        //Checks to see current position. If position is unchanged from original  the direction
        //will remain the same and enemy will move up.
        else if (enemy.transform.position.y - originalPosition <= 0.0f)
        {
            direction = 1;
        }
        //Enemy will move up
        enemy.transform.Translate(Vector3.up * direction * speed * Time.deltaTime);
    }
}

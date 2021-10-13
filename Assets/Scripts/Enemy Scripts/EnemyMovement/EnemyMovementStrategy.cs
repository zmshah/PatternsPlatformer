//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Abstract movementStrategy class
public abstract class EnemyMovementStrategy 
{
    //Method move takes the enemy object, its original/current position and the speed
    public abstract void Move(GameObject enemy, float originalPosition, float speed);   
}

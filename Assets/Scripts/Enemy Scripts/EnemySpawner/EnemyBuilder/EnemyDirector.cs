//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is the director class that will call each method in the builder classes to build the enemy
public class EnemyDirector 
{
    //Construct the enemy
    public void ConstructEnemy(EnemyBuilder builder)
    {
        builder.BuildEnemyAttributes();

        builder.BuildEnemyMovement();

        builder.BuildEnemyCollison();
    }
}

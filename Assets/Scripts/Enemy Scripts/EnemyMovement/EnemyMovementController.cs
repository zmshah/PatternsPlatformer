//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The controller class that assigns the movement algorithm based on the enemy type
public class EnemyMovementController : MonoBehaviour
{
    private ContextEnemyMovement enemyMovement;
    
    //The original x position of the enemy
    private float originalPositionX;

    //The original y position of the enemy
    private float originalPositionY;

    //Enemey movement speed
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        originalPositionX = transform.position.x;
        originalPositionY = transform.position.y;

        //Assigns a random speed
        //speed = Random.Range(1, 5);

        //Assigns a speed of 2
        speed = 2;

        //Assigns a speed of 0...hence enemeies don't move
        //speed = 0;

        //Checks to see type of enemy and decides on which movement class to use based on that
        if (gameObject.name.Equals("Ground Enemy"))
        {
            int n = Random.Range(0, 2);
            //Ground enemies can either move left to right or right to left. This is assigned randomly
            if(n == 0)
            {
                enemyMovement = new ContextEnemyMovement(new RightEnemyMovement());
            }
            else
            {
                enemyMovement = new ContextEnemyMovement(new LeftEnemyMovement());
            }
        }
        else if (gameObject.name.Equals("Sky Enemy"))
        {
            enemyMovement = new ContextEnemyMovement(new UpEnemyMovement());
        }
        else if (gameObject.name.Equals("Underground Enemy"))
        {
            enemyMovement = new ContextEnemyMovement(new DownEnemyMovement());
        }
    }

    // Update is called once per frame
    // Each update checks to see current position of enemy and determines if direction needs to be changed
    void Update()
    {
        if (gameObject.name.Equals("Ground Enemy"))
        {
            enemyMovement.executeMove(gameObject, originalPositionX, speed);
        }
        else if (gameObject.name.Equals("Sky Enemy"))
        {
            enemyMovement.executeMove(gameObject, originalPositionY, speed);
        }
        else if (gameObject.name.Equals("Underground Enemy"))
        {
            enemyMovement.executeMove(gameObject, originalPositionY, speed);
        }
    }
}

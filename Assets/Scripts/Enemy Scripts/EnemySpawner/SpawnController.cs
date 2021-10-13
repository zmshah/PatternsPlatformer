//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    //Enemy prefab
    [SerializeField]
    private GameObject defaultGroundEnemy;

    //Enemy prefab
    [SerializeField]
    private GameObject defaultSkyEnemy;

    //Enemy prefab
    [SerializeField]
    private GameObject defaultUndergroundEnemy;

    //Template for ground enemy
    private Enemy groundEnemyPrototype;

    //Template for sky enemy
    private Enemy skyEnemyPrototype;

    //Template for underground enemy
    private Enemy undergroundEnemyPrototype;

    //Create positions object. Uses the proxy pattern
    ProxyPosition positions = new ProxyPosition(new EnemyPositions());

    //Create an arrays object for storing enemies. The array is created in a singleton
    Enemies enemies = Enemies.Instance;

    // Start is called before the first frame update
    void Start()
    {
        //Generate positions
        positions.GeneratePositions();

        //create the enemies
        CreateEnemies();
    }

    public void CreateEnemies()
    {
        //Create ground enemies
        CreateGroundEnemies();

        //Create sky enemies
        CreateSkyEnemies();

        //Create underground enemies
        CreateUndergroundEnemies();
    }

    //Create ground enemies
    public void CreateGroundEnemies()
    {
        //Create a new ground enemy. This will be the default/prototype and all remaining enemies will
        //use it as a template
        groundEnemyPrototype = new GroundEnemy(defaultGroundEnemy, positions.getGroundPosition(0));

        //Add the enemy to the enemies array
        enemies.AddEnemy(groundEnemyPrototype);

        //Create a new spawner that will take the original ground enemy to clone
        Spawner groundEnemySpawner = new Spawner(groundEnemyPrototype);

        //For loop to clone the original enemy and create new ones
        for (int i = 1; i < 3; ++i)
        {
            Enemy groundEnemy = groundEnemySpawner.SpawnEnemy(positions.getGroundPosition(i)) as GroundEnemy;

            //Add the enemy to the enemies array
            enemies.AddEnemy(groundEnemy);
        }
    }

    //Create sky enemies
    public void CreateSkyEnemies()
    {
        //Create a new sky enemy. This will be the default/prototype and all remaining enemies will
        //use it as a template
        skyEnemyPrototype = new SkyEnemy(defaultSkyEnemy, positions.getSkyPosition(0));

        //Add the enemy to the enemies array
        enemies.AddEnemy(skyEnemyPrototype);

        //Create a new spawner that will take the original sky enemy to clone
        Spawner skyEnemySpawner = new Spawner(skyEnemyPrototype);

        //For loop to clone the original enemy and create new ones
        for (int i = 1; i < 2; ++i)
        {
            Enemy skyEnemy = skyEnemySpawner.SpawnEnemy(positions.getSkyPosition(i)) as SkyEnemy;

            //Add the enemy to the enemies array
            enemies.AddEnemy(skyEnemy);
        }
    }

    //Create underground enemies
    public void CreateUndergroundEnemies()
    {
        //Create a new underground enemy. This will be the default/prototype and all remaining enemies will
        //use it as a template
        undergroundEnemyPrototype = new UndergroundEnemy(defaultUndergroundEnemy, positions.getUndergroundPosition(0));

        //Add the enemy to the enemies array
        enemies.AddEnemy(undergroundEnemyPrototype);

        //Create a new spawner that will take the original underground enemy to clone
        Spawner undergroundEnemySpawner = new Spawner(undergroundEnemyPrototype);

        //For loop to clone the original enemy and create new ones
        for (int i = 1; i < 2; ++i)
        {
            Enemy undergroundEnemy = undergroundEnemySpawner.SpawnEnemy(positions.getUndergroundPosition(i)) as UndergroundEnemy;

            //Add the enemy to the enemies array
            enemies.AddEnemy(undergroundEnemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    
}

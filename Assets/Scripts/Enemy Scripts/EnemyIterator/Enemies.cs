//Zawaad M Shah

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Singleton class for creating arrays of enemies by implementing the aggregate class
//This is where all the enemy objects are stored and accessed later
//Using a singleton as the array and its items may need to be accessed by other objects
public sealed class Enemies 
{
    //create a new enemies list
    ConcreteAggregate enemiesList = new ConcreteAggregate(); 

    private readonly static Enemies instance;

    private Enemies() { }

    static Enemies()
    {
        Enemies.instance = new Enemies();

    }

    public static Enemies Instance
    {
        get
        {
            return Enemies.instance;
        }
    }

    public void AddEnemy(Enemy enemy)
    {
        enemiesList.Add(enemy);
    }

    public ConcreteAggregate GetEnemiesList()
    {
        return enemiesList;
    }

    public Enemy GetEnemy(int n)
    {
        return (Enemy)enemiesList[0];
    }
}

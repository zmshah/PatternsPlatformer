using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;   // controls the speed of bullet
    public int damage = 40;
    public Rigidbody2D rb;      //Referenece to rigidbody
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Bullet";
        // method for bullet to fly
        rb.velocity = transform.right * speed;
      
    }

    //Damage function
    //void OnTriggerEnter2D(Collider2D hitInfo)
    //{
    //    EnemyMovement enemyMovement = hitInfo.GetComponent<EnemyMovement>();
    //    if (enemyMovement != null)
    //    {
    //        enemyMovement.TakeDamage(damage);
    //    }
    //    Destroy(gameObject);
    //}

}

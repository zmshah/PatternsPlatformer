using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgram : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public PlayerFacade playerFacade;

    void Update()
    {
        playerFacade.Update();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        playerFacade.OnCollisionEnter2D(collision);
    }

    void OnLanding()
    {
        playerFacade.OnLanding();
    }

    void OnCrouching(bool isCrouching)
    {
        playerFacade.OnCrouching(isCrouching);
    }

}

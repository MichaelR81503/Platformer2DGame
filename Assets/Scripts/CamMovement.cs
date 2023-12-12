using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    //variables for the game
    public GameObject target;       //determines what object is the camara going to follow

    // Update is called once per frame
    void Update()
    {
        //follow the player on the x axis
        transform.position = new Vector3(target.transform.position.x, transform.position.y, -10);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 7;
    public float leftrightspeed = 5;
    static public bool canMove = false;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftside)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftrightspeed);
                }

            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightside)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftrightspeed * -1);
                }

            }
        }
    }
}

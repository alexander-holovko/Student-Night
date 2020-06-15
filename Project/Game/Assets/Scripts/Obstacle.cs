using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Unit
{
    private void OnCollisionEnter2D(Collision2D collision)
    {        

        if (collision.gameObject.tag == "Kill")
        {
			Destroy(gameObject);
        }
    }
}
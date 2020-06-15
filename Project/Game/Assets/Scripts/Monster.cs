using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Unit
{
    protected virtual void Awake() { }
    protected virtual void Start() { }
    protected virtual void Update() { }

     private void OnCollisionEnter2D(Collision2D collision)
    {        

        if (collision.gameObject.tag == "Kill")
        {
			Destroy(gameObject);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField]
    private int lives = 4;
    [SerializeField]
    private float speed = 3.0f;
    [SerializeField]
    private float jumpforce = 11.0f;

    new private RigidBoody2D rboody;
    private Animator animator;
    private SpriteRenderer sprite;

    private void Awake()
    {
        rboody = GetComponent<RigidBoody2D>();
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class MoveableMonster : Monster
{
    [SerializeField]
    private float speed = 2.0F;

    private Vector3 direction;


    private SpriteRenderer sprite;

    protected override void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    protected override void Start()
    {
        direction = transform.right;
    }

    protected override void Update()
    {
        Move();
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {        

        if (collision.gameObject.tag == "Kill")
        {
			Destroy(gameObject);
        }
    }

    private void Move()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.5F + transform.right * direction.x * 0.5F, 0.1F);

        if (colliders.Length > 0 && colliders.All(x => !x.GetComponent<Hero>())) direction *= -1.0F;

        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
		
		sprite.flipX = direction.x > 0.0F;

    }
}

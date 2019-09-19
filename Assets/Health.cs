using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float deathSpeed;
    public float maxHealth = 100f;
    public float health;
    // Start is called before the first frame update
    void Awake()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            Die();
        }
    }

    public void hurt(float damage)
    {
        health -= damage;
    }

    public void Die()
    {
        GetComponent<Collider2D>().isTrigger = true;
        GetComponent<Rigidbody2D>().gravityScale = 0f;
        GetComponent<SpriteRenderer>().color = Color.Lerp(GetComponent<SpriteRenderer>().color, Color.clear, deathSpeed);
    }
}

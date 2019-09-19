using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    public float damage;
    Animator anim;
    public float speedThreshold;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D c)
    {
        Health otherPlayer = c.collider.GetComponent<Health>();
        if (otherPlayer != null)
        {
            anim.SetTrigger("isAttacking");
            otherPlayer.hurt(damage);

        }

        if (c.collider.CompareTag("Hammer") && c.relativeVelocity.magnitude > speedThreshold)
        {
            Destroy(gameObject);
        }
    }
}

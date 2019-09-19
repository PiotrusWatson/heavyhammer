using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float horizontal;
    Vector2 mouseMovement;
    Vector2 movement;

    Rigidbody2D rb2D;
    Camera mainCamera;

    GameObject hammer;
    HingeJoint2D joint;
    // Start is called before the first frame update
    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        hammer = transform.Find("Hammer").gameObject;
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        joint = GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        mouseMovement = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        joint.useMotor = Input.GetButton("Jump");
        
        
    }

    void FixedUpdate()
    {
        movement = new Vector2(horizontal*speed, rb2D.velocity.y);
        rb2D.velocity = movement;

    }
}

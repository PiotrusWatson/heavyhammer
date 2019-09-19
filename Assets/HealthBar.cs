using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Health playerHealth;
    Slider bar;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Health>();
        bar = GetComponent<Slider>();
        bar.maxValue = playerHealth.maxHealth;


    }

    // Update is called once per frame
    void Update()
    {
        bar.value = playerHealth.health;
    }
}

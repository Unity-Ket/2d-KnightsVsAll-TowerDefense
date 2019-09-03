﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem1Health : MonoBehaviour
{
    [Range (100,300)][SerializeField] float health;
    //Animation Anim;
    //Rigidbody2D Golem1;

    private void Start()
    {
        //Anim = GetComponent<Animation>();
        //Golem1 = GetComponent<Rigidbody2D>();
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            //Anim.SetTrigger("Death");
            Destroy(gameObject);
        }
    }

}//Golem1Health
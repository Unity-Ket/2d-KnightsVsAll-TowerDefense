﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleKnightAttack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D InvaderCollider)
    {
        GameObject invaderObject = InvaderCollider.gameObject;

        if (invaderObject.GetComponent<Attacker>())
        {
            GetComponent<MeleeDefender>().attackInvader(invaderObject);
        }
    }
}//MaleKnightAttack

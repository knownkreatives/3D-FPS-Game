using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerMovement pMove;
    private PlayerHealth pHealth;

    void start(){
        pMove = gameObject.GetComponent<PlayerMovement>();
        pHealth = gameObject.GetComponent<PlayerHealth>();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nice : MonoBehaviour
{
    public GameObject player;
    private PlayerMovement playerMove;


    void Start()
    {
      playerMove = player.GetComponent<PlayerMovement>();
    }

    void Update()
    {

    }
}

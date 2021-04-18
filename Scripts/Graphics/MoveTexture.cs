using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTexture : MonoBehaviour
{
    public float scrollSpeed = 0.1f;

    public Vector2 direction;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float move = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(move * direction.x, move * direction.y));
    }
}

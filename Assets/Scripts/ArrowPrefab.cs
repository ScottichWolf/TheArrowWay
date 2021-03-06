﻿using UnityEngine;

public class ArrowPrefab : MonoBehaviour
{
    private CapsuleCollider2D collider;

    void Start()
    {
        collider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        if (collider.IsTouchingLayers(LayerMask.GetMask("Walls")))
        {
            // GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }

        if (collider.IsTouchingLayers(LayerMask.GetMask("ArrowInstance")))
        {
            //  GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }

    }

}
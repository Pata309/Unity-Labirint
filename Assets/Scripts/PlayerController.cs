﻿using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    public float speed = 50.0f;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        // Inicijalizacija Rigidbody komponente objekta
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        // Dohvat horizontalnog pomaka
        float moveVertical = Input.GetAxis("Horizontal");
        // Dohvat vertikalnog pomaka
        float moveHorizontal = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        // Pomicanje objekta pomocu njegove Rigidbody komponente
        rb.AddForce(movement * speed);
    }
}
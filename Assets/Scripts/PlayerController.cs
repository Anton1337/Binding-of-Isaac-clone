﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour {

    public static readonly string TAG = "Player";   

    private Stats _stats;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _stats = new Stats();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 normalizedInput = new Vector2(horizontal, vertical).normalized;
        Vector2 position = _rb.position;
        position.x = position.x + _stats.MoveSpeed * normalizedInput.x * Time.deltaTime;
        position.y = position.y + _stats.MoveSpeed * normalizedInput.y * Time.deltaTime;

        _rb.MovePosition(position);
    }
}

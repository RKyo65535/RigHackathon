﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallRock : MonoBehaviour
{

    Rigidbody2D objectRigidbody;
    Transform TF;
    Transform cameraTF;

    // Start is called before the first frame update
    void OnEnable()
    {
        cameraTF = GameObject.FindWithTag("MainCamera").transform;
        TF = GetComponent<Transform>();
        objectRigidbody = GetComponent<Rigidbody2D>();
        objectRigidbody.velocity = new Vector2(0, -2);
    }

    private void Update()
    {
        if (TF.position.y < cameraTF.position.y - 100)
        {
            gameObject.SetActive(false);
        }
    }
}

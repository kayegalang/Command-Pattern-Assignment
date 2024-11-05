using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moonshine : MonoBehaviour
{
    private const float GRAVITY_STRENGTH = 9.8f;
    private const float GRAVITY_DIRECTION = -1;

    private void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(GRAVITY_STRENGTH * GRAVITY_DIRECTION, 0));
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

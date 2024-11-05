using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Corgi : MonoBehaviour
{
    public GameManager GameManager;
    
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Beer") || col.gameObject.CompareTag("Moonshine"))
        {
            GameManager.StopGame();
            PlayDeathAnimation();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.CompareTag("Bone"))
        {
            Destroy(col.gameObject);
        }
    }

    private void PlayDeathAnimation()
    {
        animator.Play("Corgi Dying Animation");
    }
}


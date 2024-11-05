// Jump.cs
// This class defines the Jump command for the Command Pattern, allowing an actor
// to perform a jumping action. It manages the jump distance and the falling behavior
// after the jump, ensuring that the actor can only jump when not already in the air.
// Author: Kaye Galang
// Date: 9/23/24
using System.Collections;
using System.Collections.Generic;
using CommandPattern;
using UnityEngine;

public class Jump : Command
{
    private const float JUMP_DISTANCE = 2f;
    
    private bool isJumping = false;

    public override void Execute(GameObject actor)
    {
        if (!isJumping)
        {
            isJumping = true;
            actor.transform.Translate(Vector3.up * JUMP_DISTANCE);
            actor.GetComponent<MonoBehaviour>().StartCoroutine(Fall(actor));
        }
    }

    private IEnumerator Fall(GameObject actor)
    {
        int count = 2;
        while (count > 0)
        {
            yield return new WaitForSeconds(1f);
            actor.transform.Translate(Vector3.down * 1f);
            count--;
        }
        isJumping = false;
    }
}

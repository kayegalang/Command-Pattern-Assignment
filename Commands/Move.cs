// Move.cs
// This class defines the Move command for the Command Pattern, enabling an actor
// to move in a specified direction by a defined step distance. It ensures that 
// the actor's position remains within the bounds of the camera's view.
// Author: Kaye Galang
// Date: 9/23/24
using System.Collections;
using System.Collections.Generic;
using CommandPattern;
using UnityEngine;

public class Move : Command
{
   private const float MOVE_STEP_DISTANCE = 1f;

   private Vector3 direction;
   private Camera mainCamera;

   public Move(Vector3 direction)
   {
      this.direction = direction;
      mainCamera = Camera.main;
   }
   public override void Execute(GameObject actor)
   {
      Vector3 newPosition = actor.transform.position + direction * MOVE_STEP_DISTANCE;
      
      float screenWidth = mainCamera.orthographicSize * mainCamera.aspect;
      
      newPosition.x = Mathf.Clamp(newPosition.x, -screenWidth, screenWidth);

      actor.transform.position = newPosition;
   }
}

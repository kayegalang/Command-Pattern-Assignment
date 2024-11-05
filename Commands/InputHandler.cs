// InputHandler.cs
// This script handles player input in the game, utilizing the Command Pattern
// to execute actions such as moving left, moving right, jumping, and closing the game.
// It checks for specific key inputs and executes the corresponding commands.
// Author: Kaye Galang
// Date: 9/23/24
using System;
using System.Collections;
using System.Collections.Generic;
using CommandPattern;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameManager GameManager;
    
    private Command moveLeft;
    private Command moveRight;
    private Command jump;
    private Command closeGame;

    private void Start()
    {
        moveLeft = new Move(Vector3.left);
        moveRight = new Move(Vector3.right);
        jump = new Jump();
        closeGame = new CloseGame();
    }

    void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        if (!GameManager.GetIsGameRunning())
        {
            return;
        } 
        
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveLeft.Execute(gameObject);
            FaceSpriteLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        { 
            moveRight.Execute(gameObject); 
            FaceSpriteRight();
        }
        else if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            jump.Execute(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            closeGame.Execute(gameObject);
        }
    }

    private void FaceSpriteLeft()
    {
        gameObject.GetComponent<SpriteRenderer>().flipX = true;
    }

    private void FaceSpriteRight()
    {
        gameObject.GetComponent<SpriteRenderer>().flipX = false;
    }
}

using System;
using System.Collections;
using UnityEngine;
using static UnityEngine.InputSystem.Mouse;

public class CursorFollow : MonoBehaviour
{
    private Vector2 _mouseOffset;
    private Vector2 _latsMousePosition;

    private void Awake()
    {
        _mouseOffset = Vector2.zero;
        _latsMousePosition =  Vector2.zero;
        _latsMousePosition = current.position.ReadValue();
    }

    private void Update()
    {
        SetPlayerPositionFromMouse();
    }

    private void SetPlayerPositionFromMouse()
    {
        var transform1 = transform;
        var playerPosition = transform1.position;
        
        
        playerPosition.x = current.position.x.ReadValue()/1920*17.78f - 8.89f;
        playerPosition.y = current.position.y.ReadValue()/1080*10-5;
        transform1.position = playerPosition;
    }
}
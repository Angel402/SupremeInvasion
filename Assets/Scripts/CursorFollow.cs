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

    private void Start()
    {
        SetFirstTimePositionFromMouse();
    }

    private void Update()
    {
        SetPlayerPostionFromMouse();
    }

    private void SetPlayerPostionFromMouse()
    {
        _mouseOffset.x = (current.position.x.ReadValue() - _latsMousePosition.x)/1920*17.78f;
        _mouseOffset.y = (current.position.y.ReadValue() - _latsMousePosition.y)/1080*10;
        _latsMousePosition = current.position.ReadValue();
        var transform1 = transform;
        var playerPosition = transform1.position;
        playerPosition.x += _mouseOffset.x;
        playerPosition.y += _mouseOffset.y;
        transform1.position = playerPosition;
        _mouseOffset = Vector2.zero;
    }

    private void SetFirstTimePositionFromMouse()
    {
        var transform1 = transform;
        var playerPosition = transform1.position;
        playerPosition.x = (current.position.x.ReadValue()) * 17.78f - 8.89f;
        playerPosition.y = (current.position.y.ReadValue()) * 10 - 5;
        transform1.position = playerPosition;
    }
    
}
using System;
using System.Collections;
using UnityEngine;
public class CursorFollow : MonoBehaviour
{
    private Vector2 _mouseOffset;
    private Vector2 _latsMousePosition;

    private void Awake()
    {
        _mouseOffset = Vector2.zero;
        _latsMousePosition =  Vector2.zero;
        _latsMousePosition = Input.mousePosition;
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
        _mouseOffset.x = (Input.mousePosition.x - _latsMousePosition.x)/1920*17.78f;
        _mouseOffset.y = (Input.mousePosition.y - _latsMousePosition.y)/1080*10;
        _latsMousePosition = Input.mousePosition;
        var playerPosition = transform.position;
        playerPosition.x += _mouseOffset.x;
        playerPosition.y += _mouseOffset.y;
        transform.position = playerPosition;
        _mouseOffset = Vector2.zero;
    }

    private void SetFirstTimePositionFromMouse()
    {
        var playerPosition = transform.position;
        playerPosition.x = (Input.mousePosition.x / 1920) * 17.78f - 8.89f;
        playerPosition.y = (Input.mousePosition.y / 1080) * 10 - 5;
        transform.position = playerPosition;
    }
    
}
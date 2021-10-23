using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameFacade : MonoBehaviour
{    
    private ConstantBackgroundMovement _constantBackgroundMovement;
    [SerializeField] private GameObject backgroundGO;
    private void Awake()
    {
        _constantBackgroundMovement = new ConstantBackgroundMovement();
    }

    private void Update()
    {
        _constantBackgroundMovement.MoveBackground(backgroundGO);
    }
    
    
    
}
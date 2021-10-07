using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFacade : MonoBehaviour
{
    [SerializeField] private Shot shotPrefab;
    [SerializeField] private GameObject backgroundGO;
    [SerializeField] private float velocidad = 2;
    private ConstantBackgroundMoviment _constantBackgroundMoviment;

    [SerializeField] private int numberOfBullets = 1;
    private float bulletSpeed;
    void Start()
    {
        _constantBackgroundMoviment = new ConstantBackgroundMoviment();
        //Cursor.visible = false;
    }

    void Update()
    {
        _constantBackgroundMoviment.MoveBackground(backgroundGO,velocidad);
    }
    
    private void OnMouseDown()
    {
        shotPrefab.Create(transform.position, numberOfBullets);
    }

    public void IncreaseShootSpeed(GameObject gameObject)
    {
        bulletSpeed += 0.01f;
        shotPrefab.SetBulletSpeed(bulletSpeed);
        Transform.Destroy(gameObject);
    }
    
    
    
}

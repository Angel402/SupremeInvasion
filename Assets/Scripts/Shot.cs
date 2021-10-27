using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    public float bulletSpeed = 0;
    
    public void Create(Vector3 position, int numberOfBullets)
    {
        var shot = Instantiate(gameObject);
        transform.position = new Vector3(position.x, position.y, 0);
        CreateBullets(shot,position,numberOfBullets);
    }

    private void CreateBullets(GameObject shotGO, Vector3 position1, int numberOfBullets)
    {
        for (var i = 0; i < numberOfBullets; i++)
        {
            var bulletGO = Instantiate(bulletPrefab.gameObject, shotGO.transform, true);
            bulletGO.transform.position = new Vector3(position1.x+(0.13f*i), position1.y, 0);
        }

        var position = shotGO.transform.position;
        position = new Vector3(position.x-((.13f*numberOfBullets)/2),position.y,0);
        shotGO.transform.position = position;
    }

    private void Update()
    {
        gameObject.transform.Translate(new Vector3(0, bulletSpeed));
        if(transform.childCount == 0) Destroy(gameObject);
    }
}

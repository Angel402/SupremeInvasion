using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private GameObject _shotGO;
    private float _bulletSpeed;
    
    public void Create(Vector3 posicion, int numberOfBullets)
    {
        _shotGO = gameObject;
        _shotGO = Instantiate(gameObject);
        _shotGO.transform.position = new Vector3(posicion.x, posicion.y, 0);
        CreateBullets(_shotGO,posicion,numberOfBullets);
    }

    private void CreateBullets(GameObject shotGO, Vector3 posicion, int numberOfBullets)
    {
        for (var i = 0; i < numberOfBullets; i++)
        {
            var bulletGO = Instantiate(bulletPrefab.gameObject, shotGO.transform, true);
            bulletGO.transform.position = new Vector3(posicion.x+(0.13f*i), posicion.y+1, 0);
        }

        var position = shotGO.transform.position;
        position = new Vector3(position.x-((.13f*numberOfBullets)/2),position.y,0);
        shotGO.transform.position = position;
    }

    public void SetBulletSpeed (float bulletSpeed)
    {
        _bulletSpeed = bulletSpeed;
    }
    
    private void Update()
    {
        if (_shotGO != null)
        {
            _shotGO.gameObject.transform.Translate(new Vector3(0, _bulletSpeed));
        }
    }
}

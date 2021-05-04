using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private float _spreadAngle;
    public override void Shoot(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.Euler(0, 0, -_spreadAngle));
        Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        Instantiate(Bullet, shootPoint.position, Quaternion.Euler(0, 0, _spreadAngle));
    }
}

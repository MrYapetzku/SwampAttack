using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UZI : Weapon
{
    [SerializeField] private float timeBetweenShots;
    [SerializeField] private int countOfBulletInShoot;

    private Coroutine _shotCoroutine;

    public override void Shoot(Transform shootPoint)
    {
        if (_shotCoroutine == null)
            _shotCoroutine = StartCoroutine(ShotQueue(countOfBulletInShoot, shootPoint));        
    }

    private IEnumerator ShotQueue(int numberOfBullets, Transform shootPoint)
    {
        int shotsLeft = numberOfBullets;
        while (shotsLeft > 0)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            --shotsLeft;
            yield return new WaitForSeconds(timeBetweenShots);
        }
        //StopCoroutine(_shotCoroutine);
        _shotCoroutine = null;
    }
}

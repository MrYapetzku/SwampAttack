using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Attack", menuName = "Enemy Attack/Create new enemy attack", order = 51)]

public class EnemyAttack : ScriptableObject
{
    [SerializeField] private int _damage;
    [SerializeField] private float _delay;
    [SerializeField] private string _animationTag;

    public int Damage => _damage;
    public float Delay => _delay;
    public string AnimationTag => _animationTag;
}

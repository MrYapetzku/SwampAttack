using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class AttackState : State
{
    [SerializeField] private EnemyAttack[] _attacks;

    private float _lastAttackTime;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_lastAttackTime <= 0)
        {
            int i = Random.Range(0, _attacks.Length);

            Attack(Target, _attacks[i].Damage, _attacks[i].AnimationTag);
            _lastAttackTime = _attacks[i].Delay;
        }

        _lastAttackTime -= Time.deltaTime;
    }

    private void Attack(Player target, int damage, string animationTag)
    {
        _animator.Play(animationTag);
        target.ApplyDamage(damage);
    }
}

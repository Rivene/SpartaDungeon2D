using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class TopDownPlayerAnimationController : TopDownAnimations
{
    private static readonly int isMove = Animator.StringToHash("isMove");
    private static readonly int Attack = Animator.StringToHash("Attack");
    private static readonly int IsHit = Animator.StringToHash("IsHit");
    private static readonly int Death = Animator.StringToHash("Death");

    private HealthSystem _healthSystem;

    protected override void Awake()
    {
        base.Awake();
        _healthSystem = GetComponent<HealthSystem>();
    }

    void Start()
    {
        controller.OnAttackEvent += Attacking;
        controller.OnMoveEvent += Move;

        if (_healthSystem != null)
        {
           // _healthSystem.OnDamage += Hit;
           // _healthSystem.OnInvincibilityEnd += InvincibilityEnd;
        }
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(isMove, obj.magnitude > .5f);
    }

    private void Attacking(AttackSO obj)
    {
        animator.SetTrigger(Attack);
    }

    //private void hit()
    //{
    //    animator.setbool(ishit, true);
    //}

    //private void invincibilityend()
    //{
    //    animator.setbool(ishit, false);
    //}

    private void isDeath()
    {
        animator.SetBool(Death, true);
    }
}

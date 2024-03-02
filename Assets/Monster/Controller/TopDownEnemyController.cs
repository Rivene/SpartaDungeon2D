using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownEnemyController : TopDownCharacterController
{
    GameManager gameManager;

    protected Transform ClosestTarget { get; private set; }

    protected override void Awake()
    {
        base.Awake();
    }

    protected virtual void Start()
    {
        gameManager = GameManager.Instance;
        if (gameManager != null)
        {
            ClosestTarget = gameManager.Player;
            if (ClosestTarget != null)
            {
                Debug.Log("ClosestTarget is set to: " + ClosestTarget.name);
            }
        }
    }

    protected virtual void FixedUpdate()
    {

    }

    protected float DistanceTotarget()
    {
        if (ClosestTarget != null)
        {
            return Vector3.Distance(transform.position, ClosestTarget.position);
        }
        else
        {
            return float.MaxValue;
        }
    }

    protected Vector2 DirectionToTarget()
    {
        if (ClosestTarget != null)
        {
            return (ClosestTarget.position - transform.position).normalized;
        }
        else
        {
            return Vector2.zero;
        }
    }
}
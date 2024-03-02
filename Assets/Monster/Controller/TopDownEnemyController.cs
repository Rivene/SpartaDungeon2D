using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownEnemyController : TopDownCharacterController
{
    GameManager gameManager;

    protected Transform ClosestTarget { get; private set; }
    public static GameManager instance;

    private void Awake()
    {
        if (GameManager.instance == null)
        {
            GameManager.instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    protected virtual void Start()
    {
        gameManager = GameManager.instance;
        if (gameManager != null)
        {
            ClosestTarget = gameManager.Player;
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
            return float.MaxValue; // 또는 적절한 값으로 초기화
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
            return Vector2.zero; // 또는 적절한 값으로 초기화
        }
    }
}
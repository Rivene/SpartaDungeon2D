using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject arrowPrefab; // 화살 프리팹
    public Transform firePoint; // 화살이 발사될 위치
    public float arrowSpeed;

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        
        if (arrowPrefab != null)
        {
            // 화살을 생성하고 발사 위치에 배치
            GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);

            // 화살이 방향을 설정 (플레이어가 바라보는 방향)
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            direction.Normalize();
            arrow.GetComponent<Rigidbody2D>().velocity = direction * arrowSpeed;
        }
    }
}

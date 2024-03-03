using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject arrowPrefab; // ȭ�� ������
    public Transform firePoint; // ȭ���� �߻�� ��ġ
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
            // ȭ���� �����ϰ� �߻� ��ġ�� ��ġ
            GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);

            // ȭ���� ������ ���� (�÷��̾ �ٶ󺸴� ����)
            Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            direction.Normalize();
            arrow.GetComponent<Rigidbody2D>().velocity = direction * arrowSpeed;
        }
    }
}

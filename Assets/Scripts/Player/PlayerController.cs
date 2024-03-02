using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.PlayerSettings;

public class PlayerController : MonoBehaviour
{
    public float attackDamage = 10f;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private SceneLoader loader;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        loader = FindObjectOfType<SceneLoader>();
    }

    private float curTime;
    public float coolTime = 0.5f;
    public Transform pos;
    public Vector2 boxSize;

    void Update()
    {
        //�����̱�
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        rb.velocity = movement * moveSpeed;

        //�ִϸ��̼�
        if (movement.magnitude > 0.1f) //�����϶�
        {
            animator.SetBool("isMove", true);
        }
        else //������������
        {
            animator.SetBool("isMove", false);
        }

        // ���콺 ���⿡ ���� ĳ���� �¿� �ٲٱ�
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePosition.x < transform.position.x)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }

        if (curTime <= 0) // ���콺 ���� ��ư�� ���� ��
        {
            if (Input.GetMouseButtonDown(0))
            {
                Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(pos.position, boxSize, 0);
                foreach (Collider2D collider in collider2Ds)
                {
                    if (collider.CompareTag("Enemy")) // ���͸� ������ ��
                    {
                        AttackEnemy(collider.gameObject);
                    }
                }
                animator.SetTrigger("Attack");
                curTime = coolTime;
            }
        }
        else
        {
            curTime -= Time.deltaTime;
        }

    }

    void AttackEnemy(GameObject enemy)
    {
        // ���Ϳ��� �������� ������ �ڵ带 �ۼ��ϼ���
        // ���� ��� ���Ͱ� HealthSystem�� ������ �ִٸ� HealthSystem�� ����Ͽ� �������� ���� �� �ֽ��ϴ�
        HealthSystem enemyHealth = enemy.GetComponent<HealthSystem>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(attackDamage); // attackDamage�� �÷��̾� ���ݷ¿� ���� �����Ǿ�� �մϴ�
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "DungeonPortal")
        {
            Debug.Log("��Ż");
            loader.isDungeonPortal();
        }
        else if(coll.gameObject.tag == "ExitPortal")
        {
            Debug.Log("��Ż");
            loader.isExitPortal();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(pos.position, boxSize);
    }
}

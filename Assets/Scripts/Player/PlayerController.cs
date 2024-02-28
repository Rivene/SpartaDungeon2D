using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int attackDamage = 10;
    public LayerMask monsterLayer;

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

    void Update()
    {
        //�����̱�
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

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

        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư�� ���� ��
        {
            Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
    }

    //private void OnTriggerEnter2D(Collider2D coll)
    //{
    //    if (coll.gameobject.comparetag("monster"))
    //    {
    //        monster monster = coll.gameobject.getcomponent<monster>();
    //        if (monster != null)
    //        {

    //            monster.takedamage(attackdamage);
    //        }
    //    }

    //    else if (coll.gameObject.CompareTag("DungeonPortal") && loader != null)
    //    {
    //        loader.isDungeonPortal();
    //    }
    //}

    void Die()
    {
        Destroy(gameObject);
    }
}

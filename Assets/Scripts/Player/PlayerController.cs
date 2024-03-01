using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.PlayerSettings;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private SceneLoader loader;
    private CharacterStatsHandler statsHandler;
    public AttackSO attackSO;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        loader = FindObjectOfType<SceneLoader>();
        statsHandler = GetComponent<CharacterStatsHandler>();
    }

    private float curTime;
    public float coolTime = 0.5f;
    public Transform pos;
    public Vector2 boxSize;

    void Update()
    {
        //움직이기
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontalInput, verticalInput);
        rb.velocity = movement * moveSpeed;

        //애니메이션
        if (movement.magnitude > 0.1f) //움직일때
        {
            animator.SetBool("isMove", true);
        }
        else //가만히있을때
        {
            animator.SetBool("isMove", false);
        }

        // 마우스 방향에 따라 캐릭터 좌우 바꾸기
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePosition.x < transform.position.x)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }

        if (curTime <= 0) // 마우스 왼쪽 버튼을 누를 때
        {
            if (Input.GetMouseButtonDown(0))
            {
                Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(pos.position, boxSize, 0);
                foreach (Collider2D collider in collider2Ds)
                {
                    Debug.Log(collider.tag);
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

    void Attack()
    {
        animator.SetTrigger("Attack");
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "DungeonPortal")
        {
            Debug.Log("포탈");
            loader.isDungeonPortal();
        }
        else if(coll.gameObject.tag == "ExitPortal")
        {
            Debug.Log("포탈");
            loader.isExitPortal();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(pos.position, boxSize);
    }
}

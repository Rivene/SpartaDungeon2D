using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
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

    void Update()
    {
        //움직이기
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

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

        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼을 누를 때
        {
            Attack();
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
}

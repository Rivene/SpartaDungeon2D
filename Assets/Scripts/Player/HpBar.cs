using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    private SceneLoader loader;
    public Slider hpSlider; 
    public float maxHealth = 100f; 
    public float damage = 10f;
    public float damageDelay = 1f;

    private float timeCheck = 0f;

    private void Awake()
    {
        loader = FindObjectOfType<SceneLoader>();
    }

    private void Update()
    {
        timeCheck += Time.deltaTime;
        hpSlider.value = maxHealth;
        if(maxHealth > 100)
        {
            maxHealth = 100f;
        }
    }

    //private void OnTriggerEnter2D(UnityEngine.Collider2D coll)
    //{
    //    if(coll.gameObject.tag == ("Arrow"))
    //    {
    //        Debug.Log("적원거리공격");
    //        TakeDamage();
    //    }
    //}
    private void OnCollisionEnter2D(UnityEngine.Collision2D coll)
    {
        if (coll.gameObject.tag == ("Enemy"))
        {
            TakeDamage();
            timeCheck = 0f;
        }
    }

    private void OnCollisionStay2D(UnityEngine.Collision2D coll)
    {
        if (coll.gameObject.tag == ("Enemy"))
        {
            if (timeCheck > 1f)
            {
                TakeDamage();
                timeCheck = 0f;
            }
        }
    }
    private void OnCollisionExit2D(UnityEngine.Collision2D coll)
    {
        if (coll.gameObject.tag == ("Enemy"))
        {
            timeCheck = 0f;
        }
    }
    

    private void TakeDamage()
    {
        maxHealth -= damage;


        if (maxHealth <= 0)
        {
            Debug.Log("게임오버");
            loader.isDeath();
        }
    }
}

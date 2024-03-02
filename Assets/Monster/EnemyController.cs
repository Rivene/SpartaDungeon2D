using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private HealthSystem healthSystem;

    private void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
        healthSystem.OnDamage += OnDamage;
        healthSystem.OnDeath += OnDeath;
    }

    private void OnDamage()
    {
        Debug.Log("Enemy is damaged!");
    }

    private void OnDeath()
    {
        Debug.Log("Enemy is dead!");
        Destroy(gameObject);
    }
}

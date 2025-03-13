using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyDamageController : MonoBehaviour
{
    [SerializeField]
    float damage;

    public float cooldownTime = 1f;
    private bool canDamage = true;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HealthController playerHealth = other.GetComponent<HealthController>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
                StartCoroutine(Cooldown());
            }
        }
    }

    private IEnumerator Cooldown()
    {
        canDamage = false;
        yield return new WaitForSeconds(cooldownTime);
        canDamage = true;
    }

}
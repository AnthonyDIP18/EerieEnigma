using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    float maxHealth;
    float _currentHealth;

    [SerializeField]
    bool isPlayer;


    public AudioSource audioSource;
    public AudioClip damageSonido;
    public float volumen = 1f;

    private void Awake()
    {
        _currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= Mathf.Abs(damage);
        audioSource.PlayOneShot(damageSonido, volumen);
        if (_currentHealth <= 0.0F)
        {
            if (isPlayer)
            {
                Cursor.visible = true;
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    public void Heal(float repair)
    {
        _currentHealth += Mathf.Abs(repair);
    }
}

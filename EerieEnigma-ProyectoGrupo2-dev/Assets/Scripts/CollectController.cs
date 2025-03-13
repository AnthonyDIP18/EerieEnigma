using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class CollectController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int collectables = 0;

    public AudioSource audioSource;
    public AudioClip recogerSonido;
    public float volumen = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            Destroy(other.gameObject , 2f);
            collectables++;
            
            UpdateCollectableText();
            audioSource.PlayOneShot(recogerSonido, volumen);
        }

        if (collectables == 5)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Win");
        }
    }



    private void UpdateCollectableText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Artefactos: " + collectables.ToString() + "/5";
        }
    }

    

}
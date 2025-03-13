using UnityEngine;

public class ColectSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip recogerSonido;
    public float volumen = 1f;

    public void RecogerSound()
    {
        audioSource.PlayOneShot(recogerSonido, volumen);
    }
}
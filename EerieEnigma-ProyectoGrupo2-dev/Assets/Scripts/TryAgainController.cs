using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainController : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = true;
    }
    public void TryAgain()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Map_Hospital");
        Cursor.visible = false;
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Cursor.visible = true; // Asegura que el cursor esté visible al cargar una nueva escena
    }

}
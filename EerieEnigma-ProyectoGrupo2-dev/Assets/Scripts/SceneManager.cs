using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Map_Hospital");
        Cursor.visible = false;
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
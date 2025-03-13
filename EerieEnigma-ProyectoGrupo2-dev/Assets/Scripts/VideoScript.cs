using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public VideoPlayer video;

    void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video.Play();
        video.loopPointReached += CheckOver;
    }
    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("InitialMenu");
    }

    void CheckOver(VideoPlayer vp)
    {
        RestartGame();
    }
}


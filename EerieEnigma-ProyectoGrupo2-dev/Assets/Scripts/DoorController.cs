using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator doorAnimator;

    bool doorOpen = false;

    private void Awake()
    {
        doorAnimator = GetComponent<Animator>();

    }

    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            doorAnimator.Play("OpenDoor", 0, 0.0f);
            doorOpen = true;
        }
        else
        {
            doorAnimator.Play("CloseDoor", 0, 0.0f);
            doorOpen = false;
        }
    }
}


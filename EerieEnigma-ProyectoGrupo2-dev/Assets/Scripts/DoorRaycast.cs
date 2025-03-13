using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorRaycast : MonoBehaviour
{
    [SerializeField]
    float rayLength = 0.0F;

    [SerializeField]
    LayerMask layerMaskInteract;

    [SerializeField]
    string excludeLayerName = null;

    private DoorController raycastedObj;

    [SerializeField]
    KeyCode openDoorKey = KeyCode.Mouse0;

    [SerializeField]
    Image crosshair = null;

    bool isCrosshairActive;
    bool doOnce;

    const string intercatableTag = "InteractiveObject";

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if (hit.collider.CompareTag(intercatableTag))
            {
                if(!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<DoorController>();
                    CrossshairChange(true);
                }

                isCrosshairActive = true;
                doOnce = true;

                if (Input.GetKeyDown(openDoorKey))
                {
                    raycastedObj.PlayAnimation();
                }
            }
        }

        else
        {
            if (isCrosshairActive)
            {
                CrossshairChange(false);
                doOnce = false;
            }
        }
    }

    void CrossshairChange(bool on)
    {
        if (on && !doOnce) 
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
            isCrosshairActive = false;
        }
    }
}

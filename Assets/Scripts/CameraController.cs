using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera MainCamera;

    public void PointTo(Transform target)
    {
        MainCamera.transform.LookAt(target);
    }

}

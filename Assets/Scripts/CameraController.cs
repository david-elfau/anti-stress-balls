using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera MainCamera;
    public Vector3 offset;

    public void PointTo(Vector3 point)
    {
        MainCamera.transform.LookAt(point + offset);
    }

}

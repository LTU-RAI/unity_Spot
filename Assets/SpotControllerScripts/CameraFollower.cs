using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // public Vector3 rotation;
    // public Eigen:
    // public Quater rotation;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;

        // transform.rotation = transform.rotation + rotation;
    }
}

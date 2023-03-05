using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private Camera cam;

    private Vector3 velocity = Vector3.zero;// ÿ���ƶ��ľ���
    private Vector3 yRotation = Vector3.zero; // ��ת��ɫ
    private Vector3 xRotation = Vector3.zero; // ��ת�����


    public void Move(Vector3 velo)
    {
        velocity = velo;
    }

    public void Rotate(Vector3 yRotate, Vector3 xRotate)
    {
        yRotation = yRotate;
        xRotation = xRotate;
    }

    private void PerformMovement()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        }
    }

    private void PerformRotation()
    {
        if (yRotation != Vector3.zero)
        {
            rb.transform.Rotate(yRotation);
        }

        if (xRotation != Vector3.zero)
        {
            cam.transform.Rotate(xRotation);
        }
    }

    private void FixedUpdate()
    {
        PerformMovement();
        PerformRotation();
    }
}

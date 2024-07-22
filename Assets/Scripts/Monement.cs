using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private GameObject camera;

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        UpdateCameraPosition();
    }

    private void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized * moveSpeed * Time.deltaTime;
        transform.position += move;
    }

    private void UpdateCameraPosition()
    {
        if (camera != null)
        {
            camera.transform.position = transform.position + new Vector3(0, 5, -2); // Adjust as needed
        }
    }
}

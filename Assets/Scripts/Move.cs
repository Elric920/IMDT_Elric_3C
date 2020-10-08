using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (h!=0||v!=0)
        {
            moveSpeed = Mathf.Lerp(moveSpeed, 10, Time.deltaTime);
            transform.Translate(new Vector3(h * Time.deltaTime * moveSpeed, 0, v * Time.deltaTime * moveSpeed));
        }
        else
        {
            moveSpeed = 0.0f;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rbPlayer;
    [SerializeField]float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalalInput = Input.GetAxis("Vertical");
        Vector3 v3 = new Vector3(horizontalInput , 0f, verticalalInput);
        rbPlayer.AddForce(v3 * speed);
    }
}

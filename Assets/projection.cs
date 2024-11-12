using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projection : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector3(0.0f, 0.1f,8.5f);
    }

    // Update is called once per frame
    void Update()
    {
        float steering = Input.GetAxis("Vertical");
         if (Input.GetKey(KeyCode.Space)) {
            Rigidbody rb = GetComponent<Rigidbody> ();
            rb.AddForce(new Vector3(0.0f, 5.0f,-30.0f));
         }
    }

    // void OnCollisionEnter() {

    // }
}

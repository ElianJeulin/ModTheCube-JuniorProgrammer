using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMvt = Input.GetAxis("Horizontal");
        float verticalMvt = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * horizontalMvt);
        transform.Translate(Vector3.up * speed * Time.deltaTime * verticalMvt);
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
    }
}

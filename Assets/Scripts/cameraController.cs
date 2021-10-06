using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    [SerializeField]
    float rotSpeed = 150;

    [SerializeField]
    Transform lookvertical;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        Debug.Log(lookvertical.localRotation.x);

        if (lookvertical.rotation.y >= 0.45)
        {
            lookvertical.Rotate(new Vector3(-80, 0, 0));
            Debug.Log("too far!");
        }
        if (lookvertical.rotation.y <= -0.45)
        {
            lookvertical.Rotate(new Vector3(80, 0, 0));
            Debug.Log("too far!");
        }

        transform.Rotate(new Vector3(0, x*rotSpeed*Time.deltaTime, 0));
        lookvertical.Rotate(new Vector3(-y * rotSpeed * Time.deltaTime, 0, 0));

       
    }
}

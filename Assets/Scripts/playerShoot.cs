using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{

    [SerializeField]
    GameObject bullet;

    [SerializeField]
    Transform gunBarrel;

    [SerializeField]
    float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ammo: " + gameManager.instance.ammo);
        Debug.Log("Score: " + gameManager.instance.score);
        if (gameManager.instance.ammo > 0 && Input.GetButtonDown("Fire1"))
        {
            gameManager.instance.ammo--;
            Vector3 bulletDirection = transform.forward * bulletSpeed;
            GameObject b = Instantiate(bullet, gunBarrel.position, transform.rotation);
            b.GetComponent<Rigidbody>().velocity = bulletDirection;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed;
    float vMouse;
    float vRotation;
    float mouseSensitivity = 300f;

    public bool canShoot = true;

    public GameObject Gun;

    void Start() { 
    
    }
    void Update()
    {
        vMouse = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        vRotation += vMouse * -1;                                          
        vRotation = Mathf.Clamp(vRotation, -90f, 15f);

        Gun.transform.Rotate(Vector3.right * vMouse);
        Gun.transform.localRotation = Quaternion.Euler(vRotation, 0, 0);

        if (Input.GetButtonDown("Fire1") && canShoot == true)
        {
            StartCoroutine(FireBurst());
        }
    }
    public IEnumerator FireBurst()
    {
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            canShoot = false;
            yield return new WaitForSeconds(1.5f);
            canShoot = true;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Something")
        {
            Destroy(gameObject);
        }
    }
}

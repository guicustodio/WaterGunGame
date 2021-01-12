using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
            Destroy(gameObject);
    }
}

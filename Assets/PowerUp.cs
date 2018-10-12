using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Untagged"))
        {
            print(other.tag);
            //print(other.CompareTag("Untagged"));
            Destroy(gameObject);
        }
    }

}
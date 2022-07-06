using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float force;
    public float x;

    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(!collision.collider.CompareTag("Bounce"))
        //Alternative : if(collision.collider.tag != "Bounce") 
        // "si le tag de l'objet avec lequel je suis entré en collision (càd le collider ) n'est pas "Bounce", alors je ne peux pas se tp (mieux qu'un if...else car on aurait eu un if vide et notre code dans notre else)
        {
            ContactPoint cp = collision.GetContact(0);
            if(Vector3.Angle(cp.normal, Vector3.up) <= 45){
                playerTransform.position = collision.GetContact(0).point;
                Destroy(gameObject);            

            }

        }
    }

}

// la normale = direction perpendiculaire à la collision


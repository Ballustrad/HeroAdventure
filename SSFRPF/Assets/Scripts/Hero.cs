using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        CapsuleCollider2D collider = collision.otherCollider as CapsuleCollider2D;
        
        if (collider != null)
        {
            Debug.Log("oui");

        }
        else
        {
            print("non");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyBomb : MonoBehaviour
{
    public float bombDamage = 50f;
    private void OnCollisionEnter(Collision collision)
    {
        PlayerMovement playerMovement = collision.gameObject.GetComponentInParent<PlayerMovement>();

        if (playerMovement != null)
        {
            Debug.Log("I have collided");

            // Call a function on the PlayerMovement component
            playerMovement.TakeDamage(bombDamage);
            // Alternatively, if you want to call a function with parameters:
            // playerMovement.YourFunctionNameHere(bombDamage);
        }
    }

}

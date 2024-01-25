using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : Weapon
{
    public Animator animator = null;
    public CapsuleCollider myCollider = null;

    protected new void Start()
    {
        base.Start();
    }

    public override bool Fire()
    {

        if (base.Fire() == false)
        {
            return false;
        }
        Debug.Log("TRO");
        StartSlashRoutine();
        return true;
    }

    void StartSlashRoutine()
    {
        StartCoroutine(SlashAttack());
    }
    IEnumerator SlashAttack()
    {
        animator.SetBool("isSlash", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("isSlash", false);
    }
    
    public void InitializeCollider()
    {
        myCollider.enabled = true;
    }

    public void DeactivateCollider()
    {
        myCollider.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.collider == myCollider)
        {
            Debug.Log("Hitted");
        }
    }
}

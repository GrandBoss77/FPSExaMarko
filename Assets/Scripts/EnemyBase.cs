using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : Agent
{
    public PlayerMovement activePlayer = null;
    public float detectionRange = 10.0f;
    bool moveTowardTarget = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleDetectTarget()
    {
        RaycastHit hit;

        if(Physics.Raycast(new Ray(transform.position, (activePlayer.transform.position - transform.position).normalized), out hit, detectionRange))
        {
            var playerMovement = hit.transform.gameObject.GetComponent<PlayerMovement>();
            if(playerMovement != null)
            {
                OnTargetDetected();
            }
        }
    }

    public void OnTargetDetected()
    {

    }

    public void HandleFollowTarget()
    {

    }

    public void TryHandleEngaged()
    {

    }


}

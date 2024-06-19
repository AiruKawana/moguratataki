using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoleAction : MonoBehaviour
{
 
    [SerializeField] private Vector3 molestartPosition;
    [SerializeField] private float targetPosition = -4.5f;
    [SerializeField] private float startYPosition = -7.71f;
    [SerializeField] private float upRange = 0.02f;
    [SerializeField] private float downRange = -0.02f;
    [SerializeField] private float secondsTimer = 0.01f;

    //[SerializeField] private GameObject mole1;
    // Start is called before the first frame update
    [SerializeField] public void MoleActionStart()
    {
        StartCoroutine("MoleMoveUp");
    }

   IEnumerator MoleMoveUp()
    {
        while (molestartPosition.y < targetPosition)
        {
            molestartPosition = transform.position;
            transform.Translate(0, upRange, 0);
            yield return new WaitForSeconds(secondsTimer);
            StartCoroutine("MoleMoveDown");
        }
    }

    IEnumerator MoleMoveDown()
    {
        if(molestartPosition.y > targetPosition)
        {
            while(molestartPosition.y > startYPosition)
            {
                molestartPosition = transform.position;
                transform.Translate(0, downRange, 0);
                yield return new WaitForSeconds(secondsTimer);
            }   
        }
        
    }
}

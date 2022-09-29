using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTap : MonoBehaviour
{
    [SerializeField] private Animator areaAnime;
    public PadTap padTap; //use variable from another scripts

    private void OnTriggerEnter(Collider other)
    {
        //initial ring i=1
        if (other.CompareTag("Player") && padTap.initials == 1)
        {
            areaAnime.SetBool("playArea", true);
                        
            padTap.initials ++;
            Debug.Log(padTap.initials);        
            return;
        }
    }
}

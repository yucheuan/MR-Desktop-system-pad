using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadTap : MonoBehaviour
{
    [SerializeField] private Animator padAnime;
    [SerializeField] private Animator arrow1Anime;
    [SerializeField] private Animator arrow2Anime;    
    [SerializeField] private Animator areaAnime;
    [SerializeField] private Animator grassAnime;
    public int initials = 0;  

    private void OnTriggerEnter(Collider other)
    {
        //initial ring i=0
        if (other.CompareTag("Player") && initials == 0)
        {
            
            Debug.Log("true");
            padAnime.SetBool("playPadInitials", true);
            arrow1Anime.SetBool("playArrow1", true);
            arrow2Anime.SetBool("playArrow2", true);
            
            if(initials !=1){
                initials++;
                Debug.Log("FIRST");
                Debug.Log(initials);
            }

            return;
        }

        //initial area by arrows i=1
        if (other.CompareTag("Player") && initials == 1)
        {
            if (areaAnime.GetBool("playArea") == false)
            {            
                Debug.Log("SECOND NOT YET");
                Debug.Log(initials);

                return;
            }      

            else{
                initials++;
                Debug.Log("SECOND Done");
                Debug.Log(initials);

                return;
            }
        } 

        //play grass animation i=3
        if (other.CompareTag("Player") && initials != 0 && initials != 1)
        {
            padAnime.SetBool("playPadComfirm", true);
            grassAnime.SetBool("playGrassInitials", true);
            
            if(initials !=1){
                initials++;
                
                Debug.Log("tHIRD");
                Debug.Log(initials);
            }

            return;
        }        
        
        Debug.Log(initials);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            padAnime.SetBool("playPadComfirm", false);
            //panelAnime.SetBool("playPanelAppearAnime", false);
        }
    }
}

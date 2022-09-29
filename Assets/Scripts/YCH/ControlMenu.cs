using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenu : MonoBehaviour
{
    [SerializeField] private Animator ringAnime;
    [SerializeField] private Animator arrow1Anime;
    [SerializeField] private Animator arrow2Anime;
    [SerializeField] private Animator areaAnime;
    [SerializeField] private Animator SideBtnNonUse;
    [SerializeField] private Animator areaDivideAnime;
    [SerializeField] private Animator areaDivideBtnAnime;
    [SerializeField] private Animator windowAnime;
    [SerializeField] private Animator windowBtnAnime;
    [SerializeField] private Animator grassAnime;
    [SerializeField] private Animator grassTransitionAnime;
    [SerializeField] private Animator areaShare;

    public bool play1_Initial = false;
    public bool play2_Comfirm_Toggle = false;
    public bool play3_SyncTable = false;
    public bool play4_BtnDisplay = false;
    public bool play5_AreaDivide = false;
    public bool play6_Window = false;
    public bool play7_Grass = false;
    public bool play8_GrassTransition = false;
    public bool play9_AreaShare = false;

    private int x = 0;

    void Update ()
    {        
        if (play1_Initial == true) {x=1;}
        if (play2_Comfirm_Toggle == true) {x=2;}
        if (play3_SyncTable == true) {x=3;}
        if (play4_BtnDisplay == true) {x=4;}
        if (play5_AreaDivide == true) {x=5;}
        if (play6_Window == true) {x=6;}
        if (play7_Grass == true) {x=7;}
        if (play8_GrassTransition == true) {x=8;}
        if (play9_AreaShare == true) {x=9;}
        

        switch (x)
        {
            case 1: 
            {
                Debug.Log("ok 1");
                ringAnime.SetBool("playPadInitials", true);  
                ringAnime.SetBool("playPadComfirm", false);    
                return;
            }

            case 2:
            {
                Debug.Log("ok 2");
                ringAnime.SetBool("playPadComfirm", true);    
                arrow1Anime.SetBool("playArrowInitial", true);     
                arrow2Anime.SetBool("playArrowInitial", true);     
                return;
            }

            case 3:
            {
                Debug.Log("ok 3");
                areaAnime.SetBool("playArea", true);      
                arrow1Anime.SetBool("playArrowSync", true);    
                return;
            } 

            case 4:
            {
                Debug.Log("ok 4");
                SideBtnNonUse.SetBool("playWindowBtnShow", true);
                windowBtnAnime.SetBool("playWindowBtnShow", true);
                areaDivideBtnAnime.SetBool("playAreaDivideBtnShow", true);
                return;
            }      

            case 5:
            {
                Debug.Log("ok 5");
                areaDivideAnime.SetBool("playAreaDivide", true);  
                areaDivideBtnAnime.SetBool("playAreaDivideBtn", true);  
                return;
            }  

            case 6:
            {
                Debug.Log("ok 6");
                windowAnime.SetBool("playWindow", true);  
                windowBtnAnime.SetBool("playWindowBtn", true);  
                return;
            }  

            case 7:
            {
                Debug.Log("ok 7");
                grassAnime.SetBool("playGrassInitials", true); 

                arrow1Anime.SetBool("notDisplay", true);     
                arrow2Anime.SetBool("notDisplay", true);
                areaDivideAnime.SetBool("notDisplay", true);   
                areaAnime.SetBool("notDisplay", true);
                SideBtnNonUse.SetBool("notDisplay", true);
                windowBtnAnime.SetBool("notDisplay", true);
                areaDivideBtnAnime.SetBool("notDisplay", true);
                return;
            }  

            case 8:
            {
                Debug.Log("ok 7");
                grassTransitionAnime.SetBool("playTransitionAnim", true);   
                return;
            }     

            case 9:
            {
                Debug.Log("ok 7");
                areaShare.SetBool("playShareAnim", true);   
                return;
            }                   
        }  
    }
}

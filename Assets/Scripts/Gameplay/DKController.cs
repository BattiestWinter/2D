using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DKController : MonoBehaviour
{

    public SpriteRenderer dkSprite;

    void Start()
    {
        
    }

    void Update()
    {
//Dependencia de la plataforma
#if UNITY_ANDROID && !UNITY_EDITOR
        if (Input.touchCount > 0)
        {
            fingerTouch = Input.GetTouch(0);
            Debug.Log("Touch count: " + Input.touchCount);
            Debug.Log("Touch position: " + fingerTouch.position);

            if(fingerTouch.position.x < (Screen.width*0.5f))
            {
                dkSprite.flipX = true;
            } 
            else
            {
                dkSprite.flipX = false;
            }
            
        }
#endif

#if UNITY_EDITOR
        if(Input.GetAxis("Horizontal") > 0)
        {
            dkSprite.flipX = false;
        }
        else
        {
            dkSprite.flipX = true;
        }
#endif
    }
}

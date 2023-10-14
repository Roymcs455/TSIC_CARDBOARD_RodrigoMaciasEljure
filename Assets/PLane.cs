using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PLane : MonoBehaviour
{   
    private bool isLookedAt =false;
    private float timeCounter = 0.0f;
    public GameObject desactivar = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( isLookedAt == true)
            timeCounter += Time.deltaTime;
        else
        {
            timeCounter = 0.0f;
        }


        if(timeCounter > 1.0f)
        {
            desactivar.SetActive(false);
        }
        else{
            desactivar.SetActive(true);
        }
        
    }
    void OnPointerEnter()
    {
        isLookedAt = true;
        Debug.Log("is looked at, timeCounter: "+timeCounter);
    }
    void OnPointerExit()
    {
        isLookedAt = false;
        Debug.Log("stopped looked at");
    }
}

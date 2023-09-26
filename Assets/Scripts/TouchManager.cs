using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;


public class TouchManager : MonoBehaviour
{
    [SerializeField] private GameObject[] objetos;
    [SerializeField] private Material[] skybox;

    [SerializeField]private int index = 0; 


    void DesactivarObjetos()
    {
        foreach (var item in objetos)
        {
            item.SetActive(false);
        }
    }
    void Awake()
    {
        DesactivarObjetos();
    }
    void Update() {
    #if UNITY_EDITOR
        if( Input.GetMouseButtonDown(0))
    #else
        if (Input.GetTouch(0).phase == TouchPhase.Began)
    #endif
        {
            DesactivarObjetos();
            switch (index++)
            {
                
                case 0:
                    RenderSettings.skybox = skybox[0];
                break;
                case 1:
                    RenderSettings.skybox = skybox[1];
                break;
                case 2:
                    objetos[0].SetActive(true);
                break;
                case 3:
                    objetos[1].SetActive(true);
                break;
                case 4:
                    objetos[2].SetActive(true);
                break;
                case 5:
                    objetos[3].SetActive(true);
                break;
                case 6:
                    objetos[4].SetActive(true);
                break;
                case 7:
                    objetos[5].SetActive(true);
                break;
                default:
                    index = 0;
                break;
            }
            
            /*if (index == objetos.Length)
            {
                DesactivarObjetos();
            }
            else if (index > objetos.Length + 1)
            {
                index = 0;
                DesactivarObjetos();
                objetos[index].SetActive(true);
            }
            else
            {
                DesactivarObjetos();
                objetos[index].SetActive(true);
            }*/
        }

    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ReponsePos : MonoBehaviour , IDropHandler
{
    public GameObject rp1, rp2, rp3;
    public GameObject Red, Green;
    public Vector2 Rp1Pos, Rp2Pos, Rp3Pos;
    public Vector2 ResponsePos;
    public bool Reponse ;
    public GameObject panel;
    public GameObject outil;
    public void Start()
    {
        
        ResponsePos = this.GetComponent<RectTransform>().position;
        Red.SetActive(false);
        Green.SetActive(false);

    }

    public void Update()
    {


    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "true")
        {
            Reponse = true;
            Green.SetActive(true);
            Red.SetActive(false);
            Debug.Log("mass");
           Destroy(panel, 1.5f);
            Destroy(outil);

        }
        else if (other.tag == "false")
        {
            Reponse = false;
            Red.SetActive(true);
            Green.SetActive(false);
           Destroy(panel, 1.5f);


        }

    }

    public void OnDrop (PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
          
            eventData.pointerDrag.GetComponent<RectTransform>().position = GetComponent<RectTransform>().position;
        }
       
    }
}

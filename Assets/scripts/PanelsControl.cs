using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PanelsControl : MonoBehaviour
{
    public GameObject panelJump;
    public GameObject ques1;
    public GameObject ques2;
    public GameObject ques3;

  
    public float time2 , time3 , time1 , time = 30f;


    public Text TmText1 , TmText2, TmText3;
    public bool Response;
    


    // Start is called before the first frame update
    void Start()
    {
        panelJump.SetActive(false);
        ques1.SetActive(false);
        ques2.SetActive(false);
        ques3.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (ques1.activeSelf==true){ TimeCount(time); }
        if (ques2.activeSelf==true){ TimeX(time1); }
        if (ques3.activeSelf==true){ TimeY(time3);}
       
    }

    public void TimeCount(float totalSeconds)
    {
        
        if (time > 0.1f)
        {
            time -= Time.deltaTime;
        }
        else if (time < 0.1f)
        {
            Debug.Log("timeUp");
            Response = false;
            ques1.SetActive(false);
            ques2.SetActive(false);
            ques3.SetActive(false);
        }

        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        string formatedSeconds = seconds.ToString();

       if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;

        }

        TmText1.text = minutes.ToString("00") + ":" + seconds.ToString("00");




    }



    public void TimeX(float totalSeconds)
    {

        if (time1 > 0.1f)
        {
            time1 -= Time.deltaTime;
        }
        else if (time1< 0.1f)
        {
            Debug.Log("timeUp");
            Response = false;
            ques1.SetActive(false);
            ques2.SetActive(false);
            ques3.SetActive(false);
        }

        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;

        }

        TmText2.text = minutes.ToString("00") + ":" + seconds.ToString("00");



    }



   public void TimeY(float totalSeconds)
    {

        if (time3 > 0.1f)
        {
            time3 -= Time.deltaTime;
        }
        else if (time3 < 0.1f)
        {
            Debug.Log("timeUp");
            Response = false;
            ques1.SetActive(false);
            ques2.SetActive(false);
            ques3.SetActive(false);
        }

        int minutes = Mathf.FloorToInt(totalSeconds / 60f);
        int seconds = Mathf.RoundToInt(totalSeconds % 60f);

        string formatedSeconds = seconds.ToString();

        if (seconds == 60)
        {
            seconds = 0;
            minutes += 1;

        }

       
        TmText3.text = minutes.ToString("00") + ":" + seconds.ToString("00");

    }



    public void ResponseSpeed()
    { if (Response == true)
        {
            Fire.RepeatTime = 4f;

        }
    else if (Response == false)
        {
            Fire.RepeatTime = 0.2f;

        }

    }

        private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "JumpP")
        {
            panelJump.SetActive(true);
        }


        if (other.name == "obs 1")
        {
            ques1.SetActive(true);
        }
       if (other.name == "obs2")
        {
            ques2.SetActive(true);


        }

       if (other.name == "obs3")
        {
            ques3.SetActive(true);

        }
        else
        {
            Time.timeScale = 1;

        }

     

        }
}

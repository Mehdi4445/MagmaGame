using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject FirePref;
    public Transform Pos1;
    public Vector3 pos;
    public float i =0;
    public static float RepeatTime;
    // Start is called before the first frame update
    void Start()
    {
        RepeatTime = 1f;
        InvokeRepeating("Spawn", 2f, RepeatTime);
        
    }

    // Update is called once per frame
    void Update()
    { 
       pos= new Vector3(-109f, -3.22f, -7);
     

    }
    public void Spawn()
    {
        Instantiate(FirePref, new Vector3(pos.x+i, pos.y , pos.z), Quaternion.identity);
        i = i + 2;


    }
    }
   

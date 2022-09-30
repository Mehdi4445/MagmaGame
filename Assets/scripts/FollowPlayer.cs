using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 PlayerPos;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
       // PlayerPos = Player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       //transform.position = PlayerPos + offset;
        transform.position = new Vector3(Player.position.x + offset.x, Player.position.y + offset.y, offset.z);

    }
}

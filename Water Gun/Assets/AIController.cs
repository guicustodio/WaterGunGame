using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public Transform Player;
    int MoveSpeed = 2;
    int MaxDist = 10;
    int MinDist = 5;

    void Update()
    {
        {
            transform.LookAt(Player);

            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;

                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    //play enemy animation
                    //any function we need
                }
            }
        }
    }
}

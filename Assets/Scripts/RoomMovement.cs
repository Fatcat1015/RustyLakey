using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMovement : MonoBehaviour
{
    [Header("Set Positions")]
    public Vector3 rightRoomPosition;
    public Vector3 leftRoomPosition;
    public Vector3 backRoomPosition;

    public Vector3 startRoomPosition;

    public void Awake()
    {
        startRoomPosition = Camera.main.transform.position;
    }

    public void goRightRoom()
    {
        Camera.main.transform.position = rightRoomPosition;
    }

    public void goLeftRoom()
    {
        Camera.main.transform.position = leftRoomPosition;
    }

    public void goBackRoom()
    {
        Camera.main.transform.position = backRoomPosition;
    }

}

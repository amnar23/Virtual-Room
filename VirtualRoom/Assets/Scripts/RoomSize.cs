using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSize : MonoBehaviour
{
    //[SerializeField]
    //GameObject floor;
    //[SerializeField]
    //GameObject roof;
    //[SerializeField]
    //GameObject frontWall;
    //[SerializeField]
    //GameObject rightWall;
    //[SerializeField]
    //GameObject leftWall;
    //[SerializeField]
    //GameObject backWall;

    //bool once = false;
    //Vector3 []size;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    size = new Vector3[6];

    //    size[0] = floor.transform.localScale;
    //    size[1] = roof.transform.localScale;
    //    size[2] = frontWall.transform.localScale;
    //    size[3] = rightWall.transform.localScale;
    //    size[4] = leftWall.transform.localScale;
    //    size[5] = backWall.transform.localScale;
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //    if (!once)
    //    {
    //        size[0].y += 20f;
    //        floor.transform.localScale = size[0];
    //        once = true;
    //    }

    //}
    [SerializeField]
    GameObject room;
    public void SetRoomSize(int length, int width)
    {
        Vector3 size = new Vector3(length, 10, width);
        room.transform.localScale = size;
    }

}

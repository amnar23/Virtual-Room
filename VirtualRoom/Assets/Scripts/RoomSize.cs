using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSize : MonoBehaviour
{
    [SerializeField]
    GameObject room;
    public void SetSize(string json)
    {
        JsonObject jsonObject = JsonUtility.FromJson<JsonObject>(json);
        int length = (jsonObject.length)/10;
        int width = (jsonObject.width)/10;
        Vector3 size = new Vector3(width, 1, length);
        room.transform.localScale = size;
    }
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

    //public void SetSize(string json)
    //{
    //    Debug.Log(json);
        
    //    JsonObject jsonObject = JsonUtility.FromJson<JsonObject>(json);
    //    int length = jsonObject.length;
    //    int width = jsonObject.width;
    //    Debug.Log(width);
    //    Debug.Log(length);
    //    Vector3 size = new Vector3(0.25f, length, width);
    //    roof.transform.localScale = size;
    //    floor.transform.localScale = size;
    //    Vector3 sizee = new Vector3(0.25f, 9, width);
    //    frontWall.transform.localScale = sizee;
    //    backWall.transform.localScale = sizee;
    //    Vector3 sizeee = new Vector3(0.25f, 9, length);
    //    leftWall.transform.localScale = sizeee;
    //    rightWall.transform.localScale = sizeee;

    //}
    //private void Awake()
    //{
    //    int length = 20/10;
    //    int width = 40/10;
    //    Vector3 size = new Vector3(width, 1, length);
    //    room.transform.localScale = size;
    //    //roof.transform.localScale = size;
    //    //floor.transform.localScale = size;
    //    //Vector3 sizee = new Vector3(0.25f, 9, width);
    //    //frontWall.transform.localScale = sizee;
    //    //backWall.transform.localScale = sizee;
    //    //Vector3 sizeee = new Vector3(0.25f, 9, length);
    //    //leftWall.transform.localScale = sizeee;
    //    //rightWall.transform.localScale = sizeee;
    //}
    public class JsonObject
    {
        public int length;
        public int width;
    }

}

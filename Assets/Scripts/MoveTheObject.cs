using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheObject : MonoBehaviour
{
    public GameObject circleItem;
    public GameObject destroyerCube;
    public float speed;
  

    void Update()
    {
        circleItem.transform.position = Vector2.MoveTowards(circleItem.transform.position, destroyerCube.transform.position, speed); 
    }

}

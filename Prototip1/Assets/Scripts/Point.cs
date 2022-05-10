using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    void Update()
    {
        SelfRotate();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PointTaken();
        }
    }
    private void SelfRotate()
    {
        transform.Rotate(0, 45f * Time.deltaTime, 0);
    }
    private void PointTaken()
    {
        
            Destroy(gameObject);
            GameManager.instance.IncreasePoint();
            //IncreasePoint();
    }
}

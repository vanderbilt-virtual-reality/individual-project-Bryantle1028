using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public int Score1;
    public int Score2;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Goal1")
        {
            transform.position = GameObject.Find("BallPosition").transform.position;
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Score1 += 1;
        }
        if (other.gameObject.tag == "Goal2")
        {
            transform.position = GameObject.Find("BallPosition").transform.position;
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Score2 += 1;
        }
    }

    public void Update()
    {
        GameObject.Find("Score1").GetComponent<TextMesh>().text = Score1 + "";
        GameObject.Find("Score2").GetComponent<TextMesh>().text = Score2 + "";
    }
}

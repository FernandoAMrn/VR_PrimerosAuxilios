using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Score.instance.AddPoint();
        }
    }
}

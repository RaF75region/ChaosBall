using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    private void OnTriggerEnter(Collider other)
    {
        GameObject collWidth = other.gameObject;
        if (collWidth.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collWidth);
        }
    }
}

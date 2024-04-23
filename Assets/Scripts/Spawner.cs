using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float destructionDelay = 1f;

    public GameObject leftHandSensor;
    public GameObject rightHandSensor;

    public Transform upperHandLocationL;
    public Transform handLocationL;

    public Transform upperHandLocationR;
    public Transform handLocationR;



    // Start is called before the first frame update

    public void SpawnUpperHandL()
    {
        GameObject sensor = Instantiate(leftHandSensor, upperHandLocationL);
        Destroy(sensor, destructionDelay);
    }

    public void SpawnHandRightt()
    {
        GameObject sensor = Instantiate(rightHandSensor, handLocationR);
        Destroy(sensor, destructionDelay);
    }

    public void SpawnUpperHandR()
    {
        GameObject sensor = Instantiate(rightHandSensor, upperHandLocationR);
        Destroy(sensor, destructionDelay);
    }

    public void SpawnHandLeft()
    {
        GameObject sensor = Instantiate(leftHandSensor, handLocationL);
        Destroy(sensor, destructionDelay);
    }
}

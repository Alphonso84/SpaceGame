using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{
    public GameObject objectToFollow;
    public GameObject[] backgrounds;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        print(objectToFollow.transform.position.y);

        //Make Camera follow player
        transform.position = new Vector3(objectToFollow.transform.position.x, objectToFollow.transform.position.y + Time.deltaTime, -90);

    }
}

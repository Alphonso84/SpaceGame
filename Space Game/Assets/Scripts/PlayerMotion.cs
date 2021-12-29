using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    //private float backgroundMaxYPos = -58.58f;
    //private float backgroundXPos;
    private readonly float speed = 15f;
    private readonly float horizontalSpeed = 20f;
    public GameObject[] background;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        #region PlayerControl
        transform.Translate(Vector2.up * Time.deltaTime * speed);
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector2.left * Time.deltaTime * horizontalSpeed);

        }
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector2.right * Time.deltaTime * horizontalSpeed);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector2.up * Time.deltaTime * (speed + 10f));
            //background[0].transform.Translate(Vector2.down * Time.deltaTime * 5f);
            //background[1].transform.Translate(Vector2.down * Time.deltaTime * 5f);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(Vector2.down * Time.deltaTime * (speed + 20f));
        }
        if (transform.position.y >= 238.6)
        {
            print("Move Ship");
            transform.position = new Vector3(-3.7f, 0f, -1);
        }
        #endregion
    }
}

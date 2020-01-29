using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject MyPlayer;
    public GameObject MyCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MyCamera.transform.position = new Vector3 (MyPlayer.transform.position.x, MyPlayer.transform.position.y+0.5f, MyPlayer.transform.position.z-1);

        if (Input.GetKey("w"))
        {
            MyPlayer.transform.Translate(0, 0, -0.2f);

        }
        if (Input.GetKey("s"))
        {
            MyPlayer.transform.Translate(0, 0, 0.2f);

        }
        if (Input.GetKey("a"))
        {
            MyPlayer.transform.Translate(0.2f, 0, 0);

        }
        if (Input.GetKey("d"))
        {
            MyPlayer.transform.Translate(-0.2f, 0, 0);

        }

    }

}

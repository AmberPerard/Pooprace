using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public Transform target;
    public float step = 0.0001f;
    public string keyInput;

    public string carName;
    public GameObject scoreboardPosition;
    public int position = 0;

    // Start is called before the first frame update
    void Start()
    {
        carName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
//Debug.Log( carName + position);

        if (Input.GetKeyDown(keyInput))
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step / 4);
            position = position +  1;
        }

        if (transform.position == target.position)
        {
            Debug.Log("This car " + gameObject.name.ToString() + " has hit the finish line");
        }
     }


}

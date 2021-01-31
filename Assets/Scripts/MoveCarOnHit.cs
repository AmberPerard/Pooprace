using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCarOnHit : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameObject currentObject1 = GameObject.Find("Player1Car");
        MoveCar currentObjectMove1 = currentObject1.GetComponent<MoveCar>();
        currentObjectMove1.keyInput = "q";

        GameObject currentObject2 = GameObject.Find("Player2Car");
        MoveCar currentObjectMove2 = currentObject2.GetComponent<MoveCar>();
        currentObjectMove2.keyInput = "s";

        GameObject currentObject3 = GameObject.Find("Player3Car");
        MoveCar currentObjectMove3 = currentObject3.GetComponent<MoveCar>();
        currentObjectMove3.keyInput = "l";

        GameObject currentObject4 = GameObject.Find("Player4Car");
        MoveCar currentObjectMove4 = currentObject4.GetComponent<MoveCar>();
        currentObjectMove4.keyInput = "m";

    }

    // Update is called once per frame
    void Update()
    {
       
           

    }
}

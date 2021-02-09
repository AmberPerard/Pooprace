using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCarOnHit : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //gives keyinputs to every object
        GameObject currentObject1 = GameObject.Find("Player1Car");
        MoveCar currentObjectMove1 = currentObject1.GetComponent<MoveCar>();
        currentObjectMove1.keyInput = "f";

        GameObject currentObject2 = GameObject.Find("Player2Car");
        MoveCar currentObjectMove2 = currentObject2.GetComponent<MoveCar>();
        currentObjectMove2.keyInput = "g";

        GameObject currentObject3 = GameObject.Find("Player3Car");
        MoveCar currentObjectMove3 = currentObject3.GetComponent<MoveCar>();
        currentObjectMove3.keyInput = "h";

        GameObject currentObject4 = GameObject.Find("Player4Car");
        MoveCar currentObjectMove4 = currentObject4.GetComponent<MoveCar>();
        currentObjectMove4.keyInput = "j";

    }
}

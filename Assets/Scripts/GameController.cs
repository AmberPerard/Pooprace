using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<MoveCar> Carlist = new List<MoveCar>(4);
    public List<GameObject> playerPos = new List<GameObject>(4);
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;


    private Vector3 firstP = new Vector3(-34f, 2.4f, 0.8f);
    private Vector3 secondP = new Vector3(-3.4f,1.7f, 0.8f);
    private Vector3 thirdP = new Vector3(-3.4f, 1.3f, 0.8f);
    private Vector3 forthP = new Vector3(-3.4f, 0.9f, 0.8f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // sort cars 
        Carlist.Sort((a, b) => (a.position).CompareTo(b.position));
        Carlist.Reverse();


        //Debug.Log(Carlist[0].scoreboardPosition.transform.position);
        Carlist[0].scoreboardPosition.transform.position = Vector3.MoveTowards(transform.position, target1.position, 1000);
        Carlist[1].scoreboardPosition.transform.position = Vector3.MoveTowards(transform.position, target2.position, 1000);
        Carlist[2].scoreboardPosition.transform.position = Vector3.MoveTowards(transform.position, target3.position, 1000);
        Carlist[3].scoreboardPosition.transform.position = Vector3.MoveTowards(transform.position, target4.position, 1000);

        Debug.Log(Carlist[0].carName);


    }
}

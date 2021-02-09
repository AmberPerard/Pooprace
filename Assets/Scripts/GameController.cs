using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public List<MoveCar> Carlist = new List<MoveCar>(4);

    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;

    public Text Place1;
    public Text Place2;
    public Text Place3;
    public Text Place4;

    public Image IPlace1;
    public Image IPlace2;
    public Image IPlace3;

    // The popscreens for the info
    public GameObject beginScreen;
    public GameObject endScreen;

    public float startTimer = 15f;
    public Text StartTimer;

    private float endTimer = 100f;

    public bool gameIsActive = false;

    // Start is called before the first frame update
    void Start()
    {
        // start with a clean score
        PlayerPrefs.DeleteAll();

        // start the game timer
        beginScreen.SetActive(true);
        endScreen.SetActive(false);
        gameIsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        //the timer for the countdown with the info shown in seconds
        startTimer -= Time.deltaTime;
        int seconds = Mathf.FloorToInt(startTimer);
        StartTimer.text = seconds.ToString();

        // if the timer is zero start the game
        if (startTimer <= 0)
        {
            beginScreen.SetActive(false);
            gameIsActive = true;
            // sort cars to show the car that has the furthest positions first 
            Carlist.Sort((a, b) => (a.position).CompareTo(b.position));
            Carlist.Reverse();

            Carlist[0].scoreboardPosition.transform.position = Vector3.MoveTowards(transform.position, target1.position, 1000);
            Carlist[1].scoreboardPosition.transform.position = Vector3.MoveTowards(transform.position, target2.position, 1000);
            Carlist[2].scoreboardPosition.transform.position = Vector3.MoveTowards(transform.position, target3.position, 1000);
            Carlist[3].scoreboardPosition.transform.position = Vector3.MoveTowards(transform.position, target4.position, 1000);

            Debug.Log(Carlist[0].carName);
        }

        //checks if the first car has reached the end and stops the game
        if (Carlist[0].end == true)
        {

            endTimer -= Time.deltaTime;
            endScreen.SetActive(true);
            gameIsActive = false;

            //show the text on the scoreboard
            Place1.text = Carlist[0].scoreboardPosition.name;
            Place2.text = Carlist[1].scoreboardPosition.name;
            Place3.text = Carlist[2].scoreboardPosition.name;
            Place4.text = Carlist[3].scoreboardPosition.name;

            //show the car in the corresponding position
            IPlace1.sprite = Carlist[0].EndPref.GetComponent<Image>().sprite;
            IPlace2.sprite = Carlist[1].EndPref.GetComponent<Image>().sprite;
            IPlace3.sprite = Carlist[2].EndPref.GetComponent<Image>().sprite;

            //add the animatator for the cars
            IPlace1.GetComponent<Animator>().runtimeAnimatorController = Carlist[0].EndPref.GetComponent<Animator>().runtimeAnimatorController;
            IPlace2.GetComponent<Animator>().runtimeAnimatorController = Carlist[1].EndPref.GetComponent<Animator>().runtimeAnimatorController;
            IPlace3.GetComponent<Animator>().runtimeAnimatorController = Carlist[2].EndPref.GetComponent<Animator>().runtimeAnimatorController;

            // to create the loop for the installation
            //logic OR operator
            if (endTimer <= 0 ^ Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene(sceneName: "StartScene");
            }
        }
    }
}

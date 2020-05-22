using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ObstacleScript : MonoBehaviour
{
    public int levelno;
    public int xpos1;
    public int ypos1;
    public int xpos2;
    public int ypos2;
    public int xposp1;
    public int yposp1;
    public int xposp2;
    public int yposp2;
    public int xmin;
    public int ymin;
    public int levelunclock;
    public string currentLevel;
    public int movelimit;
    int moves = 0;
    public Text move;
    public Text levels;
    public GameObject win;
    public GameObject loose;
    public Button movesadd;
    public int TCR;
    int f = 1;
    public Text coinstotal;
    public Text congrats;

    public Button home;
    public Button retry;
    public Button yourButtondown;
    public Button yourButtonup;
    public Button yourButtonleft;
    public Button yourButtonright;
    public int xobs1p;
    public int yobs1p;
    public int xobs2p;
    public int yobs2p;
    public int x2obs1p;
    public int y2obs1p;
    public int x2obs2p;
    public int y2obs2p;


    public void Start()
    {
        TCR = PlayerPrefs.GetInt("TCR", 60);
        coinstotal.text = "X " + TCR;
        Button btnmoves = movesadd.GetComponent<Button>();
        btnmoves.onClick.AddListener(TaskOnMoveClick);
        Button btndown = yourButtondown.GetComponent<Button>();
        btndown.onClick.AddListener(TaskOnDownClick);
        Button btnup = yourButtonup.GetComponent<Button>();
        btnup.onClick.AddListener(TaskOnUpClick);
        Button btnleft = yourButtonleft.GetComponent<Button>();
        btnleft.onClick.AddListener(TaskOnLeftClick);
        Button btnright = yourButtonright.GetComponent<Button>();
        btnright.onClick.AddListener(TaskOnRightClick);
        Button btnhome = home.GetComponent<Button>();
        btnhome.onClick.AddListener(TaskOnHomeClick);
        Button btnretry = retry.GetComponent<Button>();
        btnretry.onClick.AddListener(TaskOnRetryClick);
    }
    void TaskOnMoveClick()
    {
        if (TCR - 100 >= 0)
        {
            TCR -= 100;
            PlayerPrefs.SetInt("TCR", TCR);
            coinstotal.text = "X " + TCR;
            if (levelno == (PlayerPrefs.GetInt("LTS", 2) - 1))
            {
                PlayerPrefs.SetInt("LTS", levelunclock);
            }
            Invoke("winpanel", 0.5f);
            active();
        }
    }
    void TaskOnRetryClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void TaskOnHomeClick()
    {
        SceneManager.LoadScene("AMenu");
    }
    void TaskOnDownClick()
    {
        if (((ypos1 - 1) != yobs1p || xpos1 != xobs1p) && ((ypos1 - 1) != yobs2p || xpos1 != xobs2p))
        {
            if (ypos1 > 0)
            {
                ypos1--;
            }
        }
        if (((ypos2 + 1) != y2obs1p || xpos2 != x2obs1p) && ((ypos2 + 1) != y2obs2p || xpos2 != x2obs2p))
        {
            if (ypos2 < ymin)
            {
                ypos2++;
            }
        }
        moves++;
        FindObjectOfType<AudioManager>().Play("Player");
    }
    void TaskOnUpClick()
    {
        if (((ypos1 + 1) != yobs1p || xpos1 != xobs1p) && ((ypos1 + 1) != yobs2p || xpos1 != xobs2p))
        {
            if (ypos1 < ymin)
            {
                ypos1++;
            }
        }
        if (((ypos2 - 1) != y2obs1p || xpos2 != x2obs1p) && ((ypos2 - 1) != y2obs2p || xpos2 != x2obs2p))
        {
            if (ypos2 > 0)
            {
                ypos2--;
            }
        }
        moves++;
        FindObjectOfType<AudioManager>().Play("Player");
    }
    void TaskOnLeftClick()
    {
        if (((xpos1 + 1) != xobs1p || ypos1 != yobs1p) && ((xpos1 + 1) != xobs2p || ypos1 != yobs2p))
        {
            if (xpos1 < xmin)
            {
                xpos1++;
            }
        }
        if (((xpos2 - 1) != x2obs1p || ypos2 != y2obs1p) && ((xpos2 - 1) != x2obs2p || ypos2 != y2obs2p))
        {
            if (xpos2 > 0)
            {
                xpos2--;
            }
        }
        moves++;
        FindObjectOfType<AudioManager>().Play("Player");
    }
    void TaskOnRightClick()
    {
        if (((xpos1 - 1) != xobs1p || ypos1 != yobs1p) && ((xpos1 - 1) != xobs2p || ypos1 != yobs2p))
        {
            if (xpos1 > 0)
            {
                xpos1--;
            }
        }
        if (((xpos2 + 1) != x2obs1p || ypos2 != y2obs1p) && ((xpos2 + 1) != x2obs2p || ypos2 != y2obs2p))
        {
            if (xpos2 < xmin)
            {
                xpos2++;
            }
        }
        moves++;
        FindObjectOfType<AudioManager>().Play("Player");
    }

    private void Update()
    {
        move.text = "moves : " + (movelimit - moves).ToString();
        levels.text = currentLevel;
        if (xpos1 == xposp1 && ypos1 == yposp1 && xpos2 == xposp2 && ypos2 == yposp2 && moves <= movelimit)
        {
            if (f == 1)
            {
                Debug.Log("You won" + currentLevel);
                Debug.Log("During level : " + PlayerPrefs.GetInt("LTS", 2));
                if (levelno == (PlayerPrefs.GetInt("LTS", 2) - 1))
                {
                    TCR += 10;
                    PlayerPrefs.SetInt("TCR", TCR);
                    coinstotal.text = "X " + TCR;
                    PlayerPrefs.SetInt("LTS", levelunclock);
                    congrats.text = "COngratulations!!! " +
                        "  you earned 10 Coins ";
                }
                else
                {
                    congrats.text = "COngratulations!!!";
                }
                f = 0;
            }
            Invoke("winpanel", 0.5f);
            active();
            //PlayerPrefs.SetInt("LTS", levelunclock);
            // SceneManager.LoadScene("ASelectLevels");
            // SceneManager.LoadScene(lname);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (xpos1 == xposp1 && ypos1 == yposp1 || xpos2 == xposp2 && ypos2 == yposp2 || (movelimit - moves == 0))
        {
            Debug.Log("loose");
            move.text = "moves : 0";
            Invoke("loosepanel", 0.5f);
            active();
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        PlayerPrefs.Save();
    }
    void active()
    {
        yourButtondown.interactable = false;
        yourButtonleft.interactable = false;
        yourButtonright.interactable = false;
        yourButtonup.interactable = false;
        movesadd.interactable = false;
        home.interactable = false;
        retry.interactable = false;
    }
    void winpanel()
    {
        win.SetActive(true);
    }
    void loosepanel()
    {
        loose.SetActive(true);
    }
    // Update is called once per frame

}
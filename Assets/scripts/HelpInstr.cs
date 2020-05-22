using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class HelpInstr : MonoBehaviour
{
    public GameObject scroll;
    public GameObject info;
    public Button ButtonX;
    public Button Buttonback;
    public Button Buttongb;
    public Button Buttonbb;
    public Button Buttonbv;
    public Button Buttongate;
    public Button Buttoncoin;
    public Button Buttonstone;
    public Button Buttonhport;
    public Button Buttonvport;
    public Text infotext;
    //public SpriteRenderer rend;
    public Sprite p1;
    public Sprite p2;
    public Sprite p3;
    public Sprite gate;
    public Sprite coin;
    public Sprite stone;
    public Sprite hport;
    public Sprite vport;

    public GameObject img;

    // Start is called before the first frame update
    void Start()
    {
        Button btnx = ButtonX.GetComponent<Button>();
        btnx.onClick.AddListener(TaskOnXClick);
        Button btnback = Buttonback.GetComponent<Button>();
        btnback.onClick.AddListener(TaskOnBackClick);
        Button btnbb = Buttonbb.GetComponent<Button>();
        btnbb.onClick.AddListener(TaskOnBBClick);
        Button btngb = Buttongb.GetComponent<Button>();
        btngb.onClick.AddListener(TaskOnGBClick);
        Button btnbv = Buttonbv.GetComponent<Button>();
        btnbv.onClick.AddListener(TaskOnBVClick);
        Button btngate = Buttongate.GetComponent<Button>();
        btngate.onClick.AddListener(TaskOnGateClick);
        Button btncoin = Buttoncoin.GetComponent<Button>();
        btncoin.onClick.AddListener(TaskOnCoinClick);
        Button btnstone = Buttonstone.GetComponent<Button>();
        btnstone.onClick.AddListener(TaskOnStoneClick);
        Button btnvport = Buttonvport.GetComponent<Button>();
        btnvport.onClick.AddListener(TaskOnVPortClick);
        Button btnhport = Buttonhport.GetComponent<Button>();
        btnhport.onClick.AddListener(TaskOnHPortClick);
    }

    void TaskOnXClick()
    {
        info.SetActive(false);
        scroll.SetActive(true);
    }
    void TaskOnBackClick()
    {
        SceneManager.LoadScene("AMenu");
    }

        void TaskOnBBClick()
    {
        info.SetActive(true);
        scroll.SetActive(false);
        img.GetComponent<Image>().sprite = p2;
        infotext.text = "the blue brother is a loyal brother and follows all the instructions.\nPress the arrow buttons to control his movement.";
    }

    void TaskOnGBClick()
    {
        info.SetActive(true);
        scroll.SetActive(false);
        img.GetComponent<Image>().sprite = p1;
        infotext.text = "the green brother is a loyal brother and follows all the instructions.\nPress the arrow buttons to control his movement.";
    }
    void TaskOnBVClick()
    {
        info.SetActive(true);
        scroll.SetActive(false);
        img.GetComponent<Image>().sprite = p3;
        infotext.text = "the naughty brother is a vicious brother and does all the actions opposite to what he is instructed to do.\nPress the arrow buttons to control him.";
    }
    void TaskOnGateClick()
    {
        info.SetActive(true);
        scroll.SetActive(false);
        img.GetComponent<Image>().sprite = gate;
        infotext.text = "the door helps both the brothers on the board to get to the next level.\nmove the brothers in such a way that both of them enter the door at the same time.";
    }
    void TaskOnStoneClick()
    {
        info.SetActive(true);
        scroll.SetActive(false);
        img.GetComponent<Image>().sprite = stone;
        infotext.text = "the stone is a large mass which obstructs the brothers when they try to move through them.\nbut you can use stones effectively in certain situations.";
    }
    void TaskOnCoinClick()
    {
        info.SetActive(true);
        scroll.SetActive(false);
        img.GetComponent<Image>().sprite = coin;
        infotext.text = "if you run out of ideas use coins to skip to next level.\n you can earn more coins by completing different levels.";
    }
    void TaskOnHPortClick()
    {
        info.SetActive(true);
        scroll.SetActive(false);
        img.GetComponent<Image>().sprite = hport;
        infotext.text = "the horizontal portal is a magical illusion which transports the brothers to the one next horizontal tile on the board when they pass through it.";
    }
    void TaskOnVPortClick()
    {
        info.SetActive(true);
        scroll.SetActive(false);
        img.GetComponent<Image>().sprite = vport;
        infotext.text = "the vertical portal is a magical illusion which transports the brothers to the one next vertical tile on the board when they pass through it.";
    }
    // Update is called once per frame

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PortalPlayer : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float Xincrement;
    public float speed;
    public int xpos;
    public int ypos;
    public int x;
    public int y;
    public Button yourButtondown;
    public Button yourButtonup;
    public Button yourButtonleft;
    public Button yourButtonright;
    public int xport;
    public int yport;

    public void Start()
    {
        Button btndown = yourButtondown.GetComponent<Button>();
        btndown.onClick.AddListener(TaskOnDownClick);
        Button btnup = yourButtonup.GetComponent<Button>();
        btnup.onClick.AddListener(TaskOnUpClick);
        Button btnleft = yourButtonleft.GetComponent<Button>();
        btnleft.onClick.AddListener(TaskOnLeftClick);
        Button btnright = yourButtonright.GetComponent<Button>();
        btnright.onClick.AddListener(TaskOnRightClick);
    }

    void TaskOnDownClick()
    {
        if (ypos < y)
        {
            if ((ypos + 1) == yport && xpos == xport)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
                transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
                ypos++;
            }
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            ypos++;
        }
    }
    void TaskOnUpClick()
    {
        if (ypos > 0)
        {
            if ((ypos - 1) == yport && xpos == xport)
            {
                targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
                transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
                ypos--;
            }
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            ypos--;
        }
    }
    void TaskOnLeftClick()
    {
        if ((xpos - 1) != xport || ypos != yport)
        {
            if (xpos > 0)
            {
                targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
                transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
                xpos--;
            }
        }
    }
    void TaskOnRightClick()
    {
        if ((xpos + 1) != xport || ypos != yport)
        {
            if (xpos < x)
            {
                targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
                transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
                xpos++;
            }
        }
    }
    // Update is called once per frame

}

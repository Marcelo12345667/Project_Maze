using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;
using Unity.PlasticSCM.Editor.WebApi;

public class Coins : MonoBehaviour
{

    public GameObject Gate;
    public GameObject GateMiddle1;
    public GameObject GateMiddle2;
    public GameObject GateMiddleLate;
    public GameObject GateEnd;
    public GameObject wall;
    private int Coin = 0;
    private int KeyNum = 0;
    public int CoinsLeft;
    public int NewCoins;
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI KeyState;
    public TextMeshPro Number;
    public TextMeshPro Number2;
    public TextMeshPro Number3;
    public TextMeshPro Number4;
    public TextMeshPro Number5;
    public TextMeshPro destroy;


    void Start()
    {
        Number.text = "coins:" + CoinsLeft;
    }
    private void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "coin")
        {
            Coin++;
            coinText.text = "Coin:" + Coin;
            if (CoinsLeft != 0)
            {

                CoinsLeft--;
                Number.text = "coins:" + CoinsLeft;
                Number2.text = "coins:" + CoinsLeft;
                Number3.text = "coins:" + CoinsLeft;
                Number4.text = "coins:" + CoinsLeft;
                Number5.text = "coins:" + CoinsLeft;
            }
            if (CoinsLeft == 0)
            {
                CoinsLeft += 6;
                Number.text = "coins:" + CoinsLeft;
                Number2.text = "coins:" + CoinsLeft;
                Number3.text = "coins:" + CoinsLeft;
                Number4.text = "coins:" + CoinsLeft;
                Number5.text = "coins:" + CoinsLeft;
            }
            Debug.Log(Coin);
            Destroy(other.gameObject);
            if (Coin == 1)
            {
                Destroy(Gate);

            }
            if (Coin == 7)
            {
                Destroy(GateMiddle1);
                Destroy(GateMiddle2);

            }
            if (Coin == 13)
            {
                Destroy(GateMiddleLate);

            }
            if (Coin == 19)
            {
                Destroy(GateEnd);

            }


        }
        if (other.transform.tag == "Key")
        {
            KeyNum++;
            KeyState.text = "Key:" + KeyNum;         
            Destroy(other.gameObject);
            Destroy(destroy.gameObject);
            Destroy(wall.gameObject);

        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour, IInventoryItem
{
    public Sprite _Image = null;
    public GameObject candleFire;
    public GameObject curtainFire;
    public GameObject curtain;
    public ScareMeter scareMeter;
    int ifCounter;
    public string Name
    {
        get
        {
            return "Lighter";
        }
    }

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        curtainFire.SetActive(false);
        candleFire.SetActive(false);

        ifCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPickup()
    {
        gameObject.SetActive(false);
    }

    public void OnDrop()
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 10000))
        {
            if (hit.collider.tag == "candle")
            {
                Invoke("Curtain", 2.0f);
                Animator curtainAnimator = curtain.GetComponent<Animator>();
                curtainAnimator.SetBool("isLit", true);

                //StartCoroutine(Remove());

                Debug.Log("Tag foud. Hitting the candle");
                candleFire.SetActive(true);

                GameObject character2 = GameObject.FindGameObjectWithTag("character2");
                Animator characterAnimator = character2.GetComponent<Animator>();

                

                if (character2 != null)
                {
                    // trigger character animation when chandelier falls
                    characterAnimator.Play("sitting-to-stand-scared");
                    Debug.Log("scare animation for candle");

                    if (scareMeter != null)
                    {
                        if (ifCounter == 0)
                        {
                            int scareCount = 1;
                            //scareMeter.ScareCount();
                            scareMeter.ScareEvent(scareCount);
                            //scareMeter.counter++;
                        }
                    }

                }


            }
            else
            {
                Debug.Log("Not hitting the candle");
                transform.localPosition = Vector3.zero;
            }

        }

    }

    public void Curtain()
    {
        curtainFire.SetActive(true);
    }

 

}

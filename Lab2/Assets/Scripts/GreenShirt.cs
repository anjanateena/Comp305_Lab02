using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenShirt : MonoBehaviour
{

    public GameObject Greenshirt;
    public Sprite firstSprite;
    public Sprite seconSprite;
      private Rigidbody2D rBody;
    private SpriteRenderer sRend;

    // Use this for initialization

    void Start()
    {

        rBody = Greenshirt.GetComponent<Rigidbody2D>();
        sRend = Greenshirt.GetComponent<SpriteRenderer>();
      
    }

        void OnMouseDown()
            {
    
        if(sRend.sprite==firstSprite)
        {
            sRend.sprite = seconSprite;

        }
        else
        {
            sRend.sprite = firstSprite;

        }
        rBody.velocity *= -1;


        }


        
    }
    
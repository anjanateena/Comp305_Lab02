using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedShirt : MonoBehaviour {
    public GameObject Redshirt;
    public Sprite sprite1;
    public Sprite sprite2;
    private Rigidbody2D rBody;
    private SpriteRenderer sRend;

    // Use this for initialization
    void Start () {
        rBody =Redshirt.GetComponent<Rigidbody2D>();
        sRend = Redshirt.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void OnMouseDown()
    {

        if (sRend.sprite == sprite1)
        {
            sRend.sprite = sprite2;

        }
        else
        {
            sRend.sprite = sprite1;
        }
        rBody.velocity *= -1;

    }

		
	}


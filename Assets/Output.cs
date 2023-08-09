using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Output : MonoBehaviour
{

    public GameObject text;

    public int Font_Size;
    //public float Text_Width;
    //public float Text_Height;

    //public enum TEXT_COLOR
    //{
    //    WHITE,
    //    BLACK,
    //    RED,
    //    GREEN,
    //    BLUE,
    //}
    //public TEXT_COLOR Text_Color;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        text.GetComponent<Text>().text = this.GetComponent<WebCamTextureToCloudVision>().text;

        if (Input.GetKeyDown(KeyCode.S))
        {
            OpenJTalk.Speak(text.GetComponent<Text>().text);
            //Debug.Log(text.GetComponent<Text>().text);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Font_Size = Font_Size - 1;
            text.GetComponent<Text>().fontSize = Font_Size;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Font_Size = Font_Size + 1;
            text.GetComponent<Text>().fontSize = Font_Size;
        }
        
        if(Input.GetKeyDown(KeyCode.Q))
        {
            text.GetComponent<Text>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            text.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            text.GetComponent<Text>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            text.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
        }

        //text.GetComponent<RectTransform>().sizeDelta = new Vector2(Text_Width, Text_Height);
        //text.GetComponent<RectTransform>().anchoredPosition = new Vector2(Text_Width / 2, -Text_Height / 2);
        
        //switch (Text_Color)
        //{
        //    case TEXT_COLOR.WHITE:
        //        text.GetComponent<Text>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        //        break;
        //    case TEXT_COLOR.BLACK:
        //        text.GetComponent<Text>().color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
        //        break;
        //    case TEXT_COLOR.RED:
        //        text.GetComponent<Text>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        //        break;
        //    case TEXT_COLOR.GREEN:
        //        text.GetComponent<Text>().color = new Color(0.0f, 1.0f, 0.0f, 1.0f);
        //        break;
        //    case TEXT_COLOR.BLUE:
        //        text.GetComponent<Text>().color = new Color(0.0f, 0.0f, 1.0f, 1.0f);
        //        break;
        //}

    }
}

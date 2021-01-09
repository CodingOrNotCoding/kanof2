using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject kano;
    public Text ScoreText;
    public Text leftText;
    public Text rightText;
    private float score;
    public int scoreInt;
    private string fleft;
    private string fright;
    private string oleft;
    private string oright;
    private string tleft;
    private string tright;

    public SpriteRenderer Block;
    public Sprite BlockLv1;
    public Sprite BlockLv2;
    public Sprite BlockLv3;
    public Sprite BlockLv4;
    public Sprite BlockLv5;
    public Sprite BlockLv6;
    public SpriteRenderer SO1;
    public SpriteRenderer SO2;
    public SpriteRenderer SO3;
    public SpriteRenderer SO4;
    public SpriteRenderer SO5;
    public SpriteRenderer GS1;
    public SpriteRenderer GS2;
    public SpriteRenderer GS3;
    public SpriteRenderer GS4;
    public SpriteRenderer GS5;
    public SpriteRenderer W1;
    public SpriteRenderer W2;
    public SpriteRenderer W3;
    public SpriteRenderer W4;
    public SpriteRenderer W5;
    bool islvl2;
    public Sprite Lv1B;
    public Sprite Lv1W;
    public Sprite Lv2B;
    public Sprite Lv2W;
    public Sprite Lv3B;
    public Sprite Lv4B;
    public Sprite Lv5B;
    public Sprite Lv6B;
    void LVC1()
    {
        Block.sprite = BlockLv1;
        SO1.sprite = Lv1B;
        SO2.sprite = Lv1B;
        SO3.sprite = Lv1B;
        SO4.sprite = Lv1B;
        SO5.sprite = Lv1B;
        GS1.sprite = Lv1B;
        GS2.sprite = Lv1B;
        GS3.sprite = Lv1B;
        GS4.sprite = Lv1B;
        GS5.sprite = Lv1B;
        W1.sprite = Lv1W;
        W2.sprite = Lv1W;
        W3.sprite = Lv1W;
        W4.sprite = Lv1W;
        W5.sprite = Lv1W;
    }
    void LVB2()
    {
        Block.sprite = BlockLv2;
        SO1.sprite = Lv2B;
        SO2.sprite = Lv2B;
        SO3.sprite = Lv2B;
        SO4.sprite = Lv2B;
        SO5.sprite = Lv2B;
        GS1.sprite = Lv2B;
        GS2.sprite = Lv2B;
        GS3.sprite = Lv2B;
        GS4.sprite = Lv2B;
        GS5.sprite = Lv2B;
        W1.sprite = Lv2W;
        W2.sprite = Lv2W;
        W3.sprite = Lv2W;
        W4.sprite = Lv2W;
        W5.sprite = Lv2W;
    }

    void LVB3()
    {
        Block.sprite = BlockLv3;
        SO1.sprite = Lv3B;
        SO2.sprite = Lv3B;
        SO3.sprite = Lv3B;
        SO4.sprite = Lv3B;
        SO5.sprite = Lv3B;
        GS1.sprite = Lv3B;
        GS2.sprite = Lv3B;
        GS3.sprite = Lv3B;
        GS4.sprite = Lv3B;
        GS5.sprite = Lv3B;
        W1.sprite = Lv2W;
        W2.sprite = Lv2W;
        W3.sprite = Lv2W;
        W4.sprite = Lv2W;
        W5.sprite = Lv2W;
    }
    void LVB4()
    {
        Block.sprite = BlockLv4;
        SO1.sprite = Lv4B;
        SO2.sprite = Lv4B;
        SO3.sprite = Lv4B;
        SO4.sprite = Lv4B;
        SO5.sprite = Lv4B;
        GS1.sprite = Lv4B;
        GS2.sprite = Lv4B;
        GS3.sprite = Lv4B;
        GS4.sprite = Lv4B;
        GS5.sprite = Lv4B;
        W1.sprite = Lv2W;
        W2.sprite = Lv2W;
        W3.sprite = Lv2W;
        W4.sprite = Lv2W;
        W5.sprite = Lv2W;
    }
    void LVB5()
    {
        Block.sprite = BlockLv5;
        SO1.sprite = Lv5B;
        SO2.sprite = Lv5B;
        SO3.sprite = Lv5B;
        SO4.sprite = Lv5B;
        SO5.sprite = Lv5B;
        GS1.sprite = Lv5B;
        GS2.sprite = Lv5B;
        GS3.sprite = Lv5B;
        GS4.sprite = Lv5B;
        GS5.sprite = Lv5B;
        W1.sprite = Lv2W;
        W2.sprite = Lv2W;
        W3.sprite = Lv2W;
        W4.sprite = Lv2W;
        W5.sprite = Lv2W;
    }
    void LVB6()
    {
        Block.sprite = BlockLv6;
        SO1.sprite = Lv6B;
        SO2.sprite = Lv6B;
        SO3.sprite = Lv6B;
        SO4.sprite = Lv6B;
        SO5.sprite = Lv6B;
        GS1.sprite = Lv6B;
        GS2.sprite = Lv6B;
        GS3.sprite = Lv6B;
        GS4.sprite = Lv6B;
        GS5.sprite = Lv6B;
        W1.sprite = Lv2W;
        W2.sprite = Lv2W;
        W3.sprite = Lv2W;
        W4.sprite = Lv2W;
        W5.sprite = Lv2W;
    }
    void Start()
    {
         fleft = "Stay here for BUZUL";
         fright = "Stay here for ÇAMUR";
        oleft = "Stay here for KUM";
        oright = "Stay here for ÇİÇEK";
        tleft = "Stay here for KAYA";
        tright = "Stay here for TUZ";
    }
    void Update()
    {
        

            score += 0.01f;
            scoreInt = (int)score;
            ScoreText.text = ("Score = " + scoreInt.ToString());

        if (scoreInt == 30)
        {
            leftText.text = fleft;
            rightText.text = fright;
        }

        if(scoreInt == 60)
        {
            leftText.text = " ";
            rightText.text = " ";
            if (kano.transform.position.x < 0)
            {
                islvl2 = true;
                LVB2();
            }
            else
            {
                islvl2 = false;
                LVC1();
            }
            
        }
        if (scoreInt == 100)
        {
            if (islvl2)
            {
                leftText.text = tleft;
                rightText.text = tright;
            }
            else
            {
                leftText.text = oleft;
                rightText.text = oright;
            }
            
        }

        if (scoreInt == 130)
        {
            leftText.text = " ";
            rightText.text = " ";
            if (kano.transform.position.x < 0 && islvl2)
            {
                LVB6();
            }
            if (kano.transform.position.x < 0 && !(islvl2))
            {
                LVB4();
            }
            if (kano.transform.position.x > 0 && !(islvl2))
            {
                LVB3();
            }
            if (kano.transform.position.x > 0 && islvl2)
            {
                LVB5();
            }

        }
    }
}
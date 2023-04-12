using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayScript : MonoBehaviour
{
    public int Randomcolor;
    public int score1, score2, score3, score4;
    public Text ScoreText1, ScoreText2, ScoreText3, ScoreText4;
    public Text Win;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score1 >= 10)
        {
            Win.text = "Player1 win the Game";
        }
        if (score2 >= 10)
        {
            Win.text = "Player2 win the Game";
        }
        if (score3 >= 10)
        {
            Win.text = "Player3 win the Game";
        }
        if (score4 >= 10)
        {
            Win.text = "Player4 win the Game";
        }
    }

    public void Dice1()
    {
        Randomcolor = Random.Range(0, 6);
        if (Randomcolor == 0)   //0=rot, 1=gelb, 3= weiß, 4=blau, 5=grün, 6=schwarz
        {
            score1++;
        }
        if (Randomcolor == 1)
        {
            
        }
        if (Randomcolor == 2)
        {

        }
        if (Randomcolor == 3)
        {

        }
        if (Randomcolor == 4)
        {

        }
        if (Randomcolor == 5)
        {
            score1 += 2;
        }
        if (Randomcolor == 6)
        {
            score1 -= 2;
        }
        ScoreText1.text = score1.ToString();
    }
    public void Dice2()
    {
        Randomcolor = Random.Range(0, 6);
        if (Randomcolor == 0)   //0=rot, 1=gelb, 3= weiß, 4=blau, 5=grün, 6=schwarz
        {
            
        }
        if (Randomcolor == 1)
        {
           score2++;
        }
        if (Randomcolor == 2)
        {

        }
        if (Randomcolor == 3)
        {

        }
        if (Randomcolor == 4)
        {

        }
        if (Randomcolor == 5)
        {
            score2 += 2;
        }
        if (Randomcolor == 6)
        {
            score2 -= 2;
        }
        ScoreText2.text = score2.ToString();
    }
    public void Dice3()
    {
        Randomcolor = Random.Range(0, 6);
        if (Randomcolor == 0)   //0=rot, 1=gelb, 3= weiß, 4=blau, 5=grün, 6=schwarz
        {
            
        }
        if (Randomcolor == 1)
        {

        }
        if (Randomcolor == 2)
        {
            score3++;
        }
        if (Randomcolor == 3)
        {

        }
        if (Randomcolor == 4)
        {

        }
        if (Randomcolor == 5)
        {
            score3 += 2;
        }
        if (Randomcolor == 6)
        {
            score3 -= 2;
        }
        ScoreText3.text = score3.ToString();
    }
    public void Dice4()
    {
        Randomcolor = Random.Range(0, 6);
        if (Randomcolor == 0)   //0=rot, 1=gelb, 3= weiß, 4=blau, 5=grün, 6=schwarz
        {

        }
        if (Randomcolor == 1)
        {

        }
        if (Randomcolor == 2)
        {
            
        }
        if (Randomcolor == 3)
        {
            score1++;
        }
        if (Randomcolor == 4)
        {

        }
        if (Randomcolor == 5)
        {
            score4 += 2;
        }
        if (Randomcolor == 6)
        {
            score4 -= 2;
        }
        ScoreText4.text = score4.ToString();
    }

    
}

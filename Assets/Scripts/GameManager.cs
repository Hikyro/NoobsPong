using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int rightpoint, leftpoint;
    Transform ballTransform;
    [SerializeField]
    Text rightScore, leftScore;

    void Start()
    {
        ballTransform = FindObjectOfType<Ball>().transform;
    }


    void Update()
    {

    }

    public void SetPoints()
    {
        if(ballTransform.position.x > 0)
        {
        leftpoint++;
        leftScore.text = leftpoint.ToString();
        }
        else
        {
        rightpoint++;
        rightScore.text = rightpoint.ToString();
        }

    }
    }


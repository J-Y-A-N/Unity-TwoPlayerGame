using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Globalization;
using System.Collections.Specialized;

public class RestartAuto : MonoBehaviour {

    [SerializeField]
    GameObject blueBall;

    [SerializeField]
    GameObject redBall;


    static int blueVal = 0;
    static int redVal = 0;

    public Text blueScore = null;
    public Text redScore = null;

    public void Start()
    {
        blueScore.text = "0";
        redScore.text = "0";
    }

	private void OnCollisionEnter(Collision c)
    {
		if(c.collider.tag == "Player2")
        {
            blueVal += 1;
            blueScore.text = blueVal.ToString();
        } else
        {
            redVal += 1;
            redScore.text = redVal.ToString();
        }

        blueBall.transform.position = new Vector3(0.5f, 4f, -5f);
        blueBall.GetComponent<Rigidbody>().velocity = Vector3.zero;
        blueBall.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        redBall.transform.position = new Vector3(0.5f, 4f, 0.88f);
        redBall.GetComponent<Rigidbody>().velocity = Vector3.zero;
        redBall.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}

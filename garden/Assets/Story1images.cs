using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Story1images : MonoBehaviour {

	public GameObject shot2;
	public GameObject shot3;
	public GameObject shot4;

//	public GameObject option1;
//	public GameObject option2;
//	public GameObject option3;


	IEnumerator Fading(string Scene_name,LoadSceneMode mode)
	{
		yield return new WaitForSeconds (GameObject.Find("blackfading").GetComponent<FadingController>().BeginFade(1));

		SceneManager.LoadScene (Scene_name,mode);

		yield return new WaitForSeconds (GameObject.Find("blackfading").GetComponent<FadingController>().BeginFade(-1));
	}

	void InteractiveCallback(int shot)
	{
		switch (shot) {
		case 1:
			// Shot #6
			shot2.GetComponent<Animator>().Play("Chapter2_shot6");
			break;
		case 2:
			// Shot #7
			shot3.GetComponent<Animator>().Play("Chapter2_shot7");
			break;
		case 3:
			// Shot #8
			shot4.GetComponent<Animator>().Play("Chapter2_shot8");
			break;
		default :
			break;
		}

	}
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}

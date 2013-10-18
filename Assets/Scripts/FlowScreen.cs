using UnityEngine;
using System.Collections;


public class FlowScreen : MonoBehaviour {
	
	
	public enum MenuScreen
	{
		Intro,
		Main,
		Tutorial,
		MakerRobot,
		MyRobots,
		PlayAnimation,
	}
	
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease,
	}
	
	public Trigger trigger = Trigger.OnClick;
	public MenuScreen actionButton = MenuScreen.Intro;
	public GameObject nextScreen = null;
	public string nameAnimation = "";
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnClick ()
	{
		if (enabled && trigger == Trigger.OnClick)
		{
			
			ActionButton();

		}
	}
	
	void ActionButton()
	{
		switch(actionButton)
		{
				
			case MenuScreen.Intro:
				Application.LoadLevel("Intro");
				break;
			case MenuScreen.Main:
				Application.LoadLevel("Main");
				break;
			case MenuScreen.Tutorial:
				Application.LoadLevel("Tutorial");
				break;
			case MenuScreen.MakerRobot:
				Application.LoadLevel("MakerRobot");
				break;
			case MenuScreen.MyRobots:
				Application.LoadLevel("MyRobots");
				break;
			case MenuScreen.PlayAnimation:
				this.transform.parent.GetComponent<Animation>().Play(nameAnimation);
				nextScreen.GetComponent<Animation>().Play(nameAnimation);
				break;
		}
	}
	
	void ActiveScreen()
	{
		if(nextScreen!= null)
			nextScreen.SetActive(true);
		
	}
	
	
}

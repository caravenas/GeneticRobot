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
	public MenuScreen m_screen = MenuScreen.Intro;
	
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
			switch(m_screen){
				
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
			}
			

		}
	}
}

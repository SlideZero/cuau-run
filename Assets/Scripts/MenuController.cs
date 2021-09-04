using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	[SerializeField] private Animator _navAnimator;
	private bool _openNavBar;

	void Awake () 
	{
		Screen.orientation = ScreenOrientation.Portrait;
	}

	void Start()
	{
		_navAnimator.GetComponent<Animator>();
	}

	public void changeToNextScene(string _nextScene)
	{
		SceneManager.LoadScene(_nextScene, LoadSceneMode.Single);
	}

	public void openNavBar()
	{
		_openNavBar =  !_openNavBar;
		_navAnimator.SetBool("Open_NavBar", _openNavBar);
	}
}

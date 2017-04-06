using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Ui_Level_Select : MonoBehaviour {

	private Button tutorial;
	private Button level1;
	private Button level2;
	private Button level3;
	private Button level4;
	private Button level5;
	private Button wareHouse_1;
	private Button wareHouse_2;
	private Button wareHouse_3;
	private Button wareHouse_4;
    private Button wareHouse_5;
	private Stack<Button> active_buttons; // contains all the buttons to the scene hides them last in first out fashion
	public int buildIndexMax; // make sure to change it every time you add a new level so forexample you added two buttons .... increase current value by 2

	// Use this for initialization
	void Start () {
		active_buttons = new Stack<Button> ();
		fetchButtonsFromScene ();

		addButtonsToStack ();
		hideButtons (compute ());


		
	}
	/*
	 * just computes how many buttons to turn off dont play with it please
	 * */
	private int compute(){
		int max = LevelLock.lastestIndex;
		Debug.Log (max);
		int maxIndex = buildIndexMax;
		int final = maxIndex - max;
		return final;


	}
	/*
	 * gets all the buittons from the current scene
	 * */
	private void fetchButtonsFromScene() {
		// leave tutorial empty it's fine if it's null wont crash the game
		level1 = GameObject.Find ("Level 1").GetComponent <Button> ();
		level2 = GameObject.Find ("Level 2").GetComponent <Button> ();
		level3 = GameObject.Find ("Level 3").GetComponent <Button> ();
		level4 = GameObject.Find ("Level 4").GetComponent <Button> ();
		level5 = GameObject.Find ("Level 5").GetComponent <Button> ();
	
		wareHouse_1 = GameObject.Find ("Warehouse Level").GetComponent <Button> ();
		wareHouse_2 = GameObject.Find ("Warehouse Level 1").GetComponent <Button> ();
		wareHouse_3 = GameObject.Find ("Warehouse Level 2").GetComponent <Button> ();
		wareHouse_4 = GameObject.Find ("Warehouse Level 3").GetComponent <Button> ();
        wareHouse_5 = GameObject.Find ("Warehouse Level 4").GetComponent <Button>();
		// if you need to add a button to the script lets say warehoure5
		// first decalare it as a global variable up top 
		// wareHouse_5 = GaneObject.Find ("Name of button here Exactly as scene").GetComponent <Button> ();



	}


	private void addButtonsToStack() {

		active_buttons.Push (tutorial);
		active_buttons.Push (level1);
		active_buttons.Push (level2);
		active_buttons.Push (level3);
		active_buttons.Push (level4);
		active_buttons.Push (level5);
		// add new levels here for sheep
		active_buttons.Push (wareHouse_1);
		active_buttons.Push (wareHouse_2);
		active_buttons.Push (wareHouse_3);
		active_buttons.Push (wareHouse_4);
        // add new levels here for warehouse
        active_buttons.Push(wareHouse_5);





	}

	private void hideButtons (int amountToHide) {
		while (amountToHide>2){
		active_buttons.Pop ().gameObject.SetActive (false);
			amountToHide --;
		}
	}

}

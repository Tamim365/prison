using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	private enum States {StartGame, cell, sheets_0, mirror, lock_0, sheets_1, cell_mirror, lock_1, freedom};
	private States myStates;

	public Text text;

	// Use this for initialization
	void Start () {
		//sorry, you're useless xD
	}
	
	// Update is called once per frame
	void Update () {
		//print(myStates);  //my debugging tool
		if (myStates==States.StartGame){
			states_start_game();
		}
		else if (myStates==States.cell){
			states_cell();
		}
		else if (myStates==States.sheets_0){
			states_sheets_0();
		}
		else if (myStates==States.mirror){
			states_mirror();
		}
		else if (myStates==States.lock_0){
			states_lock_0();
		}
		else if (myStates==States.sheets_1){
			states_sheets_1();
		}
		else if (myStates==States.cell_mirror){
			states_cell_mirror();
		}
		else if (myStates==States.lock_1){
			states_lock_1();
		}
		else if (myStates==States.freedom){
			states_freedom();
		}
	}

	//start function
	void states_start_game (){
		text.text="Welcome to PRISON \n\n"+
				  "Press Space to Start";
			if (Input.GetKeyDown(KeyCode.Space)){
				myStates=States.cell;
		}
	}

	//main cell
	void states_cell(){
			text.text="You are in a prison cell. There are some dirty sheets on the bed, "+
				      "a mirror on the wall, and the door is locked from the outside.\n \n"+
					  "Press S to veiw Sheets, M to view Mirror and L to view Lock";
		if (Input.GetKeyDown(KeyCode.S))
		{
			myStates=States.sheets_0;
		}
		if (Input.GetKeyDown(KeyCode.M)){
			myStates=States.mirror;
		}
		if (Input.GetKeyDown(KeyCode.L)){
			myStates=States.lock_0;
		}
	}

	//1st time sheet view
	void states_sheets_0 (){
		text.text="I can't believe you sleep in these things. Surely it's time somebody " +
			"changed them. "+"The pleasure of prison life I guess!\n\n"+
				"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)){
			myStates=States.cell;
		}
	}

	//taking mirror
	void states_mirror(){
		text.text="The dirty old mirror on the wall seems loose.\n\n"+
			"Press T  to take the mirror, or R to Return to cell";
		if (Input.GetKeyDown(KeyCode.T)){
			myStates=States.cell_mirror;
		}
		if (Input.GetKeyDown(KeyCode.R)){
			myStates=States.cell;
		}
	}

	//1st time lock view
	void states_lock_0(){
		text.text="This is one of those button locks. You have no idea what the combination is."+
			"I wish you could somehow see where the dirty fingerprints were, maybe that whould help \n\n" +
			"Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)){
			myStates=States.cell;
		}
	}

	//mirror hint
	void states_cell_mirror(){
		text.text="You are still in cell, and you still want to ESCAPE! There are some dirty sheets " +
			"on the bed, and a mark where the mirror was. The pesky door is still there and firmly locked.\n\n" +
				"Press S to view Sheets, or L to veiw Lock, or R to Return to cell";
		if (Input.GetKeyDown(KeyCode.S)){
			myStates=States.sheets_1;
		}
		if (Input.GetKeyDown(KeyCode.L)){
			myStates=States.lock_1;
		}
		if (Input.GetKeyDown(KeyCode.R)){
			myStates=States.cell;
		}
	}

	//2nd time sheet view
	void states_sheets_1 (){
		text.text="Holding a mirror in your hand doesnot make the sheets any better. Please make sense! \n\n" +
			"Press R to Return";
		if (Input.GetKeyDown(KeyCode.R)){
			myStates=States.cell_mirror;
		}
	}

	//2nd time lock view
	void states_lock_1 (){
		text.text="Please carefully put the mirror through the bars, and turn it round. " +
			"Now you can see the lock. You can just make out fingerprints around. Press the " +
				"dirty button and YOU WILL HEAR A ''CLICK!!'' \n\n" +
				"Press B to press that Button";
		if (Input.GetKeyDown(KeyCode.B)){
			myStates=States.freedom;
		}
	}

	//getting freedom
	void states_freedom(){
		text.text="Congratulations!\n" +
			"Your're Free!\n" +
				"Press P to Play again";
		if (Input.GetKeyDown(KeyCode.P)){
			myStates=States.StartGame;
		}
	}
}

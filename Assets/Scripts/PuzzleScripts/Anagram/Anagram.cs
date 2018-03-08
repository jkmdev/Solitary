﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anagram: Puzzle {

	// Sets the parent fields
	void Awake () {
		puzzleName = "Anagram";
		difficulty = NextSceneManager.instance.setPuzzledifficulty;
		placeholder = NextSceneManager.instance.placeholder;
		Debug.Log ("Difficulty for puzzle " + puzzleName + " is: "+ this.difficulty);
	}


	/* Your wonderful startup puzzle code here :3 */

}
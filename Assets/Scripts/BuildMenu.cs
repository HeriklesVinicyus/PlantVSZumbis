using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour {
	public Texture sunImage;

	public BuildInfo[] plants;

	public static BuildInfo cur;

	void OnGUI() {
		GUILayout.BeginArea(new Rect(Screen.width/2 - 100, -7, 200, 100));
		GUILayout.BeginHorizontal("box");

		GUILayout.Box(new GUIContent(SunCollected.score.ToString(), sunImage));

		foreach (BuildInfo bi in plants) {
			GUI.enabled = SunCollected.score >= bi.price;
			if (GUILayout.Button (new GUIContent (bi.price.ToString (), bi.previewImage))) {
				cur = bi;
			}
		}

		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
}
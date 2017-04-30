using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Utilities {
	
	/// <summary>
	/// Development Tools
	/// </summary>
	public class Like_a_Boss {
	
	    /// <summary>
	    /// Alphabetically sorts the project tag list 
	    /// </summary>
	    [MenuItem("Like a Boss/Sort Project Tags")]
	    static void SortProjectTags () {
	    	
	    	SerializedObject tagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
	    	
	    	SerializedProperty tagsProp = tagManager.FindProperty("tags");
			for (int pos = 1; pos < tagsProp.arraySize; pos++) 
				if (tagsProp.GetArrayElementAtIndex (pos).stringValue.CompareTo (tagsProp.GetArrayElementAtIndex (pos-1).stringValue) < 0) 
					tagsProp.MoveArrayElement (pos, --pos);
	    		
	    	tagManager.ApplyModifiedProperties ();
	    }
		
	}
	
}

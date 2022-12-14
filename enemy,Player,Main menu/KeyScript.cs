using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
	[SerializeField] private KeyColor keyColor;

    public enum KeyColor {
		Yellow,
		Blue,
		Red,
		Black
	}

	public KeyColor GetKeyColor(){
		return keyColor;
	}
}
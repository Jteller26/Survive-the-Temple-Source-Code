using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable] public class GameObjectEvent : UnityEvent<GameObject> {}
[Serializable] public class FloatEvent : UnityEvent<float> {}
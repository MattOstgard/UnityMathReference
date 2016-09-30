﻿using UnityEngine;
using Reign;

public class RayTraceBenchmark : MonoBehaviour
{

	void Start()
	{
		RayTraceEngine.Init();
	}
	
	void Update()
	{
		if (Input.GetKeyUp(KeyCode.R)) RayTraceEngine.Render();
	}
}

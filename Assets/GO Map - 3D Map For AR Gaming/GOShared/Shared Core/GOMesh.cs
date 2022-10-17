using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GoShared {

	public class GOMesh {

		public string name;
		
		public Vector3[] vertices;
		public int[] triangles;
		public Vector2[] uv;

		public Vector3[] normals;
		public Color32[] colors;

		public GOMesh secondaryMesh;

		//Mesh Extrusion info
		public float sliceHeight;
		public float heightOriginal;
		public bool separateTop = false;
		public bool separateBottom = false;
		public int [] topTriangles;
		public int [] bottomTriangles;

		public GOMesh () {}
		public GOMesh (GOMesh premesh) {
		
			vertices = premesh.vertices;
			triangles = premesh.triangles;
			uv = premesh.uv;
		}

		public Mesh ToMesh (bool recalculateNormals_ = true) {

			// Create the mesh
			Mesh msh = new Mesh();
			msh.vertices = vertices;
			msh.triangles = triangles;
			msh.uv = uv;

			if (recalculateNormals_)
				msh.RecalculateNormals();
//			msh.RecalculateBounds();
//			msh.name = name;

			return msh;

		}

		public Mesh ToSubmeshes () {

			if (topTriangles == null)
				return ToMesh ();

			// Create the mesh
			Mesh msh = new Mesh();
			msh.vertices = vertices;
			msh.uv = uv;
//			msh.name = name;

			msh.subMeshCount = 2;

			msh.SetTriangles(triangles,0);
			if (separateTop)
				msh.SetTriangles(topTriangles,1);
			else if (separateBottom)
				msh.SetTriangles(topTriangles,1);

			msh.RecalculateNormals();
//			msh.RecalculateBounds();

			return msh;

		}

		public Mesh ToRoadMesh () {

			// Create the mesh
			Mesh msh = new Mesh();
			msh.vertices = vertices;
			msh.uv = uv;

			msh.subMeshCount = 2;
			msh.SetTriangles(triangles,0);
			msh.SetTriangles(topTriangles,1);

			msh.RecalculateNormals();

			return msh;

		}

	}



}
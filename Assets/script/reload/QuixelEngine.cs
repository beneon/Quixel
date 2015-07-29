using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using System.IO;

namespace Quixx
{
  public static class QuixelEngine
  {
    public static Material[] materials;
    private static GameObject cameraObj;
    private static bool active = true;

    public static void init(Material[] mats, GameObject terrainObj, string worldName)
    {
      MeshFactory.terrainObj = terrainObj;
      materials = mats;
      Debug.Log("Materials: "+mats.Length);
      DensityPool.init();
      MeshFactory.start();
      NodeManager.init(worldName);
    }

    public static void setVoxelSize(int size, int maxLOD)
    {
      NodeManager.maxLOD = maxLOD;
      NodeManager.nodeCount = new int[maxLOD+1];
      for(int i=0;i<=maxLOD;i++)
      {
        NodeManager.LODSize[i] = (int)Mathf.Pow(2,i+size);
      }
    }

    public static void setTerrainGenerator(IGenerator gen)
    {
      MeshFactory.terrainGenerator = gen;
    }

    public static void update()
    {
      DensityPool.update();
      MeshFactory.update();

      if(cameraObj != null)
        NodeManager.setViewPosition(cameraObj.transform.position);

      if(!Application.isPlaying)
        active = false;
    }
    public static bool isActive()
    {
      return active;
    }

    public static void terminate()
    {
      active = false;
    }


  }
}

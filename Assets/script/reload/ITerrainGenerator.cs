using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using System.IO;

namespace Quixx
{
  public interface IGenerator
  {
    VoxelData calculateDensity(Vector3 pos);
  }

  public struct VoxelData
  {
      public float density;
      public byte material;
  }

  internal class BasicTerrain:IGenerator
  {
    VoxelData IGenerator.calculateDensity(Vector3 pos){
      float xx,yy,zz;
      xx = pos.x;
      yy = pos.y;
      zz = pos.z;

      float d = yy - (-50f);

      return new VoxelData()
      {
        density = d,
        material = 0
      };
    }
  }
}

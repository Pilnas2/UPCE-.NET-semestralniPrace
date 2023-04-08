
using System.Collections.Generic;
using UnityEngine;

namespace Kulicka
{
    public static class Platforms
    {
        public static GameObject[] All { get; set; }
        public static float MinY { get; set; }

        public static void Initiaize()
        {
            All = GameObject.FindGameObjectsWithTag(Tag.Platform);
            foreach (GameObject obj in All)
            {
                Renderer render = obj.GetComponent<Renderer>();
                if (render == null) { continue; }
                MinY = Mathf.Min(MinY, render.bounds.min.y);
            }
        }
    }
}
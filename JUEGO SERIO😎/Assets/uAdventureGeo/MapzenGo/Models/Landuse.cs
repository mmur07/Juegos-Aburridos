﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapzenGo.Helpers;
using MapzenGo.Models.Enums;
using UnityEngine;

namespace MapzenGo.Models
{
    [RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
    public class Landuse : MonoBehaviour
    {
        public string Id;
        public string Type;
        public LanduseKind Kind;
        public string Name;
        public int SortKey;
    }

}

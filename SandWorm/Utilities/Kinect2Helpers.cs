﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using Rhino.Geometry;

namespace SandWorm
{
    public static class Kinect2Helpers
    {
        public static Vector2 GetDepthPixelSpacing(double sensorHeight)
        {
            return new Vector2(GetDepthPixelSizeInDimension(KinectForWindows.kinect2FOVForX, KinectForWindows.depthWidth, sensorHeight),
                GetDepthPixelSizeInDimension(KinectForWindows.kinect2FOVForY, KinectForWindows.depthHeight, sensorHeight));

        }

        private static float GetDepthPixelSizeInDimension(double fovAngle, double resolution, double height)
        {
            double fovInRadians = (Math.PI / 180) * fovAngle;
            double dimensionSpan = 2 * height * Math.Tan(fovInRadians / 2);
            return (float)(dimensionSpan / resolution);
        }

    }
}

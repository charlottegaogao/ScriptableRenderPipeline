using System;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.HDPipeline
{
    [Serializable]
    public class ScreenSpaceRefractionVolume : VolumeComponent
    {
        public IntParameter                 rayMinLevel = new IntParameter(2);
        public IntParameter                 rayMaxLevel = new IntParameter(6);
        public IntParameter                 rayMaxIterations = new IntParameter(1024);
        public FloatParameter               rayDepthSuccessBias = new FloatParameter(0.1f);

        public void PushShaderParameters(CommandBuffer cmd)
        {
            cmd.SetGlobalInt(HDShaderIDs._SSRefractionRayMinLevel, rayMinLevel.value);
            cmd.SetGlobalInt(HDShaderIDs._SSRefractionRayMaxLevel, rayMaxLevel.value);
            cmd.SetGlobalInt(HDShaderIDs._SSRefractionRayMaxIterations, rayMaxIterations.value);
            cmd.SetGlobalFloat(HDShaderIDs._SSRefractionRayDepthSuccessBias, rayDepthSuccessBias.value);
        }
    }
}
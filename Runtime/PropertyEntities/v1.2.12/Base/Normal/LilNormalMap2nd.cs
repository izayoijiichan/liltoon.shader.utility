// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : LilNormalMap2nd
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Normal Map 2nd
    /// </summary>
    public class LilNormalMap2nd : ILilNormalMap2nd
    {
        /// <summary>UseBump 2nd Map</summary>
        //[DefaultValue(false)]
        public bool UseBump2ndMap { get; set; }

        /// <summary>Bump 2nd Map</summary>
        public Texture2D Bump2ndMap { get; set; }

        /// <summary>Bump 2nd Scale</summary>
        //[Range(-10.0f, 10.0f)]
        //[DefaultValue(1.0f)]
        public float Bump2ndScale { get; set; }

        /// <summary>Bump 2nd Scale Mask</summary>
        public Texture2D Bump2ndScaleMask { get; set; }
    }
}
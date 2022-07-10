// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilGlitter
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Glitter Interface
    /// </summary>
    public interface ILilGlitter
    {
        /// <summary>Use Glitter</summary>
        //[DefaultValue(false)]
        bool UseGlitter { get; set; }

        /// <summary>Glitter UV Mode</summary>
        //[DefaultValue(LilGlitterUVMode.UV0)]
        LilGlitterUVMode GlitterUVMode { get; set; }

        /// <summary>Glitter Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color GlitterColor { get; set; }

        /// <summary>Glitter Color Texture</summary>
        Texture2D GlitterColorTex { get; set; }

        /// <summary>Glitter Main Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float GlitterMainStrength { get; set; }

        /// <summary>Glitter Normal Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float GlitterNormalStrength { get; set; }

        /// <summary>Glitter Params1</summary>
        /// <remarks>Tiling|Particle Size|Contrast</remarks>
        //[DefaultValue(256,256,0.16f,50)]
        Vector4 GlitterParams1 { get; set; }

        /// <summary>Glitter Params2</summary>
        /// <remarks>Blink Speed|Angle|Blend Light Direction|Color Randomness</remarks>
        //[DefaultValue(0.25f,0,0,0)]
        Vector4 GlitterParams2 { get; set; }

        /// <summary>Glitter Post Contrast</summary>
        //[DefaultValue(1.0f)]
        float GlitterPostContrast { get; set; }

        /// <summary>Glitter Enable Lighting</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float GlitterEnableLighting { get; set; }

        /// <summary>Glitter Shadow Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        float GlitterShadowMask { get; set; }

        /// <summary>Glitter Backface Mask</summary>
        //[DefaultValue(false)]
        bool GlitterBackfaceMask { get; set; }

        /// <summary>Glitter Apply Transparency</summary>
        //[DefaultValue(true)]
        bool GlitterApplyTransparency { get; set; }

        /// <summary>Glitter VR Parallax Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        float GlitterVRParallaxStrength { get; set; }
    }
}
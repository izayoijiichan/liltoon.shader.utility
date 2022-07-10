// ----------------------------------------------------------------------
// @Namespace : LilToonShader.v1_2_12
// @Class     : ILilMain3rd
// ----------------------------------------------------------------------
namespace LilToonShader.v1_2_12
{
    using UnityEngine;

    /// <summary>
    /// lilToon Main 3rd Interface
    /// </summary>
    public interface ILilMain3rd
    {
        /// <summary>Use Main 3rd Texture</summary>
        //[DefaultValue(false)]
        bool UseMain3rdTex { get; set; }

        /// <summary>Main 3rd Color</summary>
        //[DefaultValue(0,1,1,1)]
        Color Color3rd { get; set; }

        /// <summary>Main 3rd Texture</summary>
        Texture2D Main3rdTex { get; set; }

        /// <summary>Main 3rd Texture UV Mode</summary>
        //[DefaultValue(LilUVMode.UV0)]
        LilMainUVMode Main3rdTex_UVMode { get; set; }

        /// <summary>Main 3rd Texture Angle</summary>
        //[DefaultValue(0)]
        float Main3rdTexAngle { get; set; }

        /// <summary>Main 3rd Texture Decal Animation</summary>
        /// <remarks>X Size|Y Size|Frames|FPS</remarks>
        //[DefaultValue(1,1,1,30)]
        Vector4 Main3rdTexDecalAnimation { get; set; }

        /// <summary>Main 3rd Texture Decal Sub Param</summary>
        /// <remarks>Ratio X|Ratio Y|Fix Border</remarks>
        //[DefaultValue(1,1,0,1)]
        Vector4 Main3rdTexDecalSubParam { get; set; }

        /// <summary>Main 3rd Texture Is Decal</summary>
        //[DefaultValue(false)]
        bool Main3rdTexIsDecal { get; set; }

        /// <summary>Main 3rd Texture Is Left Only</summary>
        //[DefaultValue(false)]
        bool Main3rdTexIsLeftOnly { get; set; }

        /// <summary>Main 3rd Texture Is Right Only</summary>
        //[DefaultValue(false)]
        bool Main3rdTexIsRightOnly { get; set; }

        /// <summary>Main 3rd Texture Should Copy</summary>
        //[DefaultValue(false)]
        bool Main3rdTexShouldCopy { get; set; }

        /// <summary>Main 3rd Texture Should Flip Mirror</summary>
        //[DefaultValue(false)]
        bool Main3rdTexShouldFlipMirror { get; set; }

        /// <summary>Main 3rd Texture Should Flip Copy</summary>
        //[DefaultValue(false)]
        bool Main3rdTexShouldFlipCopy { get; set; }

        /// <summary>Main 3rd Texture Is MSDF</summary>
        //[DefaultValue(false)]
        bool Main3rdTexIsMSDF { get; set; }

        /// <summary>Main 3rd Blend Mask</summary>
        Texture2D Main3rdBlendMask { get; set; }

        /// <summary>Main 3rd Texture Blend Mode</summary>
        //[DefaultValue(LilBlendMode.Normal)]
        LilBlendMode Main3rdTexBlendMode { get; set; }

        /// <summary>Main 3rd Enable Lighting</summary>
        //[DefaultValue(true)]
        bool Main3rdEnableLighting { get; set; }

        /// <summary>Main 3rd Dissolve Mask</summary>
        Texture2D Main3rdDissolveMask { get; set; }

        /// <summary>Main 3rd Dissolve Noise Mask</summary>
        Texture2D Main3rdDissolveNoiseMask { get; set; }

        /// <summary>Main 3rd Dissolve Noise Mask Scroll Rotate</summary>
        Vector4 Main3rdDissolveNoiseMask_ScrollRotate { get; set; }

        /// <summary>Main 3rd Dissolve Noise Strength</summary>
        //[DefaultValue(0.1f)]
        float Main3rdDissolveNoiseStrength { get; set; }

        /// <summary>Main 3rd Dissolve Color</summary>
        //[DefaultValue(1,1,1,1)]
        Color Main3rdDissolveColor { get; set; }

        /// <summary>Main 3rd Dissolve Params</summary>
        /// <remarks>Dissolve Mode|None|Alpha|UV|Position|Dissolve Shape|Point|Line|Border|Blur</remarks>
        //[DefaultValue(0,0,0.5,0.1)]
        Vector4 Main3rdDissolveParams { get; set; }

        /// <summary>Main 3rd Dissolve Position</summary>
        Vector4 Main3rdDissolvePos { get; set; }

        /// <summary>Main 3rd Distance Fade</summary>
        /// <remarks>Start|End|Strength|Fix backface</remarks>
        Vector4 Main3rdDistanceFade { get; set; }
    }
}
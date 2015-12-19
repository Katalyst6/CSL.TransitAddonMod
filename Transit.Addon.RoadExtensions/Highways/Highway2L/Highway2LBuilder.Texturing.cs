﻿using Transit.Framework;
using Transit.Framework.Texturing;

namespace Transit.Addon.RoadExtensions.Highways.Highway2L
{
    public partial class Highway2LBuilder
    {
        private static void SetupTextures(NetInfo info, NetInfoVersion version)
        {
            var texturePack = new Highway2LTexturePack();

            switch (version)
            {
                case NetInfoVersion.Ground:
                    info.SetAllSegmentsTexture(
                        new TexturesSet(
                            texturePack.Default_Segment_MainTex,
                            texturePack.Default_Segment_APRMap),
                        new LODTexturesSet
                           (@"Highways\Highway2L\Textures\Ground_SegmentLOD__MainTex.png",
                            @"Highways\Highway2L\Textures\Ground_SegmentLOD__APRMap.png",
                            @"Highways\Highway2L\Textures\Ground_LOD__XYSMap.png"));
                    info.SetAllNodesTexture(
                        new TexturesSet(
                            texturePack.Default_Node_MainTex,
                            texturePack.Default_Node_APRMap),
                        new LODTexturesSet
                           (@"Highways\Highway2L\Textures\Ground_NodeLOD__MainTex.png",
                            @"Highways\Highway2L\Textures\Ground_NodeLOD__APRMap.png",
                            @"Highways\Highway2L\Textures\Ground_LOD__XYSMap.png"));
                    break;

                case NetInfoVersion.Elevated:
                case NetInfoVersion.Bridge:
                    info.SetAllSegmentsTexture(
                        new TexturesSet(
                            texturePack.Default_Segment_MainTex,
                            texturePack.Default_Segment_APRMap),
                        new LODTexturesSet
                           (@"Highways\Highway2L\Textures\Elevated_SegmentLOD__MainTex.png",
                            @"Highways\Highway2L\Textures\Elevated_SegmentLOD__APRMap.png",
                            @"Highways\Highway2L\Textures\Elevated_NodeLOD__XYSMap.png"));
                    info.SetAllNodesTexture(
                        new TexturesSet(
                            texturePack.Default_Node_MainTex,
                            texturePack.Default_Node_APRMap),
                        new LODTexturesSet
                           (@"Highways\Highway2L\Textures\Elevated_NodeLOD__MainTex.png",
                            @"Highways\Highway2L\Textures\Elevated_NodeLOD__APRMap.png",
                            @"Highways\Highway2L\Textures\Elevated_NodeLOD__XYSMap.png"));
                    break;

                case NetInfoVersion.Slope:
                    info.SetAllSegmentsTexture(
                        new TexturesSet(
                            texturePack.Slope_Segment_MainTex,
                            texturePack.Slope_Segment_APRMap),
                        new LODTexturesSet
                           (@"Highways\Highway2L\Textures\Slope_SegmentLOD__MainTex.png",
                            @"Highways\Highway2L\Textures\Slope_SegmentLOD__APRMap.png",
                            @"Highways\Highway2L\Textures\Slope_SegmentLOD__XYSMap.png"));
                    info.SetAllNodesTexture(
                        new TexturesSet(
                            texturePack.Slope_Node_MainTex,
                            texturePack.Slope_Node_APRMap),
                        new LODTexturesSet
                           (@"Highways\Highway2L\Textures\Ground_NodeLOD__MainTex.png",
                            @"Highways\Highway2L\Textures\Ground_NodeLOD__APRMap.png",
                            @"Highways\Highway2L\Textures\Ground_LOD__XYSMap.png"));
                    break;

                case NetInfoVersion.Tunnel:
                    info.SetAllSegmentsTexture(
                        new TexturesSet
                           (@"Highways\Highway2L\Textures\Tunnel_Segment__MainTex.png",
                            @"Highways\Highway2L\Textures\Tunnel__APRMap.png"),
                    new LODTexturesSet
                           (@"Highways\Highway2L\Textures\Tunnel_SegmentLOD__MainTex.png",
                            @"Highways\Highway2L\Textures\TunnelLOD__APRMap.png",
                            @"Highways\Highway2L\Textures\Slope_NodeLOD__XYSMap.png"));
                    info.SetAllNodesTexture(
                        new TexturesSet
                           (@"Highways\Highway2L\Textures\Tunnel_Node__MainTex.png",
                            @"Highways\Highway2L\Textures\Tunnel__APRMap.png"),
                        new LODTexturesSet
                           (@"Highways\Highway2L\Textures\Tunnel_NodeLOD__MainTex.png",
                            @"Highways\Highway2L\Textures\TunnelLOD__APRMap.png",
                            @"Highways\Highway2L\Textures\Slope_NodeLOD__XYSMap.png"));
                    break;
            }
        }
    }
}

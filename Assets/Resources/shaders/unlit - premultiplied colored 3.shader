Shader "Hidden/Unlit/Premultiplied Colored 3"
{
	Properties
	{
		_MainTex ("Base (RGB), Alpha (A)", 2D) = "black" {}
	}

	SubShader
	{
		LOD 200

		Tags
		{
			"Queue" = "Transparent"
			"IgnoreProjector" = "True"
			"RenderType" = "Transparent"
		}
		
		Cull Off
		Lighting Off
		ZWrite Off
		Fog { Mode Off }
		Offset -1, -1
		Blend One OneMinusSrcAlpha

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			struct appdata_t
			{
				float4 vertex : POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
				fixed4 color : COLOR;
				float2 texcoord : TEXCOORD0;
				float4 worldPos0 : TEXCOORD1;
				float2 worldPos1 : TEXCOORD2;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			float4 _ClipRange0 = float4(0.0, 0.0, 1.0, 1.0);
			float4 _ClipArgs0 = float4(1000.0, 1000.0, 0.0, 1.0);
			float4 _ClipRange1 = float4(0.0, 0.0, 1.0, 1.0);
			float4 _ClipArgs1 = float4(1000.0, 1000.0, 0.0, 1.0);
			float4 _ClipRange2 = float4(0.0, 0.0, 1.0, 1.0);
			float4 _ClipArgs2 = float4(1000.0, 1000.0, 0.0, 1.0);

			v2f vert (appdata_t v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.color = v.color;
				o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
				o.worldPos0.xy = v.vertex.xy * _ClipRange0.zw + _ClipRange0.xy;
				o.worldPos0.zw = v.vertex.xy * _ClipRange1.zw + _ClipRange1.xy;
				o.worldPos1 = v.vertex.xy * _ClipRange2.zw + _ClipRange2.xy;
				return o;
			}

			fixed4 frag (v2f i) : SV_Target
			{
				float2 factor0 = (float2(1.0, 1.0) - abs(i.worldPos0.xy)) * _ClipArgs0.xy;
				float2 factor1 = (float2(1.0, 1.0) - abs(i.worldPos0.zw)) * _ClipArgs1.xy;
				float2 factor2 = (float2(1.0, 1.0) - abs(i.worldPos1)) * _ClipArgs2.xy;
				float f = clamp(min(min(min(factor0.x, factor0.y), min(factor1.x, factor1.y)), min(factor2.x, factor2.y)), 0.0, 1.0);
				fixed4 col = tex2D(_MainTex, i.texcoord) * i.color;
				col *= f;
				return col;
			}
			ENDCG
		}
	}
}

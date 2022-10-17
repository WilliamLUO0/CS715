// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:33525,y:32766,varname:node_4795,prsc:2|emission-3653-OUT,alpha-219-OUT,voffset-8637-OUT;n:type:ShaderForge.SFN_Tex2d,id:8325,x:32176,y:32492,ptovrint:False,ptlb:Ramp,ptin:_Ramp,varname:node_8325,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f952b3580d0baf14ca6d479694b70b75,ntxv:0,isnm:False|UVIN-4925-OUT;n:type:ShaderForge.SFN_Append,id:4925,x:32001,y:32492,varname:node_4925,prsc:2|A-4141-R,B-3352-OUT;n:type:ShaderForge.SFN_Vector1,id:3352,x:31793,y:32547,varname:node_3352,prsc:2,v1:0;n:type:ShaderForge.SFN_Tex2dAsset,id:7971,x:31619,y:32250,ptovrint:False,ptlb:ComTex,ptin:_ComTex,varname:node_7971,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:188f2bfc9732789478088758cf8b86d8,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:9218,x:31820,y:32250,varname:node_9218,prsc:2,tex:188f2bfc9732789478088758cf8b86d8,ntxv:0,isnm:False|UVIN-4218-OUT,TEX-7971-TEX;n:type:ShaderForge.SFN_Multiply,id:3653,x:32492,y:32401,varname:node_3653,prsc:2|A-8325-RGB,B-6740-OUT;n:type:ShaderForge.SFN_Multiply,id:4546,x:32720,y:32871,varname:node_4546,prsc:2|A-9218-G,B-4141-A,C-9886-OUT;n:type:ShaderForge.SFN_Slider,id:6740,x:32019,y:32686,ptovrint:False,ptlb:Final Power,ptin:_FinalPower,varname:node_6740,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5,max:10;n:type:ShaderForge.SFN_VertexColor,id:4141,x:31440,y:32777,varname:node_4141,prsc:2;n:type:ShaderForge.SFN_Slider,id:9886,x:32157,y:32827,ptovrint:False,ptlb:Opacity Boost,ptin:_OpacityBoost,varname:node_9886,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:4,max:4;n:type:ShaderForge.SFN_Clamp01,id:219,x:32884,y:32871,varname:node_219,prsc:2|IN-4546-OUT;n:type:ShaderForge.SFN_TexCoord,id:1500,x:30977,y:32001,varname:node_1500,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:8637,x:32664,y:33488,varname:node_8637,prsc:2|A-3278-OUT,B-2946-OUT,C-8536-OUT,D-6618-OUT,E-1205-OUT;n:type:ShaderForge.SFN_Tex2d,id:5304,x:32226,y:33192,ptovrint:False,ptlb:OffsetTex,ptin:_OffsetTex,varname:node_5304,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:False|UVIN-4218-OUT;n:type:ShaderForge.SFN_Slider,id:1205,x:32176,y:33717,ptovrint:False,ptlb:Offset Power,ptin:_OffsetPower,varname:node_1205,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_OneMinus,id:2946,x:31824,y:33303,varname:node_2946,prsc:2|IN-4141-R;n:type:ShaderForge.SFN_RemapRange,id:3278,x:32393,y:33192,varname:node_3278,prsc:2,frmn:0,frmx:1,tomn:-1,tomx:1|IN-5304-RGB;n:type:ShaderForge.SFN_OneMinus,id:8536,x:31824,y:33428,varname:node_8536,prsc:2|IN-4141-A;n:type:ShaderForge.SFN_Vector3,id:6618,x:32277,y:33554,varname:node_6618,prsc:2,v1:1,v2:1,v3:1;n:type:ShaderForge.SFN_Add,id:8462,x:31185,y:32084,varname:node_8462,prsc:2|A-1500-U,B-1922-OUT;n:type:ShaderForge.SFN_Time,id:7717,x:30712,y:32161,varname:node_7717,prsc:2;n:type:ShaderForge.SFN_Multiply,id:1922,x:30977,y:32186,varname:node_1922,prsc:2|A-7717-T,B-5717-OUT;n:type:ShaderForge.SFN_Slider,id:5717,x:30406,y:32394,ptovrint:False,ptlb:Scroll Speed,ptin:_ScrollSpeed,varname:node_5717,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-4,cur:0,max:4;n:type:ShaderForge.SFN_Append,id:4218,x:31378,y:32222,varname:node_4218,prsc:2|A-8462-OUT,B-1500-V;proporder:8325-7971-6740-9886-5304-1205-5717;pass:END;sub:END;*/

Shader "Sine VFX/FireDarts" {
    Properties {
        _Ramp ("Ramp", 2D) = "white" {}
        _ComTex ("ComTex", 2D) = "white" {}
        _FinalPower ("Final Power", Range(0, 10)) = 5
        _OpacityBoost ("Opacity Boost", Range(0, 4)) = 4
        _OffsetTex ("OffsetTex", 2D) = "bump" {}
        _OffsetPower ("Offset Power", Range(0, 1)) = 0
        _ScrollSpeed ("Scroll Speed", Range(-8, 8)) = 0
		_EdgeColor ("Edge Color", Color) = (0,0,0,1)
		_EdgeThickness ("Scroll Speed", Range(0, 4)) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu
            #pragma target 3.0
            uniform sampler2D _Ramp; uniform float4 _Ramp_ST;
            uniform sampler2D _ComTex; uniform float4 _ComTex_ST;
            uniform float _FinalPower;
            uniform float _OpacityBoost;
            uniform sampler2D _OffsetTex; uniform float4 _OffsetTex_ST;
            uniform float _OffsetPower;
            uniform float _ScrollSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                float4 node_7717 = _Time;
                float2 node_4218 = float2((o.uv0.r+(node_7717.g*_ScrollSpeed)),o.uv0.g);
                float4 _OffsetTex_var = tex2Dlod(_OffsetTex,float4(TRANSFORM_TEX(node_4218, _OffsetTex),0.0,0));
                v.vertex.xyz += ((_OffsetTex_var.rgb*2.0-1.0)*(1.0 - o.vertexColor.r)*(1.0 - o.vertexColor.a)*float3(1,1,1)*_OffsetPower);
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float2 node_4925 = float2(i.vertexColor.r,0.0);
                float4 _Ramp_var = tex2D(_Ramp,TRANSFORM_TEX(node_4925, _Ramp));
                float3 emissive = (_Ramp_var.rgb*_FinalPower);
                float3 finalColor = emissive;
                float4 node_7717 = _Time;
                float2 node_4218 = float2((i.uv0.r+(node_7717.g*_ScrollSpeed)),i.uv0.g);
                float4 node_9218 = tex2D(_ComTex,TRANSFORM_TEX(node_4218, _ComTex));
                fixed4 finalRGBA = fixed4(finalColor,saturate((node_9218.g*i.vertexColor.a*_OpacityBoost)));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }


		// MY START



		GrabPass{ }
		Pass
		{
			//Blend One One
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu
			#pragma target 3.0
			uniform sampler2D _GrabTexture;
			uniform sampler2D _OffsetTex; uniform float4 _OffsetTex_ST;
            uniform float _OffsetPower;
            uniform float _ScrollSpeed;

			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
				float4 vertexColor : COLOR;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
				float3 screen_uv : TEXCOORD1;
				float4 vertexColor : COLOR;
				UNITY_FOG_COORDS(1)
			};

			v2f vert (appdata v)
			{
				// OLD vert START

				//v2f o;
				//o.vertex = UnityObjectToClipPos(v.vertex);
				//o.uv = v.uv;
				//o.screen_uv = float3(o.vertex.xy, o.vertex.w);
				//return o;

				// OLD vert END



				// NEW vert START

				v2f o = (v2f)0;				
                o.uv = v.uv;
                o.vertexColor = v.vertexColor;
                float4 node_7717 = _Time;
                float2 node_4218 = float2((o.uv.r+(node_7717.g*_ScrollSpeed)),o.uv.g);
                float4 _OffsetTex_var = tex2Dlod(_OffsetTex,float4(TRANSFORM_TEX(node_4218, _OffsetTex),0.0,0));
                v.vertex.xyz += ((_OffsetTex_var.rgb*2.0-1.0)*(1.0 - o.vertexColor.r)*(1.0 - o.vertexColor.a)*float3(1,1,1)*_OffsetPower);
                o.vertex = UnityObjectToClipPos( v.vertex );
				o.screen_uv = float3(o.vertex.xy, o.vertex.w);
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;

				// NEW vert END


			}
			
			sampler2D _MainTex;
			float _Intensity;
			half4 _EdgeColor;
			float _EdgeThickness;

			float d;

			float lookup (float2 p, float dx, float dy)
			{
				float2 uv = (p.xy + float2(dx * d, dy * d)) / _ScreenParams.xy;
				// flip vertical
				//uv.y = 1 - uv.y;
				float4 c = tex2D(_GrabTexture, uv.xy);
	
				// return as luma
				return 0.2126*c.r + 0.7152*c.g + 0.0722*c.b;
			}

			fixed4 frag (v2f i) : SV_Target
			{
				float2 correcterScreenUV = (i.screen_uv.xy / i.screen_uv.z + 1) * 0.5;
				correcterScreenUV.y = 1 - correcterScreenUV.y;
				//d = sin(_Time.y * 5.0)*0.5 + 1.5; // kernel offset
				d = _EdgeThickness;
				float2 p = i.vertex.xy;

				// simple sobel edge detection
				float gx = 0.0;
				gx += -1.0 * lookup(p, -1.0, -1.0);
				gx += -2.0 * lookup(p, -1.0,  0.0);
				gx += -1.0 * lookup(p, -1.0,  1.0);
				gx +=  1.0 * lookup(p,  1.0, -1.0);
				gx +=  2.0 * lookup(p,  1.0,  0.0);
				gx +=  1.0 * lookup(p,  1.0,  1.0);
    
				float gy = 0.0;
				gy += -1.0 * lookup(p, -1.0, -1.0);
				gy += -2.0 * lookup(p,  0.0, -1.0);
				gy += -1.0 * lookup(p,  1.0, -1.0);
				gy +=  1.0 * lookup(p, -1.0,  1.0);
				gy +=  2.0 * lookup(p,  0.0,  1.0);
				gy +=  1.0 * lookup(p,  1.0,  1.0);

				// hack: use g^2 to conceal noise in the video
				float g = gx*gx + gy*gy;
				//float g2 = g * (sin(_Time.y) / 2.0 + 0.5);

				float4 ccol = tex2D(_GrabTexture, correcterScreenUV);

				//ccol += float4(g, g, g, 1.0) * _EdgeColor;
				//ccol += float4(0.0, g, g2, 1.0) * _EdgeColor;
				ccol += float4(g, g, g, 1.0) * _EdgeColor;

				//fixed4 c = tex2D(_GrabTexture, correcterScreenUV); 

				//float4 result = c;
				//result.rgb = lerp(c.rgb, ccol, _Intensity);
				return ccol;
			}
			ENDCG
		}


		// MY END



    }
    CustomEditor "ShaderForgeMaterialInspector"
}

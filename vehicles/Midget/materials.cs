singleton Material(material1)
{
   mapTo = "body";	//the name of the mesh in blender not the DAE filename
   diffuseMap[0] = "vehicles/Midget/AO_bake.dds";
   specularPower[0] = "15";
   useAnisotropic[0] = "1";  
   
   diffuseColor[0] = "1 1 1 1";
   
   castShadows = "0";
   translucent = "1";
   alphaTest = "1";
   alphaRef = "0";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
	
};
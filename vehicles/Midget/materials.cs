singleton Material(midget_material1)
{
   mapTo = "material1";	//the name of the material in blender
   diffuseMap[0] = "AO_bake.dds";
   specularPower[0] = "15";
   useAnisotropic[0] = "1";
   castShadows = "1";
   translucent = "0";
   alphaTest = "0";
   alphaRef = "0";
   //dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   materialTag0 = "beamng"; materialTag1 = "vehicle";
	
};

singleton Material(midget_dull_metal)
{
   mapTo = "dull_metal";	//the name of the material in blender
   diffuseColor[0] = "0.470588 0.470588 0.470588 1";
   specular[0] = "Black";
   specularPower[0] = "128";
   translucentBlendOp = "none";
};

singleton Material(midget_Rim)
{
   mapTo = "crome";	//the name of the material in blender
    diffuseMap[0] = "Wheel.dds";
	//specularMap[0] = "Wheel_Reflect.dds";
	//normalMap[0] = "Wheel_Normals.dds";
   specularPower[0] = "16";
   translucentBlendOp = "none";
};
singleton Material(midget_material1)
{
   mapTo = "material1";	//the name of the material in blender
   diffuseMap[0] = "Body_AO.dds";
   specularPower[0] = "200";
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
	specularMap[0] = "Wheel_Reflect.dds";
	//normalMap[0] = "Wheel_Normals.dds";
   specularPower[0] = "200";
   translucentBlendOp = "none";
};

singleton Material(midget_Underbody)
{
  mapTo = "plastic_black";	//the name of the material in blender
   diffuseColor[0] = "0.15 0.15 0.15 1";
   specular[0] = "Black";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};

singleton Material(midget_carpet)
{
   mapTo = "carpet";	//the name of the material in blender
   diffuseColor[0] = "0.25 0.25 0.25 1";
   specular[0] = "Black";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};

singleton Material(midget_walls)
{
   mapTo = "shiny_leather";	//the name of the material in blender
   diffuseColor[0] = "0.2 0.2 0.2 1";
   specular[0] = "100";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};

singleton Material(midget_door_Cards)
{
   mapTo = "door_card";	//the name of the material in blender
   diffuseColor[0] = "0.2 0.2 0.2 1";
   specular[0] = "100";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};




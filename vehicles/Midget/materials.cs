singleton Material(midget_paint)
{
   mapTo = "body";	//the name of the material in blender
   diffuseMap[0] = "Body_AO.png";
   specular[0] = "White";
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
   mapTo = "wheel";	//the name of the material in blender
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
    diffuseMap[0] = "Carpet.dds";
   specular[0] = "Black";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};

singleton Material(midget_walls)
{
   mapTo = "shiny_leather";	//the name of the material in blender
    diffuseMap[0] = "walls.png";
   specular[0] = "Black";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};

singleton Material(door_card)
{
   mapTo = "door_card";	//the name of the material in blender
    diffuseMap[0] = "door_card.png";
   specular[0] = "Black";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};

singleton Material(front_emblum)
{
   mapTo = "front_emblum";	//the name of the material in blender
    diffuseMap[0] = "front_emblum.png";
   specular[0] = "Black";
   specularPower[0] = "100";
   translucentBlendOp = "none";
};

singleton Material(grille)
{
   mapTo = "grille";	//the name of the material in blender
    diffuseMap[0] = "grille3.png";
   specular[0] = "Black";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};

singleton Material(sideskirts)
{
   mapTo = "sideskirts";	//the name of the material in blender
    diffuseMap[0] = "sideskirts.dds";
   specular[0] = "Black";
   specularPower[0] = "75";
   translucentBlendOp = "none";
};

singleton Material(chrome)
{
   mapTo = "crome";	//the name of the material in blender
   diffuseColor[0] = "0.470588 0.470588 0.470588 1";
   specularPower[0] = "800";
   translucentBlendOp = "none";
};

singleton Material(rubber)
{
   mapTo = "rubber";	//the name of the material in blender
   diffuseColor[0] = "0.01 0.01 0.01 1";
   specular[0] = "Black";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};

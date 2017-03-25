singleton Material(midget_paint)
{
   mapTo = "body";	//the name of the material in blender
   diffuseMap[0] = "Body_AO8.dds";
   specularMap[0] = "Body_Reflect.dds";
   specularPower[0] = "400";
   useAnisotropic[0] = "1";
   castShadows = "1";
   translucent = "0";
   alphaTest = "0";
   alphaRef = "0";
   doubleSided = "1";
  // dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
};

singleton Material(midget_dull_metal)
{
   mapTo = "dull_metal";	//the name of the material in blender
   diffuseColor[0] = "0.470588 0.470588 0.470588 1";
   specular[0] = "Black";
   specularPower[0] = "128";
   doubleSided = "1";
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
   doubleSided = "1";
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
   doubleSided = "1";
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
   specularMap[0] = "vehicles/common/null.dds";

   //specular[0] = "Black";
   specularPower[0] = "200";
   translucentBlendOp = "none";
};
singleton Material(rear_emblum)
{
   mapTo = "rear_emblum";	//the name of the material in blender
   diffuseMap[0] = "Rear_emblum.png";
   specularMap[0] = "vehicles/common/null.dds";

   //specular[0] = "Black";
   specularPower[0] = "200";
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
      doubleSided = "1";
   translucentBlendOp = "none";
};

singleton Material(chrome)
{
   mapTo = "crome";	//the name of the material in blender
   
      specularMap[0] = "Body_Reflect.dds";
   specularPower[0] = "200";
   useAnisotropic[0] = "1";
   castShadows = "1";
   translucent = "0";
   alphaTest = "0";
   alphaRef = "0";
   doubleSided = "1";
   dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
   
   /* diffuseColor[0] = "0.470588 0.470588 0.470588 1";

    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "Body_Reflect.dds";

    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "0.75 0.75 0.75 0.75";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "0";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap"; */
};

singleton Material(rubber)
{
   mapTo = "rubber";	//the name of the material in blender
   diffuseColor[0] = "0.01 0.01 0.01 1";
   specular[0] = "Black";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};

singleton Material(dashboard)
{
   mapTo = "dashboard";	//the name of the material in blender
    diffuseMap[0] = "dashboard.png";
   specular[0] = "Black";
   specularPower[0] = "10";
      doubleSided = "1";
   translucentBlendOp = "none";
};

singleton Material(seats)
{
   mapTo = "seats";	//the name of the material in blender
    diffuseMap[0] = "seat.png";
   specular[0] = "Black";
   specularPower[0] = "10";
      doubleSided = "1";
   translucentBlendOp = "none";
};

singleton Material(dials)
{
   mapTo = "Dials";	//the name of the material in blender
    diffuseMap[0] = "MG2dials2.png";
   specularPower[0] = "10";
   translucentBlendOp = "none";
};

singleton Material(glass)
{
    mapTo = "glass";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    specularMap[0] = "vehicles/common/null.dds";
	diffuseMap[1] = "glass_da.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "1";
    alphaRef = "0";
    dynamicCubemap = true; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(glass_orange)
{
    mapTo = "glass_orange";
    diffuseColor[0] = "0.686 0.282 0 1";
    castShadows = "0";
    translucent = "1";
};

singleton Material(glass_red)
{
    mapTo = "glass_red_001";
    diffuseColor[0] = "0.6 0.0 0.004 1";
    castShadows = "0";
    translucent = "1";
};

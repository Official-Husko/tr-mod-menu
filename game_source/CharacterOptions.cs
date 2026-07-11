using UnityEngine;

public static class CharacterOptions
{
	public static string eyebrowsStraight = "Eyebrows/Straight";

	public static string eyebrowsExtended = "Eyebrows/Extended";

	public static string veryShortHair = "Hair/VeryShortHair";

	public static string shortHair = "Hair/ShortHair";

	public static string mediumHair = "Hair/MediumHair";

	public static string longHair = "Hair/LongHair";

	public static string ponyTail = "Hair/PonyTail";

	public static string beard = "FacialHair/Beard";

	public static string moustache = "FacialHair/Moustache";

	public static string goate = "FacialHair/Goate";

	public static string thin = "FacialHair/Thin";

	public static string stubble = "FacialHair/Stubble";

	public static string wavvy = "Shirts/Wavvy";

	public static string jacket = "Shirts/Jacket";

	public static string buttons = "Shirts/Buttons";

	public static string jacketClosed = "Shirts/JacketClosed";

	public static string breastPlate = "Shirts/BreastPlate";

	public static string backpack = "Accessories/Back/Backpack";

	public static string sword2h = "Accessories/Back/2hSword";

	public static string largeShield = "Accessories/Back/LargeShield";

	public static string lute = "Accessories/Back/Lute";

	public static string bowAndArrow = "Accessories/Back/BowAndArrow";

	public static string staff = "Accessories/Back/Staff";

	public static string dualSwords = "Accessories/Back/DualSwords";

	public static string warhammer = "Accessories/Back/Warhammer";

	public static string hoodedCloak = "Accessories/Cloak/HoodedCloak";

	public static string axe = "Accessories/Hip/Axe";

	public static string sword = "Accessories/Hip/Sword";

	public static string sidebags = "Accessories/Hip/SideBags";

	public static string potions = "Accessories/Hip/Potions";

	public static string book = "Accessories/Hip/Book";

	public static string mace = "Accessories/Hip/Mace";

	public static string daggers = "Accessories/Hip/Daggers";

	public static string wand = "Accessories/Hip/Wand";

	public static string hatFeather = "Accessories/Hat/HatFeather";

	public static string fadora = "Accessories/Hat/Fadora";

	public static string helmetHorn = "Accessories/Hat/HelmetHorn";

	public static string headWrap = "Accessories/Hat/HeadWrap";

	public static string[] hair = new string[6] { "", veryShortHair, shortHair, mediumHair, longHair, ponyTail };

	public static string[] mascHair = new string[3] { "", veryShortHair, shortHair };

	public static string[] femHair = new string[3] { mediumHair, longHair, ponyTail };

	public static string[] hairNoHat = new string[1] { ponyTail };

	public static string[] facialHair = new string[6] { beard, moustache, goate, thin, stubble, "" };

	public static string[] eyebows = new string[2] { eyebrowsStraight, eyebrowsExtended };

	public static string[] shirts = new string[5] { "", jacket, buttons, jacketClosed, breastPlate };

	public static string[] shirtArmor = new string[1] { breastPlate };

	public static string[] copyColourShirts = new string[1] { wavvy };

	public static string[] back = new string[9] { "", backpack, sword2h, largeShield, lute, bowAndArrow, staff, dualSwords, warhammer };

	public static string[] backUnderHair = new string[2] { backpack, largeShield };

	public static string[] cloak = new string[2] { "", hoodedCloak };

	public static string[] hip = new string[8] { "", axe, sword, sidebags, potions, book, mace, daggers };

	public static string[] weapons = new string[4] { axe, sword, book, mace };

	public static string[] hats = new string[5] { "", hatFeather, fadora, helmetHorn, headWrap };

	public static string[] hatColour = new string[1] { headWrap };

	public static string[] hatShortHair = new string[1] { headWrap };

	public static string[] hatArmor = new string[1] { helmetHorn };

	public static string[] hatNoArmor = new string[3] { hatFeather, fadora, headWrap };

	public static Color[] jacketColours = (Color[])(object)new Color[3]
	{
		new Color(0.8301887f, 0.6194386f, 0.3250267f),
		new Color(0.245283f, 0.245283f, 0.245283f),
		new Color(0.5f, 0.4200307f, 0.3089623f)
	};

	public static Color[] lighterHairColours = (Color[])(object)new Color[4]
	{
		new Color(0.8867924f, 0.3494804f, 0.1129405f),
		new Color(0.9017736f, 0.9056604f, 0.5425419f),
		new Color(75f / 106f, 75f / 106f, 75f / 106f),
		new Color(1f, 1f, 1f)
	};

	public static Color[] darkerHairColours = (Color[])(object)new Color[4]
	{
		new Color(0.4716981f, 0.3164397f, 0.2069242f),
		new Color(0.6792453f, 0.4435917f, 0.1826273f),
		new Color(29f / 106f, 0.2005336f, 0.1122731f),
		new Color(37f / 106f, 0.3116691f, 0.2683784f)
	};

	public static Color[] bodyCommonColours = (Color[])(object)new Color[5]
	{
		new Color(1f, 1f, 1f),
		new Color(0.245283f, 0.245283f, 0.245283f),
		new Color(105f / 106f, 0.8960455f, 0.7522694f),
		new Color(0.8301887f, 0.6194386f, 0.3250267f),
		new Color(0.5f, 0.4200307f, 0.3089623f)
	};

	public static Color[] bodyUncommonColours = (Color[])(object)new Color[7]
	{
		new Color(101f / 106f, 0.3447115f, 0.2741634f),
		new Color(0.9622642f, 0.5844109f, 0.1407084f),
		new Color(0.9987697f, 1f, 0.4764151f),
		new Color(0.5221552f, 1f, 0.4745098f),
		new Color(0.3515486f, 0.4856319f, 0.9433962f),
		new Color(0.6738845f, 0.5161979f, 0.754717f),
		new Color(1f, 0.7216981f, 0.9738187f)
	};

	public static Color[] legsColours = (Color[])(object)new Color[4]
	{
		new Color(0.3584906f, 0.3359737f, 0.3026878f),
		new Color(43f / 106f, 0.304759f, 0.2238786f),
		new Color(79f / 106f, 0.5640161f, 0.2988163f),
		new Color(0.2496333f, 0.2924528f, 0.1586419f)
	};

	public static Color[] eyeColours = (Color[])(object)new Color[5]
	{
		new Color(0.2075472f, 0.2075472f, 0.2075472f),
		new Color(0.1815781f, 0.6415094f, 0f),
		new Color(0.4150943f, 0.3413366f, 0.2095052f),
		new Color(0.754717f, 0.6283711f, 0.4022784f),
		new Color(0f, 0.3425286f, 0.8301887f)
	};

	public static Color[] lighterSkinColours = (Color[])(object)new Color[2]
	{
		new Color(1f, 1f, 1f),
		new Color(1f, 0.9163207f, 0.7688679f)
	};

	public static Color[] darkerSkinColours = (Color[])(object)new Color[3]
	{
		new Color(0.9245283f, 0.7925901f, 0.5538448f),
		new Color(0.6981132f, 0.6002942f, 0.4247953f),
		new Color(57f / 106f, 0.4552999f, 0.3069153f)
	};

	public static Color[] feetColours = (Color[])(object)new Color[4]
	{
		new Color(87f / 106f, 0.7111748f, 0.5768512f),
		new Color(57f / 106f, 0.4169051f, 0.2663314f),
		new Color(61f / 106f, 0.3227073f, 0.002714496f),
		new Color(0.3018868f, 0.2806647f, 0.254895f)
	};

	public static Color[] cloakColours = (Color[])(object)new Color[5]
	{
		new Color(0.7271987f, 0.6018156f, 0.7924528f),
		new Color(0.5896226f, 0.7830226f, 1f),
		new Color(0.5882353f, 1f, 0.6203169f),
		new Color(0.3066038f, 1f, 0.8641515f),
		new Color(1f, 0.4284377f, 0.4103774f)
	};
}

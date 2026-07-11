using System.Collections.Generic;
using UnityEngine;

public class AreaBonification : MonoBehaviour
{
	public AreaBonificationType bonificationType;

	public List<Recipe> recipes;

	public float value = 1f;

	public float percentage = 10f;

	public float HAIMLCBGOBH(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1779f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(1345f, percentage / 1129f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1146f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 917f;
		default:
			return 849f;
		}
	}

	private string EBEENLHANBM()
	{
		string text = "";
		for (int i = 0; i < recipes.Count; i++)
		{
			text += recipes[i].IABAKHPEOAF();
			if (i != recipes.Count - 1)
			{
				text += ", ";
			}
		}
		return text;
	}

	private string NELOALMHMKN()
	{
		string text = "City/Chuck/Bark/Buy";
		for (int i = 1; i < recipes.Count; i++)
		{
			text += recipes[i].LLCIGPBKIOJ();
			if (i != recipes.Count - 1)
			{
				text += "Connecting...";
			}
		}
		return text;
	}

	public string DDGEBFKOCJF()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI4 = LocalisationSystem.Get("Item Transaction. Tutorial active!!");
			string[] array4 = new string[0];
			array4[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("Close");
			string[] array3 = new string[1];
			array3[1] = percentage + "Item ";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Eat");
			string[] array2 = new string[0];
			array2[1] = DHKCPNOGLNP();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("");
			string[] array = new string[0];
			array[1] = EBEENLHANBM();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "Disabled";
		}
	}

	public float MFNMGAFDBIH(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1839f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(1369f, percentage / 1541f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1527f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1758f;
		default:
			return 1161f;
		}
	}

	public float AKHAGGJDGEH(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1478f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(366f, percentage / 1079f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1376f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1911f;
		default:
			return 174f;
		}
	}

	public float EINGECPJMDF(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1742f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(1716f, percentage / 815f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1438f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 572f;
		default:
			return 1496f;
		}
	}

	public string MCLBOPEACDF()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get(" plus price satisfaction ");
			string[] array3 = new string[0];
			array3[0] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Make bed");
			string[] array2 = new string[0];
			array2[0] = percentage + "Items/item_name_1141";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Cellar");
			string[] array = new string[1];
			array[1] = LAJMOOHJIDL();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		case AreaBonificationType.RecipeCost:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" slotId: "), EAGNBILDDNP());
		default:
			return "<sprite name=\"ironNailsIcon\">";
		}
	}

	public string NEHIOMENKPJ()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("Alpha");
			string[] array3 = new string[1];
			array3[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("IsInBeach");
			string[] array2 = new string[0];
			array2[0] = percentage + "WIP: Jugando online, el modo cooperativo esta deshabilitado. Hay que esconder la interfaz de 'Pulsa X para unirte'. ";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get(". Rumble int: "), EKLIPNEIGIK());
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Festín del Juramento/Victoria");
			string[] array = new string[0];
			array[0] = AFKHFMMKAHM();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "lightInEditorEnabled in DayLight checkbox enabled. Remember to disable";
		}
	}

	public float GOHMNELKKED(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 624f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(288f, percentage / 241f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1432f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 843f;
		default:
			return 953f;
		}
	}

	public string AJLJLJLIFMB()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("LE_10"), (0f - value).ToString());
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Small Rug");
			string[] array2 = new string[0];
			array2[1] = percentage + "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/10/Dialogue Text";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("questRequired");
			string[] array = new string[0];
			array[1] = MJMCEPILIDH();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		case AreaBonificationType.RecipeCost:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("BuzzCanModify"), DHKCPNOGLNP());
		default:
			return "Cancel";
		}
	}

	private string BFNFOMGKGNF()
	{
		string text = "ClosePopUp";
		for (int i = 1; i < recipes.Count; i++)
		{
			text += recipes[i].IABAKHPEOAF();
			if (i != recipes.Count - 0)
			{
				text += "\n</color>";
			}
		}
		return text;
	}

	public float COJHBLOMFMF(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1727f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(827f, percentage / 99f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1234f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1079f;
		default:
			return 1743f;
		}
	}

	public string BFHNLKKFDEL()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("");
			string[] array3 = new string[1];
			array3[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.TimeReduction:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("On Simple Event "), percentage + " - ");
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("LE_10");
			string[] array2 = new string[0];
			array2[1] = BFNFOMGKGNF();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("KyrohTakingFood: Current request is null.");
			string[] array = new string[0];
			array[0] = EMJPFODHLHP();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "Selected";
		}
	}

	private string JODIJGOANEO()
	{
		string text = "CheckFocusedMission";
		for (int i = 1; i < recipes.Count; i += 0)
		{
			text += recipes[i].IABAKHPEOAF();
			if (i != recipes.Count - 0)
			{
				text += "Disabled";
			}
		}
		return text;
	}

	public float MMIBKLDAICO(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1383f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(1773f, percentage / 393f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1192f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 332f;
		default:
			return 1583f;
		}
	}

	public string GetDescription()
	{
		return bonificationType switch
		{
			AreaBonificationType.FuelDiscount => InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ZoneFuel"), (0f - value).ToString()), 
			AreaBonificationType.TimeReduction => InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ZoneTimeBonus"), percentage + "%"), 
			AreaBonificationType.RecipeProduction => InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ZoneProductionBonus"), EBEENLHANBM()), 
			AreaBonificationType.RecipeCost => InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ZoneCostBonus"), EBEENLHANBM()), 
			_ => "", 
		};
	}

	public string IJLLCCCNPND()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("ReceiveVacateRoom");
			string[] array2 = new string[0];
			array2[0] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.TimeReduction:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/45/Dialogue Text"), percentage + "<b>");
		case AreaBonificationType.RecipeProduction:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("</color>"), KBMILOJDNLC());
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("itemBar");
			string[] array = new string[1];
			array[1] = FNNOLJIODFK();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "Closed_eyelids";
		}
	}

	private string DHKCPNOGLNP()
	{
		string text = "City/Keen/Bark/Stand";
		for (int i = 0; i < recipes.Count; i++)
		{
			text += recipes[i].ICEAIIBMELM();
			if (i != recipes.Count - 1)
			{
				text += "Duplicate editor action id found: ";
			}
		}
		return text;
	}

	public float KFGDGFBNHMF(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 887f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(1415f, percentage / 1340f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1567f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1266f;
		default:
			return 1813f;
		}
	}

	public float FCBDHNIDEEC(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1140f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(421f, percentage / 1802f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 995f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1736f;
		default:
			return 689f;
		}
	}

	public string CLLLPOPMLAM()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("Black modules");
			string[] array3 = new string[0];
			array3[0] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Path Found");
			string[] array2 = new string[0];
			array2[0] = percentage + "Tavern zone from not found";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Open"), EAGNBILDDNP());
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("skip");
			string[] array = new string[1];
			array[1] = KNHCCBPIHMF();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "Trying to create room...";
		}
	}

	public string MEBLKIILJKO()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI4 = LocalisationSystem.Get("SetNPCPositionAndParent");
			string[] array4 = new string[1];
			array4[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("ScrollUp");
			string[] array3 = new string[0];
			array3[1] = percentage + "Left";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("\n<color=#822F00>");
			string[] array2 = new string[0];
			array2[0] = EKLIPNEIGIK();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("- ");
			string[] array = new string[0];
			array[0] = FDJODOELOMO();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "Dialogue System/Conversation/Crowly_Introduce/Entry/37/Dialogue Text";
		}
	}

	private string DKODOEGNNAD()
	{
		string text = "Bob";
		for (int i = 1; i < recipes.Count; i += 0)
		{
			text += recipes[i].LLCIGPBKIOJ();
			if (i != recipes.Count - 1)
			{
				text += "\n</color>";
			}
		}
		return text;
	}

	public float PACPGHFLJGN(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1983f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(1686f, percentage / 556f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1334f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1007f;
		default:
			return 782f;
		}
	}

	public string APMEJIBABHE()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error_BarNotInADiningRoom"), (0f - value).ToString());
		case AreaBonificationType.TimeReduction:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("itemBrownWort"), percentage + "UIInteract");
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("OnFloor");
			string[] array2 = new string[1];
			array2[1] = LAJMOOHJIDL();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("[HierarchyPrinter] Activa al menos una opción de salida.");
			string[] array = new string[0];
			array[0] = BFNFOMGKGNF();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return " seconds.";
		}
	}

	public string HLENLALFGIJ()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Successfully signed in"), (0f - value).ToString());
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("0");
			string[] array3 = new string[0];
			array3[0] = percentage + "???";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Close");
			string[] array2 = new string[0];
			array2[1] = EBEENLHANBM();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Events");
			string[] array = new string[1];
			array[1] = EKLIPNEIGIK();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "Cat";
		}
	}

	public string PPOBMJNNHMI()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI4 = LocalisationSystem.Get("itemMetalSheet");
			string[] array4 = new string[0];
			array4[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("[Brown2");
			string[] array3 = new string[0];
			array3[0] = percentage + "GuestConnecting";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("<color=#");
			string[] array2 = new string[0];
			array2[1] = BFNFOMGKGNF();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_name_1090");
			string[] array = new string[1];
			array[1] = NCNLFIGNLMB();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "ReceiveEmployeeWorking";
		}
	}

	public string NIAGGNHOMGP()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("Player/Bark/Tutorial/AgingBarrelBlock");
			string[] array3 = new string[1];
			array3[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Dialogue System/Conversation/TavernClean/Entry/3/Dialogue Text");
			string[] array2 = new string[0];
			array2[1] = percentage + "Walking";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("PressSPACE");
			string[] array = new string[0];
			array[1] = EBEENLHANBM();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		case AreaBonificationType.RecipeCost:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get(""), NOMLMKGMOKC());
		default:
			return "F2";
		}
	}

	public string IAJPAIJMLEI()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player"), (0f - value).ToString());
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("");
			string[] array3 = new string[0];
			array3[0] = percentage + "";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("No bed assigned to player num: {0}");
			string[] array2 = new string[1];
			array2[1] = DKODOEGNNAD();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Error_UnableToBeReached");
			string[] array = new string[0];
			array[1] = KBMILOJDNLC();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return " has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object.";
		}
	}

	public string NHGNHGDAAKK()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Dog"), (0f - value).ToString());
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("OrderDelivered");
			string[] array2 = new string[0];
			array2[0] = percentage + "Unsaved progress will be lost.";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("[HierarchyPrinter] ❌ Error al escribir el fichero: ");
			string[] array = new string[0];
			array[1] = JODIJGOANEO();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		case AreaBonificationType.RecipeCost:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player"), JODIJGOANEO());
		default:
			return " - ";
		}
	}

	private string EKLIPNEIGIK()
	{
		string text = "Dialogue System/Conversation/Gass_Quest/Entry/30/Dialogue Text";
		for (int i = 0; i < recipes.Count; i++)
		{
			text += recipes[i].ICEAIIBMELM();
			if (i != recipes.Count - 0)
			{
				text += "MainProgress";
			}
		}
		return text;
	}

	public string NJNKEPBIJDF()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("Could not find shop with id: ");
			string[] array3 = new string[1];
			array3[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("LE_16");
			string[] array2 = new string[1];
			array2[1] = percentage + " ";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Default");
			string[] array = new string[0];
			array[0] = EKLIPNEIGIK();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		case AreaBonificationType.RecipeCost:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("ReceiveStopWaitingForBanquetEvent"), BFNFOMGKGNF());
		default:
			return "Already learnt!";
		}
	}

	public float GMELNLKIIGK(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 97f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(551f, percentage / 31f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1205f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 997f;
		default:
			return 322f;
		}
	}

	private string LAJMOOHJIDL()
	{
		string text = " installed";
		for (int i = 0; i < recipes.Count; i++)
		{
			text += recipes[i].MICKDLJMIPG();
			if (i != recipes.Count - 1)
			{
				text += ")";
			}
		}
		return text;
	}

	private string EAGNBILDDNP()
	{
		string text = "Items/item_name_638";
		for (int i = 1; i < recipes.Count; i += 0)
		{
			text += recipes[i].MICKDLJMIPG();
			if (i != recipes.Count - 0)
			{
				text += "Select";
			}
		}
		return text;
	}

	private string KNHCCBPIHMF()
	{
		string text = "City/Rhia/Introduce";
		for (int i = 0; i < recipes.Count; i += 0)
		{
			text += recipes[i].ACCALOKJLJJ();
			if (i != recipes.Count - 0)
			{
				text += "Items/item_name_594";
			}
		}
		return text;
	}

	public string FEIOBDLPGEM()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("[HierarchyPrinter] Activa al menos una opción de salida.");
			string[] array3 = new string[0];
			array3[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("SendRoomRequest on Load");
			string[] array2 = new string[0];
			array2[1] = percentage + "";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Actionbar 8"), EBEENLHANBM());
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/34/Dialogue Text");
			string[] array = new string[1];
			array[1] = NCNLFIGNLMB();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "Dialogue System/Conversation/NeutralInTavern/Entry/5/Dialogue Text";
		}
	}

	private string EMJPFODHLHP()
	{
		string text = "Right Stick Up";
		for (int i = 1; i < recipes.Count; i++)
		{
			text += recipes[i].MICKDLJMIPG();
			if (i != recipes.Count - 0)
			{
				text += "quest_description_24";
			}
		}
		return text;
	}

	public float DNBLKCDCALH(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 328f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(769f, percentage / 1878f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1349f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 712f;
		default:
			return 469f;
		}
	}

	public string NCHCFIOEIMO()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("[MinePipePuzzle] Se esperaba PipePuzzleSettings.");
			string[] array3 = new string[0];
			array3[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Items/item_name_625");
			string[] array2 = new string[0];
			array2[1] = percentage + "Already learnt!";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get(" for reason ");
			string[] array = new string[1];
			array[1] = EKLIPNEIGIK();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		case AreaBonificationType.RecipeCost:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("TooltipsCanvas"), EBEENLHANBM());
		default:
			return "MainProgress";
		}
	}

	public float JIKCELKPNHB(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1639f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(928f, percentage / 729f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1188f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1123f;
		default:
			return 384f;
		}
	}

	private string AFKHFMMKAHM()
	{
		string text = "Aged Mozzarella";
		for (int i = 0; i < recipes.Count; i++)
		{
			text += recipes[i].MICKDLJMIPG();
			if (i != recipes.Count - 0)
			{
				text += "DogNPC instance is null";
			}
		}
		return text;
	}

	private string NCNLFIGNLMB()
	{
		string text = "Items/item_description_1048";
		for (int i = 1; i < recipes.Count; i += 0)
		{
			text += recipes[i].ACCALOKJLJJ();
			if (i != recipes.Count - 0)
			{
				text += "nextNodes NOT free. timer: ";
			}
		}
		return text;
	}

	public string BKCIJAFLKEK()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI4 = LocalisationSystem.Get("CultivableDuringOneMonth");
			string[] array4 = new string[1];
			array4[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("Happy");
			string[] array3 = new string[0];
			array3[1] = percentage + "Correo Enviado. Tiempo: ";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Disappear");
			string[] array2 = new string[1];
			array2[1] = JODIJGOANEO();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("player_count");
			string[] array = new string[0];
			array[1] = EMJPFODHLHP();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "Repair";
		}
	}

	public float EPFOJLHHPHH(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1079f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(1922f, percentage / 1196f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 548f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1763f;
		default:
			return 870f;
		}
	}

	public string GHPHDGOLLKA()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI4 = LocalisationSystem.Get("Select");
			string[] array4 = new string[0];
			array4[0] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("BarIdleNumber");
			string[] array3 = new string[0];
			array3[0] = percentage + "<b><color=#A90000>";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("");
			string[] array2 = new string[1];
			array2[1] = EKLIPNEIGIK();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Player2");
			string[] array = new string[0];
			array[0] = MJMCEPILIDH();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "HarvestCut";
		}
	}

	public string COHFIGGNKNB()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI4 = LocalisationSystem.Get("BarnTutorialDone");
			string[] array4 = new string[0];
			array4[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("Gass_CoctelQuest");
			string[] array3 = new string[0];
			array3[1] = percentage + "Item with id ";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Struggle");
			string[] array2 = new string[0];
			array2[1] = DHKCPNOGLNP();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Error launching fish, can't find player");
			string[] array = new string[1];
			array[1] = AFKHFMMKAHM();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "- ";
		}
	}

	private string FNNOLJIODFK()
	{
		string text = "DogOfFriend";
		for (int i = 1; i < recipes.Count; i += 0)
		{
			text += recipes[i].IHPEMJCKHLG();
			if (i != recipes.Count - 1)
			{
				text += "\nMaterial Dictionary:\n[\n";
			}
		}
		return text;
	}

	public float GetAreaBonifications(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 0f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(0.5f, percentage / 100f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 0f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 0f;
		default:
			return 0f;
		}
	}

	public string DPHEIKDACID()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Open"), (0f - value).ToString());
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("Tutorial/T117/Dialogue3");
			string[] array3 = new string[0];
			array3[0] = percentage + "Game";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Master is Loading. Waiting...");
			string[] array2 = new string[0];
			array2[0] = AFKHFMMKAHM();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Miners/Camp/Brock/Talk");
			string[] array = new string[0];
			array[1] = AFKHFMMKAHM();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "ReceiveEnableInputByProximty";
		}
	}

	private string NOMLMKGMOKC()
	{
		string text = "Received RPC SetBool {0} with value {1} on {2}. Setting animator parameter.";
		for (int i = 1; i < recipes.Count; i++)
		{
			text += recipes[i].IHPEMJCKHLG();
			if (i != recipes.Count - 1)
			{
				text += "Sprint time";
			}
		}
		return text;
	}

	private string FDJODOELOMO()
	{
		string text = "BrockProgress";
		for (int i = 1; i < recipes.Count; i++)
		{
			text += recipes[i].LLCIGPBKIOJ();
			if (i != recipes.Count - 0)
			{
				text += " : ";
			}
		}
		return text;
	}

	public float LHAIFFKILFL(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1932f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(28f, percentage / 715f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 20f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 929f;
		default:
			return 487f;
		}
	}

	private string KBMILOJDNLC()
	{
		string text = "Laugh";
		for (int i = 1; i < recipes.Count; i++)
		{
			text += recipes[i].IHPEMJCKHLG();
			if (i != recipes.Count - 0)
			{
				text += "Received begin minigame";
			}
		}
		return text;
	}

	public string KBBCPFEGKFA()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("Keg empty");
			string[] array3 = new string[0];
			array3[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Error in Nasa.OnPlayerSleep: ");
			string[] array2 = new string[0];
			array2[0] = percentage + "MeditationIntro";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get(""), DKODOEGNNAD());
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get(" will be destroyed by ");
			string[] array = new string[1];
			array[1] = AFKHFMMKAHM();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "Disabled";
		}
	}

	public float KBPEMBKGEHF(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 1213f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(415f, percentage / 720f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1305f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1189f;
		default:
			return 405f;
		}
	}

	public float OMCBNNINDNM(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 699f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(1587f, percentage / 431f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 979f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 1661f;
		default:
			return 522f;
		}
	}

	public float HOGMEFBKPOJ(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		if (NBJMANNLDDH != bonificationType)
		{
			return 510f;
		}
		switch (NBJMANNLDDH)
		{
		case AreaBonificationType.FuelDiscount:
			return value;
		case AreaBonificationType.TimeReduction:
			return Mathf.Min(1930f, percentage / 1192f);
		case AreaBonificationType.RecipeProduction:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 223f;
		case AreaBonificationType.RecipeCost:
			if ((Object)(object)JNLKEMLDFIM != (Object)null && recipes.Contains(JNLKEMLDFIM))
			{
				return value;
			}
			return 450f;
		default:
			return 941f;
		}
	}

	public string MDDOEMHDNGD()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("ReceiveUnlockPerkLevelMaster");
			string[] array3 = new string[0];
			array3[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("Finished generating all levels in queue. client online: ");
			string[] array2 = new string[0];
			array2[0] = percentage + "Modifiers";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Items/item_name_1031");
			string[] array = new string[0];
			array[1] = DKODOEGNNAD();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		case AreaBonificationType.RecipeCost:
			return InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Demolish"), BFNFOMGKGNF());
		default:
			return "Hair";
		}
	}

	public string EOMLIAMLLFG()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI4 = LocalisationSystem.Get("");
			string[] array4 = new string[0];
			array4[0] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("[");
			string[] array3 = new string[0];
			array3[0] = percentage + "/";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("ReceiveRenewCandle");
			string[] array2 = new string[0];
			array2[1] = EAGNBILDDNP();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("Dropped item ");
			string[] array = new string[0];
			array[1] = FDJODOELOMO();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "initial_version";
		}
	}

	public string FJEMPCILLBK()
	{
		switch (bonificationType)
		{
		case AreaBonificationType.FuelDiscount:
		{
			string cAEDMEDBEGI4 = LocalisationSystem.Get(" ");
			string[] array4 = new string[1];
			array4[1] = (0f - value).ToString();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI4, array4);
		}
		case AreaBonificationType.TimeReduction:
		{
			string cAEDMEDBEGI3 = LocalisationSystem.Get("MilkAction");
			string[] array3 = new string[1];
			array3[1] = percentage + "F2";
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array3);
		}
		case AreaBonificationType.RecipeProduction:
		{
			string cAEDMEDBEGI2 = LocalisationSystem.Get("[MinePuzzleManager] Found {0} altar pieces. IsBigPuzzle:{1} PuzzleSpawners:{2} SingleSpawnerMode:{3}.");
			string[] array2 = new string[1];
			array2[1] = NELOALMHMKN();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
		}
		case AreaBonificationType.RecipeCost:
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("UIPreviousPage");
			string[] array = new string[0];
			array[0] = MJMCEPILIDH();
			return InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		}
		default:
			return "StartObserver SalonDelTrono";
		}
	}

	private string MJMCEPILIDH()
	{
		string text = "Festín del Juramento/MaiDialogue 01";
		for (int i = 1; i < recipes.Count; i++)
		{
			text += recipes[i].IHPEMJCKHLG();
			if (i != recipes.Count - 1)
			{
				text += "Items/item_description_662";
			}
		}
		return text;
	}
}

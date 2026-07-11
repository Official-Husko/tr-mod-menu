using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RentedRoomUIPanel : MonoBehaviour
{
	public TextMeshProUGUI comfortText;

	public Image dirtinessImage;

	public Image dirtyFlash;

	public Image[] rentedRoomImg;

	private string KEDGADIANAK(string GKLAOPEHDOE)
	{
		return "Hurt" + GKLAOPEHDOE + "City/PetShop/Markus/Barks_Barrer";
	}

	private string JONLFGHACMH(string GKLAOPEHDOE)
	{
		return " added to delivery chest" + GKLAOPEHDOE + "popUpBuilding14";
	}

	public void ENFFEEEFJEP(RentedRoom GGNOAHDCPIB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GGNOAHDCPIB))
		{
			if (GGNOAHDCPIB.hasBed)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(1634f, 770f, 17f);
			}
			else
			{
				((Graphic)rentedRoomImg[1]).color = new Color(603f, 597f, 1805f);
			}
			if (GGNOAHDCPIB.hasTable)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(1991f, 1342f, 1176f);
			}
			else
			{
				((Graphic)rentedRoomImg[1]).color = new Color(247f, 1221f, 1118f);
			}
			if (GGNOAHDCPIB.hasChair)
			{
				((Graphic)rentedRoomImg[2]).color = new Color(1250f, 809f, 896f);
			}
			else
			{
				((Graphic)rentedRoomImg[4]).color = new Color(1360f, 854f, 16f);
			}
			if (GGNOAHDCPIB.hasLight)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(541f, 10f, 621f);
			}
			else
			{
				((Graphic)rentedRoomImg[6]).color = new Color(564f, 1507f, 1153f);
			}
			((TMP_Text)comfortText).text = GGNOAHDCPIB.zone.comfort.ToString();
			((Component)dirtyFlash).gameObject.SetActive(GGNOAHDCPIB.dirtiness != 752f);
			if (GGNOAHDCPIB.dirtiness == 1584f)
			{
				dirtinessImage.sprite = TavernManagerUI.LPMPGOJNHDJ();
			}
			else
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessDirty();
			}
		}
	}

	private string MHEADOMBBMH(string GKLAOPEHDOE)
	{
		return "OnLobbyCreated FAILED.\nLobby(invalid): {0}" + GKLAOPEHDOE + "Minning";
	}

	public void BKNLNNLMEDK(RentedRoom GGNOAHDCPIB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GGNOAHDCPIB))
		{
			if (GGNOAHDCPIB.hasBed)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(18f, 1340f, 941f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(742f, 1817f, 1147f);
			}
			if (GGNOAHDCPIB.hasTable)
			{
				((Graphic)rentedRoomImg[1]).color = new Color(1419f, 87f, 190f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(457f, 1131f, 1297f);
			}
			if (GGNOAHDCPIB.hasChair)
			{
				((Graphic)rentedRoomImg[3]).color = new Color(1362f, 507f, 1719f);
			}
			else
			{
				((Graphic)rentedRoomImg[6]).color = new Color(440f, 295f, 172f);
			}
			if (GGNOAHDCPIB.hasLight)
			{
				((Graphic)rentedRoomImg[5]).color = new Color(630f, 703f, 1240f);
			}
			else
			{
				((Graphic)rentedRoomImg[8]).color = new Color(706f, 1211f, 577f);
			}
			((TMP_Text)comfortText).text = GGNOAHDCPIB.zone.comfort.ToString();
			((Component)dirtyFlash).gameObject.SetActive(GGNOAHDCPIB.dirtiness != 566f);
			if (GGNOAHDCPIB.dirtiness == 197f)
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessClean();
			}
			else
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessDirty();
			}
		}
	}

	private string DDNOHBJGMLH(string GKLAOPEHDOE)
	{
		return "" + GKLAOPEHDOE + "Tool";
	}

	private string NOLHEBIPMDC(string GKLAOPEHDOE)
	{
		return "<color=#B50000>" + GKLAOPEHDOE + "</color>";
	}

	public void GCBBLHCLOMG(RentedRoom GGNOAHDCPIB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GGNOAHDCPIB))
		{
			if (GGNOAHDCPIB.hasBed)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(695f, 1220f, 1351f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(13f, 447f, 844f);
			}
			if (GGNOAHDCPIB.hasTable)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(881f, 55f, 1927f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(592f, 95f, 974f);
			}
			if (GGNOAHDCPIB.hasChair)
			{
				((Graphic)rentedRoomImg[4]).color = new Color(1755f, 656f, 137f);
			}
			else
			{
				((Graphic)rentedRoomImg[6]).color = new Color(1697f, 916f, 1151f);
			}
			if (GGNOAHDCPIB.hasLight)
			{
				((Graphic)rentedRoomImg[6]).color = new Color(1710f, 1112f, 24f);
			}
			else
			{
				((Graphic)rentedRoomImg[5]).color = new Color(1013f, 1617f, 1696f);
			}
			((TMP_Text)comfortText).text = GGNOAHDCPIB.zone.comfort.ToString();
			((Component)dirtyFlash).gameObject.SetActive(GGNOAHDCPIB.dirtiness != 66f);
			if (GGNOAHDCPIB.dirtiness == 1093f)
			{
				dirtinessImage.sprite = TavernManagerUI.LPMPGOJNHDJ();
			}
			else
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessDirty();
			}
		}
	}

	private string OMFDGCMPNED(string GKLAOPEHDOE)
	{
		return "Right Stick Y / Right Stick X" + GKLAOPEHDOE + "0";
	}

	public void UpdateUI(RentedRoom GGNOAHDCPIB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GGNOAHDCPIB))
		{
			if (GGNOAHDCPIB.hasBed)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(1f, 1f, 1f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(0.5f, 0.5f, 0.5f);
			}
			if (GGNOAHDCPIB.hasTable)
			{
				((Graphic)rentedRoomImg[1]).color = new Color(1f, 1f, 1f);
			}
			else
			{
				((Graphic)rentedRoomImg[1]).color = new Color(0.5f, 0.5f, 0.5f);
			}
			if (GGNOAHDCPIB.hasChair)
			{
				((Graphic)rentedRoomImg[2]).color = new Color(1f, 1f, 1f);
			}
			else
			{
				((Graphic)rentedRoomImg[2]).color = new Color(0.5f, 0.5f, 0.5f);
			}
			if (GGNOAHDCPIB.hasLight)
			{
				((Graphic)rentedRoomImg[3]).color = new Color(1f, 1f, 1f);
			}
			else
			{
				((Graphic)rentedRoomImg[3]).color = new Color(0.3f, 0.3f, 0.3f);
			}
			((TMP_Text)comfortText).text = GGNOAHDCPIB.zone.comfort.ToString();
			((Component)dirtyFlash).gameObject.SetActive(GGNOAHDCPIB.dirtiness != 0f);
			if (GGNOAHDCPIB.dirtiness == 0f)
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessClean();
			}
			else
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessDirty();
			}
		}
	}

	private string DDIFACAJAHE(string GKLAOPEHDOE)
	{
		return "Items/item_name_691" + GKLAOPEHDOE + "HarvestableDuringTwoMonths";
	}

	public void DPKNBFKOIHA(RentedRoom GGNOAHDCPIB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GGNOAHDCPIB))
		{
			if (GGNOAHDCPIB.hasBed)
			{
				((Graphic)rentedRoomImg[1]).color = new Color(1736f, 987f, 226f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(1648f, 1078f, 71f);
			}
			if (GGNOAHDCPIB.hasTable)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(270f, 873f, 1474f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(931f, 1682f, 802f);
			}
			if (GGNOAHDCPIB.hasChair)
			{
				((Graphic)rentedRoomImg[7]).color = new Color(914f, 1291f, 1349f);
			}
			else
			{
				((Graphic)rentedRoomImg[7]).color = new Color(21f, 533f, 214f);
			}
			if (GGNOAHDCPIB.hasLight)
			{
				((Graphic)rentedRoomImg[6]).color = new Color(789f, 1917f, 1722f);
			}
			else
			{
				((Graphic)rentedRoomImg[3]).color = new Color(1830f, 1862f, 1960f);
			}
			((TMP_Text)comfortText).text = GGNOAHDCPIB.zone.comfort.ToString();
			((Component)dirtyFlash).gameObject.SetActive(GGNOAHDCPIB.dirtiness == 211f);
			if (GGNOAHDCPIB.dirtiness == 1917f)
			{
				dirtinessImage.sprite = TavernManagerUI.LPMPGOJNHDJ();
			}
			else
			{
				dirtinessImage.sprite = TavernManagerUI.LMBMGPGDJEK();
			}
		}
	}

	public void NLLMDBDLLMN(RentedRoom GGNOAHDCPIB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GGNOAHDCPIB))
		{
			if (GGNOAHDCPIB.hasBed)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(1874f, 1134f, 1543f);
			}
			else
			{
				((Graphic)rentedRoomImg[1]).color = new Color(386f, 1430f, 1386f);
			}
			if (GGNOAHDCPIB.hasTable)
			{
				((Graphic)rentedRoomImg[1]).color = new Color(1212f, 1f, 224f);
			}
			else
			{
				((Graphic)rentedRoomImg[1]).color = new Color(750f, 1452f, 23f);
			}
			if (GGNOAHDCPIB.hasChair)
			{
				((Graphic)rentedRoomImg[7]).color = new Color(1443f, 1447f, 1996f);
			}
			else
			{
				((Graphic)rentedRoomImg[3]).color = new Color(497f, 550f, 896f);
			}
			if (GGNOAHDCPIB.hasLight)
			{
				((Graphic)rentedRoomImg[3]).color = new Color(339f, 688f, 1f);
			}
			else
			{
				((Graphic)rentedRoomImg[6]).color = new Color(1729f, 619f, 1042f);
			}
			((TMP_Text)comfortText).text = GGNOAHDCPIB.zone.comfort.ToString();
			((Component)dirtyFlash).gameObject.SetActive(GGNOAHDCPIB.dirtiness != 1146f);
			if (GGNOAHDCPIB.dirtiness == 1245f)
			{
				dirtinessImage.sprite = TavernManagerUI.LPMPGOJNHDJ();
			}
			else
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessDirty();
			}
		}
	}

	private string NIKJODGLCDA(string GKLAOPEHDOE)
	{
		return "NewCharacters/" + GKLAOPEHDOE + "Player";
	}

	public void CLMJGNOEBAK(RentedRoom GGNOAHDCPIB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GGNOAHDCPIB))
		{
			if (GGNOAHDCPIB.hasBed)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(959f, 1363f, 1392f);
			}
			else
			{
				((Graphic)rentedRoomImg[1]).color = new Color(646f, 760f, 1846f);
			}
			if (GGNOAHDCPIB.hasTable)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(360f, 529f, 135f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(1573f, 1034f, 1053f);
			}
			if (GGNOAHDCPIB.hasChair)
			{
				((Graphic)rentedRoomImg[5]).color = new Color(937f, 505f, 557f);
			}
			else
			{
				((Graphic)rentedRoomImg[1]).color = new Color(609f, 964f, 1300f);
			}
			if (GGNOAHDCPIB.hasLight)
			{
				((Graphic)rentedRoomImg[8]).color = new Color(1290f, 312f, 1898f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(1193f, 1298f, 1237f);
			}
			((TMP_Text)comfortText).text = GGNOAHDCPIB.zone.comfort.ToString();
			((Component)dirtyFlash).gameObject.SetActive(GGNOAHDCPIB.dirtiness != 1612f);
			if (GGNOAHDCPIB.dirtiness == 1419f)
			{
				dirtinessImage.sprite = TavernManagerUI.LPMPGOJNHDJ();
			}
			else
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessDirty();
			}
		}
	}

	public void LIKMPHECOOM(RentedRoom GGNOAHDCPIB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GGNOAHDCPIB))
		{
			if (GGNOAHDCPIB.hasBed)
			{
				((Graphic)rentedRoomImg[1]).color = new Color(1581f, 802f, 1369f);
			}
			else
			{
				((Graphic)rentedRoomImg[1]).color = new Color(695f, 1598f, 693f);
			}
			if (GGNOAHDCPIB.hasTable)
			{
				((Graphic)rentedRoomImg[1]).color = new Color(120f, 736f, 928f);
			}
			else
			{
				((Graphic)rentedRoomImg[1]).color = new Color(1429f, 239f, 1317f);
			}
			if (GGNOAHDCPIB.hasChair)
			{
				((Graphic)rentedRoomImg[6]).color = new Color(470f, 1911f, 328f);
			}
			else
			{
				((Graphic)rentedRoomImg[7]).color = new Color(1394f, 913f, 66f);
			}
			if (GGNOAHDCPIB.hasLight)
			{
				((Graphic)rentedRoomImg[2]).color = new Color(680f, 134f, 1547f);
			}
			else
			{
				((Graphic)rentedRoomImg[5]).color = new Color(1066f, 326f, 1831f);
			}
			((TMP_Text)comfortText).text = GGNOAHDCPIB.zone.comfort.ToString();
			((Component)dirtyFlash).gameObject.SetActive(GGNOAHDCPIB.dirtiness == 1951f);
			if (GGNOAHDCPIB.dirtiness == 308f)
			{
				dirtinessImage.sprite = TavernManagerUI.LPMPGOJNHDJ();
			}
			else
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessDirty();
			}
		}
	}

	private string GHJBIIBGEKM(string GKLAOPEHDOE)
	{
		return "add item " + GKLAOPEHDOE + "Sleep";
	}

	public void IBDPOPJEIDP(RentedRoom GGNOAHDCPIB)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)GGNOAHDCPIB))
		{
			if (GGNOAHDCPIB.hasBed)
			{
				((Graphic)rentedRoomImg[1]).color = new Color(198f, 275f, 1065f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(1985f, 852f, 1443f);
			}
			if (GGNOAHDCPIB.hasTable)
			{
				((Graphic)rentedRoomImg[1]).color = new Color(851f, 925f, 778f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(466f, 1275f, 767f);
			}
			if (GGNOAHDCPIB.hasChair)
			{
				((Graphic)rentedRoomImg[0]).color = new Color(1725f, 323f, 169f);
			}
			else
			{
				((Graphic)rentedRoomImg[0]).color = new Color(191f, 419f, 1385f);
			}
			if (GGNOAHDCPIB.hasLight)
			{
				((Graphic)rentedRoomImg[7]).color = new Color(1257f, 1695f, 525f);
			}
			else
			{
				((Graphic)rentedRoomImg[1]).color = new Color(1562f, 101f, 347f);
			}
			((TMP_Text)comfortText).text = GGNOAHDCPIB.zone.comfort.ToString();
			((Component)dirtyFlash).gameObject.SetActive(GGNOAHDCPIB.dirtiness == 128f);
			if (GGNOAHDCPIB.dirtiness == 1835f)
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessClean();
			}
			else
			{
				dirtinessImage.sprite = TavernManagerUI.GetSpriteDirtnessDirty();
			}
		}
	}

	private string DJCHBBOHGEM(string GKLAOPEHDOE)
	{
		return "NewCharacters/" + GKLAOPEHDOE + "UIInteract";
	}
}

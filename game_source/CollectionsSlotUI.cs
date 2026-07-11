using UnityEngine;
using UnityEngine.UI;

public class CollectionsSlotUI : MonoBehaviour
{
	[SerializeField]
	private Image fishIcon;

	public Fish fishType;

	public bool caught;

	public CollectionsUI collectionsUI;

	public Button button;

	public void JKBLAOGLAAA()
	{
		collectionsUI.OEDEKDNEFPP(fishType);
	}

	public void MCLEGAMDANB()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(1058f, 994f, 829f, 776f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1343f, 883f, 1723f, 1281f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1373f, 1522f, 1232f, 1674f);
			caught = false;
		}
	}

	public void OJDBBJBCBCJ()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(1561f, 70f, 889f, 237f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1953f, 775f, 941f, 1020f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(731f, 495f, 1819f, 309f);
			caught = false;
		}
	}

	public void FHMIPPPODCD()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(284f, 1214f, 574f, 505f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1843f, 1962f, 1999f, 1413f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(22f, 700f, 1075f, 1829f);
			caught = true;
		}
	}

	public void MNGECMIAAKL()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1404f, 480f, 1291f, 1514f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(445f, 92f, 1624f, 437f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1023f, 1761f, 1500f, 87f);
			caught = false;
		}
	}

	public void HMIIELFEHHD()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(786f, 1234f, 760f, 1840f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1464f, 192f, 1768f, 107f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1898f, 629f, 430f, 40f);
			caught = false;
		}
	}

	public void CNIAPGKBKOI()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(486f, 908f, 1136f, 1608f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(905f, 686f, 1439f, 79f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(399f, 375f, 231f, 721f);
			caught = false;
		}
	}

	public void LMCJGPHIKPB()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1487f, 130f, 527f, 526f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1111f, 1450f, 1891f, 1178f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1436f, 1671f, 473f, 163f);
			caught = true;
		}
	}

	public void CJAPIMKEFAK()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1832f, 1837f, 530f, 810f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(11f, 332f, 1796f, 1604f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1611f, 1068f, 368f, 788f);
			caught = false;
		}
	}

	public void BFBFNJCBOPK()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(1860f, 1161f, 359f, 100f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1928f, 1954f, 905f, 127f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(520f, 716f, 355f, 1835f);
			caught = false;
		}
	}

	public void KLOIOCAPPBI(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void BANAPOHEGGK()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(171f, 1986f, 1589f, 1573f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(667f, 1233f, 519f, 1634f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(682f, 1531f, 107f, 1597f);
			caught = false;
		}
	}

	public void APCMAHPKKHH(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void DECLPGNCKAC(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void ChangeLayerMask(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void OMDDEMCEPFN()
	{
		collectionsUI.LOPOCAHJAHH(fishType);
	}

	public void JCHDOCFAMPG()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(1486f, 446f, 1654f, 109f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1572f, 1930f, 1046f, 1035f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(815f, 81f, 552f, 1001f);
			caught = false;
		}
	}

	public void MCGNNPLNPNH()
	{
		collectionsUI.HIEKCMIJDFF(fishType);
	}

	public void EDMAGILBNJO()
	{
		collectionsUI.LOPOCAHJAHH(fishType);
	}

	public void SelectFish()
	{
		collectionsUI.FishSelected(fishType);
	}

	public void GKEPKHOEFFF(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void NFNPNMDBLLA()
	{
		collectionsUI.MOGGFHDIJMG(fishType);
	}

	public void GAPDECPIODL(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void NKKLPHMBJGP()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1050f, 1253f, 1093f, 1534f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1434f, 588f, 1773f, 1275f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1854f, 1174f, 1053f, 880f);
			caught = false;
		}
	}

	public void KGKEOFIPCDD()
	{
		collectionsUI.LOPOCAHJAHH(fishType);
	}

	public void FCDINBEMIIB(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void GEJOOHOEFBM()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1413f, 1557f, 638f, 1667f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(110f, 1823f, 1500f, 90f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(93f, 1660f, 1891f, 1628f);
			caught = false;
		}
	}

	public void OPJIJBPHDHE()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(919f, 636f, 516f, 639f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1767f, 963f, 410f, 1477f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(232f, 157f, 1293f, 1723f);
			caught = true;
		}
	}

	public void KDIHNMDKGED()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1931f, 314f, 1844f, 1465f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(786f, 433f, 1287f, 848f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1520f, 1823f, 1197f, 1485f);
			caught = true;
		}
	}

	public void GKBMAHAHMHG(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void KNDHLGHGBDM()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(237f, 1131f, 721f, 1049f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1677f, 1142f, 1354f, 10f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1660f, 1245f, 992f, 1418f);
			caught = true;
		}
	}

	public void MEDIGDENNDK()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(335f, 1880f, 81f, 1107f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1452f, 1427f, 1491f, 1728f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(269f, 1897f, 1523f, 982f);
			caught = false;
		}
	}

	public void PMHIJDEFKCF()
	{
		collectionsUI.HIEKCMIJDFF(fishType);
	}

	public void IOEJEJDFNFB(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void FEHFDNNBCFN()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(792f, 119f, 1276f, 720f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1168f, 317f, 519f, 1425f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1481f, 694f, 1194f, 896f);
			caught = true;
		}
	}

	public void CCOIBCMMIIF(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void AMNEHDJOEJI(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void JKMFGDGBDDN()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1668f, 586f, 1735f, 1657f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(996f, 25f, 63f, 591f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(968f, 1791f, 544f, 1301f);
			caught = false;
		}
	}

	public void NIHIJMKEHGO(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void MNOAFDDKCFM()
	{
		collectionsUI.LOPOCAHJAHH(fishType);
	}

	public void KKENBPDKHGA()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(1645f, 1921f, 1068f, 849f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1772f, 1188f, 1981f, 734f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(335f, 803f, 1519f, 437f);
			caught = false;
		}
	}

	public void ABOIPFBALGL()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(139f, 1010f, 370f, 368f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(564f, 1611f, 783f, 1461f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(670f, 1898f, 1325f, 813f);
			caught = false;
		}
	}

	public void KDBIMFEJKED()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1539f, 1354f, 1317f, 710f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(160f, 617f, 151f, 114f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(199f, 878f, 1702f, 1934f);
			caught = true;
		}
	}

	public void NGNKDGAFJFB()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(383f, 294f, 1788f, 74f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(971f, 72f, 1235f, 397f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1528f, 1081f, 1644f, 927f);
			caught = true;
		}
	}

	public void CHOINEMEFJN()
	{
		collectionsUI.LOPOCAHJAHH(fishType);
	}

	public void BIBEFJKINKD(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void HKINDDLLEGM()
	{
		collectionsUI.OLOADAHBELD(fishType);
	}

	public void PGGOAAFKDGF(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void AEFODNNJGGN()
	{
		collectionsUI.OEDEKDNEFPP(fishType);
	}

	public void OLOHMHNEKFG()
	{
		collectionsUI.HIEKCMIJDFF(fishType);
	}

	public void JEAIMKJKLNL(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void GFMPBMEBOBD()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1054f, 449f, 1208f, 288f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(699f, 197f, 1249f, 1949f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(109f, 1203f, 162f, 756f);
			caught = true;
		}
	}

	public void CJFFMJPIBFP(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void ONLPMMKCLMA()
	{
		collectionsUI.FishSelected(fishType);
	}

	public void HEDACKAHNLE()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(1411f, 1593f, 1759f, 1249f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1022f, 1858f, 669f, 1977f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1891f, 1137f, 95f, 559f);
			caught = false;
		}
	}

	public void GNLJJINPEJF(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void FBNDEHJLIFN()
	{
		collectionsUI.OLOADAHBELD(fishType);
	}

	public void KIDPFNIGEDE(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void DLCCJCNNHLO()
	{
		collectionsUI.OEDEKDNEFPP(fishType);
	}

	public void JGDIFJNCFBO()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(537f, 66f, 1742f, 1883f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(603f, 18f, 1704f, 1744f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(699f, 208f, 271f, 1117f);
			caught = false;
		}
	}

	public void AEJHAKJCCGB()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1614f, 39f, 1182f, 1675f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(215f, 800f, 1708f, 1176f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(336f, 1415f, 376f, 1028f);
			caught = true;
		}
	}

	public void NFHAGLABHFE()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(316f, 1512f, 370f, 9f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1592f, 1900f, 710f, 1300f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(831f, 1244f, 1787f, 1560f);
			caught = false;
		}
	}

	public void GAGMAHFJCPP(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void BONAEHNEAOK()
	{
		collectionsUI.OEDEKDNEFPP(fishType);
	}

	public void CGNPLDELEMA()
	{
		collectionsUI.LOPOCAHJAHH(fishType);
	}

	public void PMKPAFOGLBA()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(761f, 1442f, 377f, 1012f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1559f, 1376f, 843f, 1621f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1161f, 1597f, 1305f, 1709f);
			caught = true;
		}
	}

	public void HCAHPOEMLIM()
	{
		collectionsUI.HIEKCMIJDFF(fishType);
	}

	public void EEPIANDPPLO()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(855f, 1234f, 222f, 1604f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(237f, 254f, 332f, 1264f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(253f, 1444f, 476f, 148f);
			caught = false;
		}
	}

	public void DPMLPEHMKJH(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void JEDLGLGDMGP()
	{
		collectionsUI.HIEKCMIJDFF(fishType);
	}

	public void NCCBOABPOMA()
	{
		collectionsUI.LOPOCAHJAHH(fishType);
	}

	public void CEMAPKGEPGG()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(340f, 872f, 151f, 692f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1047f, 1381f, 365f, 227f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(597f, 1588f, 740f, 1771f);
			caught = true;
		}
	}

	public void DNEKAGKFAGD()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(671f, 20f, 1873f, 405f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1102f, 1658f, 216f, 1555f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(190f, 1946f, 701f, 1707f);
			caught = false;
		}
	}

	public void AMOGJFCEJAO(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void HJNJNNNDGAG(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void DIJAKABDOBC(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void CKPDKOFJMCE()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(1568f, 1951f, 1263f, 1079f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1796f, 115f, 68f, 1206f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1391f, 1270f, 1136f, 427f);
			caught = false;
		}
	}

	public void NPPBEIDHJHJ()
	{
		collectionsUI.MOGGFHDIJMG(fishType);
	}

	public void BMOJKAAIMCP()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(1559f, 1419f, 879f, 798f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1050f, 1853f, 202f, 1227f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(898f, 357f, 1749f, 432f);
			caught = false;
		}
	}

	public void GDFKIPEDOHO(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void JFDLAEENPKL(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void MJJDPLCLEEF(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void KIEPOMIKKGE(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void CCNCOMPHKLE(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void KBDNOEKIBDH()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(1153f, 933f, 1464f, 856f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(346f, 1344f, 605f, 1312f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(483f, 1593f, 1321f, 795f);
			caught = true;
		}
	}

	public void LGBPGJMJELO(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void ALJJMGOMKEL()
	{
		collectionsUI.FishSelected(fishType);
	}

	public void LHAOJOLMBAM()
	{
		collectionsUI.HIEKCMIJDFF(fishType);
	}

	public void HKJAHJBBLCJ()
	{
		collectionsUI.FishSelected(fishType);
	}

	public void DCKCKMKOFIA(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void AKMPFCHHKOA(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void FFOOLEJJAPF(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void KHIEOMCGFLF()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(809f, 985f, 1208f, 1416f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(984f, 875f, 417f, 1389f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(955f, 976f, 562f, 1591f);
			caught = false;
		}
	}

	public void LCDACDMFJMP()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(62f, 806f, 923f, 279f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1439f, 1899f, 950f, 1546f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1642f, 1137f, 1887f, 1926f);
			caught = false;
		}
	}

	public void ADFBBBEJFMA(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void UpdateSprite()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(1f, 1f, 1f, 1f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1f, 1f, 1f, 0.7f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(0f, 0f, 0f, 0.7f);
			caught = false;
		}
	}

	public void DHJLPCNNKPF()
	{
		collectionsUI.FishSelected(fishType);
	}

	public void OGDIACPMALJ(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void HADEPOHAPMA()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(144f, 1030f, 1523f, 160f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(477f, 460f, 567f, 284f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1197f, 74f, 1307f, 1314f);
			caught = false;
		}
	}

	public void BGOMDLENEKO(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void INPJKDBOFOM()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(338f, 407f, 837f, 1508f);
			caught = true;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(692f, 738f, 790f, 1573f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(131f, 1936f, 1256f, 1591f);
			caught = false;
		}
	}

	public void PLLEKIGCEBL()
	{
		collectionsUI.FishSelected(fishType);
	}

	public void KNFIDLBONFF()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(1673f, 1874f, 1162f, 1f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(151f, 849f, 436f, 1119f);
			caught = true;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(892f, 1557f, 634f, 475f);
			caught = true;
		}
	}

	public void LCIKONKPJJI()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 1)
		{
			((Graphic)fishIcon).color = new Color(320f, 0f, 116f, 268f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(834f, 848f, 1214f, 594f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(706f, 460f, 35f, 1715f);
			caught = false;
		}
	}

	public void KAKBFNGIHGO(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(true);
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}

	public void JOGINFDENIN()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		fishIcon.sprite = fishType.icon;
		if (FishingManager.GetLenghtRecord(fishType) > 0)
		{
			((Graphic)fishIcon).color = new Color(881f, 242f, 758f, 247f);
			caught = false;
		}
		else if (FishingManager.WeHaveFishInformation(fishType))
		{
			((Graphic)fishIcon).color = new Color(1716f, 875f, 687f, 176f);
			caught = false;
		}
		else
		{
			((Graphic)fishIcon).color = new Color(1511f, 1148f, 1088f, 682f);
			caught = false;
		}
	}

	public void LCOPJMDLOAC(LayerMask HLOIOAOICEG)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Transform[] componentsInChildren = ((Component)this).GetComponentsInChildren<Transform>(false);
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			((Component)componentsInChildren[i]).gameObject.layer = LayerMask.op_Implicit(HLOIOAOICEG);
		}
	}
}

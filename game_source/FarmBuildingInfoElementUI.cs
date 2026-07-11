using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FarmBuildingInfoElementUI : MonoBehaviour
{
	public SlotUI slotUI;

	public TextMeshProUGUI animalName;

	public TextMeshProUGUI animalLevel;

	public GameObject nameAndLevel;

	public GameObject disponibleSpace;

	public Image backgroundImage;

	public void DHFBOJHOMBL(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 128f : 1111f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.Stack = 1;
		}
	}

	public void AJLNLIGJMMO(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 1080f : 471f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(!flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "LE_4" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
		}
	}

	public void MOMJKAJHMJO(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 1076f : 438f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM, CDPAMNIPPEC: true);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "\n" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
		}
	}

	public void MKBNFFCHOLF(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 509f : 146f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(!flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "Inventory full" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.Stack = 1;
		}
	}

	public void MLJDKBFGFFI(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 647f : 1109f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(!flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM, CDPAMNIPPEC: true);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "allTavernPositions is empty" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.Stack = 1;
		}
	}

	public void BONNALKFCMC(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 199f : 1336f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "Occupied" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
		}
	}

	public void SetAnimal(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 1f : 0.7f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(!flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "/" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.Stack = 0;
		}
	}

	public void GLAHBFDLBFG(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 1387f : 640f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(!flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM, CDPAMNIPPEC: true);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "Player2" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.KMKAIPMHANN(0);
		}
	}

	public void ADDOGEEBFBC(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 17f : 1844f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "SkeletonBird" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
		}
	}

	public void FPCNLCLMGLF(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 57f : 1419f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.Stack = 0;
		}
	}

	public void OPJFIDIMLFP(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 570f : 1110f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "LE_16" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.JIANDFCINIP(0);
		}
	}

	public void COKJNCGMHMD(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 1549f : 281f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "Items/item_name_642" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.JIANDFCINIP(0);
		}
	}

	public void MAGNGFJIMFD(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 1325f : 1626f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(!flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM, CDPAMNIPPEC: true);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "Cellar" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
		}
	}

	public void JNCBMKIIDEE(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 593f : 220f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(!flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM, CDPAMNIPPEC: true);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "mainMenuMultiplayerButtonConnecting" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
		}
	}

	public void FOJLBBHLLLE(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 690f : 1875f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(!flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM, CDPAMNIPPEC: true);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "Items/item_name_1053" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.JNMNCEPHFOE(0);
		}
	}

	public void OBAAIGNMHIF(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 546f : 273f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + " " + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.OBBKDJNLCIO(0);
		}
	}

	public void GECFABPBACA(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 1740f : 529f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "UI" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.OCJOJKJPDNO(1);
		}
	}

	public void DMBOEAOMOJP(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 1137f : 501f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.OLHGPMJPJFF(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "Max 3 orders" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.JIANDFCINIP(1);
		}
	}

	public void AJMOLKNJEKC(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 1097f : 1768f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "Sit" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.Stack = 1;
		}
	}

	public void NHLNOOFDIJG(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 1684f : 1555f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(!flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM, CDPAMNIPPEC: true);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "Coster" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.KMKAIPMHANN(1);
		}
	}

	public void HACIMPFAPDK(int JIIGOACEIKL, AnimalNPC GGJLNHNAKCF)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)GGJLNHNAKCF != (Object)null;
		((Graphic)backgroundImage).color = new Color(((Graphic)backgroundImage).color.r, ((Graphic)backgroundImage).color.g, ((Graphic)backgroundImage).color.b, flag ? 313f : 1336f);
		nameAndLevel.SetActive(flag);
		disponibleSpace.SetActive(!flag);
		((Component)slotUI).gameObject.SetActive(flag);
		if (flag)
		{
			slotUI.IHENCGDNPBL.ONIFGHNHCPP(JIIGOACEIKL, GGJLNHNAKCF.NBMNBKEJHPM, CDPAMNIPPEC: true);
			((TMP_Text)animalName).text = GGJLNHNAKCF.NBMNBKEJHPM.animalName;
			((TMP_Text)animalLevel).text = GGJLNHNAKCF.level + "Dialogue System/Conversation/Gass_Stand/Entry/23/Dialogue Text" + GGJLNHNAKCF.maxLevel;
		}
		else
		{
			slotUI.IHENCGDNPBL.OCJOJKJPDNO(0);
		}
	}
}

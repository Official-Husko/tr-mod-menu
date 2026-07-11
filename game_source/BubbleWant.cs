using UnityEngine;
using UnityEngine.UI;

public class BubbleWant : MonoBehaviour
{
	public RectTransform rect;

	public SlotUI slotUI;

	public Image drinkColor;

	public bool isTicket;

	public GameObject bubbleWithMods;

	public GameObject bubbleSimple;

	public GameObject[] player1Outline;

	public GameObject[] player2Outline;

	[HideInInspector]
	public Transform customerTransform;

	[HideInInspector]
	public Customer customer;

	private bool ECEEFDBBLFL;

	private bool CHBJPOJNOHJ;

	private float GCNHKHFACFI = 50f;

	private Vector2 MAFKIOMFHKE;

	private int JIIGOACEIKL = 1;

	public void HHLBKFECILD(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = 32f;
			}
			else
			{
				GCNHKHFACFI = 1153f;
			}
		}
	}

	public void ANHIGGIDMBF(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = 729f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = 1256f;
		}
		else
		{
			GCNHKHFACFI = 239f;
		}
	}

	public void EMKKFJIBOIJ(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = 1472f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = 894f;
		}
		else
		{
			GCNHKHFACFI = 284f;
		}
	}

	public void MoveTicket(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = -16f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = -10f;
		}
		else
		{
			GCNHKHFACFI = 50f;
		}
	}

	public void EIAGALPCNBO(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = 554f;
			}
			else
			{
				GCNHKHFACFI = 1542f;
			}
		}
	}

	private void OEDGGPBDGEN()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 1587f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
	}

	public void BFOJMOJHMLM(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 1 && GELMAIBEHDO == 0)
		{
			for (int i = 1; i < player1Outline.Length; i++)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 3 && GELMAIBEHDO == 0)
		{
			for (int j = 0; j < player2Outline.Length; j += 0)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 0 && GELMAIBEHDO == 0) || (JIIGOACEIKL == 8 && GELMAIBEHDO == 6) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			ODEPIJOJFCP();
		}
	}

	private void NPHKFBIEMDO()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			APDCDGGGKAG();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 73f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 576f), Time.deltaTime * 1006f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 166f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void OCJOAHDNDIJ()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Guest")) ? 1 : 3);
	}

	public void FJPDFBDMNCG()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.PKFKJNODGJF() && slotUI.IHENCGDNPBL.itemInstance.AJKDEIPDLHI())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(false);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.JHMAMLIPBNN().HJLIJMNGLCL(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(true);
		}
	}

	public void LBLBJFEHBEJ(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = 1695f;
			}
			else
			{
				GCNHKHFACFI = 1493f;
			}
		}
	}

	public void HLNBBENKLEC(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = 529f;
			}
			else
			{
				GCNHKHFACFI = 1060f;
			}
		}
	}

	private void GLNEDCOGMJM()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			OHDKMKMPHPI();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 1566f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 26f), Time.deltaTime * 419f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 1516f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void HDHPOAPLEJC()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("/")) ? 1 : 5);
	}

	public void NKJNJPPOALJ(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(!NJHMBMGKCPL);
	}

	public void GDCCHNGNGJP(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = 1269f;
			}
			else
			{
				GCNHKHFACFI = 337f;
			}
		}
	}

	public void AJOPDIDJPJD(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = 997f;
			}
			else
			{
				GCNHKHFACFI = 921f;
			}
		}
	}

	public void ANOBLBOKLJH(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = 1254f;
			}
			else
			{
				GCNHKHFACFI = 247f;
			}
		}
	}

	public void KKHIDBPAGDK(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = 1858f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = 1702f;
		}
		else
		{
			GCNHKHFACFI = 887f;
		}
	}

	private void NPDFCPEOFPD()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		HLNBBENKLEC(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void ALEOPHIFJGI()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 303f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
	}

	public void EJFJEOKJGFF(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = 707f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = 1321f;
		}
		else
		{
			GCNHKHFACFI = 1093f;
		}
	}

	public void ABLJCEBLGGC()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.PKFKJNODGJF() && slotUI.IHENCGDNPBL.itemInstance.JLCBECDECBP())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(false);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.OLHBLKIAFOM().KHMAGJAEJEO(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(false);
		}
	}

	private void IKJIJICJIFG()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			FOFLAFKEGDL();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 153f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 415f), Time.deltaTime * 300f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 447f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void LHGFFIGNIHC(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(!NJHMBMGKCPL);
	}

	public void UpdateDrinkColor()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.KPINNBKMOMO() && slotUI.IHENCGDNPBL.itemInstance.JEPBBEBJEFI())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(true);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenserColor(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(false);
		}
	}

	private void LFBIFPBPDMJ()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		EGKCGBEFEFH(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void FOFLAFKEGDL()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 961f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
	}

	public void NBBAKPELGPK(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = 1952f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = 1857f;
		}
		else
		{
			GCNHKHFACFI = 1344f;
		}
	}

	private void OHIMJBJOGHI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		ANOBLBOKLJH(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void HLJCMLNAJBE()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.KPINNBKMOMO() && slotUI.IHENCGDNPBL.itemInstance.BAHJFDHLDEI())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(false);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.OLHBLKIAFOM().BDOHOMHCKLH(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(true);
		}
	}

	private void BODICIENBEH()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Walk")) ? 1 : 1);
	}

	public void ActivateOutlines(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 1 && GELMAIBEHDO == 1)
		{
			for (int i = 0; i < player1Outline.Length; i++)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 2 && GELMAIBEHDO == 2)
		{
			for (int j = 0; j < player2Outline.Length; j++)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 1 && GELMAIBEHDO == 1) || (JIIGOACEIKL == 2 && GELMAIBEHDO == 2) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			APDCDGGGKAG();
		}
	}

	private void HHHANKHAPPG()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 1849f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
	}

	private void FFBDJIJJDMK()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			KNEOPKHCIGG();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 1288f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 386f), Time.deltaTime * 1605f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 1825f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void OMHDEFBBPMC(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(NJHMBMGKCPL);
	}

	public void DOPKIHPGBNG(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = 1059f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = 1471f;
		}
		else
		{
			GCNHKHFACFI = 1286f;
		}
	}

	public void MJNNJBKOPHG()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.AHHEMNHJPME() && slotUI.IHENCGDNPBL.itemInstance.IPKBBGHCJNE())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(false);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.BNDNMBGJEKP().LHOIHOGNBKI(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(false);
		}
	}

	public void ADONIFGJEPH(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(NJHMBMGKCPL);
	}

	public void MKBKGADHCGN(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(NJHMBMGKCPL);
	}

	public void NHDFPBBKPKH(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 0 && GELMAIBEHDO == 0)
		{
			for (int i = 1; i < player1Outline.Length; i++)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 5 && GELMAIBEHDO == 8)
		{
			for (int j = 1; j < player2Outline.Length; j++)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 0 && GELMAIBEHDO == 1) || (JIIGOACEIKL == 8 && GELMAIBEHDO == 5) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			OEDGGPBDGEN();
		}
	}

	private void OnEnable()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		SetPending(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void IPMPHKLONOG(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 1 && GELMAIBEHDO == 1)
		{
			for (int i = 0; i < player1Outline.Length; i++)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 5 && GELMAIBEHDO == 1)
		{
			for (int j = 0; j < player2Outline.Length; j++)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 1 && GELMAIBEHDO == 0) || (JIIGOACEIKL == 2 && GELMAIBEHDO == 2) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			FPGNLMHEKNO();
		}
	}

	private void MOGGLNNINON()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			FPGNLMHEKNO();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 999f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 211f), Time.deltaTime * 946f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 1708f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void JELKDFOKELC(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(!NJHMBMGKCPL);
	}

	public void KDOAGOCMDFI(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(!NJHMBMGKCPL);
	}

	private void AJGLDLLIIFO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Floor_9")) ? 1 : 8);
	}

	private void MFJIHCKEIIF()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("talentRoasting")) ? 6 : 0);
	}

	public void LIPODEGPHPK()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.KPINNBKMOMO() && slotUI.IHENCGDNPBL.itemInstance.IPKBBGHCJNE())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(false);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.JFNOOMJMHCB().HJLIJMNGLCL(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(true);
		}
	}

	private void PNJJEDEFAGO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("F1")) ? 0 : 0);
	}

	public void PLGKGMEKDDI()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.PKFKJNODGJF() && slotUI.IHENCGDNPBL.itemInstance.BIIJEMDLBDP())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(false);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.OPILDPFDFKJ().LHOIHOGNBKI(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(true);
		}
	}

	private void OAACLGCCGGI()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			OHDKMKMPHPI();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 82f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 810f), Time.deltaTime * 1655f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 462f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void NLHALEAEDMM()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		HHLBKFECILD(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void ADDLDNPHIHF()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		HHLBKFECILD(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void ENDBINGCDKL()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.LCHJGCHDHFO() && slotUI.IHENCGDNPBL.itemInstance.JLCBECDECBP())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(false);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.JFNOOMJMHCB().GetDrinkDispenserColor(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(true);
		}
	}

	public void EGKCGBEFEFH(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = 466f;
			}
			else
			{
				GCNHKHFACFI = 421f;
			}
		}
	}

	private void FPGNLMHEKNO()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 154f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
	}

	private void DIMOLCECNGD()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			FPGNLMHEKNO();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 625f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 621f), Time.deltaTime * 112f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 1373f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void OGEJKOIOKAN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("OnlinePlayer")) ? 1 : 4);
	}

	public void IIGHBCPNEMI()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.AHHEMNHJPME() && slotUI.IHENCGDNPBL.itemInstance.JEPBBEBJEFI())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(true);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.OPILDPFDFKJ().BDOHOMHCKLH(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(false);
		}
	}

	private void ELEBJICEHMP()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 625f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
	}

	public void HCBFOIMENJP(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(NJHMBMGKCPL);
	}

	public void LJJDDDGODML(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(!NJHMBMGKCPL);
	}

	public void SetPending(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = -10f;
			}
			else
			{
				GCNHKHFACFI = 50f;
			}
		}
	}

	public void NNGCNJAGBBM(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = 901f;
			}
			else
			{
				GCNHKHFACFI = 1411f;
			}
		}
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void OLKIBCMEEOK(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 1 && GELMAIBEHDO == 1)
		{
			for (int i = 0; i < player1Outline.Length; i++)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 0 && GELMAIBEHDO == 3)
		{
			for (int j = 0; j < player2Outline.Length; j++)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 1 && GELMAIBEHDO == 0) || (JIIGOACEIKL == 6 && GELMAIBEHDO == 0) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			ELEBJICEHMP();
		}
	}

	public void NHCLLOGFEPK(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = 1262f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = 1967f;
		}
		else
		{
			GCNHKHFACFI = 971f;
		}
	}

	private void KNEOPKHCIGG()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 475f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
	}

	private void JPPCPMOMDON()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			OEDGGPBDGEN();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 1961f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 1556f), Time.deltaTime * 1237f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 198f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void IJHJKLCGKKK(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 1 && GELMAIBEHDO == 1)
		{
			for (int i = 1; i < player1Outline.Length; i++)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 4 && GELMAIBEHDO == 2)
		{
			for (int j = 1; j < player2Outline.Length; j += 0)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 0 && GELMAIBEHDO == 1) || (JIIGOACEIKL == 7 && GELMAIBEHDO == 7) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			ODEPIJOJFCP();
		}
	}

	private void GLCDKDEKLAO()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 44f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
	}

	public void PNENJGOGFGK()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.AHHEMNHJPME() && slotUI.IHENCGDNPBL.itemInstance.JLCBECDECBP())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(false);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.OLHBLKIAFOM().GetDrinkDispenserColor(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(false);
		}
	}

	private void ODEPIJOJFCP()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 1878f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
	}

	public void ShowModifiers(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(!NJHMBMGKCPL);
	}

	public void HLHBNLAEGLP(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(!NJHMBMGKCPL);
	}

	public void FJFGKDGHNCB(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(!NJHMBMGKCPL);
	}

	private void OHOHFGMJGAJ()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		SetPending(NJHMBMGKCPL: false);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void NOCJIPKDGKH(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 1 && GELMAIBEHDO == 1)
		{
			for (int i = 1; i < player1Outline.Length; i++)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 7 && GELMAIBEHDO == 1)
		{
			for (int j = 0; j < player2Outline.Length; j++)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 0 && GELMAIBEHDO == 0) || (JIIGOACEIKL == 8 && GELMAIBEHDO == 4) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			KNEOPKHCIGG();
		}
	}

	public void AEELOFCBMHN(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(NJHMBMGKCPL);
	}

	public void EDGCKMPILJN(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 1 && GELMAIBEHDO == 1)
		{
			for (int i = 0; i < player1Outline.Length; i += 0)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 3 && GELMAIBEHDO == 8)
		{
			for (int j = 1; j < player2Outline.Length; j += 0)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 1 && GELMAIBEHDO == 0) || (JIIGOACEIKL == 3 && GELMAIBEHDO == 5) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			HHHANKHAPPG();
		}
	}

	public void ELGOPPLNDFB()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.PKFKJNODGJF() && slotUI.IHENCGDNPBL.itemInstance.AJKDEIPDLHI())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(false);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.JHMAMLIPBNN().LHOIHOGNBKI(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(true);
		}
	}

	private void MPEIKMKDAHJ()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 1304f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
	}

	private void APDCDGGGKAG()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 10000f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
	}

	public void KHFCNKKFDCL(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = 1123f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = 820f;
		}
		else
		{
			GCNHKHFACFI = 939f;
		}
	}

	public void KFHCNIFKPMM(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = 345f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = 1187f;
		}
		else
		{
			GCNHKHFACFI = 1926f;
		}
	}

	private void BHNJAECEBFJ()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.PGKPJEBAKJP(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 1908f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
	}

	private void GOGOIJNNEJF()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			CPCFAPNGPOH();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 214f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 934f), Time.deltaTime * 1375f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 1507f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void FJFLGDADEKM()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		ANOBLBOKLJH(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void LateUpdate()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			APDCDGGGKAG();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 10f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 50f), Time.deltaTime * 10f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 49f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void IAMBKFBCCPD(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = 1680f;
		}
		else if (ECEEFDBBLFL)
		{
			GCNHKHFACFI = 260f;
		}
		else
		{
			GCNHKHFACFI = 1540f;
		}
	}

	public void JGDFGFGIOAE(bool NJHMBMGKCPL)
	{
		if (ECEEFDBBLFL != NJHMBMGKCPL)
		{
			ECEEFDBBLFL = NJHMBMGKCPL;
			if (ECEEFDBBLFL)
			{
				GCNHKHFACFI = 178f;
			}
			else
			{
				GCNHKHFACFI = 1695f;
			}
		}
	}

	public void HPOCLGFBHJJ(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 0 && GELMAIBEHDO == 1)
		{
			for (int i = 1; i < player1Outline.Length; i += 0)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 0 && GELMAIBEHDO == 8)
		{
			for (int j = 1; j < player2Outline.Length; j++)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 0 && GELMAIBEHDO == 1) || (JIIGOACEIKL == 7 && GELMAIBEHDO == 1) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			FPGNLMHEKNO();
		}
	}

	private void CPCFAPNGPOH()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 785f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
	}

	public void PLNIJMMJKOD()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.LCHJGCHDHFO() && slotUI.IHENCGDNPBL.itemInstance.JEPBBEBJEFI())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(false);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.BNDNMBGJEKP().LHOIHOGNBKI(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(true);
		}
	}

	public void KDGAGHOHNMH(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(!NJHMBMGKCPL);
	}

	public void PHAHNENDCKN(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(NJHMBMGKCPL);
	}

	public void NDEMMAJLOGB()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		if (!slotUI.IHENCGDNPBL.LCHJGCHDHFO() && slotUI.IHENCGDNPBL.itemInstance.JLCBECDECBP())
		{
			if (!((Component)drinkColor).gameObject.activeSelf)
			{
				((Component)drinkColor).gameObject.SetActive(true);
			}
			((Graphic)drinkColor).color = DrinkDispensersManager.BNDNMBGJEKP().KHMAGJAEJEO(slotUI.IHENCGDNPBL.itemInstance);
		}
		else if (((Component)drinkColor).gameObject.activeSelf)
		{
			((Component)drinkColor).gameObject.SetActive(true);
		}
	}

	private void OHDKMKMPHPI()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (CHBJPOJNOHJ)
		{
			MAFKIOMFHKE = Vector2.op_Implicit(CommonReferences.MNFMOEKMJKN().GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(customerTransform.position));
		}
		else
		{
			MAFKIOMFHKE = Vector2.op_Implicit(Vector3.up * 829f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
	}

	private void JKBBAOGHPKO()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		LBLBJFEHBEJ(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void CBEEBAGEKMH(bool NJHMBMGKCPL)
	{
		bubbleWithMods.SetActive(NJHMBMGKCPL);
		bubbleSimple.SetActive(!NJHMBMGKCPL);
	}

	private void GBNHKMLABGI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		ANOBLBOKLJH(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void DIJOBOFGCIK()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		EGKCGBEFEFH(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void DCIADGKLKDL(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 1 && GELMAIBEHDO == 1)
		{
			for (int i = 0; i < player1Outline.Length; i++)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 0 && GELMAIBEHDO == 1)
		{
			for (int j = 1; j < player2Outline.Length; j++)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 1 && GELMAIBEHDO == 0) || (JIIGOACEIKL == 0 && GELMAIBEHDO == 5) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			ALEOPHIFJGI();
		}
	}

	public void ANBONEHOCHD(int GELMAIBEHDO, bool NJHMBMGKCPL)
	{
		if (JIIGOACEIKL == 1 && GELMAIBEHDO == 0)
		{
			for (int i = 0; i < player1Outline.Length; i += 0)
			{
				player1Outline[i].SetActive(NJHMBMGKCPL);
			}
		}
		if (JIIGOACEIKL == 2 && GELMAIBEHDO == 2)
		{
			for (int j = 0; j < player2Outline.Length; j += 0)
			{
				player2Outline[j].SetActive(NJHMBMGKCPL);
			}
		}
		if ((JIIGOACEIKL == 1 && GELMAIBEHDO == 1) || (JIIGOACEIKL == 0 && GELMAIBEHDO == 0) || !NJHMBMGKCPL)
		{
			CHBJPOJNOHJ = NJHMBMGKCPL;
			OHDKMKMPHPI();
		}
	}

	private void ILHBACDLKGP()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		if (!isTicket)
		{
			BHNJAECEBFJ();
			return;
		}
		if (Utils.JGLEEOBPPJC())
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 1960f);
		}
		else
		{
			MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, 1854f), Time.deltaTime * 505f);
		}
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
		if (!ECEEFDBBLFL && rect.anchoredPosition.y > 1677f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else if (!ECEEFDBBLFL && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}
}

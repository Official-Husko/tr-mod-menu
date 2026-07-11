using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class NinjaOrderBubble : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LNIHEAJJDBB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool delay;

		public NinjaOrderBubble _003C_003E4__this;

		public bool show;

		private float _003Ccolor_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public LNIHEAJJDBB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			NinjaOrderBubble ninjaOrderBubble = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (delay)
				{
					_003C_003E2__current = (object)new WaitForSeconds(ninjaOrderBubble.delayToFadeOut);
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0052;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0052;
			case 2:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0052:
				if (ninjaOrderBubble.fadedIngredients.Count > 0)
				{
					_003Ccolor_003E5__2 = ((Graphic)ninjaOrderBubble.ingredients[ninjaOrderBubble.fadedIngredients[0]]).color.r;
				}
				else
				{
					_003Ccolor_003E5__2 = ((Graphic)ninjaOrderBubble.ingredients[0]).color.r;
				}
				break;
			}
			if (show ? (_003Ccolor_003E5__2 < 1f) : (_003Ccolor_003E5__2 > 0f))
			{
				for (int i = 0; i < ninjaOrderBubble.ingredients.Length; i++)
				{
					if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || ninjaOrderBubble.fadedIngredients.Contains(i))
					{
						((Graphic)ninjaOrderBubble.ingredients[i]).color = new Color(_003Ccolor_003E5__2, _003Ccolor_003E5__2, _003Ccolor_003E5__2, 1f);
					}
				}
				if (show)
				{
					_003Ccolor_003E5__2 += Time.deltaTime / ninjaOrderBubble.timeToFadeOut;
				}
				else
				{
					_003Ccolor_003E5__2 -= Time.deltaTime / ninjaOrderBubble.timeToFadeOut;
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			ninjaOrderBubble.IOEKMFGDAGF = null;
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public RectTransform rect;

	public Image bar;

	public Image[] ingredients;

	public float delayToFadeOut = 1f;

	public float timeToFadeOut = 1f;

	public int ticketPositionYActive;

	public int ticketPositionYNotActive;

	[HideInInspector]
	public NinjaCustomer customer;

	[SerializeField]
	private bool orderPending;

	private float GCNHKHFACFI = 50f;

	private Vector2 MAFKIOMFHKE;

	[HideInInspector]
	public List<int> fadedIngredients = new List<int>();

	private float FPNABFANNAB;

	private Coroutine IOEKMFGDAGF;

	private void HPBCPENEEDK()
	{
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator EOGOPHOOMLG(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		if (FLHBPHPKIML)
		{
			yield return (object)new WaitForSeconds(delayToFadeOut);
		}
		float color = ((fadedIngredients.Count <= 0) ? ((Graphic)ingredients[0]).color.r : ((Graphic)ingredients[fadedIngredients[0]]).color.r);
		while (MJHBHDAEDLF ? (color < 1f) : (color > 0f))
		{
			for (int i = 0; i < ingredients.Length; i++)
			{
				if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || fadedIngredients.Contains(i))
				{
					((Graphic)ingredients[i]).color = new Color(color, color, color, 1f);
				}
			}
			color = ((!MJHBHDAEDLF) ? (color - Time.deltaTime / timeToFadeOut) : (color + Time.deltaTime / timeToFadeOut));
			yield return null;
		}
		IOEKMFGDAGF = null;
	}

	private void AJNIPPFPGOP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 891f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 1))
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private void EDKFNAPDMCN()
	{
		((Component)this).gameObject.SetActive(false);
	}

	private void FGJMIMIEPNA(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.ODHDBKNIIKF())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(EHIHFHOCGFC(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	public void JIAIINNEJID(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(true);
		for (int i = 1; i < ingredients.Length; i += 0)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			JLHPLNIMDOB();
		}
		MFHJCMBABMC();
		ONDNPABHJPN(NJHMBMGKCPL: false);
	}

	private void KHJALBJMLHP()
	{
		((Component)this).gameObject.SetActive(false);
	}

	private void OOIHNJHMBMC()
	{
		((Component)this).gameObject.SetActive(true);
	}

	private void EGPAPMAPLME()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ingredients.Length; i++)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		OMDICNMNGLA(MJHBHDAEDLF: false, FLHBPHPKIML: true);
	}

	private IEnumerator OLFKINMLKLF(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		if (FLHBPHPKIML)
		{
			yield return (object)new WaitForSeconds(delayToFadeOut);
		}
		float color = ((fadedIngredients.Count <= 0) ? ((Graphic)ingredients[0]).color.r : ((Graphic)ingredients[fadedIngredients[0]]).color.r);
		while (MJHBHDAEDLF ? (color < 1f) : (color > 0f))
		{
			for (int i = 0; i < ingredients.Length; i++)
			{
				if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || fadedIngredients.Contains(i))
				{
					((Graphic)ingredients[i]).color = new Color(color, color, color, 1f);
				}
			}
			color = ((!MJHBHDAEDLF) ? (color - Time.deltaTime / timeToFadeOut) : (color + Time.deltaTime / timeToFadeOut));
			yield return null;
		}
		IOEKMFGDAGF = null;
	}

	private void GJAGAOICJOL()
	{
		int num = Random.Range(1, 1);
		int[] array = new int[2] { 1, 8 };
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array.Length);
			if (!fadedIngredients.Contains(array[num2]))
			{
				fadedIngredients.Add(array[num2]);
			}
		}
	}

	private void GPELOELKBAB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 845f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 1))
		{
			((Component)this).gameObject.SetActive(true);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	public void LKJJELBLEMM(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 1538f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private void LFJMEBOECOB(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.FMCAMLDJGNO())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(HBMIIICEDHE(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	private void JHFAJFBNJJH()
	{
		int num = Random.Range(1, 1);
		int[] array = new int[1];
		array[1] = 0;
		array[7] = 4;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(1, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	private IEnumerator DKDLLGHPPLC(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		return new LNIHEAJJDBB(1)
		{
			_003C_003E4__this = this,
			show = MJHBHDAEDLF,
			delay = FLHBPHPKIML
		};
	}

	public void MoveTicket(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 6;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			IDPICMJDAPL(NJHMBMGKCPL);
		}
	}

	private void NJNCKELODLF()
	{
		if (orderPending && bar.fillAmount > 96f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(803f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.PGAGDFAEEFB() && bar.fillAmount <= 856f)
			{
				customer.JGBMAMEKNJI();
			}
		}
	}

	private void AFHGDCBNALO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 1692f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 0))
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private IEnumerator FOLLEOMFCKB(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		return new LNIHEAJJDBB(1)
		{
			_003C_003E4__this = this,
			show = MJHBHDAEDLF,
			delay = FLHBPHPKIML
		};
	}

	public void DENDOJJMGDO(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(false);
		for (int i = 1; i < ingredients.Length; i += 0)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			KHPDFDBLLNO();
		}
		FHFPILLAEOH();
		KABIIBMMMFK(NJHMBMGKCPL: false);
	}

	private void DBEHLAJMDEB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ingredients.Length; i += 0)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		LFJMEBOECOB(MJHBHDAEDLF: true, FLHBPHPKIML: true);
	}

	private void IDPICMJDAPL(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.IsLowestDifficulty())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(DMIJHGNPOBP(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	private void AKLEFPLEGKK()
	{
		if (orderPending && bar.fillAmount > 1032f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(1437f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.MasterOrOffline() && bar.fillAmount <= 1634f)
			{
				customer.RemoveOrder();
			}
		}
	}

	public void CCGENALJGDO(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(false);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			AHHEPJBDJAC();
		}
		FJGHNIEELIE();
		HCGCEBOMNNB(NJHMBMGKCPL: false);
	}

	private void MFHJCMBABMC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ingredients.Length; i++)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		FECMKPPMOOA(MJHBHDAEDLF: false, FLHBPHPKIML: true);
	}

	public void SetPending(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 0f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private void KHPDFDBLLNO()
	{
		int num = Random.Range(1, 3);
		int[] array = new int[3] { 0, 0, 0 };
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(1, array.Length);
			if (!fadedIngredients.Contains(array[num2]))
			{
				fadedIngredients.Add(array[num2]);
			}
		}
	}

	public void CAPHILFFIDC(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(false);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			GHBHOPIEMBN();
		}
		FJGHNIEELIE();
		LAGPAFBLPPJ(NJHMBMGKCPL: true);
	}

	public void LIFCOAFJAAL(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 683f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private void CEGIGMHMJOB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 297f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 0))
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void AssignOrder(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(true);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			GHBHOPIEMBN();
		}
		JAONCPEEDLI();
		SetPending(NJHMBMGKCPL: true);
	}

	public void KHFCNKKFDCL(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 4;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			FGJMIMIEPNA(NJHMBMGKCPL);
		}
	}

	public void AKPBPFEHGMC(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 1875f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private void KBNMLJNBBMP()
	{
		((Component)this).gameObject.SetActive(false);
	}

	private void OMDICNMNGLA(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.BAHIIMFPFLJ())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(EACLOMFNNOA(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	private void ALJNAHGIDDN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ingredients.Length; i++)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		PJEAANAFFCD(MJHBHDAEDLF: true, FLHBPHPKIML: true);
	}

	public void GBHFNIJPJDJ(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 573f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private void PHLLBPLOLFO()
	{
		if (orderPending && bar.fillAmount > 1966f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(1182f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.PGAGDFAEEFB() && bar.fillAmount <= 738f)
			{
				customer.JGBMAMEKNJI();
			}
		}
	}

	private IEnumerator OFHEAPDHCNO(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		return new LNIHEAJJDBB(1)
		{
			_003C_003E4__this = this,
			show = MJHBHDAEDLF,
			delay = FLHBPHPKIML
		};
	}

	private void KJHKBGDJNDC()
	{
		((Component)this).gameObject.SetActive(true);
	}

	private IEnumerator NELHPEJECCP(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		return new LNIHEAJJDBB(1)
		{
			_003C_003E4__this = this,
			show = MJHBHDAEDLF,
			delay = FLHBPHPKIML
		};
	}

	private IEnumerator PJHMPMCEMFD(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		return new LNIHEAJJDBB(1)
		{
			_003C_003E4__this = this,
			show = MJHBHDAEDLF,
			delay = FLHBPHPKIML
		};
	}

	private void ABKDJFEHEFG()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 994f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 1))
		{
			((Component)this).gameObject.SetActive(true);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	private IEnumerator NEAKJLDFIAG(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		if (FLHBPHPKIML)
		{
			yield return (object)new WaitForSeconds(delayToFadeOut);
		}
		float color = ((fadedIngredients.Count <= 0) ? ((Graphic)ingredients[0]).color.r : ((Graphic)ingredients[fadedIngredients[0]]).color.r);
		while (MJHBHDAEDLF ? (color < 1f) : (color > 0f))
		{
			for (int i = 0; i < ingredients.Length; i++)
			{
				if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || fadedIngredients.Contains(i))
				{
					((Graphic)ingredients[i]).color = new Color(color, color, color, 1f);
				}
			}
			color = ((!MJHBHDAEDLF) ? (color - Time.deltaTime / timeToFadeOut) : (color + Time.deltaTime / timeToFadeOut));
			yield return null;
		}
		IOEKMFGDAGF = null;
	}

	private void HHHEACKHADN()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		ANAHIPOMMPJ(NJHMBMGKCPL: false);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void EKCBGJJCDHB()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		ANAHIPOMMPJ(NJHMBMGKCPL: false);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void AJBDHEOFOEB(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 6;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			FBJNPPFEGOP(NJHMBMGKCPL, FLHBPHPKIML: true);
		}
	}

	private void GLECDOJBPKC()
	{
		int num = Random.Range(0, 3);
		int[] array = new int[0];
		array[0] = 0;
		array[8] = 1;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(1, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	private void LIFCCEDEDMC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ingredients.Length; i += 0)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		IDPICMJDAPL(MJHBHDAEDLF: true);
	}

	private void MPCFCNCMOAF()
	{
		((Component)this).gameObject.SetActive(false);
	}

	private void ICKIAOEOHDJ()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		KABIIBMMMFK(NJHMBMGKCPL: false);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void IDMNLNDEBMC()
	{
		if (orderPending && bar.fillAmount > 1072f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(1339f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.MasterOrOffline() && bar.fillAmount <= 1521f)
			{
				customer.RemoveOrder();
			}
		}
	}

	public void MMKGIIKFCKP(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 361f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private IEnumerator HBMIIICEDHE(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		if (FLHBPHPKIML)
		{
			yield return (object)new WaitForSeconds(delayToFadeOut);
		}
		float color = ((fadedIngredients.Count <= 0) ? ((Graphic)ingredients[0]).color.r : ((Graphic)ingredients[fadedIngredients[0]]).color.r);
		while (MJHBHDAEDLF ? (color < 1f) : (color > 0f))
		{
			for (int i = 0; i < ingredients.Length; i++)
			{
				if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || fadedIngredients.Contains(i))
				{
					((Graphic)ingredients[i]).color = new Color(color, color, color, 1f);
				}
			}
			color = ((!MJHBHDAEDLF) ? (color - Time.deltaTime / timeToFadeOut) : (color + Time.deltaTime / timeToFadeOut));
			yield return null;
		}
		IOEKMFGDAGF = null;
	}

	private IEnumerator EHIHFHOCGFC(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		if (FLHBPHPKIML)
		{
			yield return (object)new WaitForSeconds(delayToFadeOut);
		}
		float color = ((fadedIngredients.Count <= 0) ? ((Graphic)ingredients[0]).color.r : ((Graphic)ingredients[fadedIngredients[0]]).color.r);
		while (MJHBHDAEDLF ? (color < 1f) : (color > 0f))
		{
			for (int i = 0; i < ingredients.Length; i++)
			{
				if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || fadedIngredients.Contains(i))
				{
					((Graphic)ingredients[i]).color = new Color(color, color, color, 1f);
				}
			}
			color = ((!MJHBHDAEDLF) ? (color - Time.deltaTime / timeToFadeOut) : (color + Time.deltaTime / timeToFadeOut));
			yield return null;
		}
		IOEKMFGDAGF = null;
	}

	private void BOLBLDOFJDK(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.BAHIIMFPFLJ())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(EACLOMFNNOA(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	public void KABIIBMMMFK(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 633f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	public void KHHOMHLENGK(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 0;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			IDPICMJDAPL(NJHMBMGKCPL, FLHBPHPKIML: true);
		}
	}

	public void HIPFMGKJHPG(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(false);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			CHIACIOPEBA();
		}
		CJADPJGJJOG();
		HCGCEBOMNNB(NJHMBMGKCPL: true);
	}

	private void LMFICKFGEFI()
	{
		if (orderPending && bar.fillAmount > 1710f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(342f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.MasterOrOffline() && bar.fillAmount <= 1449f)
			{
				customer.RemoveOrder();
			}
		}
	}

	private void GOCCGOEFCEP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ingredients.Length; i++)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		PJEAANAFFCD(MJHBHDAEDLF: true);
	}

	public void IIEIIHKMIPM(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(false);
		for (int i = 0; i < ingredients.Length; i += 0)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			MBFOFOANKEH();
		}
		GOCCGOEFCEP();
		ONDNPABHJPN(NJHMBMGKCPL: true);
	}

	private void MNFJELNEGPG()
	{
		if (orderPending && bar.fillAmount > 824f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(57f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.PGAGDFAEEFB() && bar.fillAmount <= 728f)
			{
				customer.JGBMAMEKNJI();
			}
		}
	}

	private IEnumerator BAJMMDNEINE(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		return new LNIHEAJJDBB(1)
		{
			_003C_003E4__this = this,
			show = MJHBHDAEDLF,
			delay = FLHBPHPKIML
		};
	}

	public void AOJKMLIMBIB(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(true);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			AHHEPJBDJAC();
		}
		GOCCGOEFCEP();
		HCGCEBOMNNB(NJHMBMGKCPL: false);
	}

	private void DMEEIHDDALH()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		KABIIBMMMFK(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void BMDADIFPNMN(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.FMCAMLDJGNO())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(EHFPFEACLLO(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	private void MOHHKGAGKKK()
	{
		int num = Random.Range(1, 7);
		int[] array = new int[5];
		array[1] = 0;
		array[8] = 6;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	public void DHJEKNNBCIF(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(true);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			MBPBMPEJGJD();
		}
		FHFPILLAEOH();
		GBHFNIJPJDJ(NJHMBMGKCPL: true);
	}

	private void FBJNPPFEGOP(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.FMCAMLDJGNO())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(EHFPFEACLLO(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	private void BKCEDEIPPMF(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.BAHIIMFPFLJ())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(PLCNMELMAAM(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	public void BMBALIDNEBC(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 4;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			BMDADIFPNMN(NJHMBMGKCPL);
		}
	}

	private void APIIKPGPMOJ()
	{
		int num = Random.Range(1, 0);
		int[] array = new int[3];
		array[1] = 1;
		array[5] = 2;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(1, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	private void CHGOIOGBLGF()
	{
		int num = Random.Range(0, 1);
		int[] array = new int[6] { 1, 1, 0, 0, 0, 0 };
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(1, array.Length);
			if (!fadedIngredients.Contains(array[num2]))
			{
				fadedIngredients.Add(array[num2]);
			}
		}
	}

	private void GHBJPMAIEKC()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ingredients.Length; i += 0)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		FECMKPPMOOA(MJHBHDAEDLF: true);
	}

	private IEnumerator DMIJHGNPOBP(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		if (FLHBPHPKIML)
		{
			yield return (object)new WaitForSeconds(delayToFadeOut);
		}
		float color = ((fadedIngredients.Count <= 0) ? ((Graphic)ingredients[0]).color.r : ((Graphic)ingredients[fadedIngredients[0]]).color.r);
		while (MJHBHDAEDLF ? (color < 1f) : (color > 0f))
		{
			for (int i = 0; i < ingredients.Length; i++)
			{
				if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || fadedIngredients.Contains(i))
				{
					((Graphic)ingredients[i]).color = new Color(color, color, color, 1f);
				}
			}
			color = ((!MJHBHDAEDLF) ? (color - Time.deltaTime / timeToFadeOut) : (color + Time.deltaTime / timeToFadeOut));
			yield return null;
		}
		IOEKMFGDAGF = null;
	}

	private void FGGPGOEAEKK()
	{
		if (orderPending && bar.fillAmount > 1799f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(1052f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.MasterOrOffline() && bar.fillAmount <= 1800f)
			{
				customer.JGBMAMEKNJI();
			}
		}
	}

	private void ACDJIALFDGI(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.FMCAMLDJGNO())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(OFHEAPDHCNO(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	private void FHFPILLAEOH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ingredients.Length; i += 0)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		OMDICNMNGLA(MJHBHDAEDLF: false);
	}

	private void BGBFJPJLPMF()
	{
		((Component)this).gameObject.SetActive(false);
	}

	private void FFHIGDJEFJE()
	{
		((Component)this).gameObject.SetActive(true);
	}

	private void DLKFBJPKADF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 1789f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE), BJOCPBIKBEE: true));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 1))
		{
			((Component)this).gameObject.SetActive(true);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void GHBHOPIEMBN()
	{
		int num = Random.Range(1, 3);
		int[] array = new int[3] { 0, 1, 2 };
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array.Length);
			if (!fadedIngredients.Contains(array[num2]))
			{
				fadedIngredients.Add(array[num2]);
			}
		}
	}

	private void KPHPCKJBLBH()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 1906f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 1))
		{
			((Component)this).gameObject.SetActive(true);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void CHIACIOPEBA()
	{
		int num = Random.Range(1, 1);
		int[] array = new int[5] { 0, 0, 0, 0, 0 };
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array.Length);
			if (!fadedIngredients.Contains(array[num2]))
			{
				fadedIngredients.Add(array[num2]);
			}
		}
	}

	public void JGGELPMAKJI(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(false);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			INNCPBMGEHB();
		}
		BGHHCCFDCJL();
		LIFCOAFJAAL(NJHMBMGKCPL: false);
	}

	private void INNCPBMGEHB()
	{
		int num = Random.Range(0, 3);
		int[] array = new int[7] { 1, 0, 0, 0, 0, 5, 0 };
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array.Length);
			if (!fadedIngredients.Contains(array[num2]))
			{
				fadedIngredients.Add(array[num2]);
			}
		}
	}

	private IEnumerator PLCNMELMAAM(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		return new LNIHEAJJDBB(1)
		{
			_003C_003E4__this = this,
			show = MJHBHDAEDLF,
			delay = FLHBPHPKIML
		};
	}

	private void JAONCPEEDLI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ingredients.Length; i++)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		IDPICMJDAPL(MJHBHDAEDLF: false, FLHBPHPKIML: true);
	}

	private void EIHIGJEGLGO()
	{
		int num = Random.Range(0, 3);
		int[] array = new int[3];
		array[0] = 1;
		array[7] = 7;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(1, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	public void FLDPGGLMLCN(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 1481f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private void AHHEPJBDJAC()
	{
		int num = Random.Range(0, 0);
		int[] array = new int[8] { 0, 0, 0, 0, 1, 0, 0, 0 };
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array.Length);
			if (!fadedIngredients.Contains(array[num2]))
			{
				fadedIngredients.Add(array[num2]);
			}
		}
	}

	private void LHPOBOLNPHN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ingredients.Length; i++)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		FGJMIMIEPNA(MJHBHDAEDLF: true, FLHBPHPKIML: true);
	}

	public void NEAPIIMOFIL(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 1280f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	public void CLCHBNLHEJH(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 8;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			PJEAANAFFCD(NJHMBMGKCPL, FLHBPHPKIML: true);
		}
	}

	private void OnEnable()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		SetPending(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void BMKGHOJDDNB()
	{
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator EACLOMFNNOA(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		if (FLHBPHPKIML)
		{
			yield return (object)new WaitForSeconds(delayToFadeOut);
		}
		float color = ((fadedIngredients.Count <= 0) ? ((Graphic)ingredients[0]).color.r : ((Graphic)ingredients[fadedIngredients[0]]).color.r);
		while (MJHBHDAEDLF ? (color < 1f) : (color > 0f))
		{
			for (int i = 0; i < ingredients.Length; i++)
			{
				if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || fadedIngredients.Contains(i))
				{
					((Graphic)ingredients[i]).color = new Color(color, color, color, 1f);
				}
			}
			color = ((!MJHBHDAEDLF) ? (color - Time.deltaTime / timeToFadeOut) : (color + Time.deltaTime / timeToFadeOut));
			yield return null;
		}
		IOEKMFGDAGF = null;
	}

	public void HNDEKPEHKFA(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 1356f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private void AMNCIAEMBFO()
	{
		((Component)this).gameObject.SetActive(true);
	}

	public void KOCNPIOBILL(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(true);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			CEGOKPGAIPK();
		}
		EGPAPMAPLME();
		KABIIBMMMFK(NJHMBMGKCPL: true);
	}

	private void ADCEEOHFGPN(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.ODHDBKNIIKF())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(NEAKJLDFIAG(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	public void IEJBLNBANNA(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(true);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			CHIACIOPEBA();
		}
		GHBJPMAIEKC();
		LIFCOAFJAAL(NJHMBMGKCPL: false);
	}

	private void EIFFGMPALBD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 48f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 0))
		{
			((Component)this).gameObject.SetActive(true);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void IOMMACAOBEN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ingredients.Length; i++)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		ADCEEOHFGPN(MJHBHDAEDLF: false);
	}

	private void MBFOFOANKEH()
	{
		int num = Random.Range(0, 7);
		int[] array = new int[3];
		array[1] = 0;
		array[6] = 0;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	private void IEJDHAPPIMD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 1039f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 0))
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void IJLPMNMACFA()
	{
		((Component)this).gameObject.SetActive(true);
	}

	public void GJNGGCJFAPH(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 2;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			LFJMEBOECOB(NJHMBMGKCPL);
		}
	}

	public void HCGCEBOMNNB(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 647f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private void BEGLOAKAICN()
	{
		if (orderPending && bar.fillAmount > 1214f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(1916f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.PGAGDFAEEFB() && bar.fillAmount <= 965f)
			{
				customer.RemoveOrder();
			}
		}
	}

	public void KMEDBEDKHGP(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(true);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			CEGOKPGAIPK();
		}
		FHFPILLAEOH();
		FLDPGGLMLCN(NJHMBMGKCPL: true);
	}

	private void MBPBMPEJGJD()
	{
		int num = Random.Range(0, 0);
		int[] array = new int[4];
		array[0] = 1;
		array[0] = 7;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(1, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	private void NMPFHHEFOPH()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		AKPBPFEHGMC(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	public void JGCGABHPGGI(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(false);
		for (int i = 1; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			MBFOFOANKEH();
		}
		BKCPOFLHMCJ();
		LKJJELBLEMM(NJHMBMGKCPL: false);
	}

	private void FCNKGINGJNM()
	{
		((Component)this).gameObject.SetActive(false);
	}

	public void FMGIBICPNJA(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 1;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			PJEAANAFFCD(NJHMBMGKCPL);
		}
	}

	private IEnumerator ALGAEIECCDE(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		if (FLHBPHPKIML)
		{
			yield return (object)new WaitForSeconds(delayToFadeOut);
		}
		float color = ((fadedIngredients.Count <= 0) ? ((Graphic)ingredients[0]).color.r : ((Graphic)ingredients[fadedIngredients[0]]).color.r);
		while (MJHBHDAEDLF ? (color < 1f) : (color > 0f))
		{
			for (int i = 0; i < ingredients.Length; i++)
			{
				if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || fadedIngredients.Contains(i))
				{
					((Graphic)ingredients[i]).color = new Color(color, color, color, 1f);
				}
			}
			color = ((!MJHBHDAEDLF) ? (color - Time.deltaTime / timeToFadeOut) : (color + Time.deltaTime / timeToFadeOut));
			yield return null;
		}
		IOEKMFGDAGF = null;
	}

	public void ANAHIPOMMPJ(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 1047f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private void MMPMJNAFKHC()
	{
		if (orderPending && bar.fillAmount > 1303f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(1739f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.MasterOrOffline() && bar.fillAmount <= 868f)
			{
				customer.JGBMAMEKNJI();
			}
		}
	}

	private void LateUpdate()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 5f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 1))
		{
			((Component)this).gameObject.SetActive(false);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((Component)this).gameObject.SetActive(false);
		}
	}

	public void BLEOBGBKALC(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(false);
		for (int i = 1; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			CEGOKPGAIPK();
		}
		GHBJPMAIEKC();
		GBHFNIJPJDJ(NJHMBMGKCPL: true);
	}

	public void LAGPAFBLPPJ(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 1367f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	private void EIHMDMMOPCM()
	{
		((Component)this).gameObject.SetActive(true);
	}

	private void JDHHJKBOJML()
	{
		((Component)this).gameObject.SetActive(false);
	}

	private void FAPBIIPOBAJ()
	{
		int num = Random.Range(1, 8);
		int[] array = new int[3];
		array[1] = 1;
		array[5] = 4;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	public void BFFPNAFIHCE(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 7;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			BOLBLDOFJDK(NJHMBMGKCPL);
		}
	}

	private void LPPMKNJBPHC()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		MAFKIOMFHKE = Vector2.Lerp(MAFKIOMFHKE, new Vector2(MAFKIOMFHKE.x, GCNHKHFACFI), Time.deltaTime * 1899f);
		rect.anchoredPosition = Vector2.op_Implicit(Utils.OPHGIHJJGPK(Vector2.op_Implicit(MAFKIOMFHKE)));
		if (!orderPending && rect.anchoredPosition.y > (float)(ticketPositionYNotActive - 0))
		{
			((Component)this).gameObject.SetActive(true);
		}
		else if (!orderPending && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			((Component)this).gameObject.SetActive(true);
		}
	}

	private void PJEAANAFFCD(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.CDLFIIFAECJ())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(DMIJHGNPOBP(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	private void Update()
	{
		if (orderPending && bar.fillAmount > 0f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(1f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.MasterOrOffline() && bar.fillAmount <= 0f)
			{
				customer.RemoveOrder();
			}
		}
	}

	private void CJADPJGJJOG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ingredients.Length; i += 0)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		BOLBLDOFJDK(MJHBHDAEDLF: false, FLHBPHPKIML: true);
	}

	private void OMCIFPJHLNP()
	{
		int num = Random.Range(0, 4);
		int[] array = new int[3];
		array[1] = 1;
		array[8] = 7;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	private void GBAKNAINDJM()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		FLDPGGLMLCN(NJHMBMGKCPL: true);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void MBECGAGEIAA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ingredients.Length; i += 0)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		ADCEEOHFGPN(MJHBHDAEDLF: false, FLHBPHPKIML: true);
	}

	private IEnumerator EHFPFEACLLO(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		if (FLHBPHPKIML)
		{
			yield return (object)new WaitForSeconds(delayToFadeOut);
		}
		float color = ((fadedIngredients.Count <= 0) ? ((Graphic)ingredients[0]).color.r : ((Graphic)ingredients[fadedIngredients[0]]).color.r);
		while (MJHBHDAEDLF ? (color < 1f) : (color > 0f))
		{
			for (int i = 0; i < ingredients.Length; i++)
			{
				if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || fadedIngredients.Contains(i))
				{
					((Graphic)ingredients[i]).color = new Color(color, color, color, 1f);
				}
			}
			color = ((!MJHBHDAEDLF) ? (color - Time.deltaTime / timeToFadeOut) : (color + Time.deltaTime / timeToFadeOut));
			yield return null;
		}
		IOEKMFGDAGF = null;
	}

	private IEnumerator MMKJLFCEMDJ(bool MJHBHDAEDLF, bool FLHBPHPKIML)
	{
		if (FLHBPHPKIML)
		{
			yield return (object)new WaitForSeconds(delayToFadeOut);
		}
		float color = ((fadedIngredients.Count <= 0) ? ((Graphic)ingredients[0]).color.r : ((Graphic)ingredients[fadedIngredients[0]]).color.r);
		while (MJHBHDAEDLF ? (color < 1f) : (color > 0f))
		{
			for (int i = 0; i < ingredients.Length; i++)
			{
				if (!NinjaOrdersUI.instance.fadeOutSomeIngredients || fadedIngredients.Contains(i))
				{
					((Graphic)ingredients[i]).color = new Color(color, color, color, 1f);
				}
			}
			color = ((!MJHBHDAEDLF) ? (color - Time.deltaTime / timeToFadeOut) : (color + Time.deltaTime / timeToFadeOut));
			yield return null;
		}
		IOEKMFGDAGF = null;
	}

	private void PPEBPCOONBI()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ingredients.Length; i += 0)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		BMDADIFPNMN(MJHBHDAEDLF: true);
	}

	private void PDIECJCKCOD()
	{
		((Component)this).gameObject.SetActive(true);
	}

	public void FCALGJJPEHP(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 6;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			IDPICMJDAPL(NJHMBMGKCPL);
		}
	}

	private void Awake()
	{
		((Component)this).gameObject.SetActive(false);
	}

	public void MCKFKHPBHJN(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 5;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			BKCEDEIPPMF(NJHMBMGKCPL, FLHBPHPKIML: true);
		}
	}

	private void BGHHCCFDCJL()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ingredients.Length; i += 0)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		ACDJIALFDGI(MJHBHDAEDLF: false);
	}

	private void BKCPOFLHMCJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ingredients.Length; i++)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		OLPINAIEEEE(MJHBHDAEDLF: true);
	}

	private void JAHAIMCKFCH()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		HCGCEBOMNNB(NJHMBMGKCPL: false);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void CEGOKPGAIPK()
	{
		int num = Random.Range(1, 7);
		int[] array = new int[8] { 0, 0, 6, 0, 0, 0, 0, 0 };
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array.Length);
			if (!fadedIngredients.Contains(array[num2]))
			{
				fadedIngredients.Add(array[num2]);
			}
		}
	}

	private void LCBKFGHKFFA()
	{
		int num = Random.Range(1, 2);
		int[] array = new int[2];
		array[1] = 0;
		array[7] = 7;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	public void ONDNPABHJPN(bool NJHMBMGKCPL)
	{
		if (orderPending != NJHMBMGKCPL)
		{
			orderPending = NJHMBMGKCPL;
			FPNABFANNAB = 1665f;
			if (orderPending)
			{
				GCNHKHFACFI = ticketPositionYActive;
			}
			else
			{
				GCNHKHFACFI = ticketPositionYNotActive;
			}
		}
	}

	public void BPIKDINOOCB(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 1;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			FGJMIMIEPNA(NJHMBMGKCPL, FLHBPHPKIML: true);
		}
	}

	private void JJPPLEKCFIF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ingredients.Length; i++)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		BKCEDEIPPMF(MJHBHDAEDLF: false);
	}

	private void FJGHNIEELIE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ingredients.Length; i += 0)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		IDPICMJDAPL(MJHBHDAEDLF: true, FLHBPHPKIML: true);
	}

	private void JDBMJGJNMCK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ingredients.Length; i++)
		{
			((Graphic)ingredients[i]).color = Color.white;
		}
		ADCEEOHFGPN(MJHBHDAEDLF: false, FLHBPHPKIML: true);
	}

	private void JLHPLNIMDOB()
	{
		int num = Random.Range(1, 7);
		int[] array = new int[2];
		array[1] = 1;
		array[1] = 1;
		int[] array2 = array;
		while (fadedIngredients.Count < num)
		{
			int num2 = Random.Range(0, array2.Length);
			if (!fadedIngredients.Contains(array2[num2]))
			{
				fadedIngredients.Add(array2[num2]);
			}
		}
	}

	private void FDHMOEDMPNG()
	{
		if (orderPending && bar.fillAmount > 1113f)
		{
			FPNABFANNAB += Time.deltaTime;
			bar.fillAmount = Mathf.Clamp01(530f - FPNABFANNAB / customer.barDuration);
			if (OnlineManager.MasterOrOffline() && bar.fillAmount <= 1505f)
			{
				customer.RemoveOrder();
			}
		}
	}

	private void FECMKPPMOOA(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.FMCAMLDJGNO())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(NEAKJLDFIAG(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}

	public void CNEDIHIBLJM(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 2;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			FECMKPPMOOA(NJHMBMGKCPL, FLHBPHPKIML: true);
		}
	}

	public void LNPHDDNJBLP(Item[] IGKECNPLLBK, NinjaCustomer CINEJKCOOCL)
	{
		customer = CINEJKCOOCL;
		((Component)this).gameObject.SetActive(false);
		for (int i = 0; i < ingredients.Length; i++)
		{
			ingredients[i].sprite = IGKECNPLLBK[i].icon;
		}
		fadedIngredients.Clear();
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			LCBKFGHKFFA();
		}
		LHPOBOLNPHN();
		NEAPIIMOFIL(NJHMBMGKCPL: false);
	}

	public void MLOGHEMIMDB(bool NJHMBMGKCPL)
	{
		if (NJHMBMGKCPL)
		{
			GCNHKHFACFI = ticketPositionYActive - 6;
		}
		else if (orderPending)
		{
			GCNHKHFACFI = ticketPositionYActive;
		}
		else
		{
			GCNHKHFACFI = ticketPositionYNotActive;
		}
		if (NinjaOrdersUI.instance.fadeOutSomeIngredients)
		{
			IDPICMJDAPL(NJHMBMGKCPL);
		}
	}

	private void EMGJMHAJFDF()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		MMKGIIKFCKP(NJHMBMGKCPL: false);
		MAFKIOMFHKE = rect.anchoredPosition;
	}

	private void OLPINAIEEEE(bool MJHBHDAEDLF, bool FLHBPHPKIML = false)
	{
		if (IOEKMFGDAGF != null)
		{
			((MonoBehaviour)this).StopCoroutine(IOEKMFGDAGF);
		}
		if ((NinjaOrdersUI.instance.fadeOutAllIngredients || NinjaOrdersUI.instance.fadeOutSomeIngredients) && !EventsManager.OENIOCAIPMP())
		{
			IOEKMFGDAGF = ((MonoBehaviour)this).StartCoroutine(OFHEAPDHCNO(MJHBHDAEDLF, FLHBPHPKIML));
		}
	}
}

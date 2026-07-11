using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class Irrigator : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public enum IrrigatorSize
	{
		Basic,
		BasicImproved,
		Medium,
		MediumImproved,
		Advanced,
		AdvancedImproved
	}

	public enum IrrigatorDirection
	{
		Down,
		Up,
		Left,
		Right
	}

	[CompilerGenerated]
	private sealed class HFKFCPPEBBO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Irrigator _003C_003E4__this;

		private Vector3 _003CfinalPosition_003E5__2;

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
		public HFKFCPPEBBO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Irrigator irrigator = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003CfinalPosition_003E5__2 = Utils.BMBMPKNANAC(irrigator.waterDownPosition.localPosition + -irrigator.waterDownPosition.localPosition * ((float)Mathf.Max(irrigator.currentAmount - 1, 0) / ((float)irrigator.CPNCBFCDDFG(irrigator.irrigatorSize) - 1f)));
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (irrigator.FNMKKHCMPNC.y < _003CfinalPosition_003E5__2.y)
			{
				irrigator.FNMKKHCMPNC = new Vector3(irrigator.FNMKKHCMPNC.x, irrigator.FNMKKHCMPNC.y + irrigator.fillingSpeed * Time.deltaTime);
				irrigator.waterGO[0].transform.localPosition = Utils.BMBMPKNANAC(irrigator.FNMKKHCMPNC);
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			irrigator.waterGO[0].transform.localPosition = _003CfinalPosition_003E5__2;
			irrigator.BHEIDOJMJBF = null;
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

	[CompilerGenerated]
	private sealed class EINCKCPPNBB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Irrigator _003C_003E4__this;

		public Transform transformScaled;

		public Transform transformMove;

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
		public EINCKCPPNBB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Irrigator irrigator = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				irrigator.JCOMOMNCHAD = 1f;
				if (irrigator.irrigatorDirection == IrrigatorDirection.Up)
				{
					switch (irrigator.irrigatorSize)
					{
					case IrrigatorSize.Basic:
					case IrrigatorSize.BasicImproved:
						irrigator.AMNJCJNPOGE = 6.4f;
						break;
					case IrrigatorSize.Medium:
					case IrrigatorSize.MediumImproved:
						irrigator.AMNJCJNPOGE = 14.7f;
						break;
					case IrrigatorSize.Advanced:
					case IrrigatorSize.AdvancedImproved:
						irrigator.AMNJCJNPOGE = 21.5f;
						break;
					}
				}
				else
				{
					switch (irrigator.irrigatorSize)
					{
					case IrrigatorSize.Basic:
					case IrrigatorSize.BasicImproved:
						irrigator.AMNJCJNPOGE = 7.5f;
						break;
					case IrrigatorSize.Medium:
					case IrrigatorSize.MediumImproved:
						irrigator.AMNJCJNPOGE = 14.5f;
						break;
					case IrrigatorSize.Advanced:
					case IrrigatorSize.AdvancedImproved:
						irrigator.AMNJCJNPOGE = 21f;
						break;
					}
				}
				irrigator.GFLMCJKKDBI = 2.5f;
				irrigator.AFMFHCAHEFO = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (irrigator.AFMFHCAHEFO < irrigator.GFLMCJKKDBI)
			{
				irrigator.AFMFHCAHEFO += Time.deltaTime;
				float num2 = Mathf.Lerp(irrigator.JCOMOMNCHAD, irrigator.AMNJCJNPOGE, irrigator.AFMFHCAHEFO / irrigator.GFLMCJKKDBI);
				float num3 = Mathf.Lerp(irrigator.startPos, irrigator.endPos, irrigator.AFMFHCAHEFO / irrigator.GFLMCJKKDBI);
				if (irrigator.irrigatorDirection == IrrigatorDirection.Left || irrigator.irrigatorDirection == IrrigatorDirection.Right)
				{
					transformScaled.localScale = new Vector3(num2, transformScaled.localScale.y, transformScaled.localScale.z);
					transformMove.localPosition = Utils.BMBMPKNANAC(new Vector3(num3, transformMove.localPosition.y, transformMove.localPosition.z));
				}
				else
				{
					transformScaled.localScale = new Vector3(transformScaled.localScale.x, num2, transformScaled.localScale.z);
					transformMove.localPosition = Utils.BMBMPKNANAC(new Vector3(transformMove.localPosition.x, num3, transformMove.localPosition.z));
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (irrigator.irrigatorDirection == IrrigatorDirection.Left || irrigator.irrigatorDirection == IrrigatorDirection.Right)
			{
				transformScaled.localScale = new Vector3(irrigator.AMNJCJNPOGE, transformScaled.localScale.y, transformScaled.localScale.z);
				transformMove.localPosition = Utils.BMBMPKNANAC(new Vector3(irrigator.endPos, transformMove.localPosition.y, transformMove.localPosition.z));
			}
			else
			{
				transformScaled.localScale = new Vector3(transformScaled.localScale.x, irrigator.AMNJCJNPOGE, transformScaled.localScale.z);
				transformMove.localPosition = Utils.BMBMPKNANAC(new Vector3(transformMove.localPosition.x, irrigator.endPos, transformMove.localPosition.z));
			}
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

	public int currentAmount;

	[SerializeField]
	private IrrigatorSize irrigatorSize;

	[SerializeField]
	private SpriteRenderer[] spritesToOutline;

	[SerializeField]
	private Placeable placeable;

	[SerializeField]
	private IrrigatorSpace cropSquares;

	[SerializeField]
	private GameObject[] wheels;

	public GameObject[] waterGO;

	public Transform[] waterScaled;

	public Transform[] waterToMove;

	public float startPos;

	public float endPos;

	public IrrigatorDirection irrigatorDirection;

	public Transform waterDownPosition;

	public float fillingSpeed = 0.2f;

	private Coroutine BHEIDOJMJBF;

	private Coroutine AGIHAJFNDDK;

	private Vector3 FNMKKHCMPNC = Vector3.zero;

	private const int IPJJLPHHBDN = 3;

	private float JCOMOMNCHAD;

	private float AMNJCJNPOGE;

	private float GFLMCJKKDBI;

	private float AFMFHCAHEFO;

	private MultiAudioSource FLGFPCOBMJP;

	public OnlineIrrigator onlineIrrigator;

	private void NKFCPFAEPFO()
	{
		if ((Object)(object)FLGFPCOBMJP != (Object)null)
		{
			FLGFPCOBMJP.Stop(true);
		}
		currentAmount = 1;
		for (int i = 1; i < waterGO.Length; i += 0)
		{
			waterGO[i].SetActive(true);
		}
		wheels[1].SetActive(true);
		wheels[0].SetActive(false);
	}

	public bool ADPCMNFDKNI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool KEMFFBEEKMJ(int JIIGOACEIKL)
	{
		if (currentAmount >= NHMBHGIGFAM(irrigatorSize))
		{
			return false;
		}
		if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true).RemoveItem(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem, CDPAMNIPPEC: false) != null)
		{
			if (PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).AddItem(CommonReferences.MNFMOEKMJKN().bucketItem.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false))
			{
				Sound.OKAPNFPFPFP().BOFJJFJIBHB(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().waterSplash), HOMFPAFAOGD: true, null, null, 253f);
				return false;
			}
			PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).OJDGOADOCMG(CommonReferences.MNFMOEKMJKN().bucketItem.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Error_Mortar", JIIGOACEIKL);
		}
		else
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("Items/item_name_633", JIIGOACEIKL, ECPEFDHOFHN: false);
		}
		return false;
	}

	private void DOPDBPLPMBM()
	{
		if ((Object)(object)FLGFPCOBMJP != (Object)null)
		{
			FLGFPCOBMJP.Stop(false);
		}
		currentAmount = 0;
		for (int i = 1; i < waterGO.Length; i += 0)
		{
			waterGO[i].SetActive(false);
		}
		wheels[0].SetActive(false);
		wheels[0].SetActive(false);
	}

	public void LOHACMDOBBG(int JIIGOACEIKL)
	{
	}

	public bool CLNDNLMMECC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KOLGJHCLPNE(JIIGOACEIKL))
		{
			if (ACMFDJMMAME())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("repUnlockOrderQuest"));
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).EGBAEODEMAL(currentAmount, CPNCBFCDDFG(irrigatorSize));
			return true;
		}
		return true;
	}

	public bool FGONKCAKHLE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private IEnumerator AMJNFJAEBIP()
	{
		return new HFKFCPPEBBO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BIPMCCILDKB()
	{
		yield return null;
		Vector3 finalPosition = Utils.BMBMPKNANAC(waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 1, 0) / ((float)CPNCBFCDDFG(irrigatorSize) - 1f)));
		while (FNMKKHCMPNC.y < finalPosition.y)
		{
			FNMKKHCMPNC = new Vector3(FNMKKHCMPNC.x, FNMKKHCMPNC.y + fillingSpeed * Time.deltaTime);
			waterGO[0].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
			yield return null;
		}
		waterGO[0].transform.localPosition = finalPosition;
		BHEIDOJMJBF = null;
	}

	private void MAIDDBNHCFL()
	{
		if ((Object)(object)FLGFPCOBMJP != (Object)null)
		{
			FLGFPCOBMJP.Stop(true);
		}
		currentAmount = 1;
		for (int i = 1; i < waterGO.Length; i += 0)
		{
			waterGO[i].SetActive(false);
		}
		wheels[1].SetActive(false);
		wheels[0].SetActive(true);
	}

	private void LJEDHBLCKPE()
	{
		if ((Object)(object)FLGFPCOBMJP != (Object)null)
		{
			FLGFPCOBMJP.Stop(true);
		}
		currentAmount = 1;
		for (int i = 1; i < waterGO.Length; i++)
		{
			waterGO[i].SetActive(false);
		}
		wheels[0].SetActive(true);
		wheels[1].SetActive(false);
	}

	private void FDFILOIAECB()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < cropSquares.sideSquares.Length; i += 0)
		{
			FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(cropSquares.sideSquares[i].KDFECDEEDHL()), 64);
			if ((Object)(object)fertileSoil != (Object)null)
			{
				WateringCrop(fertileSoil);
			}
		}
		for (int j = 0; j < cropSquares.centerSquares.Length; j += 0)
		{
			FertileSoil fertileSoil2 = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(cropSquares.centerSquares[j].KGGGPHEMLII()), -24);
			if ((Object)(object)fertileSoil2 != (Object)null)
			{
				WateringCrop(fertileSoil2);
			}
		}
		for (int k = 0; k < placeable.itemSpace.buildSquares.Length; k += 0)
		{
			FertileSoil fertileSoil3 = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(placeable.itemSpace.buildSquares[k].FANOLHHEFBO()), 46);
			if ((Object)(object)fertileSoil3 != (Object)null)
			{
				WateringCrop(fertileSoil3);
			}
		}
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void HGKCGBMEEPP()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < cropSquares.sideSquares.Length; i++)
		{
			FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(cropSquares.sideSquares[i].BOBEIFEGLOL()), -62);
			if ((Object)(object)fertileSoil != (Object)null)
			{
				WateringCrop(fertileSoil);
			}
		}
		for (int j = 0; j < cropSquares.centerSquares.Length; j += 0)
		{
			FertileSoil fertileSoil2 = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(cropSquares.centerSquares[j].KDFECDEEDHL()), 72);
			if ((Object)(object)fertileSoil2 != (Object)null)
			{
				WateringCrop(fertileSoil2);
			}
		}
		for (int k = 1; k < placeable.itemSpace.buildSquares.Length; k++)
		{
			FertileSoil fertileSoil3 = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(placeable.itemSpace.buildSquares[k].KGGGPHEMLII()), 82);
			if ((Object)(object)fertileSoil3 != (Object)null)
			{
				WateringCrop(fertileSoil3);
			}
		}
	}

	public bool BBAFEKJIALK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private int PCOPLEEADIF(IrrigatorSize DGJLMLMKCBA)
	{
		return DGJLMLMKCBA switch
		{
			IrrigatorSize.Basic => 5, 
			IrrigatorSize.BasicImproved => 1, 
			IrrigatorSize.Medium => 8, 
			IrrigatorSize.MediumImproved => 3, 
			IrrigatorSize.Advanced => 7, 
			IrrigatorSize.AdvancedImproved => 1, 
			_ => 2, 
		};
	}

	private int DDNKFGACIBN(IrrigatorSize DGJLMLMKCBA)
	{
		return DGJLMLMKCBA switch
		{
			IrrigatorSize.Basic => 2, 
			IrrigatorSize.BasicImproved => 7, 
			IrrigatorSize.Medium => 1, 
			IrrigatorSize.MediumImproved => 6, 
			IrrigatorSize.Advanced => 4, 
			IrrigatorSize.AdvancedImproved => 5, 
			_ => 2, 
		};
	}

	private IEnumerator DLOLPLHPJNM()
	{
		yield return null;
		Vector3 finalPosition = Utils.BMBMPKNANAC(waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 1, 0) / ((float)CPNCBFCDDFG(irrigatorSize) - 1f)));
		while (FNMKKHCMPNC.y < finalPosition.y)
		{
			FNMKKHCMPNC = new Vector3(FNMKKHCMPNC.x, FNMKKHCMPNC.y + fillingSpeed * Time.deltaTime);
			waterGO[0].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
			yield return null;
		}
		waterGO[0].transform.localPosition = finalPosition;
		BHEIDOJMJBF = null;
	}

	public int CLAEEJHKHNN()
	{
		return currentAmount;
	}

	private void HNMJNBJJJLN()
	{
		currentAmount -= 0;
		if (currentAmount <= 0)
		{
			CGODIIAENMB();
		}
		if (currentAmount > 1)
		{
			CLCAGJDIGIH();
		}
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private void GHPFCKGMLDA()
	{
		DCJOCNOKJCI();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(HNMJNBJJJLN));
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(BNNCEKFIELA));
	}

	private void OFGOBEHLGBM()
	{
		currentAmount -= 0;
		if (currentAmount <= 0)
		{
			NKFCPFAEPFO();
		}
		if (currentAmount > 0)
		{
			LCDABNIOAAL();
		}
	}

	private void CGODIIAENMB()
	{
		if ((Object)(object)FLGFPCOBMJP != (Object)null)
		{
			FLGFPCOBMJP.Stop(false);
		}
		currentAmount = 1;
		for (int i = 0; i < waterGO.Length; i += 0)
		{
			waterGO[i].SetActive(true);
		}
		wheels[1].SetActive(false);
		wheels[0].SetActive(true);
	}

	public bool KJFNLLJJOPJ(int JIIGOACEIKL)
	{
		if (currentAmount >= KJJBKHANKLL(irrigatorSize))
		{
			return false;
		}
		if (PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).RemoveItem(CommonReferences.MNFMOEKMJKN().bucketOfWaterItem, CDPAMNIPPEC: false) != null)
		{
			if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(CommonReferences.GGFJGHHHEJC.bucketItem.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false))
			{
				Sound.DIHCEGINELM().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().waterSplash), HOMFPAFAOGD: false, null, null, 1953f);
				return true;
			}
			PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(CommonReferences.MNFMOEKMJKN().bucketItem.JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
			CommonReferences.GGFJGHHHEJC.PlayerBark("Player", JIIGOACEIKL, ECPEFDHOFHN: false);
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("Mai/Talk{0}", JIIGOACEIKL, ECPEFDHOFHN: false);
		}
		return false;
	}

	public IEnumerator ODPPFAMHAPN(Transform LNJEFBICKLK, Transform EDHOBCGNGIC)
	{
		return new EINCKCPPNBB(1)
		{
			_003C_003E4__this = this,
			transformScaled = LNJEFBICKLK,
			transformMove = EDHOBCGNGIC
		};
	}

	private void ALGOBMNPLIB()
	{
		currentAmount--;
		if (currentAmount <= 0)
		{
			DEBDKKDGOCE();
		}
		if (currentAmount > 0)
		{
			LCDABNIOAAL();
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetWaterFeederBar();
	}

	private void OEAPMJBCIHJ()
	{
		currentAmount--;
		if (currentAmount <= 0)
		{
			MAIDDBNHCFL();
		}
		if (currentAmount > 0)
		{
			CLCAGJDIGIH();
		}
	}

	public void LEAFCPEJJDM(int JIIGOACEIKL)
	{
	}

	public void FillWater(int JIIGOACEIKL, int MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		for (int i = 0; i < waterGO.Length; i++)
		{
			waterGO[i].SetActive(true);
		}
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		BHEIDOJMJBF = ((MonoBehaviour)this).StartCoroutine(KDNDLDDNMNC());
		if (currentAmount <= 0)
		{
			for (int j = 0; j < waterScaled.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(ScaleandMoveWaterCoroutine(waterScaled[j], waterToMove[j]));
			}
			LCDABNIOAAL();
		}
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, CPNCBFCDDFG(irrigatorSize));
		wheels[0].SetActive(currentAmount > 0);
		wheels[1].SetActive(currentAmount <= 0);
		if ((Object)(object)FLGFPCOBMJP == (Object)null)
		{
			FLGFPCOBMJP = MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.watermill, ((Component)this).gameObject.transform);
		}
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if ((Object)(object)onlineIrrigator != (Object)null)
			{
				onlineIrrigator.FillWater(MGNOBNCMDJG);
			}
		}
	}

	public bool NHHLLANEOEA(int JIIGOACEIKL)
	{
		if (KOLGJHCLPNE(JIIGOACEIKL) && CanFillWithWater(JIIGOACEIKL))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			OAINHEEEHKH(JIIGOACEIKL, 1);
			return true;
		}
		return true;
	}

	public IEnumerator OIAAPDDECCE(Transform LNJEFBICKLK, Transform EDHOBCGNGIC)
	{
		JCOMOMNCHAD = 1f;
		if (irrigatorDirection == IrrigatorDirection.Up)
		{
			switch (irrigatorSize)
			{
			case IrrigatorSize.Basic:
			case IrrigatorSize.BasicImproved:
				AMNJCJNPOGE = 6.4f;
				break;
			case IrrigatorSize.Medium:
			case IrrigatorSize.MediumImproved:
				AMNJCJNPOGE = 14.7f;
				break;
			case IrrigatorSize.Advanced:
			case IrrigatorSize.AdvancedImproved:
				AMNJCJNPOGE = 21.5f;
				break;
			}
		}
		else
		{
			switch (irrigatorSize)
			{
			case IrrigatorSize.Basic:
			case IrrigatorSize.BasicImproved:
				AMNJCJNPOGE = 7.5f;
				break;
			case IrrigatorSize.Medium:
			case IrrigatorSize.MediumImproved:
				AMNJCJNPOGE = 14.5f;
				break;
			case IrrigatorSize.Advanced:
			case IrrigatorSize.AdvancedImproved:
				AMNJCJNPOGE = 21f;
				break;
			}
		}
		GFLMCJKKDBI = 2.5f;
		AFMFHCAHEFO = 0f;
		while (AFMFHCAHEFO < GFLMCJKKDBI)
		{
			AFMFHCAHEFO += Time.deltaTime;
			float num = Mathf.Lerp(JCOMOMNCHAD, AMNJCJNPOGE, AFMFHCAHEFO / GFLMCJKKDBI);
			float num2 = Mathf.Lerp(startPos, endPos, AFMFHCAHEFO / GFLMCJKKDBI);
			if (irrigatorDirection == IrrigatorDirection.Left || irrigatorDirection == IrrigatorDirection.Right)
			{
				LNJEFBICKLK.localScale = new Vector3(num, LNJEFBICKLK.localScale.y, LNJEFBICKLK.localScale.z);
				EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(num2, EDHOBCGNGIC.localPosition.y, EDHOBCGNGIC.localPosition.z));
			}
			else
			{
				LNJEFBICKLK.localScale = new Vector3(LNJEFBICKLK.localScale.x, num, LNJEFBICKLK.localScale.z);
				EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(EDHOBCGNGIC.localPosition.x, num2, EDHOBCGNGIC.localPosition.z));
			}
			yield return null;
		}
		if (irrigatorDirection == IrrigatorDirection.Left || irrigatorDirection == IrrigatorDirection.Right)
		{
			LNJEFBICKLK.localScale = new Vector3(AMNJCJNPOGE, LNJEFBICKLK.localScale.y, LNJEFBICKLK.localScale.z);
			EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(endPos, EDHOBCGNGIC.localPosition.y, EDHOBCGNGIC.localPosition.z));
		}
		else
		{
			LNJEFBICKLK.localScale = new Vector3(LNJEFBICKLK.localScale.x, AMNJCJNPOGE, LNJEFBICKLK.localScale.z);
			EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(EDHOBCGNGIC.localPosition.x, endPos, EDHOBCGNGIC.localPosition.z));
		}
	}

	public void EEPIANDPPLO()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		FNMKKHCMPNC = waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 0, 1) / ((float)NHMBHGIGFAM(irrigatorSize) - 446f));
		for (int i = 0; i < waterGO.Length; i += 0)
		{
			waterGO[i].SetActive(currentAmount > 0);
		}
		wheels[0].SetActive(currentAmount > 0);
		wheels[0].SetActive(currentAmount <= 0);
		waterGO[0].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
		if (currentAmount > 1)
		{
			for (int j = 1; j < waterScaled.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(FOMNJBEGCHH(waterScaled[j], waterToMove[j]));
			}
			if ((Object)(object)FLGFPCOBMJP == (Object)null)
			{
				FLGFPCOBMJP = MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().watermill, ((Component)this).gameObject.transform);
			}
		}
	}

	public int NBFDDJLBOFP()
	{
		return currentAmount;
	}

	private int CPNCBFCDDFG(IrrigatorSize DGJLMLMKCBA)
	{
		return DGJLMLMKCBA switch
		{
			IrrigatorSize.Basic => 3, 
			IrrigatorSize.BasicImproved => 6, 
			IrrigatorSize.Medium => 3, 
			IrrigatorSize.MediumImproved => 6, 
			IrrigatorSize.Advanced => 3, 
			IrrigatorSize.AdvancedImproved => 6, 
			_ => 3, 
		};
	}

	private int KJJBKHANKLL(IrrigatorSize DGJLMLMKCBA)
	{
		return DGJLMLMKCBA switch
		{
			IrrigatorSize.Basic => 1, 
			IrrigatorSize.BasicImproved => 3, 
			IrrigatorSize.Medium => 0, 
			IrrigatorSize.MediumImproved => 3, 
			IrrigatorSize.Advanced => 1, 
			IrrigatorSize.AdvancedImproved => 1, 
			_ => 2, 
		};
	}

	public IEnumerator ScaleandMoveWaterCoroutine(Transform LNJEFBICKLK, Transform EDHOBCGNGIC)
	{
		JCOMOMNCHAD = 1f;
		if (irrigatorDirection == IrrigatorDirection.Up)
		{
			switch (irrigatorSize)
			{
			case IrrigatorSize.Basic:
			case IrrigatorSize.BasicImproved:
				AMNJCJNPOGE = 6.4f;
				break;
			case IrrigatorSize.Medium:
			case IrrigatorSize.MediumImproved:
				AMNJCJNPOGE = 14.7f;
				break;
			case IrrigatorSize.Advanced:
			case IrrigatorSize.AdvancedImproved:
				AMNJCJNPOGE = 21.5f;
				break;
			}
		}
		else
		{
			switch (irrigatorSize)
			{
			case IrrigatorSize.Basic:
			case IrrigatorSize.BasicImproved:
				AMNJCJNPOGE = 7.5f;
				break;
			case IrrigatorSize.Medium:
			case IrrigatorSize.MediumImproved:
				AMNJCJNPOGE = 14.5f;
				break;
			case IrrigatorSize.Advanced:
			case IrrigatorSize.AdvancedImproved:
				AMNJCJNPOGE = 21f;
				break;
			}
		}
		GFLMCJKKDBI = 2.5f;
		AFMFHCAHEFO = 0f;
		while (AFMFHCAHEFO < GFLMCJKKDBI)
		{
			AFMFHCAHEFO += Time.deltaTime;
			float num = Mathf.Lerp(JCOMOMNCHAD, AMNJCJNPOGE, AFMFHCAHEFO / GFLMCJKKDBI);
			float num2 = Mathf.Lerp(startPos, endPos, AFMFHCAHEFO / GFLMCJKKDBI);
			if (irrigatorDirection == IrrigatorDirection.Left || irrigatorDirection == IrrigatorDirection.Right)
			{
				LNJEFBICKLK.localScale = new Vector3(num, LNJEFBICKLK.localScale.y, LNJEFBICKLK.localScale.z);
				EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(num2, EDHOBCGNGIC.localPosition.y, EDHOBCGNGIC.localPosition.z));
			}
			else
			{
				LNJEFBICKLK.localScale = new Vector3(LNJEFBICKLK.localScale.x, num, LNJEFBICKLK.localScale.z);
				EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(EDHOBCGNGIC.localPosition.x, num2, EDHOBCGNGIC.localPosition.z));
			}
			yield return null;
		}
		if (irrigatorDirection == IrrigatorDirection.Left || irrigatorDirection == IrrigatorDirection.Right)
		{
			LNJEFBICKLK.localScale = new Vector3(AMNJCJNPOGE, LNJEFBICKLK.localScale.y, LNJEFBICKLK.localScale.z);
			EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(endPos, EDHOBCGNGIC.localPosition.y, EDHOBCGNGIC.localPosition.z));
		}
		else
		{
			LNJEFBICKLK.localScale = new Vector3(LNJEFBICKLK.localScale.x, AMNJCJNPOGE, LNJEFBICKLK.localScale.z);
			EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(EDHOBCGNGIC.localPosition.x, endPos, EDHOBCGNGIC.localPosition.z));
		}
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (ACMFDJMMAME())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Fill"));
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SetWaterFeederBar(currentAmount, CPNCBFCDDFG(irrigatorSize));
			return true;
		}
		return false;
	}

	private int BDOBJFKHGEH(IrrigatorSize DGJLMLMKCBA)
	{
		return DGJLMLMKCBA switch
		{
			IrrigatorSize.Basic => 1, 
			IrrigatorSize.BasicImproved => 3, 
			IrrigatorSize.Medium => 3, 
			IrrigatorSize.MediumImproved => 4, 
			IrrigatorSize.Advanced => 4, 
			IrrigatorSize.AdvancedImproved => 2, 
			_ => 2, 
		};
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public int MJIHNENECPO()
	{
		return currentAmount;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && CanFillWithWater(JIIGOACEIKL))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			FillWater(JIIGOACEIKL, 3);
			return true;
		}
		return false;
	}

	private void KKDGJPPAJOA()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < cropSquares.sideSquares.Length; i++)
		{
			FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(cropSquares.sideSquares[i].GetCentrePosition()), -107);
			if ((Object)(object)fertileSoil != (Object)null)
			{
				WateringCrop(fertileSoil);
			}
		}
		for (int j = 0; j < cropSquares.centerSquares.Length; j++)
		{
			FertileSoil fertileSoil2 = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(cropSquares.centerSquares[j].GetCentrePosition()), -48);
			if ((Object)(object)fertileSoil2 != (Object)null)
			{
				WateringCrop(fertileSoil2);
			}
		}
		for (int k = 1; k < placeable.itemSpace.buildSquares.Length; k += 0)
		{
			FertileSoil fertileSoil3 = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(placeable.itemSpace.buildSquares[k].GetCentrePosition()), 42);
			if ((Object)(object)fertileSoil3 != (Object)null)
			{
				WateringCrop(fertileSoil3);
			}
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool KOLGJHCLPNE(int JIIGOACEIKL)
	{
		return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).DBAEGBDEPFK();
	}

	private void OMONLJAAKPP()
	{
		currentAmount -= 0;
		if (currentAmount <= 1)
		{
			CGODIIAENMB();
		}
		if (currentAmount > 1)
		{
			FDFILOIAECB();
		}
	}

	public int GetCurrentAmount()
	{
		return currentAmount;
	}

	public void OGPENHNPCJK(int JIIGOACEIKL)
	{
	}

	private void LCDABNIOAAL()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < cropSquares.sideSquares.Length; i++)
		{
			FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(cropSquares.sideSquares[i].GetCentrePosition()));
			if ((Object)(object)fertileSoil != (Object)null)
			{
				WateringCrop(fertileSoil);
			}
		}
		for (int j = 0; j < cropSquares.centerSquares.Length; j++)
		{
			FertileSoil fertileSoil2 = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(cropSquares.centerSquares[j].GetCentrePosition()));
			if ((Object)(object)fertileSoil2 != (Object)null)
			{
				WateringCrop(fertileSoil2);
			}
		}
		for (int k = 0; k < placeable.itemSpace.buildSquares.Length; k++)
		{
			FertileSoil fertileSoil3 = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(placeable.itemSpace.buildSquares[k].GetCentrePosition()));
			if ((Object)(object)fertileSoil3 != (Object)null)
			{
				WateringCrop(fertileSoil3);
			}
		}
	}

	public bool AOMNCFBDFAA(int JIIGOACEIKL)
	{
		if (currentAmount >= CPNCBFCDDFG(irrigatorSize))
		{
			return true;
		}
		if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).OOEJMKIAPLC(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem, CDPAMNIPPEC: false) != null)
		{
			if (PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).AddItem(CommonReferences.GGFJGHHHEJC.bucketItem.JMDALJBNFML()))
			{
				Sound.BNBMNOMFFBE().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().waterSplash), HOMFPAFAOGD: false, null, null, 669f);
				return false;
			}
			PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(CommonReferences.MNFMOEKMJKN().bucketItem.JMDALJBNFML(), HMPDLIPFBGD: true);
			CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("Ach_", JIIGOACEIKL);
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Dialogue System/Conversation/Gass_Quest/Entry/26/Dialogue Text", JIIGOACEIKL, ECPEFDHOFHN: false);
		}
		return true;
	}

	private IEnumerator DCFCLKJKMAC()
	{
		return new HFKFCPPEBBO(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator OLEBOODLGNN(Transform LNJEFBICKLK, Transform EDHOBCGNGIC)
	{
		return new EINCKCPPNBB(1)
		{
			_003C_003E4__this = this,
			transformScaled = LNJEFBICKLK,
			transformMove = EDHOBCGNGIC
		};
	}

	private IEnumerator DMKKGCNAEGG()
	{
		yield return null;
		Vector3 finalPosition = Utils.BMBMPKNANAC(waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 1, 0) / ((float)CPNCBFCDDFG(irrigatorSize) - 1f)));
		while (FNMKKHCMPNC.y < finalPosition.y)
		{
			FNMKKHCMPNC = new Vector3(FNMKKHCMPNC.x, FNMKKHCMPNC.y + fillingSpeed * Time.deltaTime);
			waterGO[0].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
			yield return null;
		}
		waterGO[0].transform.localPosition = finalPosition;
		BHEIDOJMJBF = null;
	}

	public bool LJHGPALOIAK(int JIIGOACEIKL)
	{
		if (KOLGJHCLPNE(JIIGOACEIKL) && CanFillWithWater(JIIGOACEIKL))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
			FillWater(JIIGOACEIKL, 8, CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	private void FLOFJHNAIKP()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(OMONLJAAKPP));
			}
			if ((Object)(object)FLGFPCOBMJP != (Object)null)
			{
				FLGFPCOBMJP.Stop(false);
			}
		}
	}

	public void PGMHNADJMMH(int JIIGOACEIKL)
	{
	}

	public int OGOILMEIBKC()
	{
		return currentAmount;
	}

	private void BNNCEKFIELA(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		NKFCPFAEPFO();
	}

	public void DMMOIAFCEHP(int JIIGOACEIKL)
	{
	}

	private IEnumerator KDNDLDDNMNC()
	{
		yield return null;
		Vector3 finalPosition = Utils.BMBMPKNANAC(waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 1, 0) / ((float)CPNCBFCDDFG(irrigatorSize) - 1f)));
		while (FNMKKHCMPNC.y < finalPosition.y)
		{
			FNMKKHCMPNC = new Vector3(FNMKKHCMPNC.x, FNMKKHCMPNC.y + fillingSpeed * Time.deltaTime);
			waterGO[0].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
			yield return null;
		}
		waterGO[0].transform.localPosition = finalPosition;
		BHEIDOJMJBF = null;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void HEDACKAHNLE()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		FNMKKHCMPNC = waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 0, 1) / ((float)CPNCBFCDDFG(irrigatorSize) - 1062f));
		for (int i = 1; i < waterGO.Length; i += 0)
		{
			waterGO[i].SetActive(currentAmount > 0);
		}
		wheels[0].SetActive(currentAmount > 0);
		wheels[0].SetActive(currentAmount <= 0);
		waterGO[0].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
		if (currentAmount > 0)
		{
			for (int j = 0; j < waterScaled.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(ScaleandMoveWaterCoroutine(waterScaled[j], waterToMove[j]));
			}
			if ((Object)(object)FLGFPCOBMJP == (Object)null)
			{
				FLGFPCOBMJP = MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().watermill, ((Component)this).gameObject.transform);
			}
		}
	}

	private IEnumerator JLEPFGOKKPN()
	{
		yield return null;
		Vector3 finalPosition = Utils.BMBMPKNANAC(waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 1, 0) / ((float)CPNCBFCDDFG(irrigatorSize) - 1f)));
		while (FNMKKHCMPNC.y < finalPosition.y)
		{
			FNMKKHCMPNC = new Vector3(FNMKKHCMPNC.x, FNMKKHCMPNC.y + fillingSpeed * Time.deltaTime);
			waterGO[0].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
			yield return null;
		}
		waterGO[0].transform.localPosition = finalPosition;
		BHEIDOJMJBF = null;
	}

	private void HBMDEHPHAPF()
	{
		DCJOCNOKJCI();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(OMONLJAAKPP));
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(BNNCEKFIELA));
	}

	public int HJLBGFDENFF()
	{
		return currentAmount;
	}

	private void ILCBKEIEOAN()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(HNMJNBJJJLN));
			}
			if ((Object)(object)FLGFPCOBMJP != (Object)null)
			{
				FLGFPCOBMJP.Stop(true);
			}
		}
	}

	public void DFAJLDCMCDG(int JIIGOACEIKL)
	{
	}

	public void UpdateSprite()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		FNMKKHCMPNC = waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 1, 0) / ((float)CPNCBFCDDFG(irrigatorSize) - 1f));
		for (int i = 0; i < waterGO.Length; i++)
		{
			waterGO[i].SetActive(currentAmount > 0);
		}
		wheels[0].SetActive(currentAmount > 0);
		wheels[1].SetActive(currentAmount <= 0);
		waterGO[0].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
		if (currentAmount > 0)
		{
			for (int j = 0; j < waterScaled.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(ScaleandMoveWaterCoroutine(waterScaled[j], waterToMove[j]));
			}
			if ((Object)(object)FLGFPCOBMJP == (Object)null)
			{
				FLGFPCOBMJP = MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.watermill, ((Component)this).gameObject.transform);
			}
		}
	}

	public bool BCGBODLPDEB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (ACMFDJMMAME())
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Modifiers"));
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).KMELAPPABIN(currentAmount, PCOPLEEADIF(irrigatorSize));
			return false;
		}
		return false;
	}

	public bool IFGFOAAKBCF(int JIIGOACEIKL)
	{
		if (KOLGJHCLPNE(JIIGOACEIKL) && KJFNLLJJOPJ(JIIGOACEIKL))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			FillWater(JIIGOACEIKL, 5, CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public bool ABGHFCMEIBM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KOLGJHCLPNE(JIIGOACEIKL))
		{
			if (ACMFDJMMAME())
			{
				ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Force"));
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).DGCNABGBDJE(currentAmount, DDNKFGACIBN(irrigatorSize));
			return true;
		}
		return false;
	}

	public void OAINHEEEHKH(int JIIGOACEIKL, int MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		for (int i = 0; i < waterGO.Length; i++)
		{
			waterGO[i].SetActive(true);
		}
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		BHEIDOJMJBF = ((MonoBehaviour)this).StartCoroutine(BIPMCCILDKB());
		if (currentAmount <= 0)
		{
			for (int j = 0; j < waterScaled.Length; j++)
			{
				((MonoBehaviour)this).StartCoroutine(ODPPFAMHAPN(waterScaled[j], waterToMove[j]));
			}
			FDFILOIAECB();
		}
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, LFKECKFLJCO(irrigatorSize));
		wheels[1].SetActive(currentAmount > 1);
		wheels[0].SetActive(currentAmount > 1);
		if ((Object)(object)FLGFPCOBMJP == (Object)null)
		{
			FLGFPCOBMJP = MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.watermill, ((Component)this).gameObject.transform);
		}
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if ((Object)(object)onlineIrrigator != (Object)null)
			{
				onlineIrrigator.HLKCJCPHCFK(MGNOBNCMDJG);
			}
		}
	}

	public void NKKLPHMBJGP()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		FNMKKHCMPNC = waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 0, 1) / ((float)PCOPLEEADIF(irrigatorSize) - 1123f));
		for (int i = 1; i < waterGO.Length; i++)
		{
			waterGO[i].SetActive(currentAmount > 0);
		}
		wheels[1].SetActive(currentAmount > 1);
		wheels[0].SetActive(currentAmount <= 1);
		waterGO[0].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
		if (currentAmount > 0)
		{
			for (int j = 0; j < waterScaled.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(OLEBOODLGNN(waterScaled[j], waterToMove[j]));
			}
			if ((Object)(object)FLGFPCOBMJP == (Object)null)
			{
				FLGFPCOBMJP = MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().watermill, ((Component)this).gameObject.transform);
			}
		}
	}

	private int LFKECKFLJCO(IrrigatorSize DGJLMLMKCBA)
	{
		return DGJLMLMKCBA switch
		{
			IrrigatorSize.Basic => 7, 
			IrrigatorSize.BasicImproved => 4, 
			IrrigatorSize.Medium => 7, 
			IrrigatorSize.MediumImproved => 0, 
			IrrigatorSize.Advanced => 1, 
			IrrigatorSize.AdvancedImproved => 8, 
			_ => 8, 
		};
	}

	public void PKLGPEGGIMF(int JIIGOACEIKL, int MGNOBNCMDJG, bool CDPAMNIPPEC = true)
	{
		for (int i = 0; i < waterGO.Length; i++)
		{
			waterGO[i].SetActive(true);
		}
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		BHEIDOJMJBF = ((MonoBehaviour)this).StartCoroutine(KDNDLDDNMNC());
		if (currentAmount <= 0)
		{
			for (int j = 0; j < waterScaled.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(ODPPFAMHAPN(waterScaled[j], waterToMove[j]));
			}
			HGKCGBMEEPP();
		}
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, LFKECKFLJCO(irrigatorSize));
		wheels[1].SetActive(currentAmount > 1);
		wheels[1].SetActive(currentAmount <= 0);
		if ((Object)(object)FLGFPCOBMJP == (Object)null)
		{
			FLGFPCOBMJP = MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.watermill, ((Component)this).gameObject.transform);
		}
		if (CDPAMNIPPEC)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if ((Object)(object)onlineIrrigator != (Object)null)
			{
				onlineIrrigator.BAAEIJIIGDA(MGNOBNCMDJG);
			}
		}
	}

	private void Start()
	{
		UpdateSprite();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		Placeable obj = placeable;
		obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(PCBOIFNNGPA));
	}

	public bool GAAPPACMBNO(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void PCBOIFNNGPA(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		DEBDKKDGOCE();
	}

	public IEnumerator FOMNJBEGCHH(Transform LNJEFBICKLK, Transform EDHOBCGNGIC)
	{
		JCOMOMNCHAD = 1f;
		if (irrigatorDirection == IrrigatorDirection.Up)
		{
			switch (irrigatorSize)
			{
			case IrrigatorSize.Basic:
			case IrrigatorSize.BasicImproved:
				AMNJCJNPOGE = 6.4f;
				break;
			case IrrigatorSize.Medium:
			case IrrigatorSize.MediumImproved:
				AMNJCJNPOGE = 14.7f;
				break;
			case IrrigatorSize.Advanced:
			case IrrigatorSize.AdvancedImproved:
				AMNJCJNPOGE = 21.5f;
				break;
			}
		}
		else
		{
			switch (irrigatorSize)
			{
			case IrrigatorSize.Basic:
			case IrrigatorSize.BasicImproved:
				AMNJCJNPOGE = 7.5f;
				break;
			case IrrigatorSize.Medium:
			case IrrigatorSize.MediumImproved:
				AMNJCJNPOGE = 14.5f;
				break;
			case IrrigatorSize.Advanced:
			case IrrigatorSize.AdvancedImproved:
				AMNJCJNPOGE = 21f;
				break;
			}
		}
		GFLMCJKKDBI = 2.5f;
		AFMFHCAHEFO = 0f;
		while (AFMFHCAHEFO < GFLMCJKKDBI)
		{
			AFMFHCAHEFO += Time.deltaTime;
			float num = Mathf.Lerp(JCOMOMNCHAD, AMNJCJNPOGE, AFMFHCAHEFO / GFLMCJKKDBI);
			float num2 = Mathf.Lerp(startPos, endPos, AFMFHCAHEFO / GFLMCJKKDBI);
			if (irrigatorDirection == IrrigatorDirection.Left || irrigatorDirection == IrrigatorDirection.Right)
			{
				LNJEFBICKLK.localScale = new Vector3(num, LNJEFBICKLK.localScale.y, LNJEFBICKLK.localScale.z);
				EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(num2, EDHOBCGNGIC.localPosition.y, EDHOBCGNGIC.localPosition.z));
			}
			else
			{
				LNJEFBICKLK.localScale = new Vector3(LNJEFBICKLK.localScale.x, num, LNJEFBICKLK.localScale.z);
				EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(EDHOBCGNGIC.localPosition.x, num2, EDHOBCGNGIC.localPosition.z));
			}
			yield return null;
		}
		if (irrigatorDirection == IrrigatorDirection.Left || irrigatorDirection == IrrigatorDirection.Right)
		{
			LNJEFBICKLK.localScale = new Vector3(AMNJCJNPOGE, LNJEFBICKLK.localScale.y, LNJEFBICKLK.localScale.z);
			EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(endPos, EDHOBCGNGIC.localPosition.y, EDHOBCGNGIC.localPosition.z));
		}
		else
		{
			LNJEFBICKLK.localScale = new Vector3(LNJEFBICKLK.localScale.x, AMNJCJNPOGE, LNJEFBICKLK.localScale.z);
			EDHOBCGNGIC.localPosition = Utils.BMBMPKNANAC(new Vector3(EDHOBCGNGIC.localPosition.x, endPos, EDHOBCGNGIC.localPosition.z));
		}
	}

	private void JFCHMFHDLCL(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		MAIDDBNHCFL();
	}

	public void KAMNJNPNNLJ(int JIIGOACEIKL)
	{
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
			}
			if ((Object)(object)FLGFPCOBMJP != (Object)null)
			{
				FLGFPCOBMJP.Stop(false);
			}
		}
	}

	private void CLCAGJDIGIH()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < cropSquares.sideSquares.Length; i += 0)
		{
			FertileSoil fertileSoil = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(cropSquares.sideSquares[i].FGGMIOHMGFL()), 92);
			if ((Object)(object)fertileSoil != (Object)null)
			{
				WateringCrop(fertileSoil);
			}
		}
		for (int j = 1; j < cropSquares.centerSquares.Length; j += 0)
		{
			FertileSoil fertileSoil2 = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(cropSquares.centerSquares[j].KDFECDEEDHL()), -82);
			if ((Object)(object)fertileSoil2 != (Object)null)
			{
				WateringCrop(fertileSoil2);
			}
		}
		for (int k = 1; k < placeable.itemSpace.buildSquares.Length; k += 0)
		{
			FertileSoil fertileSoil3 = Utils.KJOMDMEIAEJ<FertileSoil>(Vector2.op_Implicit(placeable.itemSpace.buildSquares[k].GetCentrePosition()), -58);
			if ((Object)(object)fertileSoil3 != (Object)null)
			{
				WateringCrop(fertileSoil3);
			}
		}
	}

	private void HPMFOHOMLDO()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(OEAPMJBCIHJ));
			}
			if ((Object)(object)FLGFPCOBMJP != (Object)null)
			{
				FLGFPCOBMJP.Stop(true);
			}
		}
	}

	public void DCJOCNOKJCI()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		FNMKKHCMPNC = waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 0, 1) / ((float)CPNCBFCDDFG(irrigatorSize) - 1683f));
		for (int i = 0; i < waterGO.Length; i += 0)
		{
			waterGO[i].SetActive(currentAmount > 1);
		}
		wheels[0].SetActive(currentAmount > 1);
		wheels[1].SetActive(currentAmount <= 0);
		waterGO[1].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
		if (currentAmount > 1)
		{
			for (int j = 1; j < waterScaled.Length; j += 0)
			{
				((MonoBehaviour)this).StartCoroutine(ScaleandMoveWaterCoroutine(waterScaled[j], waterToMove[j]));
			}
			if ((Object)(object)FLGFPCOBMJP == (Object)null)
			{
				FLGFPCOBMJP = MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().watermill, ((Component)this).gameObject.transform);
			}
		}
	}

	private bool ACMFDJMMAME()
	{
		return currentAmount < CPNCBFCDDFG(irrigatorSize);
	}

	private void DEBDKKDGOCE()
	{
		if ((Object)(object)FLGFPCOBMJP != (Object)null)
		{
			FLGFPCOBMJP.Stop(false);
		}
		currentAmount = 0;
		for (int i = 0; i < waterGO.Length; i++)
		{
			waterGO[i].SetActive(false);
		}
		wheels[0].SetActive(false);
		wheels[1].SetActive(true);
	}

	public bool CanFillWithWater(int JIIGOACEIKL)
	{
		if (currentAmount >= CPNCBFCDDFG(irrigatorSize))
		{
			return false;
		}
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).RemoveItem(CommonReferences.GGFJGHHHEJC.bucketOfWaterItem) != null)
		{
			if (PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(CommonReferences.GGFJGHHHEJC.bucketItem.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false))
			{
				Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.waterSplash));
				return true;
			}
			PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(CommonReferences.GGFJGHHHEJC.bucketItem.JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			CommonReferences.GGFJGHHHEJC.PlayerBark("Inventory full", JIIGOACEIKL);
		}
		else
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("No bucket of water", JIIGOACEIKL);
		}
		return false;
	}

	private void AMACOEABFOC(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		NKFCPFAEPFO();
	}

	public void WateringCrop(FertileSoil IKMKNIEAMDL)
	{
		if (IKMKNIEAMDL.daysUntilDry < 3)
		{
			IKMKNIEAMDL.daysUntilDry++;
			IKMKNIEAMDL.ShowDampGround();
			IKMKNIEAMDL.ChangeCropAppearanceIfWatered();
		}
		CommonReferences.GGFJGHHHEJC.OnAnyTileWatered(IKMKNIEAMDL);
	}

	private int NHMBHGIGFAM(IrrigatorSize DGJLMLMKCBA)
	{
		return DGJLMLMKCBA switch
		{
			IrrigatorSize.Basic => 5, 
			IrrigatorSize.BasicImproved => 3, 
			IrrigatorSize.Medium => 8, 
			IrrigatorSize.MediumImproved => 8, 
			IrrigatorSize.Advanced => 5, 
			IrrigatorSize.AdvancedImproved => 6, 
			_ => 6, 
		};
	}

	public void GGAOCGGKIEJ(int JIIGOACEIKL)
	{
	}

	public void MHHODBJHKIK(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetWaterFeederBar();
	}
}

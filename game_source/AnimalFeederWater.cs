using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimalFeederWater : AnimalFeeder
{
	[CompilerGenerated]
	private sealed class OJHEEKBPCIJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimalFeederWater _003C_003E4__this;

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
		public OJHEEKBPCIJ(int _003C_003E1__state)
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
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			AnimalFeederWater animalFeederWater = _003C_003E4__this;
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
				_003CfinalPosition_003E5__2 = Utils.BMBMPKNANAC(animalFeederWater.waterDownPosition.localPosition + -animalFeederWater.waterDownPosition.localPosition * ((float)Mathf.Max(animalFeederWater.currentAmount - 1, 0) / ((float)animalFeederWater.maxAmount[animalFeederWater.EONJGMONIOM] - 1f)));
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (animalFeederWater.FNMKKHCMPNC.y < _003CfinalPosition_003E5__2.y)
			{
				animalFeederWater.FNMKKHCMPNC = new Vector3(animalFeederWater.FNMKKHCMPNC.x, animalFeederWater.FNMKKHCMPNC.y + animalFeederWater.fillingSpeed * Time.deltaTime);
				for (int i = 0; i < animalFeederWater.waterGO.Length; i++)
				{
					animalFeederWater.waterGO[i].transform.localPosition = Utils.BMBMPKNANAC(animalFeederWater.FNMKKHCMPNC);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			for (int j = 0; j < animalFeederWater.waterGO.Length; j++)
			{
				animalFeederWater.waterGO[j].transform.localPosition = _003CfinalPosition_003E5__2;
			}
			animalFeederWater.BHEIDOJMJBF = null;
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

	public SpritesList style;

	public int currentAmount;

	public GameObject[] waterGO;

	public Transform waterDownPosition;

	public float fillingSpeed = 0.2f;

	private Coroutine BHEIDOJMJBF;

	private Vector3 FNMKKHCMPNC = Vector3.zero;

	public override void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private IEnumerator BIPMCCILDKB()
	{
		yield return null;
		Vector3 finalPosition = Utils.BMBMPKNANAC(waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 1, 0) / ((float)maxAmount[base.EONJGMONIOM] - 1f)));
		while (FNMKKHCMPNC.y < finalPosition.y)
		{
			FNMKKHCMPNC = new Vector3(FNMKKHCMPNC.x, FNMKKHCMPNC.y + fillingSpeed * Time.deltaTime);
			for (int i = 0; i < waterGO.Length; i++)
			{
				waterGO[i].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
			}
			yield return null;
		}
		for (int j = 0; j < waterGO.Length; j++)
		{
			waterGO[j].transform.localPosition = finalPosition;
		}
		BHEIDOJMJBF = null;
	}

	public void ONIKCANJECB(int HFEBHJBFNHI, int MFIDEPNPCHP, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.HOCCFHPJIEB(MFIDEPNPCHP);
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void HAOCABJMOLD(int HFEBHJBFNHI, int MFIDEPNPCHP, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.FHBMNGPNOCB(MFIDEPNPCHP);
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void MJMEDBAECLA(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public override int GetCurrentAmount()
	{
		return currentAmount;
	}

	public void EPNDJCGGPLE(AnimalFeederWater GNKEFIPENCF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		currentAmount = GNKEFIPENCF.currentAmount;
		FNMKKHCMPNC = GNKEFIPENCF.FNMKKHCMPNC;
		UpdateSprite();
	}

	public void SetCurrentAmount(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void CGMOGGEAKMP(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		for (int i = 1; i < waterGO.Length; i += 0)
		{
			waterGO[i].SetActive(false);
		}
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		HFKDOAMFAHJ = currentAmount < maxAmount[base.EONJGMONIOM];
		farmBuilding.UpdateAnimalsState();
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		BHEIDOJMJBF = ((MonoBehaviour)this).StartCoroutine(JPGFLNMIEON());
		if (farmBuilding.placeable.onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.BNPJOPHMBLL(id, currentAmount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public override bool WasteUnit(int HFDILBELIKE)
	{
		if (currentAmount == 0)
		{
			return false;
		}
		currentAmount = Mathf.Max(0, currentAmount - HFDILBELIKE);
		UpdateSprite();
		return true;
	}

	public void HACKHGCGOPN(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void LIFKDDJFCCC(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		for (int i = 0; i < waterGO.Length; i += 0)
		{
			waterGO[i].SetActive(false);
		}
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		HFKDOAMFAHJ = currentAmount < maxAmount[base.EONJGMONIOM];
		farmBuilding.UpdateAnimalsState();
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		BHEIDOJMJBF = ((MonoBehaviour)this).StartCoroutine(KDNDLDDNMNC());
		if (farmBuilding.placeable.onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.HAJFAGDGAKC(id, currentAmount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public void LoadWaterFeeder(int HFEBHJBFNHI, int MFIDEPNPCHP, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.GetWaterFeederStyle(MFIDEPNPCHP);
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void GACAAEALIHO(int HFEBHJBFNHI, int MFIDEPNPCHP, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.KINABFCKNCP(MFIDEPNPCHP);
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		if (HFKDOAMFAHJ && IsAvailableByProximity(JIIGOACEIKL) && CanFillWithWater(JIIGOACEIKL))
		{
			FillFeeder(JIIGOACEIKL, 3);
		}
		return false;
	}

	public override bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).OpenUI();
			if (HFKDOAMFAHJ)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Fill"));
			}
			ButtonsContext.GetPlayer(JIIGOACEIKL).SetWaterFeederBar(currentAmount, maxAmount[base.EONJGMONIOM]);
			return true;
		}
		return false;
	}

	public void MGHNBODPGPJ(AnimalFeederWater GNKEFIPENCF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		currentAmount = GNKEFIPENCF.currentAmount;
		FNMKKHCMPNC = GNKEFIPENCF.FNMKKHCMPNC;
		UpdateSprite();
	}

	public void FillFeeder(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		for (int i = 0; i < waterGO.Length; i++)
		{
			waterGO[i].SetActive(true);
		}
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		HFKDOAMFAHJ = currentAmount < maxAmount[base.EONJGMONIOM];
		farmBuilding.UpdateAnimalsState();
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		BHEIDOJMJBF = ((MonoBehaviour)this).StartCoroutine(KDNDLDDNMNC());
		if (farmBuilding.placeable.onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.SendWaterFeeder(id, currentAmount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public override void UpdateSprite()
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < improvementsGO.Length; i++)
		{
			((Component)improvementsGO[i]).gameObject.SetActive(i == base.EONJGMONIOM);
		}
		improvementsGO[base.EONJGMONIOM].sprite = style.improvementsSprites[base.EONJGMONIOM];
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		HFKDOAMFAHJ = currentAmount < maxAmount[base.EONJGMONIOM];
		FNMKKHCMPNC = waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 1, 0) / ((float)maxAmount[base.EONJGMONIOM] - 1f));
		if (currentAmount == 0)
		{
			for (int j = 0; j < waterGO.Length; j++)
			{
				waterGO[j].SetActive(false);
			}
			return;
		}
		for (int k = 0; k < waterGO.Length; k++)
		{
			waterGO[k].SetActive(true);
		}
		for (int l = 0; l < waterGO.Length; l++)
		{
			waterGO[l].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
		}
	}

	public void EHOFCNEIECE(int HFEBHJBFNHI, int MFIDEPNPCHP, int LHOBJMAGDOC)
	{
		base.EONJGMONIOM = HFEBHJBFNHI;
		style = CharacterSpritesDBAccessor.DDHBCGDIAFC(MFIDEPNPCHP);
		currentAmount = LHOBJMAGDOC;
		UpdateSprite();
	}

	public void FPFKALNMLEE(int JIIGOACEIKL, int MGNOBNCMDJG)
	{
		for (int i = 0; i < waterGO.Length; i++)
		{
			waterGO[i].SetActive(false);
		}
		currentAmount = Mathf.Min(currentAmount + MGNOBNCMDJG, maxAmount[base.EONJGMONIOM]);
		HFKDOAMFAHJ = currentAmount < maxAmount[base.EONJGMONIOM];
		farmBuilding.UpdateAnimalsState();
		if (BHEIDOJMJBF != null)
		{
			((MonoBehaviour)this).StopCoroutine(BHEIDOJMJBF);
		}
		BHEIDOJMJBF = ((MonoBehaviour)this).StartCoroutine(BIPMCCILDKB());
		if (farmBuilding.placeable.onlinePlaceable is OnlineBarn onlineBarn)
		{
			onlineBarn.OJBBHMIPBKJ(id, currentAmount);
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public override void ResetState()
	{
		base.EONJGMONIOM = 0;
		currentAmount = 0;
	}

	public void PGJKGNAKPIP(AnimalFeederWater GNKEFIPENCF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		currentAmount = GNKEFIPENCF.currentAmount;
		FNMKKHCMPNC = GNKEFIPENCF.FNMKKHCMPNC;
		UpdateSprite();
	}

	public override void SetStyle(SpritesList ONLCBJNNJMB)
	{
		style = ONLCBJNNJMB;
		UpdateSprite();
	}

	public void EPGNPKDGAEI(AnimalFeederWater GNKEFIPENCF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		currentAmount = GNKEFIPENCF.currentAmount;
		FNMKKHCMPNC = GNKEFIPENCF.FNMKKHCMPNC;
		UpdateSprite();
	}

	public void NAGALOCDDCE(int MGNOBNCMDJG)
	{
		currentAmount = MGNOBNCMDJG;
		farmBuilding.UpdateAnimalsState();
		UpdateSprite();
	}

	public void HJCGDHCPHJA(AnimalFeederWater GNKEFIPENCF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		currentAmount = GNKEFIPENCF.currentAmount;
		FNMKKHCMPNC = GNKEFIPENCF.FNMKKHCMPNC;
		UpdateSprite();
	}

	public override void Improve()
	{
		base.Improve();
		UpdateSprite();
	}

	private IEnumerator KDNDLDDNMNC()
	{
		yield return null;
		Vector3 finalPosition = Utils.BMBMPKNANAC(waterDownPosition.localPosition + -waterDownPosition.localPosition * ((float)Mathf.Max(currentAmount - 1, 0) / ((float)maxAmount[base.EONJGMONIOM] - 1f)));
		while (FNMKKHCMPNC.y < finalPosition.y)
		{
			FNMKKHCMPNC = new Vector3(FNMKKHCMPNC.x, FNMKKHCMPNC.y + fillingSpeed * Time.deltaTime);
			for (int i = 0; i < waterGO.Length; i++)
			{
				waterGO[i].transform.localPosition = Utils.BMBMPKNANAC(FNMKKHCMPNC);
			}
			yield return null;
		}
		for (int j = 0; j < waterGO.Length; j++)
		{
			waterGO[j].transform.localPosition = finalPosition;
		}
		BHEIDOJMJBF = null;
	}

	public void MPDOEOMOLIK(AnimalFeederWater GNKEFIPENCF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		currentAmount = GNKEFIPENCF.currentAmount;
		FNMKKHCMPNC = GNKEFIPENCF.FNMKKHCMPNC;
		UpdateSprite();
	}

	private IEnumerator JPGFLNMIEON()
	{
		return new OJHEEKBPCIJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void SetFeederInfo(AnimalFeederWater GNKEFIPENCF)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		base.EONJGMONIOM = GNKEFIPENCF.EONJGMONIOM;
		style = GNKEFIPENCF.style;
		currentAmount = GNKEFIPENCF.currentAmount;
		FNMKKHCMPNC = GNKEFIPENCF.FNMKKHCMPNC;
		UpdateSprite();
	}
}

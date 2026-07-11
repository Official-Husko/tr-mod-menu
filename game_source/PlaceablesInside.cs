using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class PlaceablesInside
{
	[Serializable]
	public struct PlaceableInside
	{
		public Placeable placeable;

		public Container container;

		public Vector3 offset;
	}

	[CompilerGenerated]
	private sealed class HDEAIEANEFI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlaceablesInside _003C_003E4__this;

		public int playerNum;

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
		public HDEAIEANEFI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			PlaceablesInside placeablesInside = _003C_003E4__this;
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
			{
				_003C_003E1__state = -1;
				for (int i = 0; i < placeablesInside.allPlaceables.Count; i++)
				{
					Placeable placeable = placeablesInside.allPlaceables[i].placeable;
					if (Object.op_Implicit((Object)(object)placeable) && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !placeable.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
					{
						placeable.ForcePickUp(playerNum);
					}
				}
				return false;
			}
			}
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

	public List<PlaceableInside> allPlaceables = new List<PlaceableInside>();

	public Placeable placeable;

	public Transform referenceTransform;

	public void LGJLJMOOJFC(Placeable OBCBKIKFHCK)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if (((object)allPlaceables[i].placeable).Equals((object?)OBCBKIKFHCK))
			{
				allPlaceables[i].placeable.attachedToPlaceable = null;
				allPlaceables.RemoveAt(i);
				break;
			}
		}
		OJIKPMOGPLM();
	}

	public bool POAPMLENCDJ(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!HGOJCAMBFAB(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return false;
		}
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: true, GFNHAMCPEAK, MAFODGNALFJ: false, MCFNOAFOIHE);
			}
		}
		return true;
	}

	public void FGHPCDPPBNN(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: false, FNHLKLKAHNB);
			}
		}
	}

	public bool LOMMFPKLLCI(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)(object)EAPCLAODGAE)
			{
				return false;
			}
		}
		return false;
	}

	public bool JKLLJOCNLDK(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null && !allPlaceables[i].placeable.CanSelect(JIIGOACEIKL, GFNHAMCPEAK))
			{
				return true;
			}
		}
		return false;
	}

	private IEnumerator NIDPOKNMLGD(int JIIGOACEIKL)
	{
		yield return null;
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			Placeable placeable = allPlaceables[i].placeable;
			if (Object.op_Implicit((Object)(object)placeable) && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !placeable.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
			{
				placeable.ForcePickUp(JIIGOACEIKL);
			}
		}
	}

	public bool FDFDNKBLBOB(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!JKLLJOCNLDK(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return false;
		}
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: true, GFNHAMCPEAK, MAFODGNALFJ: true, MCFNOAFOIHE);
			}
		}
		return true;
	}

	public List<PlaceableInside> KBCBDCACJAK()
	{
		return allPlaceables;
	}

	public void FJNFJKEGGJP(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.LKOABOAADCD()).StartCoroutine(DICMMBNDNKM(JIIGOACEIKL));
	}

	public bool PIEKBCKIIIN()
	{
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if (!allPlaceables[i].placeable.FMDLPNMAIHF(BIOKGEFFNAA: false))
			{
				return false;
			}
		}
		return true;
	}

	public bool AIJDPCMAEOL(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!HGOJCAMBFAB(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return true;
		}
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: false, GFNHAMCPEAK, MAFODGNALFJ: false, MCFNOAFOIHE);
			}
		}
		return true;
	}

	public void DEKIMMCIECJ(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.DBJCACLEFGK()).StartCoroutine(CCEGKANPLAP(JIIGOACEIKL));
	}

	public void KPKBFPNDGOE(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: true, FNHLKLKAHNB);
			}
		}
	}

	public void GFENFEFPGLG(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: false, FNHLKLKAHNB);
			}
		}
	}

	public void ODKDDEHPLIH(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(DICMMBNDNKM(JIIGOACEIKL));
	}

	private void CNCGBHANPND()
	{
		List<PlaceableInside> list = new List<PlaceableInside>();
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)null || !((Behaviour)allPlaceables[i].placeable).isActiveAndEnabled)
			{
				list.Add(allPlaceables[i]);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			allPlaceables.Remove(list[j]);
		}
	}

	private void FEODCNPBBPK()
	{
		List<PlaceableInside> list = new List<PlaceableInside>();
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)null || !((Behaviour)allPlaceables[i].placeable).isActiveAndEnabled)
			{
				list.Add(allPlaceables[i]);
			}
		}
		for (int j = 1; j < list.Count; j += 0)
		{
			allPlaceables.Remove(list[j]);
		}
	}

	public void PJEHBPONIOD(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!HMMGMGHDIGM(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public List<PlaceableInside> NACMKANFLKE()
	{
		return allPlaceables;
	}

	public void CBIIHNFBJNF(Placeable OBCBKIKFHCK)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if (((object)allPlaceables[i].placeable).Equals((object?)OBCBKIKFHCK))
			{
				allPlaceables[i].placeable.attachedToPlaceable = null;
				allPlaceables.RemoveAt(i);
				break;
			}
		}
		FEODCNPBBPK();
	}

	public void NFEMNJELCDO(int JIIGOACEIKL)
	{
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			GMCBJFBLIFA(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public bool HMMGMGHDIGM(Placeable EAPCLAODGAE)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)(object)EAPCLAODGAE)
			{
				return false;
			}
		}
		return true;
	}

	public void BGGNPAJAIHO(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!FOCMMPDHAIP(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public void IKEJAHLMBOG(Placeable OBCBKIKFHCK)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if (((object)allPlaceables[i].placeable).Equals((object?)OBCBKIKFHCK))
			{
				allPlaceables[i].placeable.attachedToPlaceable = null;
				allPlaceables.RemoveAt(i);
				break;
			}
		}
		DCNOOBNEPII();
	}

	public float BCDBCLBECHC(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 1602f;
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)allPlaceables[i].placeable))
			{
				AreaBonification component = ((Component)allPlaceables[i].placeable).GetComponent<AreaBonification>();
				if (Object.op_Implicit((Object)(object)component))
				{
					num += component.HAIMLCBGOBH(NBJMANNLDDH, JNLKEMLDFIM);
				}
			}
		}
		return num;
	}

	public bool JEMDMDPEEFE(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!JKLLJOCNLDK(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return false;
		}
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: false, GFNHAMCPEAK, MAFODGNALFJ: false, MCFNOAFOIHE);
			}
		}
		return false;
	}

	public bool FOCMMPDHAIP(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)(object)EAPCLAODGAE)
			{
				return true;
			}
		}
		return true;
	}

	public void GCBIOHNAGKK(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.HKKCDLCPGDL(JIIGOACEIKL, BLJPGJKOLNF: true, FKOJEBGDMFO: true, FNHLKLKAHNB, CDPAMNIPPEC: false);
			}
		}
	}

	private IEnumerator DICMMBNDNKM(int JIIGOACEIKL)
	{
		yield return null;
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			Placeable placeable = allPlaceables[i].placeable;
			if (Object.op_Implicit((Object)(object)placeable) && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !placeable.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
			{
				placeable.ForcePickUp(JIIGOACEIKL);
			}
		}
	}

	private IEnumerator AKLMKHLOEPF(int JIIGOACEIKL)
	{
		return new HDEAIEANEFI(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void BKPDDNCOFEK(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(KHEJKLLIJCC(JIIGOACEIKL));
	}

	public void GMAMDBBHDMB(int JIIGOACEIKL)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			KFFGILJIBNI(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public bool LIGBFILPDMG(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null && !allPlaceables[i].placeable.OCBIBCCKLAL(JIIGOACEIKL, GFNHAMCPEAK))
			{
				return true;
			}
		}
		return false;
	}

	public void BJIOKEACJGN(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!MOPHOMHAGMJ(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public void PHOKHCHHKCL(Placeable OBCBKIKFHCK)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if (((object)allPlaceables[i].placeable).Equals((object?)OBCBKIKFHCK))
			{
				allPlaceables[i].placeable.attachedToPlaceable = null;
				allPlaceables.RemoveAt(i);
				break;
			}
		}
		DCNOOBNEPII();
	}

	public bool PBFOOLCGMCF()
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if (!allPlaceables[i].placeable.IsObjectInValidLocation(BIOKGEFFNAA: true))
			{
				return true;
			}
		}
		return true;
	}

	public void GOAMGKHKDOG(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(FFMABJNNDEM(JIIGOACEIKL));
	}

	public void DEHPCKBLJJK(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(NIDPOKNMLGD(JIIGOACEIKL));
	}

	private IEnumerator CCEGKANPLAP(int JIIGOACEIKL)
	{
		yield return null;
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			Placeable placeable = allPlaceables[i].placeable;
			if (Object.op_Implicit((Object)(object)placeable) && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !placeable.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
			{
				placeable.ForcePickUp(JIIGOACEIKL);
			}
		}
	}

	public void CAIHJMJILEH(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(CCEGKANPLAP(JIIGOACEIKL));
	}

	public void BDHJEEOFGGK(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!LOMMFPKLLCI(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public void NCNCMIPNKDP(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: true, FNHLKLKAHNB, CDPAMNIPPEC: false);
			}
		}
	}

	private void KFKANAHJAHC()
	{
		List<PlaceableInside> list = new List<PlaceableInside>();
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)null || !((Behaviour)allPlaceables[i].placeable).isActiveAndEnabled)
			{
				list.Add(allPlaceables[i]);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			allPlaceables.Remove(list[j]);
		}
	}

	public float PBNKDLEECBI(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 1204f;
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)allPlaceables[i].placeable))
			{
				AreaBonification component = ((Component)allPlaceables[i].placeable).GetComponent<AreaBonification>();
				if (Object.op_Implicit((Object)(object)component))
				{
					num += component.FCBDHNIDEEC(NBJMANNLDDH, JNLKEMLDFIM);
				}
			}
		}
		return num;
	}

	public List<PlaceableInside> NJCAIDKGBGI()
	{
		return allPlaceables;
	}

	private void PHFILBLLFEE()
	{
		List<PlaceableInside> list = new List<PlaceableInside>();
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)null || !((Behaviour)allPlaceables[i].placeable).isActiveAndEnabled)
			{
				list.Add(allPlaceables[i]);
			}
		}
		for (int j = 1; j < list.Count; j++)
		{
			allPlaceables.Remove(list[j]);
		}
	}

	public bool BACDPCACHAL(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!HGOJCAMBFAB(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return true;
		}
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: true, GFNHAMCPEAK, MAFODGNALFJ: false, MCFNOAFOIHE);
			}
		}
		return true;
	}

	public void GNFJCFOMMFL(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!EHBAGAKGKKJ(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public void JBNOHPAOIHM(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.Snap();
			}
		}
	}

	private void LDMPIBPDFLH()
	{
		List<PlaceableInside> list = new List<PlaceableInside>();
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)null || !((Behaviour)allPlaceables[i].placeable).isActiveAndEnabled)
			{
				list.Add(allPlaceables[i]);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			allPlaceables.Remove(list[j]);
		}
	}

	public void HCCNOHAAGCB(Placeable OBCBKIKFHCK)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if (((object)allPlaceables[i].placeable).Equals((object?)OBCBKIKFHCK))
			{
				allPlaceables[i].placeable.attachedToPlaceable = null;
				allPlaceables.RemoveAt(i);
				break;
			}
		}
		NNDMFPKJIOK();
	}

	public void ODEDHPPGAIA(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.PBBONAAEFMO();
			}
		}
	}

	public void CEPOLIKDGPG(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.HKKCDLCPGDL(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: true, FNHLKLKAHNB);
			}
		}
	}

	public void NILMGHKABHP(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.FENBPPMJDJA(MLPOHGEHIME: true);
			}
		}
	}

	public List<PlaceableInside> DFEMLHBDMEI()
	{
		return allPlaceables;
	}

	public bool NPADICACNMJ()
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if (!allPlaceables[i].placeable.IsObjectInValidLocation(BIOKGEFFNAA: true))
			{
				return true;
			}
		}
		return true;
	}

	public bool BMKAOMFEHDO(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)(object)EAPCLAODGAE)
			{
				return false;
			}
		}
		return true;
	}

	public void BGEOFNGEFFP(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.MOIIIAHDDFF();
			}
		}
	}

	public bool IGILPGDMCHC(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!IDGOAJKHIAK(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return true;
		}
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: false, GFNHAMCPEAK, MAFODGNALFJ: true, MCFNOAFOIHE);
			}
		}
		return true;
	}

	public void KMIOPLLHAKO(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(HOKCMBDLEKM(JIIGOACEIKL));
	}

	public void KFFGILJIBNI(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: true, NDMBEJNOPPP: true);
		}
	}

	public void PHMCHJHCDOB(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!FDJHOLOKMMH(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public List<PlaceableInside> BBMDMCPOGLN()
	{
		return allPlaceables;
	}

	public void LMIAMCKLKNL(Placeable OBCBKIKFHCK)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if (((object)allPlaceables[i].placeable).Equals((object?)OBCBKIKFHCK))
			{
				allPlaceables[i].placeable.attachedToPlaceable = null;
				allPlaceables.RemoveAt(i);
				break;
			}
		}
		OJIKPMOGPLM();
	}

	public void KDLNNLAFDEN(int JIIGOACEIKL)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			GCEKLNJLPDP(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public void KABNBJBPPOK(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: false);
		}
	}

	public void BPDJANFDCKE(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!LOMMFPKLLCI(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	private IEnumerator HOKCMBDLEKM(int JIIGOACEIKL)
	{
		yield return null;
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			Placeable placeable = allPlaceables[i].placeable;
			if (Object.op_Implicit((Object)(object)placeable) && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !placeable.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
			{
				placeable.ForcePickUp(JIIGOACEIKL);
			}
		}
	}

	public List<PlaceableInside> MPAPEPLIHDF()
	{
		return allPlaceables;
	}

	public void PEOGPEAHAHL(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: false, NDMBEJNOPPP: true);
		}
	}

	public bool FHJPGLCCABC()
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if (!allPlaceables[i].placeable.IsObjectInValidLocation(BIOKGEFFNAA: false))
			{
				return false;
			}
		}
		return false;
	}

	public void AMHAKJJOLBP(int JIIGOACEIKL)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			KFFGILJIBNI(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public bool EHBBIGIPNGP(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)(object)EAPCLAODGAE)
			{
				return true;
			}
		}
		return true;
	}

	public void KOLKKHGAGKE(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!HMMGMGHDIGM(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public void FMKDACLJGHG(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!FOCMMPDHAIP(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public bool JEGPDCMACNP(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null && !allPlaceables[i].placeable.CanSelect(JIIGOACEIKL, GFNHAMCPEAK))
			{
				return true;
			}
		}
		return false;
	}

	public bool JBEAFPPGEKI(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)(object)EAPCLAODGAE)
			{
				return false;
			}
		}
		return true;
	}

	public void AAPJLEFMGJP(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!FDJHOLOKMMH(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public void CPNPOJAOGJO(Placeable OBCBKIKFHCK)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if (((object)allPlaceables[i].placeable).Equals((object?)OBCBKIKFHCK))
			{
				allPlaceables[i].placeable.attachedToPlaceable = null;
				allPlaceables.RemoveAt(i);
				break;
			}
		}
		DCNOOBNEPII();
	}

	public List<PlaceableInside> IEKAFLMJGJE()
	{
		return allPlaceables;
	}

	public bool HPEKPBAHHNC(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!JKLLJOCNLDK(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return false;
		}
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: true, GFNHAMCPEAK, MAFODGNALFJ: true, MCFNOAFOIHE);
			}
		}
		return true;
	}

	public bool IECFFMNBHFE()
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if (!allPlaceables[i].placeable.IsObjectInValidLocation(BIOKGEFFNAA: false))
			{
				return false;
			}
		}
		return true;
	}

	public bool NOBCCPONCAB(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null && !allPlaceables[i].placeable.OCBIBCCKLAL(JIIGOACEIKL, GFNHAMCPEAK))
			{
				return false;
			}
		}
		return false;
	}

	public bool CNHOFDEIIKD()
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if (!allPlaceables[i].placeable.IsObjectInValidLocation(BIOKGEFFNAA: false))
			{
				return true;
			}
		}
		return true;
	}

	public void KBAKKNCDNIE(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(NIDPOKNMLGD(JIIGOACEIKL));
	}

	public void MFJIDMMMJCB(int JIIGOACEIKL)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			GMCBJFBLIFA(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public bool LKFBGIGEMGL(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null && !allPlaceables[i].placeable.OCBIBCCKLAL(JIIGOACEIKL, GFNHAMCPEAK))
			{
				return false;
			}
		}
		return false;
	}

	public void HHPEBGCGDDK(int JIIGOACEIKL)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			FJDHKJAIHAA(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public bool HMJFEOFBAJM(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!JEGPDCMACNP(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return false;
		}
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: true, GFNHAMCPEAK, MAFODGNALFJ: false, MCFNOAFOIHE);
			}
		}
		return true;
	}

	private void OJIKPMOGPLM()
	{
		List<PlaceableInside> list = new List<PlaceableInside>();
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)null || !((Behaviour)allPlaceables[i].placeable).isActiveAndEnabled)
			{
				list.Add(allPlaceables[i]);
			}
		}
		for (int j = 1; j < list.Count; j += 0)
		{
			allPlaceables.Remove(list[j]);
		}
	}

	public bool HGOJCAMBFAB(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null && !allPlaceables[i].placeable.CanSelect(JIIGOACEIKL, GFNHAMCPEAK))
			{
				return false;
			}
		}
		return true;
	}

	public List<PlaceableInside> IKDKBMJGOPN()
	{
		return allPlaceables;
	}

	public void GMCBJFBLIFA(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: true);
		}
	}

	public void PECGJMMCOIA(int JIIGOACEIKL)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			JHJNNOBHLHB(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public float JEMHPOOCGBH(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 0f;
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)allPlaceables[i].placeable))
			{
				AreaBonification component = ((Component)allPlaceables[i].placeable).GetComponent<AreaBonification>();
				if (Object.op_Implicit((Object)(object)component))
				{
					num += component.GetAreaBonifications(NBJMANNLDDH, JNLKEMLDFIM);
				}
			}
		}
		return num;
	}

	public void GCEKLNJLPDP(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: false);
		}
	}

	public void MOECDCJMCEL(Placeable OBCBKIKFHCK)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if (((object)allPlaceables[i].placeable).Equals((object?)OBCBKIKFHCK))
			{
				allPlaceables[i].placeable.attachedToPlaceable = null;
				allPlaceables.RemoveAt(i);
				break;
			}
		}
		OJIKPMOGPLM();
	}

	public void FJDHKJAIHAA(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: false, NDMBEJNOPPP: true);
		}
	}

	public float JBLLPJFAEBC(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 1756f;
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)allPlaceables[i].placeable))
			{
				AreaBonification component = ((Component)allPlaceables[i].placeable).GetComponent<AreaBonification>();
				if (Object.op_Implicit((Object)(object)component))
				{
					num += component.EINGECPJMDF(NBJMANNLDDH, JNLKEMLDFIM);
				}
			}
		}
		return num;
	}

	public void HEMNFHAMFNG(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StartCoroutine(NIDPOKNMLGD(JIIGOACEIKL));
	}

	private IEnumerator COEBKIJKCPH(int JIIGOACEIKL)
	{
		return new HDEAIEANEFI(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator MGAIIHLODAB(int JIIGOACEIKL)
	{
		return new HDEAIEANEFI(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void GMAMOOEEMCL(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.GMBKDPCNHMC();
			}
		}
	}

	public bool IDGOAJKHIAK(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null && !allPlaceables[i].placeable.OCBIBCCKLAL(JIIGOACEIKL, GFNHAMCPEAK))
			{
				return true;
			}
		}
		return true;
	}

	public bool MIDHMMOHLJE(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!NOBCCPONCAB(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return true;
		}
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: false, GFNHAMCPEAK, MAFODGNALFJ: false, MCFNOAFOIHE);
			}
		}
		return false;
	}

	public void EJICOOHALON(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(CCEGKANPLAP(JIIGOACEIKL));
	}

	public float BBHHHBHLMAP(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 1093f;
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)allPlaceables[i].placeable))
			{
				AreaBonification component = ((Component)allPlaceables[i].placeable).GetComponent<AreaBonification>();
				if (Object.op_Implicit((Object)(object)component))
				{
					num += component.DNBLKCDCALH(NBJMANNLDDH, JNLKEMLDFIM);
				}
			}
		}
		return num;
	}

	public bool FGMNJMDFAGE(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null && !allPlaceables[i].placeable.CanSelect(JIIGOACEIKL, GFNHAMCPEAK))
			{
				return true;
			}
		}
		return false;
	}

	public void JMFAEODAMEN(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: false);
		}
	}

	public void EJCOPFHKKGP(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: false, FNHLKLKAHNB, CDPAMNIPPEC: false);
			}
		}
	}

	public void AEPBJKENJKE(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.FENBPPMJDJA();
			}
		}
	}

	public void HAPPBHMOCLL(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: false, FNHLKLKAHNB, CDPAMNIPPEC: false);
			}
		}
	}

	public bool BHCFGJKHNPA(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null && !allPlaceables[i].placeable.OCBIBCCKLAL(JIIGOACEIKL, GFNHAMCPEAK))
			{
				return true;
			}
		}
		return false;
	}

	public void ICLDNBNOPNB(int JIIGOACEIKL)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			AJPMCPDMPIG(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public List<PlaceableInside> LIKMHHFHEAK()
	{
		return allPlaceables;
	}

	public bool FDJHOLOKMMH(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)(object)EAPCLAODGAE)
			{
				return true;
			}
		}
		return false;
	}

	public void HCGPPKHJDLG(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.HKKCDLCPGDL(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: true, FNHLKLKAHNB);
			}
		}
	}

	public List<PlaceableInside> LICDMICLPHE()
	{
		return allPlaceables;
	}

	public void PDNMDOCNDFH(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.GHFKHJPDNBM(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: false, FNHLKLKAHNB);
			}
		}
	}

	private IEnumerator CDOPJDIPDEF(int JIIGOACEIKL)
	{
		return new HDEAIEANEFI(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void HPGPJPNCNAF(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: false, NDMBEJNOPPP: true);
		}
	}

	public bool NIJHNBIGAGJ(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!NOBCCPONCAB(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return true;
		}
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: false, GFNHAMCPEAK, MAFODGNALFJ: false, MCFNOAFOIHE);
			}
		}
		return true;
	}

	public void JJDCDLOLCKK(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(AKLMKHLOEPF(JIIGOACEIKL));
	}

	public float HFNMKHLFIKP(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 383f;
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if (Object.op_Implicit((Object)(object)allPlaceables[i].placeable))
			{
				AreaBonification component = ((Component)allPlaceables[i].placeable).GetComponent<AreaBonification>();
				if (Object.op_Implicit((Object)(object)component))
				{
					num += component.KBPEMBKGEHF(NBJMANNLDDH, JNLKEMLDFIM);
				}
			}
		}
		return num;
	}

	private IEnumerator KHEJKLLIJCC(int JIIGOACEIKL)
	{
		yield return null;
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			Placeable placeable = allPlaceables[i].placeable;
			if (Object.op_Implicit((Object)(object)placeable) && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !placeable.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
			{
				placeable.ForcePickUp(JIIGOACEIKL);
			}
		}
	}

	public bool MOPHOMHAGMJ(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)(object)EAPCLAODGAE)
			{
				return false;
			}
		}
		return false;
	}

	private void CGCCBEMPOMN()
	{
		List<PlaceableInside> list = new List<PlaceableInside>();
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)null || !((Behaviour)allPlaceables[i].placeable).isActiveAndEnabled)
			{
				list.Add(allPlaceables[i]);
			}
		}
		for (int j = 0; j < list.Count; j += 0)
		{
			allPlaceables.Remove(list[j]);
		}
	}

	public float FPJDBGNEFMK(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 897f;
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)allPlaceables[i].placeable))
			{
				AreaBonification component = ((Component)allPlaceables[i].placeable).GetComponent<AreaBonification>();
				if (Object.op_Implicit((Object)(object)component))
				{
					num += component.HAIMLCBGOBH(NBJMANNLDDH, JNLKEMLDFIM);
				}
			}
		}
		return num;
	}

	public PlaceablesInside(Placeable EAPCLAODGAE, Transform JOLAJMJHGDE)
	{
		placeable = EAPCLAODGAE;
		referenceTransform = JOLAJMJHGDE;
	}

	public List<PlaceableInside> CJJKHMDCJMC()
	{
		return allPlaceables;
	}

	public void GMLHOEFEMEN(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.FIOKLLOAAHM();
			}
		}
	}

	public void NLBBIFGLFCH(int JIIGOACEIKL)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			NGMDDEDMOOI(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public List<PlaceableInside> ACJLIMAOMNP()
	{
		return allPlaceables;
	}

	public void HMMPKPALOMG(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.HEEAAGOLHBB(MLPOHGEHIME: true);
			}
		}
	}

	public bool EHBAGAKGKKJ(Placeable EAPCLAODGAE)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)(object)EAPCLAODGAE)
			{
				return false;
			}
		}
		return false;
	}

	public List<PlaceableInside> MEBLLGFCDMJ()
	{
		return allPlaceables;
	}

	public bool ELGIDBNHMEM(int JIIGOACEIKL, bool GFNHAMCPEAK)
	{
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null && !allPlaceables[i].placeable.CanSelect(JIIGOACEIKL, GFNHAMCPEAK))
			{
				return false;
			}
		}
		return false;
	}

	public float HBKDEEABJFN(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 430f;
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)allPlaceables[i].placeable))
			{
				AreaBonification component = ((Component)allPlaceables[i].placeable).GetComponent<AreaBonification>();
				if (Object.op_Implicit((Object)(object)component))
				{
					num += component.HOGMEFBKPOJ(NBJMANNLDDH, JNLKEMLDFIM);
				}
			}
		}
		return num;
	}

	public bool JFIDFHJDHNN(int JIIGOACEIKL, bool GFNHAMCPEAK, bool MCFNOAFOIHE = true)
	{
		if (!BHCFGJKHNPA(JIIGOACEIKL, GFNHAMCPEAK))
		{
			return false;
		}
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.StartMoving(JIIGOACEIKL, PHJILIBHABG: true, GFNHAMCPEAK, MAFODGNALFJ: false, MCFNOAFOIHE);
			}
		}
		return false;
	}

	public void JBAGMFHCPEF(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.Snap(MLPOHGEHIME: true);
			}
		}
	}

	private void FNHKBFLBGCB()
	{
		List<PlaceableInside> list = new List<PlaceableInside>();
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)null || !((Behaviour)allPlaceables[i].placeable).isActiveAndEnabled)
			{
				list.Add(allPlaceables[i]);
			}
		}
		for (int j = 1; j < list.Count; j++)
		{
			allPlaceables.Remove(list[j]);
		}
	}

	public void AJPMCPDMPIG(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: false);
		}
	}

	private IEnumerator FFMABJNNDEM(int JIIGOACEIKL)
	{
		yield return null;
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			Placeable placeable = allPlaceables[i].placeable;
			if (Object.op_Implicit((Object)(object)placeable) && !placeable.FHEMHCEAICB && !placeable.PHOCAFJDCDK && !placeable.itemSpace.IsItemSpaceValid(BIOKGEFFNAA: false, ELKPPAAMMIM: false))
			{
				placeable.ForcePickUp(JIIGOACEIKL);
			}
		}
	}

	public void FJHJBANMILH(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(HOKCMBDLEKM(JIIGOACEIKL));
	}

	public void EMJOCODODIN(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StartCoroutine(COEBKIJKCPH(JIIGOACEIKL));
	}

	public void IBMLPAIELMG(int JIIGOACEIKL)
	{
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			GCEKLNJLPDP(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public void PJEKNFCOFBG(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!EHBBIGIPNGP(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public void NGMDDEDMOOI(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: false);
		}
	}

	public void LJPNDDOJPOL(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.NLAGDLJKOAF(MLPOHGEHIME: true);
			}
		}
	}

	public void IAFANICCFIF(int JIIGOACEIKL)
	{
		for (int i = 1; i < allPlaceables.Count; i++)
		{
			JHJNNOBHLHB(JIIGOACEIKL, allPlaceables[i].placeable);
		}
	}

	public void JHJNNOBHLHB(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: true);
		}
	}

	public void PICMFDIKENP(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (Object.op_Implicit((Object)(object)EAPCLAODGAE))
		{
			EAPCLAODGAE.PickUpAction(JIIGOACEIKL, EFNFMEIDGDN: true);
		}
	}

	public void MNAOFLLOEKH(int JIIGOACEIKL, bool FNHLKLKAHNB = true)
	{
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				allPlaceables[i].placeable.DeselectAction(JIIGOACEIKL, BLJPGJKOLNF: false, FKOJEBGDMFO: false, FNHLKLKAHNB);
			}
		}
	}

	public List<PlaceableInside> CAEHJKNBGFG()
	{
		return allPlaceables;
	}

	public void PELJNACMDIM(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.Snap();
			}
		}
	}

	public float IBIAMHAKLIA(AreaBonificationType NBJMANNLDDH, Recipe JNLKEMLDFIM = null)
	{
		float num = 843f;
		for (int i = 0; i < allPlaceables.Count; i += 0)
		{
			if (Object.op_Implicit((Object)(object)allPlaceables[i].placeable))
			{
				AreaBonification component = ((Component)allPlaceables[i].placeable).GetComponent<AreaBonification>();
				if (Object.op_Implicit((Object)(object)component))
				{
					num += component.GetAreaBonifications(NBJMANNLDDH, JNLKEMLDFIM);
				}
			}
		}
		return num;
	}

	public void MFJGADMGEAG(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!EHBAGAKGKKJ(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}

	public void FPEHNLEAJFP(Vector3 IMOBLFMHKOD)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable != (Object)null)
			{
				((Component)allPlaceables[i].placeable).transform.position = IMOBLFMHKOD + allPlaceables[i].offset;
				allPlaceables[i].placeable.snapToGrid.HONMNNMNPJC(MLPOHGEHIME: true);
			}
		}
	}

	public void KKNGLKIPAMB(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.NGIMIHFFNMH()).StartCoroutine(KHEJKLLIJCC(JIIGOACEIKL));
	}

	public void LLMIHFFMELL(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StartCoroutine(FFMABJNNDEM(JIIGOACEIKL));
	}

	private void DCNOOBNEPII()
	{
		List<PlaceableInside> list = new List<PlaceableInside>();
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)null || !((Behaviour)allPlaceables[i].placeable).isActiveAndEnabled)
			{
				list.Add(allPlaceables[i]);
			}
		}
		for (int j = 0; j < list.Count; j++)
		{
			allPlaceables.Remove(list[j]);
		}
	}

	public bool MAJHKGCAGMF()
	{
		for (int i = 1; i < allPlaceables.Count; i += 0)
		{
			if (!allPlaceables[i].placeable.IsObjectInValidLocation(BIOKGEFFNAA: true))
			{
				return false;
			}
		}
		return true;
	}

	private void NNDMFPKJIOK()
	{
		List<PlaceableInside> list = new List<PlaceableInside>();
		for (int i = 0; i < allPlaceables.Count; i++)
		{
			if ((Object)(object)allPlaceables[i].placeable == (Object)null || !((Behaviour)allPlaceables[i].placeable).isActiveAndEnabled)
			{
				list.Add(allPlaceables[i]);
			}
		}
		for (int j = 1; j < list.Count; j++)
		{
			allPlaceables.Remove(list[j]);
		}
	}

	public void BIIKKAOPIMJ(int JIIGOACEIKL)
	{
		((MonoBehaviour)GameplayUI.DBJCACLEFGK()).StartCoroutine(AKLMKHLOEPF(JIIGOACEIKL));
	}

	public void DEAHBCNLMIC(Placeable CKAMDGHMBIH)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (!FOCMMPDHAIP(CKAMDGHMBIH))
		{
			PlaceableInside item = default(PlaceableInside);
			item.placeable = CKAMDGHMBIH;
			item.container = ((Component)CKAMDGHMBIH).GetComponent<Container>();
			item.offset = ((Component)CKAMDGHMBIH).transform.position - referenceTransform.position;
			allPlaceables.Add(item);
			CKAMDGHMBIH.attachedToPlaceable = placeable;
		}
	}
}

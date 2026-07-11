using System;
using UnityEngine;

public class AccessElement : MonoBehaviour
{
	public Placeable placeable;

	[SerializeField]
	protected TravelZone travelZone;

	[SerializeField]
	private bool canBeRemoved;

	protected virtual void AOJCCOIHPMH()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(NIFFFIPMOKE));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(FHJLJLAONKM));
		}
	}

	protected virtual void MAIMGNMIFKG()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(NIFFFIPMOKE));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(LBCJGAHENDC));
		}
	}

	protected virtual void MADBEAGLELM(int JIIGOACEIKL)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(false);
		}
	}

	protected virtual void ABLJNBFNMHI(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(false);
		}
	}

	protected virtual void GKCKLIAANHA()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ACLOGKBAPAM));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(DOCPPGEBOPL));
		}
	}

	protected virtual void FDGAGFIAPGJ()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(IJLJCACMNNA));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Remove(obj2.OnThisPlaceableDeselected, new Action<int>(DOCPPGEBOPL));
		}
	}

	public bool CanBeRemoved()
	{
		return canBeRemoved;
	}

	protected virtual void FINKPIHPHDE()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(NIFFFIPMOKE));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Remove(obj2.OnThisPlaceableDeselected, new Action<int>(FHJLJLAONKM));
		}
	}

	protected virtual void OnDisable()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Remove(obj2.OnThisPlaceableDeselected, new Action<int>(JGDGOCLJHJJ));
		}
	}

	protected virtual void MEENHFFEHCN(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(true);
		}
	}

	protected virtual void NIFFFIPMOKE(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(false);
		}
	}

	public bool JAHBAAGDHEL()
	{
		return canBeRemoved;
	}

	public bool HGNDGJGAAOJ()
	{
		return canBeRemoved;
	}

	protected virtual void CIFPGKHOKMF(int JIIGOACEIKL)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(false);
		}
	}

	protected virtual void HLNAKOJGHMP(int JIIGOACEIKL)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(false);
		}
	}

	public bool IJAACJAHBCB()
	{
		return canBeRemoved;
	}

	protected virtual void MMAMJDLONFA()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Remove(obj2.OnThisPlaceableDeselected, new Action<int>(NMBMJOHAHKM));
		}
	}

	protected virtual void OKFDGOCNBHJ(int JIIGOACEIKL)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(false);
		}
	}

	protected virtual void FJFLGDADEKM()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(NIFFFIPMOKE));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(OKFDGOCNBHJ));
		}
	}

	protected virtual void FHJLJLAONKM(int JIIGOACEIKL)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(false);
		}
	}

	protected virtual void OnEnable()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(JGDGOCLJHJJ));
		}
	}

	protected virtual void LCJCGFNFBBD()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(LBCJGAHENDC));
		}
	}

	protected virtual void PGDAOMNADHA()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ACLOGKBAPAM));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Remove(obj2.OnThisPlaceableDeselected, new Action<int>(JGDGOCLJHJJ));
		}
	}

	protected virtual void JIBHLLJGGEN()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(NIFFFIPMOKE));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(FHJLJLAONKM));
		}
	}

	protected virtual void IJLJCACMNNA(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(true);
		}
	}

	protected virtual void JGDGOCLJHJJ(int JIIGOACEIKL)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(true);
		}
	}

	protected virtual void NMBMJOHAHKM(int JIIGOACEIKL)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(true);
		}
	}

	protected virtual void IILOKDBOODL()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ACLOGKBAPAM));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Remove(obj2.OnThisPlaceableDeselected, new Action<int>(FHJLJLAONKM));
		}
	}

	protected virtual void OIEJIBAPDMM()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ACLOGKBAPAM));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(CIFPGKHOKMF));
		}
	}

	protected virtual void EHONGHBOHDJ(int JIIGOACEIKL)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(true);
		}
	}

	public bool KEBIPOGAPMG()
	{
		return canBeRemoved;
	}

	public bool OOGKBFDGGPB()
	{
		return canBeRemoved;
	}

	protected virtual void NMPFHHEFOPH()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(IJLJCACMNNA));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(MADBEAGLELM));
		}
	}

	protected virtual void ACLOGKBAPAM(int JIIGOACEIKL, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(false);
		}
	}

	protected virtual void ADEBBJOALDN()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Remove(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Remove(obj2.OnThisPlaceableDeselected, new Action<int>(NMBMJOHAHKM));
		}
	}

	protected virtual void DOCPPGEBOPL(int JIIGOACEIKL)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(false);
		}
	}

	public bool GDEDOGKHMIC()
	{
		return canBeRemoved;
	}

	protected virtual void LMPCDDGFBGD()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(ABLJNBFNMHI));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(NMBMJOHAHKM));
		}
	}

	protected virtual void LBCJGAHENDC(int JIIGOACEIKL)
	{
		if ((Object)(object)travelZone != (Object)null)
		{
			((Component)travelZone).gameObject.SetActive(true);
		}
	}

	public bool KNOBHLJHMAM()
	{
		return canBeRemoved;
	}

	protected virtual void NLHALEAEDMM()
	{
		if (!((Object)(object)placeable == (Object)null))
		{
			Placeable obj = placeable;
			obj.OnThisPlaceableSelected = (Action<int, bool, bool>)Delegate.Combine(obj.OnThisPlaceableSelected, new Action<int, bool, bool>(NIFFFIPMOKE));
			Placeable obj2 = placeable;
			obj2.OnThisPlaceableDeselected = (Action<int>)Delegate.Combine(obj2.OnThisPlaceableDeselected, new Action<int>(FHJLJLAONKM));
		}
	}
}

using System;
using UnityEngine;

public class AdjustColliderToWallFloor : MonoBehaviour
{
	public Placeable placeable;

	public Collider2D objectCollider2D;

	private void OIAHJHNPPCO()
	{
		DBGPIEHHLLL(1);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(LCIFJAMFFMN));
	}

	private void KFLAOJAFNBG(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1019f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 134f));
		}
	}

	private void OEMJCHIDAAJ(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(435f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 1697f));
		}
	}

	private void DBGBGKILJDC(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(522f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 1000f));
		}
	}

	private void LLKMOBMILLO(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(294f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 508f));
		}
	}

	private void HPIMHEMJMAA()
	{
		EEIGNILPACF(1);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(KFLAOJAFNBG));
	}

	private void IMEJLGEOKLC(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1374f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 273f));
		}
	}

	private void LANGHIOBJIH()
	{
		EEIGNILPACF(1);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(ELJBDBFAOIE));
	}

	private void NKDFMFFDGKC()
	{
		CFNCHKJNMKJ(1);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(LLKMOBMILLO));
	}

	private void MFMMHDPGCBO()
	{
		ELJBDBFAOIE(1);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(ILFNELEOHKH));
	}

	private void HCEDMLJNOBL()
	{
		FKBPHHMCBKF(1);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(DBGPIEHHLLL));
	}

	private void IDPHKHGHJGN()
	{
		LCIFJAMFFMN(0);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(KFLAOJAFNBG));
	}

	private void GDBHJHILHKF(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1041f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 492f));
		}
	}

	private void HBMDEHPHAPF()
	{
		DODCPAFDCGE(0);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(KFLAOJAFNBG));
	}

	private void PKHGKOFPJHG(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1065f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 411f));
		}
	}

	private void Start()
	{
		LCIFJAMFFMN(0);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(LCIFJAMFFMN));
	}

	private void GFNKFJDADOK(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1620f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 1018f));
		}
	}

	private void GNGADDPBJDC()
	{
		LCIFJAMFFMN(1);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(MHGOBBDOCEA));
	}

	private void DMFMNEMDFNP()
	{
		GDBHJHILHKF(1);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(DCJGAEMLANA));
	}

	private void IFHLGOMBACP()
	{
		DODCPAFDCGE(0);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(GGIEBDAOKJM));
	}

	private void LCIFJAMFFMN(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(0f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 0.1f));
		}
	}

	private void MHGOBBDOCEA(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1308f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 1506f));
		}
	}

	private void GGIEBDAOKJM(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1639f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 401f));
		}
	}

	private void FKBPHHMCBKF(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(727f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 164f));
		}
	}

	private void LONIACJOKEO(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1653f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 115f));
		}
	}

	private void DODCPAFDCGE(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1884f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 880f));
		}
	}

	private void DBGPIEHHLLL(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(660f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 519f));
		}
	}

	private void GJMLHECPGBP()
	{
		EEIGNILPACF(0);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(DBGBGKILJDC));
	}

	private void KDBJHCAEGCM()
	{
		IBHGIDIAHKN(0);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(LONIACJOKEO));
	}

	private void ELJBDBFAOIE(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(536f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 1313f));
		}
	}

	private void OLDDEAJMHNI()
	{
		IBHGIDIAHKN(0);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(GGIEBDAOKJM));
	}

	private void IBHGIDIAHKN(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1671f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 3f));
		}
	}

	private void GHPFCKGMLDA()
	{
		GGIEBDAOKJM(0);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(DCJGAEMLANA));
	}

	private void CFIIEJDJFPB()
	{
		FCAKPALMHGN(1);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(LLKMOBMILLO));
	}

	private void GLNCOOMDBCI(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1717f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 950f));
		}
	}

	private void FCAKPALMHGN(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(1535f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 1793f));
		}
	}

	private void ILFNELEOHKH(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(563f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 1782f));
		}
	}

	private void DCJGAEMLANA(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(983f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 1059f));
		}
	}

	private void IGIKNCOLCKL()
	{
		MHGOBBDOCEA(0);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(LONIACJOKEO));
	}

	private void CFNCHKJNMKJ(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(328f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 147f));
		}
	}

	private void EOGHJNGJFID()
	{
		GDBHJHILHKF(0);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(KFLAOJAFNBG));
	}

	private void FOHGHCPODBJ()
	{
		ELJBDBFAOIE(1);
		Placeable obj = placeable;
		obj.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(obj.OnThisPlaceablePlaced, new Action<int>(LLKMOBMILLO));
	}

	private void EEIGNILPACF(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (WorldGrid.ALNFLFCLIEP(((Component)placeable).transform.position) && WorldGrid.KHJJCAGIJAP(((Component)placeable).transform.position, out var KHEBKHFHMDB))
		{
			objectCollider2D.offset = Vector2.op_Implicit(new Vector3(464f, KHEBKHFHMDB - ((Component)placeable).transform.position.y + 72f));
		}
	}
}

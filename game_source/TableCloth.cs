using System;
using UnityEngine;

public class TableCloth : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;

	public Placeable placeable;

	public Transform tableClothMask;

	[SerializeField]
	private Sprite dirty;

	[SerializeField]
	private Sprite veryDirty;

	[SerializeField]
	private SpriteRenderer dirtySpriteSeparateRenderer;

	private Sprite CDBNDNCEOBC;

	private void EMJKKALMGLK()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	public void HMMLJFKLJLM(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)5:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	private void Awake()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void LDHMAGOHCDA(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void HOKAPOOCJCC()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(NNGIIHAJHMK));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	public void BLIIIEDALNA(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case (TableDirtLevel)7:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		}
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	private void PNMPJMJGGJF()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	public void JLAIOBKOCDJ(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Messy:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			break;
		case (TableDirtLevel)5:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	public void NDDGMEBALCN(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case TableDirtLevel.VeryDirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		}
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	private void GGOPCJOAOMC()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void GFILKGMEBOJ(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void IIPKPMPGLOL()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void HKECEBGKACL()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void IGNEGEOPLOP()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void BDMEBLBLPIA()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(MEENHFFEHCN));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	private void AHGPALJKOKP()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(LLPAIGBCNHH));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void GONDLJKGLGO()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void LALJNGFGKPA()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void GGGPLHIOGCH(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void CMLLBIDFNEB()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(GBIIFIOAAFN));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void DGOGKLMHJEG()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void NCEIPEMCJCL(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	public void EHFNNNDFPML(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)5:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case TableDirtLevel.Dirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		}
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Dirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	public void OADEBCIIKNP(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case TableDirtLevel.Messy:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case (TableDirtLevel)7:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	private void PHJKJHKAABL()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	public void IDPNDMGCKHG(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
		else if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	private void EFCNKPEPELL()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void AEDIIIAECIC()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void Start()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(ABLJNBFNMHI));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void AGILHHEMEFC()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void HPJBLOPJIMI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void AIMGHAOMBFI(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void GNOBDKFFPOL()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void GFLFDLIMOLI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	public void IFBJMGDMBGM(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case TableDirtLevel.VeryDirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Dirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	private void HNEGFBCKIIJ()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(IJLJCACMNNA));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void NEEEJJNMPOF()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void HEMAHKJEONA()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void CDDGGGHFDMD()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void MPCFCNCMOAF()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void KHONOODGLBI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void OEAAPIBLALL()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void LHJBBOCODGA(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	public void DDGPFEKHDJM(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Dirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		}
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	private void ONIALAOGMCF()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	public void IOGJBONPBCF(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)8:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			break;
		case (TableDirtLevel)7:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	private void NNGIIHAJHMK(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void AMNCIAEMBFO()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void EIHMDMMOPCM()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void JNKKJELMCNN()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	public void GPMJNLEDABJ(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case (TableDirtLevel)5:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
		else if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	public void KFHHIJPLCML(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)8:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case (TableDirtLevel)5:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
		else if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	private void CPPAHIOHOBK(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void JOIMGFPMKNI()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void OHKNLAHDFFN(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void NNMFLMJDKNH()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	public void LNFBHGEOFCB(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Dirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case (TableDirtLevel)5:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	private void KHLEMHOJMNG(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void BHAFCBHENPL()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void PDIECJCKCOD()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void ALGNGDMOKAD(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void FOJAHMIJJJM()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void LOCPMBPOJFA(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void IGBEKHCLKFD()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void PGABAEGKPIG()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void MLPAOEEILAL()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void EIMIDCDEIDD()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void LLPAIGBCNHH(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void KJOJLHCDFPP()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(KCJLFPBKPIC));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	private void EBNKNEIDDDI()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(NNGIIHAJHMK));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void DMFMNEMDFNP()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(LMJGJOEDLBD));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void CLNBMOPMNOF()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	public void JAMNACDABEE(TableDirtLevel DCDLGMBCPCE)
	{
		if (DCDLGMBCPCE == (TableDirtLevel)5)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		}
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)5:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case (TableDirtLevel)8:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	private void EBPMNJKFNMD()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(CPPAHIOHOBK));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	private void KCJLFPBKPIC(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void ABLJNBFNMHI(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void IJLJCACMNNA(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void LMJGJOEDLBD(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void JPHEOLEEAPB()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(LMJGJOEDLBD));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	private void CDFMNDEKBJE()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void OIAHJHNPPCO()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(KCJLFPBKPIC));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void LMNEMOCFHAI(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	public void KKKDBEHMFGK(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)8:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		}
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)8:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	private void MLLADNLMIMP()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(GFILKGMEBOJ));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void GBIIFIOAAFN(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	public void PANEKNMHEEK(TableDirtLevel DCDLGMBCPCE)
	{
		if (DCDLGMBCPCE == (TableDirtLevel)7)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		}
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)7:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case (TableDirtLevel)8:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	private void DFGJPDKILFJ()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void PFLBPMIEKGF()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(NNGIIHAJHMK));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	public void JPMLKOIPMFN(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Dirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case (TableDirtLevel)8:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		}
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	private void HPBCPENEEDK()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	private void IDEMDDNNLMM(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	public void AOBOMDMLAFN(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)5:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			break;
		case (TableDirtLevel)8:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	public void ChangeSprite(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.VeryDirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			break;
		case TableDirtLevel.Dirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case TableDirtLevel.Messy:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			break;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	private void EGDIINMEMGE()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(LMJGJOEDLBD));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	private void EICDGBINBAG()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void HBMDEHPHAPF()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(MEENHFFEHCN));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void EACIGGOOKGD()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(CPPAHIOHOBK));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	private void JPOLFKMLHNH()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(OHKNLAHDFFN));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	private void HLCAKACHOOE()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	public void LNAGIKBNLJD(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Dirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case (TableDirtLevel)8:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	private void GADEGOPBNGC()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void HPMFOHOMLDO()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void KOEHNENIBNP()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void LPNBCBIBNNI()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(GGGPLHIOGCH));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void FPDPAJHNGHK()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(ALGNGDMOKAD));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	private void GNMMELIJKML()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(OHKNLAHDFFN));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	private void NELBHAMPBPL()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(CPPAHIOHOBK));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void CDHBLKJEOPI()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void PEOPFPEDFAK()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void EGHOIJHBDBP()
	{
		if (!GameManager.leavingTheGame && !GameManager.CIOEICMHCCK && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void NFABFPFLNEE()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(LHJBBOCODGA));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = false;
		}
	}

	private void LKHMCLABKLG()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void HPIMHEMJMAA()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(ABLJNBFNMHI));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	private void AJGLDLLIIFO()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}

	public void JFPDDOCPBKA(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.VeryDirty:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case (TableDirtLevel)6:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			return;
		}
		if (DCDLGMBCPCE == TableDirtLevel.Perfect)
		{
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
		}
	}

	private void NLFHFPHDNCF()
	{
		Placeable obj = placeable;
		obj.OnThisPlaceableRemoved = (Action<int>)Delegate.Combine(obj.OnThisPlaceableRemoved, new Action<int>(IJLJCACMNNA));
		if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
		{
			((Renderer)dirtySpriteSeparateRenderer).enabled = true;
		}
	}

	public void LDLIOLDDLNH(TableDirtLevel DCDLGMBCPCE)
	{
		switch (DCDLGMBCPCE)
		{
		case (TableDirtLevel)7:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = veryDirty;
			}
			else
			{
				spriteRenderer.sprite = veryDirty;
			}
			return;
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = true;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
				dirtySpriteSeparateRenderer.sprite = dirty;
			}
			else
			{
				spriteRenderer.sprite = dirty;
			}
			return;
		}
		switch (DCDLGMBCPCE)
		{
		case TableDirtLevel.Clean:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		case TableDirtLevel.Perfect:
			if (Object.op_Implicit((Object)(object)dirtySpriteSeparateRenderer))
			{
				((Renderer)dirtySpriteSeparateRenderer).enabled = false;
			}
			else
			{
				spriteRenderer.sprite = CDBNDNCEOBC;
			}
			break;
		}
	}

	private void MEENHFFEHCN(int JIIGOACEIKL)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)tableClothMask))
		{
			tableClothMask.SetParent(((Component)this).transform);
			tableClothMask.localPosition = Vector3.zero;
		}
	}

	private void NCOGHEMBDBN()
	{
		if (!GameManager.leavingTheGame && !GameManager.ILMDHNFFIKH() && Object.op_Implicit((Object)(object)tableClothMask) && (Object)(object)tableClothMask.parent != (Object)(object)((Component)this).transform)
		{
			Utils.BLPDAEHPOBA(((Component)tableClothMask).gameObject);
		}
	}

	private void DKNNLPFIBIK()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		CDBNDNCEOBC = spriteRenderer.sprite;
	}
}

using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	private Vector3 EODIDNILDIF;

	private Vector2 GFJIJLHFNAL;

	public float speed = 5f;

	private float NAPCGOBFECM;

	public float currentBuildingSpeed = 0.1f;

	public FarmBuilding currentBuilding;

	private bool PHGHJDMCKCN;

	public bool LNLJMCONDNE
	{
		get
		{
			return PHGHJDMCKCN;
		}
		set
		{
			PHGHJDMCKCN = value;
		}
	}

	[SpecialName]
	public void FOFJKEAHNGO(bool AODONKKHPBP)
	{
		PHGHJDMCKCN = AODONKKHPBP;
	}

	public void CILPNJNGBOH(FarmBuilding PACHBJJJDCJ)
	{
		currentBuilding = PACHBJJJDCJ;
	}

	public void AddForce(Vector3 FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.GGFJGHHHEJC.IsInsideBuildLimits(((Component)this).transform.position + FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 1.3f, ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM))
		{
			Transform transform = ((Component)this).transform;
			transform.position += FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 1.3f;
		}
	}

	[SpecialName]
	public bool KIAKFNLLDLK()
	{
		return PHGHJDMCKCN;
	}

	[SpecialName]
	public void NMIPBNMDPOF(bool AODONKKHPBP)
	{
		PHGHJDMCKCN = AODONKKHPBP;
	}

	private void KACEOJDPLKB()
	{
		NMIPBNMDPOF(AODONKKHPBP: true);
	}

	[SpecialName]
	public bool LJBKEJHNGJN()
	{
		return PHGHJDMCKCN;
	}

	private void Start()
	{
		LNLJMCONDNE = false;
	}

	private void HFFFFAJFIPB()
	{
		LNLJMCONDNE = true;
	}

	[SpecialName]
	public bool IAIJBJGMBDK()
	{
		return PHGHJDMCKCN;
	}

	public void DPELBFPFKOE(Vector3 FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.KHMEGDIABBF().HMDJEMGNPJN(((Component)this).transform.position + FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 1803f, ConstructionFloors.OMFKNGDCJFN().DAONIMMHCFB()))
		{
			Transform transform = ((Component)this).transform;
			transform.position += FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 1276f;
		}
	}

	[SpecialName]
	public bool CFMJGLLEDPO()
	{
		return PHGHJDMCKCN;
	}

	public void OEFDANFNGEO(FarmBuilding PACHBJJJDCJ)
	{
		currentBuilding = PACHBJJJDCJ;
	}

	public void BBLDPCFJNCD(Vector3 FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.KNLLFEJAMNN().HMDJEMGNPJN(((Component)this).transform.position + FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 357f, ConstructionFloors.JFNOOMJMHCB().LKIILEMCPHH()))
		{
			Transform transform = ((Component)this).transform;
			transform.position += FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 977f;
		}
	}

	private void OIBDBLCLACB()
	{
		LNLJMCONDNE = true;
	}

	private void HCEDMLJNOBL()
	{
		LNLJMCONDNE = true;
	}

	[SpecialName]
	public bool PEAOFMJJFDD()
	{
		return PHGHJDMCKCN;
	}

	private void Update()
	{
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		if (!LNLJMCONDNE || BuildingTutorialManager.IsOpen())
		{
			return;
		}
		if (FarmConstructionManager.IsActived() && (Object)(object)currentBuilding != (Object)null && PlayerInputs.IsGamepadActive(ConstructionUI.current.JIIGOACEIKL))
		{
			((Component)this).transform.position = Vector3.Lerp(((Component)this).transform.position, ((Component)currentBuilding).transform.position, currentBuildingSpeed);
			return;
		}
		NAPCGOBFECM = speed;
		if (PlayerInputs.IsGamepadActive(ConstructionUI.current.JIIGOACEIKL))
		{
			GFJIJLHFNAL.x = PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetAxis("ObjectHorizontalMove");
			GFJIJLHFNAL.y = PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetAxis("ObjectVerticalMove");
			NAPCGOBFECM *= 1.4f;
		}
		else
		{
			GFJIJLHFNAL.x = PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetAxis("HorizontalMove");
			GFJIJLHFNAL.y = PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetAxis("VerticalMove");
			if (PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetButton("SprintHoldAction"))
			{
				NAPCGOBFECM *= 1.75f;
			}
		}
		EODIDNILDIF = Vector2.op_Implicit(GFJIJLHFNAL * NAPCGOBFECM * Time.unscaledDeltaTime);
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && TavernConstructionManager.GGFJGHHHEJC.IsInsideBuildLimits(((Component)this).transform.position + EODIDNILDIF, ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM))
		{
			Transform transform = ((Component)this).transform;
			transform.position += EODIDNILDIF;
		}
		else if (FarmConstructionManager.IsActived() && FarmConstructionManager.IsInsideBuildLimits(((Component)this).transform.position + EODIDNILDIF))
		{
			Transform transform2 = ((Component)this).transform;
			transform2.position += EODIDNILDIF;
		}
	}

	public void SetCurrentBuilding(FarmBuilding PACHBJJJDCJ)
	{
		currentBuilding = PACHBJJJDCJ;
	}

	public void ABBBLJHEBLB(Vector3 FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.DEGPIHEEFHJ().PGIOLPKOHLE(((Component)this).transform.position + FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 1386f, ConstructionFloors.DOIKFJDLKJP().ODFBDBLCFOM))
		{
			Transform transform = ((Component)this).transform;
			transform.position += FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 263f;
		}
	}

	public void KILHMBHLKND(Vector3 FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.DEGPIHEEFHJ().PGIOLPKOHLE(((Component)this).transform.position + FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 1636f, ConstructionFloors.DFJGHOHPPEL().JIBIAOMIGHP()))
		{
			Transform transform = ((Component)this).transform;
			transform.position += FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 1379f;
		}
	}

	public void LBKPBGPAPNF(Vector3 FCGBJEIIMBC)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (TavernConstructionManager.DEGPIHEEFHJ().HMDJEMGNPJN(((Component)this).transform.position + FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 1470f, ConstructionFloors.DOIKFJDLKJP().EJKJLPAFFOI()))
		{
			Transform transform = ((Component)this).transform;
			transform.position += FCGBJEIIMBC * NAPCGOBFECM * Time.unscaledDeltaTime * 196f;
		}
	}
}

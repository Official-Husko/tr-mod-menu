using System;
using UnityEngine;

public class Camera2D : MonoBehaviour
{
	public Camera mainCamera;

	[SerializeField]
	private BoxCollider2D boundingCollider;

	private Rigidbody2D PFPJCGNCGGH;

	private Vector3 OOKKLAOFELJ;

	private Vector3 GGHMLBCCMKL;

	private float IENGFEPBFNE;

	private void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		GGHMLBCCMKL = ((Component)PlayerController.GetPlayer(1)).transform.position;
	}

	private void GFABFDHPJOK()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		PFPJCGNCGGH.MovePosition(Vector2.op_Implicit(Vector3.SmoothDamp(((Component)this).transform.position, GGHMLBCCMKL, ref OOKKLAOFELJ, 595f)));
	}

	private void ODNGBEOKEFK()
	{
		SetCameraBounds(1);
		SetCameraBounds(0);
		IENGFEPBFNE = 245f;
	}

	private void CMJIKLLFHKA()
	{
		try
		{
			GAIJLIJJINO(1);
			SetCameraBounds(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("" + ex.Message));
		}
	}

	private void IDPHKHGHJGN()
	{
		FCALFILGLOA(0);
		GAIJLIJJINO(6);
		IENGFEPBFNE = 1667f;
	}

	private void OnEnable()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(SetCameraBounds));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerSleep = (Action)Delegate.Combine(instance2.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void FixedUpdate()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		PFPJCGNCGGH.MovePosition(Vector2.op_Implicit(Vector3.SmoothDamp(((Component)this).transform.position, GGHMLBCCMKL, ref OOKKLAOFELJ, 0.3f)));
	}

	private void JMDOCHBJGKG()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		GGHMLBCCMKL = ((Component)PlayerController.GetPlayer(0)).transform.position;
	}

	private void GOJFGHKOFMF()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		GGHMLBCCMKL = ((Component)PlayerController.GetPlayer(1)).transform.position;
	}

	private void BHLHCOALABE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		GGHMLBCCMKL = ((Component)PlayerController.GetPlayer(1)).transform.position;
	}

	private void CGHHPELBKBK()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravel = (Action<int>)Delegate.Combine(commonReferences.OnTravel, new Action<int>(DFBGFPPJCHD));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlayerSleep = (Action)Delegate.Combine(commonReferences2.OnPlayerSleep, new Action(CMJIKLLFHKA));
	}

	private void HGEKPHOPJCD()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravel = (Action<int>)Delegate.Combine(commonReferences.OnTravel, new Action<int>(AMHGHEABBKC));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(CMJIKLLFHKA));
	}

	private void IFHFNDELKOP()
	{
		try
		{
			SetCameraBounds(1);
			SetCameraBounds(2);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in Camera2D.OnPlayerSleep: " + ex.Message));
		}
	}

	private float FIFIGNOLLLD(float IHBJANEFIGK)
	{
		return Mathf.Round(IHBJANEFIGK / IENGFEPBFNE) * IENGFEPBFNE;
	}

	private void FBNHGAOGDJE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		PFPJCGNCGGH.MovePosition(Vector2.op_Implicit(Vector3.SmoothDamp(((Component)this).transform.position, GGHMLBCCMKL, ref OOKKLAOFELJ, 1229f)));
	}

	private void GDKOIIEHKGO()
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(SetCameraBounds));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlayerSleep = (Action)Delegate.Remove(instance2.OnPlayerSleep, new Action(IFHFNDELKOP));
		}
	}

	public void OFEDGPPHMHD(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
		position.z = ((Component)this).transform.position.z;
		((Component)this).transform.position = position;
		GGHMLBCCMKL = position;
		Camera component = ((Component)this).GetComponent<Camera>();
		Vector2 val = default(Vector2);
		val.y = 742f * component.orthographicSize;
		val.x = val.y * component.aspect;
		boundingCollider.size = val;
	}

	private void HINEHDJIPGP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		PFPJCGNCGGH.MovePosition(Vector2.op_Implicit(Vector3.SmoothDamp(((Component)this).transform.position, GGHMLBCCMKL, ref OOKKLAOFELJ, 272f)));
	}

	private void KHONOODGLBI()
	{
		PFPJCGNCGGH = ((Component)this).GetComponent<Rigidbody2D>();
		mainCamera = ((Component)this).GetComponent<Camera>();
	}

	private void IGIKNCOLCKL()
	{
		AMHGHEABBKC(0);
		DFBGFPPJCHD(8);
		IENGFEPBFNE = 135f;
	}

	private void CAIJLMJBMLA()
	{
		GAIJLIJJINO(0);
		GAIJLIJJINO(2);
		IENGFEPBFNE = 1852f;
	}

	private void ANMOAFFGEOE()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(OFEDGPPHMHD));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void EFLEPALELDJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		PFPJCGNCGGH.MovePosition(Vector2.op_Implicit(Vector3.SmoothDamp(((Component)this).transform.position, GGHMLBCCMKL, ref OOKKLAOFELJ, 643f)));
	}

	private void GHPFCKGMLDA()
	{
		SetCameraBounds(1);
		HPIIPFNKDGE(3);
		IENGFEPBFNE = 1952f;
	}

	private void JINLGFOFJAN()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravel = (Action<int>)Delegate.Combine(commonReferences.OnTravel, new Action<int>(FCALFILGLOA));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlayerSleep = (Action)Delegate.Combine(commonReferences2.OnPlayerSleep, new Action(CMJIKLLFHKA));
	}

	private void HHHEACKHADN()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnTravel = (Action<int>)Delegate.Combine(instance.OnTravel, new Action<int>(OFEDGPPHMHD));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerSleep = (Action)Delegate.Combine(instance2.OnPlayerSleep, new Action(CMJIKLLFHKA));
	}

	private void MJENOBKFPIN()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		PFPJCGNCGGH.MovePosition(Vector2.op_Implicit(Vector3.SmoothDamp(((Component)this).transform.position, GGHMLBCCMKL, ref OOKKLAOFELJ, 769f)));
	}

	private void BAKDKFKNHDE()
	{
		PFPJCGNCGGH = ((Component)this).GetComponent<Rigidbody2D>();
		mainCamera = ((Component)this).GetComponent<Camera>();
	}

	private void INEOMPKPILM()
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnTravel = (Action<int>)Delegate.Remove(commonReferences.OnTravel, new Action<int>(OFEDGPPHMHD));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(JBLKJJCNDFO));
		}
	}

	private void OFJIMLOLIDP()
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() == (Object)null))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(OFEDGPPHMHD));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlayerSleep = (Action)Delegate.Remove(instance2.OnPlayerSleep, new Action(DAEPNGOFDKM));
		}
	}

	private void Awake()
	{
		PFPJCGNCGGH = ((Component)this).GetComponent<Rigidbody2D>();
		mainCamera = ((Component)this).GetComponent<Camera>();
	}

	private void POFDOILPANH()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		GGHMLBCCMKL = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position;
	}

	private void PFLBPMIEKGF()
	{
		AMHGHEABBKC(1);
		OFEDGPPHMHD(6);
		IENGFEPBFNE = 1853f;
	}

	private void HDDBJBECDPP()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		PFPJCGNCGGH.MovePosition(Vector2.op_Implicit(Vector3.SmoothDamp(((Component)this).transform.position, GGHMLBCCMKL, ref OOKKLAOFELJ, 1121f)));
	}

	private void JLCFNPBBKEK()
	{
		SetCameraBounds(0);
		HPIIPFNKDGE(3);
		IENGFEPBFNE = 1505f;
	}

	private float BBLBCBCHJCK(float IHBJANEFIGK)
	{
		return Mathf.Round(IHBJANEFIGK / IENGFEPBFNE) * IENGFEPBFNE;
	}

	public void GAIJLIJJINO(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
		position.z = ((Component)this).transform.position.z;
		((Component)this).transform.position = position;
		GGHMLBCCMKL = position;
		Camera component = ((Component)this).GetComponent<Camera>();
		Vector2 val = default(Vector2);
		val.y = 1236f * component.orthographicSize;
		val.x = val.y * component.aspect;
		boundingCollider.size = val;
	}

	private void NEOICNJNKNL()
	{
		PFPJCGNCGGH = ((Component)this).GetComponent<Rigidbody2D>();
		mainCamera = ((Component)this).GetComponent<Camera>();
	}

	private void HKKDEKIFPPJ()
	{
		NHIBAINNAKA(0);
		DFBGFPPJCHD(4);
		IENGFEPBFNE = 1997f;
	}

	private void KAANJGEDPIN()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravel = (Action<int>)Delegate.Combine(commonReferences.OnTravel, new Action<int>(DFBGFPPJCHD));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DAEPNGOFDKM));
	}

	public void SetCameraBounds(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
		position.z = ((Component)this).transform.position.z;
		((Component)this).transform.position = position;
		GGHMLBCCMKL = position;
		Camera component = ((Component)this).GetComponent<Camera>();
		Vector2 val = default(Vector2);
		val.y = 2f * component.orthographicSize;
		val.x = val.y * component.aspect;
		boundingCollider.size = val;
	}

	private void DAEPNGOFDKM()
	{
		try
		{
			AMHGHEABBKC(1);
			GAIJLIJJINO(0);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)(" " + ex.Message));
		}
	}

	private void JHBBABPAJJC()
	{
		AMHGHEABBKC(1);
		FCALFILGLOA(1);
		IENGFEPBFNE = 371f;
	}

	private void DOKHLDBIDJB()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		GGHMLBCCMKL = ((Component)PlayerController.GetPlayer(0)).transform.position;
	}

	private void PCKOHAIPHFI()
	{
		PFPJCGNCGGH = ((Component)this).GetComponent<Rigidbody2D>();
		mainCamera = ((Component)this).GetComponent<Camera>();
	}

	private void JBLKJJCNDFO()
	{
		try
		{
			SetCameraBounds(1);
			AMHGHEABBKC(8);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Unknown command" + ex.Message));
		}
	}

	public void FCALFILGLOA(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
		position.z = ((Component)this).transform.position.z;
		((Component)this).transform.position = position;
		GGHMLBCCMKL = position;
		Camera component = ((Component)this).GetComponent<Camera>();
		Vector2 val = default(Vector2);
		val.y = 1844f * component.orthographicSize;
		val.x = val.y * component.aspect;
		boundingCollider.size = val;
	}

	private float OBBOHOIJJAI(float IHBJANEFIGK)
	{
		return Mathf.Round(IHBJANEFIGK / IENGFEPBFNE) * IENGFEPBFNE;
	}

	private void IJMBEEEGCGF()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravel = (Action<int>)Delegate.Combine(commonReferences.OnTravel, new Action<int>(OFEDGPPHMHD));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(CMJIKLLFHKA));
	}

	private void HKOFLOPDCEJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		PFPJCGNCGGH.MovePosition(Vector2.op_Implicit(Vector3.SmoothDamp(((Component)this).transform.position, GGHMLBCCMKL, ref OOKKLAOFELJ, 1269f)));
	}

	private void ICKIAOEOHDJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravel = (Action<int>)Delegate.Combine(commonReferences.OnTravel, new Action<int>(NHIBAINNAKA));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlayerSleep = (Action)Delegate.Combine(commonReferences2.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	public void HPIIPFNKDGE(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position;
		position.z = ((Component)this).transform.position.z;
		((Component)this).transform.position = position;
		GGHMLBCCMKL = position;
		Camera component = ((Component)this).GetComponent<Camera>();
		Vector2 val = default(Vector2);
		val.y = 637f * component.orthographicSize;
		val.x = val.y * component.aspect;
		boundingCollider.size = val;
	}

	private void CAOKPIIFHBJ()
	{
		HPIIPFNKDGE(1);
		OFEDGPPHMHD(4);
		IENGFEPBFNE = 1685f;
	}

	private float HAEPJBHJDFB(float IHBJANEFIGK)
	{
		return Mathf.Round(IHBJANEFIGK / IENGFEPBFNE) * IENGFEPBFNE;
	}

	private void OnDisable()
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC == (Object)null))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnTravel = (Action<int>)Delegate.Remove(instance.OnTravel, new Action<int>(SetCameraBounds));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnPlayerSleep = (Action)Delegate.Remove(instance2.OnPlayerSleep, new Action(IFHFNDELKOP));
		}
	}

	private float FDPNIFHOHHK(float IHBJANEFIGK)
	{
		return Mathf.Round(IHBJANEFIGK / IENGFEPBFNE) * IENGFEPBFNE;
	}

	private void GONDLJKGLGO()
	{
		PFPJCGNCGGH = ((Component)this).GetComponent<Rigidbody2D>();
		mainCamera = ((Component)this).GetComponent<Camera>();
	}

	private float PNIOLMIOAGG(float IHBJANEFIGK)
	{
		return Mathf.Round(IHBJANEFIGK / IENGFEPBFNE) * IENGFEPBFNE;
	}

	private void PGJLFLKDLAE()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		PFPJCGNCGGH.MovePosition(Vector2.op_Implicit(Vector3.SmoothDamp(((Component)this).transform.position, GGHMLBCCMKL, ref OOKKLAOFELJ, 1827f)));
	}

	private void HJDLNCOAKIK()
	{
		AMHGHEABBKC(1);
		NHIBAINNAKA(7);
		IENGFEPBFNE = 1811f;
	}

	private void Start()
	{
		SetCameraBounds(1);
		SetCameraBounds(2);
		IENGFEPBFNE = 1f / 32f;
	}

	private void MAIMGNMIFKG()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnTravel = (Action<int>)Delegate.Combine(commonReferences.OnTravel, new Action<int>(FCALFILGLOA));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DAEPNGOFDKM));
	}

	private float AKCMFJCGENM(float IHBJANEFIGK)
	{
		return Mathf.Round(IHBJANEFIGK / IENGFEPBFNE) * IENGFEPBFNE;
	}

	public void DFBGFPPJCHD(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
		position.z = ((Component)this).transform.position.z;
		((Component)this).transform.position = position;
		GGHMLBCCMKL = position;
		Camera component = ((Component)this).GetComponent<Camera>();
		Vector2 val = default(Vector2);
		val.y = 850f * component.orthographicSize;
		val.x = val.y * component.aspect;
		boundingCollider.size = val;
	}

	private void HEMAHKJEONA()
	{
		PFPJCGNCGGH = ((Component)this).GetComponent<Rigidbody2D>();
		mainCamera = ((Component)this).GetComponent<Camera>();
	}

	public void NHIBAINNAKA(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
		position.z = ((Component)this).transform.position.z;
		((Component)this).transform.position = position;
		GGHMLBCCMKL = position;
		Camera component = ((Component)this).GetComponent<Camera>();
		Vector2 val = default(Vector2);
		val.y = 1254f * component.orthographicSize;
		val.x = val.y * component.aspect;
		boundingCollider.size = val;
	}

	public void AMHGHEABBKC(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 position = ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position;
		position.z = ((Component)this).transform.position.z;
		((Component)this).transform.position = position;
		GGHMLBCCMKL = position;
		Camera component = ((Component)this).GetComponent<Camera>();
		Vector2 val = default(Vector2);
		val.y = 1188f * component.orthographicSize;
		val.x = val.y * component.aspect;
		boundingCollider.size = val;
	}

	private float MKLEEHJHGEM(float IHBJANEFIGK)
	{
		return Mathf.Round(IHBJANEFIGK / IENGFEPBFNE) * IENGFEPBFNE;
	}
}

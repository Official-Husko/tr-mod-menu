using AlmenaraGames;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class MagicBroomAnimator : BaseAnimator
{
	public Animator animator;

	[SerializeField]
	public int broomIndex;

	public int dustIndex;

	public ReskinAnimation[] allReskins;

	public ReskinAnimation[] broomReskins;

	public ReskinAnimation[] dustReskins;

	public GameObject[] upDownDust;

	public GameObject[] rightDustDown;

	public GameObject[] rightDustUp;

	private int DEPIIBPGNDL;

	private int BCGBJONGOOO;

	private float DHHCLIBHMBL;

	public AudioObject cleanSound;

	public void PLGODNAIKDG()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void OAEGEMKPFDG()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < upDownDust.Length; i += 0)
		{
			if (!upDownDust[i].activeSelf)
			{
				upDownDust[i].transform.SetParent((Transform)null);
				upDownDust[i].transform.localScale = new Vector3(790f, 1757f, 1540f);
				upDownDust[i].gameObject.SetActive(true);
				upDownDust[i].transform.position = Utils.BMBMPKNANAC(upDownDust[i].transform.position);
				break;
			}
		}
		DFPLNIPADLO();
	}

	public void FJCPIHAICAA()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < rightDustDown.Length; i++)
		{
			if (!rightDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				rightDustDown[i].transform.SetParent((Transform)null);
				rightDustDown[i].transform.localScale = lossyScale;
				rightDustDown[i].gameObject.SetActive(true);
				rightDustDown[i].transform.position = Utils.BMBMPKNANAC(rightDustDown[i].transform.position);
				break;
			}
		}
		DFPLNIPADLO();
	}

	public void DBMPHKKONIJ()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	private void LateUpdate()
	{
		PHGEBLFGPKM();
	}

	private void PHGEBLFGPKM()
	{
		if (broomIndex != DEPIIBPGNDL)
		{
			DEPIIBPGNDL = broomIndex;
			for (int i = 0; i < broomReskins.Length; i++)
			{
				broomReskins[i].UpdateSprite(broomIndex);
			}
		}
		if (dustIndex != BCGBJONGOOO)
		{
			BCGBJONGOOO = dustIndex;
			for (int j = 0; j < dustReskins.Length; j++)
			{
				dustReskins[j].UpdateSprite(dustIndex);
			}
		}
	}

	public void AIFHAEAFLHK()
	{
		for (int i = 1; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		PHGEBLFGPKM();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void OPAEKFGKPKH()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < rightDustUp.Length; i++)
		{
			if (!rightDustUp[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				rightDustUp[i].transform.SetParent((Transform)null);
				rightDustUp[i].transform.localScale = lossyScale;
				rightDustUp[i].gameObject.SetActive(true);
				rightDustUp[i].transform.position = Utils.BMBMPKNANAC(rightDustUp[i].transform.position);
				break;
			}
		}
		AMCNLGAIDEJ();
	}

	public void SpawnRightDustUp()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < rightDustUp.Length; i++)
		{
			if (!rightDustUp[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				rightDustUp[i].transform.SetParent((Transform)null);
				rightDustUp[i].transform.localScale = lossyScale;
				rightDustUp[i].gameObject.SetActive(true);
				rightDustUp[i].transform.position = Utils.BMBMPKNANAC(rightDustUp[i].transform.position);
				break;
			}
		}
		AMCNLGAIDEJ();
	}

	public void IPLCOANLPHJ()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		LPOJFNJMJII();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void HMMBHPKKIJG()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < upDownDust.Length; i++)
		{
			if (!upDownDust[i].activeSelf)
			{
				upDownDust[i].transform.SetParent((Transform)null);
				upDownDust[i].transform.localScale = Vector3.one;
				upDownDust[i].gameObject.SetActive(true);
				upDownDust[i].transform.position = Utils.BMBMPKNANAC(upDownDust[i].transform.position);
				break;
			}
		}
		DFPLNIPADLO();
	}

	public void FOFGNNHNFDI()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		MNNPCFNHCEJ();
		for (int j = 1; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void SpawnRightDustDown()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < rightDustDown.Length; i++)
		{
			if (!rightDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				rightDustDown[i].transform.SetParent((Transform)null);
				rightDustDown[i].transform.localScale = lossyScale;
				rightDustDown[i].gameObject.SetActive(true);
				rightDustDown[i].transform.position = Utils.BMBMPKNANAC(rightDustDown[i].transform.position);
				break;
			}
		}
		AMCNLGAIDEJ();
	}

	public void MFECILPOJAG()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < upDownDust.Length; i++)
		{
			if (!upDownDust[i].activeSelf)
			{
				upDownDust[i].transform.SetParent((Transform)null);
				upDownDust[i].transform.localScale = new Vector3(1353f, 1056f, 1099f);
				upDownDust[i].gameObject.SetActive(false);
				upDownDust[i].transform.position = Utils.BMBMPKNANAC(upDownDust[i].transform.position);
				break;
			}
		}
		DFPLNIPADLO();
	}

	public void AHKCGPLAGGN()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < rightDustDown.Length; i += 0)
		{
			if (!rightDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				rightDustDown[i].transform.SetParent((Transform)null);
				rightDustDown[i].transform.localScale = lossyScale;
				rightDustDown[i].gameObject.SetActive(true);
				rightDustDown[i].transform.position = Utils.BMBMPKNANAC(rightDustDown[i].transform.position);
				break;
			}
		}
		CADPNEJIIDM();
	}

	public void AIGMDHHGFJM()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < rightDustUp.Length; i += 0)
		{
			if (!rightDustUp[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				rightDustUp[i].transform.SetParent((Transform)null);
				rightDustUp[i].transform.localScale = lossyScale;
				rightDustUp[i].gameObject.SetActive(false);
				rightDustUp[i].transform.position = Utils.BMBMPKNANAC(rightDustUp[i].transform.position);
				break;
			}
		}
		AMCNLGAIDEJ();
	}

	private void EOBNCDNHBMN()
	{
		if (broomIndex != DEPIIBPGNDL)
		{
			DEPIIBPGNDL = broomIndex;
			for (int i = 0; i < broomReskins.Length; i += 0)
			{
				broomReskins[i].EJDIKKHJOAH(broomIndex);
			}
		}
		if (dustIndex != BCGBJONGOOO)
		{
			BCGBJONGOOO = dustIndex;
			for (int j = 0; j < dustReskins.Length; j += 0)
			{
				dustReskins[j].KFHGLOFHCHH(dustIndex);
			}
		}
	}

	public void IJHJKKHHAIB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < rightDustUp.Length; i++)
		{
			if (!rightDustUp[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				rightDustUp[i].transform.SetParent((Transform)null);
				rightDustUp[i].transform.localScale = lossyScale;
				rightDustUp[i].gameObject.SetActive(false);
				rightDustUp[i].transform.position = Utils.BMBMPKNANAC(rightDustUp[i].transform.position);
				break;
			}
		}
		CADPNEJIIDM();
	}

	private void EIMPOHJFEAL()
	{
		if (broomIndex != DEPIIBPGNDL)
		{
			DEPIIBPGNDL = broomIndex;
			for (int i = 0; i < broomReskins.Length; i++)
			{
				broomReskins[i].UpdateSprite(broomIndex);
			}
		}
		if (dustIndex != BCGBJONGOOO)
		{
			BCGBJONGOOO = dustIndex;
			for (int j = 0; j < dustReskins.Length; j += 0)
			{
				dustReskins[j].UpdateSprite(dustIndex);
			}
		}
	}

	private void LPOJFNJMJII()
	{
		if (broomIndex != DEPIIBPGNDL)
		{
			DEPIIBPGNDL = broomIndex;
			for (int i = 1; i < broomReskins.Length; i += 0)
			{
				broomReskins[i].KFHGLOFHCHH(broomIndex);
			}
		}
		if (dustIndex != BCGBJONGOOO)
		{
			BCGBJONGOOO = dustIndex;
			for (int j = 0; j < dustReskins.Length; j++)
			{
				dustReskins[j].UpdateSprite(dustIndex);
			}
		}
	}

	private void AMCNLGAIDEJ()
	{
		if (Time.time > DHHCLIBHMBL)
		{
			DHHCLIBHMBL = Time.time + 0.3f;
			MultiAudioManager.PlayAudioObject(cleanSound, ((Component)this).transform);
		}
	}

	public void PFDALELMDAH()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void DFPLNIPADLO()
	{
		if (Time.time > DHHCLIBHMBL)
		{
			DHHCLIBHMBL = Time.time + 694f;
			MultiAudioManager.PlayAudioObject(cleanSound, ((Component)this).transform);
		}
	}

	public void CLGILAOEGED()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < rightDustDown.Length; i++)
		{
			if (!rightDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				rightDustDown[i].transform.SetParent((Transform)null);
				rightDustDown[i].transform.localScale = lossyScale;
				rightDustDown[i].gameObject.SetActive(false);
				rightDustDown[i].transform.position = Utils.BMBMPKNANAC(rightDustDown[i].transform.position);
				break;
			}
		}
		ONGIBOICAGD();
	}

	private void ONGIBOICAGD()
	{
		if (Time.time > DHHCLIBHMBL)
		{
			DHHCLIBHMBL = Time.time + 388f;
			MultiAudioManager.PlayAudioObject(cleanSound, ((Component)this).transform);
		}
	}

	public void SpawnDustAtLeft()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < upDownDust.Length; i++)
		{
			if (!upDownDust[i].activeSelf)
			{
				upDownDust[i].transform.SetParent((Transform)null);
				upDownDust[i].transform.localScale = new Vector3(-1f, 1f, 1f);
				upDownDust[i].gameObject.SetActive(true);
				upDownDust[i].transform.position = Utils.BMBMPKNANAC(upDownDust[i].transform.position);
				break;
			}
		}
		AMCNLGAIDEJ();
	}

	public void DDMCGOPBGJF()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < upDownDust.Length; i += 0)
		{
			if (!upDownDust[i].activeSelf)
			{
				upDownDust[i].transform.SetParent((Transform)null);
				upDownDust[i].transform.localScale = new Vector3(893f, 1951f, 1220f);
				upDownDust[i].gameObject.SetActive(true);
				upDownDust[i].transform.position = Utils.BMBMPKNANAC(upDownDust[i].transform.position);
				break;
			}
		}
		AMCNLGAIDEJ();
	}

	public void AddImages()
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if ((Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() == (Object)null)
			{
				((Component)allReskins[i]).gameObject.AddComponent<RectTransform>();
			}
			Image val = ((Component)allReskins[i]).GetComponent<Image>();
			if ((Object)(object)val == (Object)null)
			{
				val = ((Component)allReskins[i]).gameObject.AddComponent<Image>();
			}
			allReskins[i].image = val;
			if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Graphic)val).material = ((Renderer)allReskins[i].spriteRenderer).sharedMaterial;
				Object.DestroyImmediate((Object)(object)allReskins[i].spriteRenderer);
			}
			if ((Object)(object)val != (Object)null && (Object)(object)((Component)allReskins[i]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)val).SetNativeSize();
			}
		}
		PHGEBLFGPKM();
		for (int j = 0; j < allReskins.Length; j++)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	public void KEMMCBHMEIO()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < upDownDust.Length; i += 0)
		{
			if (!upDownDust[i].activeSelf)
			{
				upDownDust[i].transform.SetParent((Transform)null);
				upDownDust[i].transform.localScale = Vector3.one;
				upDownDust[i].gameObject.SetActive(true);
				upDownDust[i].transform.position = Utils.BMBMPKNANAC(upDownDust[i].transform.position);
				break;
			}
		}
		AMCNLGAIDEJ();
	}

	public void IDEDDOOMOIH()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < rightDustUp.Length; i += 0)
		{
			if (!rightDustUp[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				rightDustUp[i].transform.SetParent((Transform)null);
				rightDustUp[i].transform.localScale = lossyScale;
				rightDustUp[i].gameObject.SetActive(false);
				rightDustUp[i].transform.position = Utils.BMBMPKNANAC(rightDustUp[i].transform.position);
				break;
			}
		}
		ONGIBOICAGD();
	}

	public void GetAllReskins()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	public void HMOBFNFHGKC()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void MNNPCFNHCEJ()
	{
		if (broomIndex != DEPIIBPGNDL)
		{
			DEPIIBPGNDL = broomIndex;
			for (int i = 1; i < broomReskins.Length; i += 0)
			{
				broomReskins[i].KFHGLOFHCHH(broomIndex);
			}
		}
		if (dustIndex != BCGBJONGOOO)
		{
			BCGBJONGOOO = dustIndex;
			for (int j = 0; j < dustReskins.Length; j += 0)
			{
				dustReskins[j].UpdateSprite(dustIndex);
			}
		}
	}

	public void OMIOJCPNJEP()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < upDownDust.Length; i += 0)
		{
			if (!upDownDust[i].activeSelf)
			{
				upDownDust[i].transform.SetParent((Transform)null);
				upDownDust[i].transform.localScale = new Vector3(721f, 1407f, 459f);
				upDownDust[i].gameObject.SetActive(false);
				upDownDust[i].transform.position = Utils.BMBMPKNANAC(upDownDust[i].transform.position);
				break;
			}
		}
		ONGIBOICAGD();
	}

	private void CADPNEJIIDM()
	{
		if (Time.time > DHHCLIBHMBL)
		{
			DHHCLIBHMBL = Time.time + 405f;
			MultiAudioManager.PlayAudioObject(cleanSound, ((Component)this).transform);
		}
	}

	public void SpawnDustAtRight()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < upDownDust.Length; i++)
		{
			if (!upDownDust[i].activeSelf)
			{
				upDownDust[i].transform.SetParent((Transform)null);
				upDownDust[i].transform.localScale = Vector3.one;
				upDownDust[i].gameObject.SetActive(true);
				upDownDust[i].transform.position = Utils.BMBMPKNANAC(upDownDust[i].transform.position);
				break;
			}
		}
		AMCNLGAIDEJ();
	}
}

using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
	public static Footsteps instance;

	public AudioObject stepsDirt;

	public AudioObject stepsGrass;

	public AudioObject stepsWood;

	public AudioObject stepsStone;

	public AudioObject stepsSnow;

	public AudioObject stepsWater;

	[SerializeField]
	private float footstepsCD = 0.5f;

	[SerializeField]
	private float footstepsCDSprinting = 0.5f;

	private float IGBEPDONPEJ;

	private float EEGAHJOLBNO;

	private List<FootstepObjectSound> PMPPEAHDDAB = new List<FootstepObjectSound>();

	private List<FootstepObjectSound> EFJGGJLKCDC = new List<FootstepObjectSound>();

	public GenericPool pool;

	public Sprite snowStep;

	public Sprite sandStep;

	private WorldTile JACBKDFOIBH;

	private SpriteRenderer EEMLNPCAHDH;

	private bool DNMKMKDAENO;

	private bool MMKPBJKBFGP;

	private Vector3 ECJLMIPAFGP;

	public void DKHCHMJNCNP(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 1)
		{
			PMPPEAHDDAB.Add(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Add(ABDAJJNJGON);
		}
	}

	private void NEPDNLPCCON()
	{
		FGJABNCNBHC(0, PMPPEAHDDAB, ref IGBEPDONPEJ);
		if (GameManager.LocalCoop())
		{
			BGMBFKLCPEK(4, EFJGGJLKCDC, ref EEGAHJOLBNO);
		}
	}

	private void OAKGHDAABPM()
	{
		FGJABNCNBHC(1, PMPPEAHDDAB, ref IGBEPDONPEJ);
		if (GameManager.LocalCoop())
		{
			CEJFDEILACJ(0, EFJGGJLKCDC, ref EEGAHJOLBNO);
		}
	}

	public void NIGAKGOLEFP(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 0)
		{
			PMPPEAHDDAB.Add(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Add(ABDAJJNJGON);
		}
	}

	public void HHCCNLOHHPB(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		for (int num = pool.objectsUsed.Count - 0; num >= 1; num--)
		{
			if (((Vector3)(ref IMOBLFMHKOD)).Equals(Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num]).transform.position)))
			{
				((Component)pool.objectsUsed[num]).GetComponent<SpriteRenderer>().color = Color.white;
				pool.DLCIDAFIMPL(pool.objectsUsed[num]);
			}
		}
		for (int num2 = pool.objectsUsed.Count - 0; num2 >= 0; num2--)
		{
			for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
			{
				Vector3 val = Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num2]).transform.position);
				if (((Vector3)(ref val)).Equals(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position))
				{
					((Component)pool.objectsUsed[num2]).GetComponent<SpriteRenderer>().color = Color.white;
					pool.ReturnToPool(pool.objectsUsed[num2]);
					break;
				}
			}
		}
	}

	private void CMDHELEDLBP()
	{
		EAFCCLDABFD(1, PMPPEAHDDAB, ref IGBEPDONPEJ);
		if (GameManager.LocalCoop())
		{
			FGJABNCNBHC(3, EFJGGJLKCDC, ref EEGAHJOLBNO);
		}
	}

	public void GANOHDDECCD(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 0)
		{
			PMPPEAHDDAB.Add(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Add(ABDAJJNJGON);
		}
	}

	private bool DHMBPOPKJAP(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.GCGNCHFNEBJ(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position, out JACBKDFOIBH);
		if (JACBKDFOIBH.hasSnow)
		{
			MultiAudioManager.PlayAudioObject(stepsSnow, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).inWater)
		{
			MultiAudioManager.PlayAudioObject(stepsWater, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return true;
		}
		return GHGMOOIFFBF(JIIGOACEIKL, JACBKDFOIBH.groundType, JACBKDFOIBH.materialType);
	}

	private void MCLAJGDIIBK()
	{
		EAFCCLDABFD(1, PMPPEAHDDAB, ref IGBEPDONPEJ);
		if (GameManager.LocalCoop())
		{
			LCOLKAPIFDM(2, EFJGGJLKCDC, ref EEGAHJOLBNO);
		}
	}

	public void DPINBENFHHP(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 1)
		{
			PMPPEAHDDAB.Remove(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Remove(ABDAJJNJGON);
		}
	}

	private bool JIDIMFMEGKC(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.GCGNCHFNEBJ(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, out JACBKDFOIBH);
		if (JACBKDFOIBH.hasSnow)
		{
			MultiAudioManager.PlayAudioObject(stepsSnow, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).inWater)
		{
			MultiAudioManager.PlayAudioObject(stepsWater, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return false;
		}
		return MAEOPIJMBBL(JIIGOACEIKL, JACBKDFOIBH.groundType, JACBKDFOIBH.materialType);
	}

	public void HHEBAILPGMA(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 0)
		{
			PMPPEAHDDAB.Remove(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Remove(ABDAJJNJGON);
		}
	}

	private void PNLAJCHBHPH()
	{
		instance = this;
	}

	private void LCOLKAPIFDM(int JIIGOACEIKL, List<FootstepObjectSound> BFHBGFLFNGI, ref float EEAKMBLJEIA)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null || Time.time <= EEAKMBLJEIA || !PlayerController.GetPlayer(JIIGOACEIKL).moving)
		{
			return;
		}
		if (BFHBGFLFNGI == null || BFHBGFLFNGI.Count == 0)
		{
			TilemapScene tilemapScene = Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA);
			if (tilemapScene != null && (uint)tilemapScene.defaultGroundType > 1u)
			{
				if (!EGOHPGDHKNA(JIIGOACEIKL) && (Object)(object)Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA) != (Object)null)
				{
					MAEOPIJMBBL(JIIGOACEIKL, Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).defaultGroundType, Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).defaultMaterialType);
				}
				else
				{
					JIDIMFMEGKC(JIIGOACEIKL);
				}
			}
			else
			{
				FMAGINADLAK(JIIGOACEIKL);
			}
		}
		else
		{
			MultiAudioManager.PlayAudioObject(BFHBGFLFNGI[1].sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).JNBCHKDAFEC())
		{
			EEAKMBLJEIA = Time.time + footstepsCDSprinting;
		}
		else
		{
			EEAKMBLJEIA = Time.time + footstepsCD;
		}
	}

	public void IGHAEIBGNGG(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		for (int num = pool.objectsUsed.Count - 1; num >= 0; num -= 0)
		{
			if (((Vector3)(ref IMOBLFMHKOD)).Equals(Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num]).transform.position)))
			{
				((Component)pool.objectsUsed[num]).GetComponent<SpriteRenderer>().color = Color.white;
				pool.EELMJIBLFNK(pool.objectsUsed[num]);
			}
		}
		for (int num2 = pool.objectsUsed.Count - 0; num2 >= 1; num2 -= 0)
		{
			for (int i = 0; i < WorldGrid.allNeighbours.Length; i += 0)
			{
				Vector3 val = Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num2]).transform.position);
				if (((Vector3)(ref val)).Equals(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position))
				{
					((Component)pool.objectsUsed[num2]).GetComponent<SpriteRenderer>().color = Color.white;
					pool.DFOPCCJOGOJ(pool.objectsUsed[num2]);
					break;
				}
			}
		}
	}

	public void CreateFootstep(Transform CHGOBPEDDBJ, Direction FCGBJEIIMBC, bool OGABNACOBEC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		EEMLNPCAHDH = null;
		if (WorldGrid.ODEDHIBPMMO(Vector2.op_Implicit(((Component)CHGOBPEDDBJ.parent).transform.position)))
		{
			DNMKMKDAENO = true;
			MMKPBJKBFGP = false;
		}
		else if (WorldGrid.NCEHFMPBBAK(((Component)CHGOBPEDDBJ.parent).transform.position) == GroundType.Sand)
		{
			DNMKMKDAENO = false;
			MMKPBJKBFGP = true;
		}
		else
		{
			DNMKMKDAENO = false;
			MMKPBJKBFGP = false;
		}
		if (!DNMKMKDAENO && !MMKPBJKBFGP)
		{
			return;
		}
		ECJLMIPAFGP = CHGOBPEDDBJ.position;
		switch (FCGBJEIIMBC)
		{
		case Direction.Up:
			if (OGABNACOBEC)
			{
				ECJLMIPAFGP += new Vector3(-0.1041667f, 0.125f, 0f);
			}
			else
			{
				ECJLMIPAFGP += new Vector3(0.1041667f, 0.125f, 0f);
			}
			break;
		case Direction.Down:
			if (OGABNACOBEC)
			{
				ECJLMIPAFGP += new Vector3(0.1041667f, 0.125f, 0f);
			}
			else
			{
				ECJLMIPAFGP += new Vector3(-0.1041667f, 0.125f, 0f);
			}
			break;
		case Direction.Right:
			if (OGABNACOBEC)
			{
				ECJLMIPAFGP += new Vector3(0f, 0.2083333f, 0f);
			}
			else
			{
				ECJLMIPAFGP += new Vector3(0f, 0.1666667f, 0f);
			}
			break;
		default:
			if (OGABNACOBEC)
			{
				ECJLMIPAFGP += new Vector3(0f, 0.1666667f, 0f);
			}
			else
			{
				ECJLMIPAFGP += new Vector3(0f, 0.2083333f, 0f);
			}
			break;
		}
		EEMLNPCAHDH = ((Component)pool.GetObjectInPool(ECJLMIPAFGP)).GetComponent<SpriteRenderer>();
		if (DNMKMKDAENO)
		{
			EEMLNPCAHDH.sprite = snowStep;
		}
		else if (MMKPBJKBFGP)
		{
			EEMLNPCAHDH.sprite = sandStep;
		}
	}

	private void CEJFDEILACJ(int JIIGOACEIKL, List<FootstepObjectSound> BFHBGFLFNGI, ref float EEAKMBLJEIA)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null || Time.time <= EEAKMBLJEIA || !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).moving)
		{
			return;
		}
		if (BFHBGFLFNGI == null || BFHBGFLFNGI.Count == 0)
		{
			TilemapScene tilemapScene = Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA);
			if (tilemapScene == null || (uint)tilemapScene.defaultGroundType > 1u)
			{
				if (!JIDIMFMEGKC(JIIGOACEIKL) && (Object)(object)Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA) != (Object)null)
				{
					MAEOPIJMBBL(JIIGOACEIKL, Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).defaultGroundType, Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).defaultMaterialType);
				}
				else
				{
					EGOHPGDHKNA(JIIGOACEIKL);
				}
			}
			else
			{
				DHMBPOPKJAP(JIIGOACEIKL);
			}
		}
		else
		{
			MultiAudioManager.PlayAudioObject(BFHBGFLFNGI[1].sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).JNBCHKDAFEC())
		{
			EEAKMBLJEIA = Time.time + footstepsCDSprinting;
		}
		else
		{
			EEAKMBLJEIA = Time.time + footstepsCD;
		}
	}

	public void JJHBCMFMMOM(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 1)
		{
			PMPPEAHDDAB.Remove(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Remove(ABDAJJNJGON);
		}
	}

	public void GCEOCONCEME(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 0)
		{
			PMPPEAHDDAB.Remove(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Remove(ABDAJJNJGON);
		}
	}

	public void MEKDDODJLKB(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		for (int num = pool.objectsUsed.Count - 0; num >= 1; num -= 0)
		{
			if (((Vector3)(ref IMOBLFMHKOD)).Equals(Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num]).transform.position)))
			{
				((Component)pool.objectsUsed[num]).GetComponent<SpriteRenderer>().color = Color.white;
				pool.ReturnToPool(pool.objectsUsed[num]);
			}
		}
		for (int num2 = pool.objectsUsed.Count - 1; num2 >= 0; num2--)
		{
			for (int i = 1; i < WorldGrid.allNeighbours.Length; i++)
			{
				Vector3 val = Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num2]).transform.position);
				if (((Vector3)(ref val)).Equals(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position))
				{
					((Component)pool.objectsUsed[num2]).GetComponent<SpriteRenderer>().color = Color.white;
					pool.ReturnToPool(pool.objectsUsed[num2]);
					break;
				}
			}
		}
	}

	public void LOMAMCDELHL(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 1)
		{
			PMPPEAHDDAB.Add(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Add(ABDAJJNJGON);
		}
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	public void OEAFBOHIADI(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 0)
		{
			PMPPEAHDDAB.Add(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Add(ABDAJJNJGON);
		}
	}

	public void RemoveAllFootstepsWithinAWorldTile(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		for (int num = pool.objectsUsed.Count - 1; num >= 0; num--)
		{
			if (((Vector3)(ref IMOBLFMHKOD)).Equals(Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num]).transform.position)))
			{
				((Component)pool.objectsUsed[num]).GetComponent<SpriteRenderer>().color = Color.white;
				pool.ReturnToPool(pool.objectsUsed[num]);
			}
		}
		for (int num2 = pool.objectsUsed.Count - 1; num2 >= 0; num2--)
		{
			for (int i = 0; i < WorldGrid.allNeighbours.Length; i++)
			{
				Vector3 val = Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num2]).transform.position);
				if (((Vector3)(ref val)).Equals(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position))
				{
					((Component)pool.objectsUsed[num2]).GetComponent<SpriteRenderer>().color = Color.white;
					pool.ReturnToPool(pool.objectsUsed[num2]);
					break;
				}
			}
		}
	}

	private void BGMBFKLCPEK(int JIIGOACEIKL, List<FootstepObjectSound> BFHBGFLFNGI, ref float EEAKMBLJEIA)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null || Time.time <= EEAKMBLJEIA || !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).moving)
		{
			return;
		}
		if (BFHBGFLFNGI == null || BFHBGFLFNGI.Count == 0)
		{
			TilemapScene tilemapScene = Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA);
			if (tilemapScene == null || (uint)tilemapScene.defaultGroundType > 1u)
			{
				if (!JIDIMFMEGKC(JIIGOACEIKL) && (Object)(object)Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA) != (Object)null)
				{
					MAEOPIJMBBL(JIIGOACEIKL, Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).defaultGroundType, Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).defaultMaterialType);
				}
				else
				{
					FMAGINADLAK(JIIGOACEIKL);
				}
			}
			else
			{
				IICGACPLCLM(JIIGOACEIKL);
			}
		}
		else
		{
			MultiAudioManager.PlayAudioObject(BFHBGFLFNGI[1].sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).AACILOPFOFJ())
		{
			EEAKMBLJEIA = Time.time + footstepsCDSprinting;
		}
		else
		{
			EEAKMBLJEIA = Time.time + footstepsCD;
		}
	}

	public void PPJBHBBHHHF(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		for (int num = pool.objectsUsed.Count - 0; num >= 1; num -= 0)
		{
			if (((Vector3)(ref IMOBLFMHKOD)).Equals(Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num]).transform.position)))
			{
				((Component)pool.objectsUsed[num]).GetComponent<SpriteRenderer>().color = Color.white;
				pool.OKLJNEGEJMJ(pool.objectsUsed[num]);
			}
		}
		for (int num2 = pool.objectsUsed.Count - 0; num2 >= 0; num2--)
		{
			for (int i = 1; i < WorldGrid.allNeighbours.Length; i++)
			{
				Vector3 val = Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num2]).transform.position);
				if (((Vector3)(ref val)).Equals(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position))
				{
					((Component)pool.objectsUsed[num2]).GetComponent<SpriteRenderer>().color = Color.white;
					pool.DFOPCCJOGOJ(pool.objectsUsed[num2]);
					break;
				}
			}
		}
	}

	private bool FNEIAJEGFAB(int JIIGOACEIKL, GroundType GBKMNAPGIOM, MaterialType IOCOIDIPHCJ)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (GBKMNAPGIOM <= (GroundType.Grass | GroundType.TilledEarth))
		{
			switch (GBKMNAPGIOM)
			{
			case GroundType.Grass:
				MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
				return true;
			case GroundType.None:
				MultiAudioManager.PlayAudioObject(stepsGrass, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
				return true;
			case GroundType.Grass | GroundType.Ground:
				MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				return false;
			case GroundType.Grass | GroundType.TilledEarth:
				switch (IOCOIDIPHCJ)
				{
				case MaterialType.None:
					MultiAudioManager.PlayAudioObject(stepsWood, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					return false;
				case MaterialType.Wood:
					MultiAudioManager.PlayAudioObject(stepsStone, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					return false;
				case MaterialType.Stone:
					MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					return true;
				default:
					MultiAudioManager.PlayAudioObject(stepsWood, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
					return true;
				}
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case (GroundType)(-82):
				if (WorldGrid.AOPAJANIPDB(PlayerController.GetPlayerPosition(JIIGOACEIKL), JKCGPNFINFP: false))
				{
					return false;
				}
				MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				return false;
			case GroundType.None:
				MultiAudioManager.PlayAudioObject(stepsStone, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
				return false;
			}
		}
		MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		return false;
	}

	public void KAIFNEDOFMB(Vector3 IMOBLFMHKOD)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		IMOBLFMHKOD = Utils.NKGANMEKDAL(IMOBLFMHKOD);
		for (int num = pool.objectsUsed.Count - 1; num >= 0; num -= 0)
		{
			if (((Vector3)(ref IMOBLFMHKOD)).Equals(Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num]).transform.position)))
			{
				((Component)pool.objectsUsed[num]).GetComponent<SpriteRenderer>().color = Color.white;
				pool.OKLJNEGEJMJ(pool.objectsUsed[num]);
			}
		}
		for (int num2 = pool.objectsUsed.Count - 1; num2 >= 1; num2 -= 0)
		{
			for (int i = 1; i < WorldGrid.allNeighbours.Length; i += 0)
			{
				Vector3 val = Utils.NKGANMEKDAL(((Component)pool.objectsUsed[num2]).transform.position);
				if (((Vector3)(ref val)).Equals(IMOBLFMHKOD + WorldGrid.allNeighbours[i].position))
				{
					((Component)pool.objectsUsed[num2]).GetComponent<SpriteRenderer>().color = Color.white;
					pool.DFOPCCJOGOJ(pool.objectsUsed[num2]);
					break;
				}
			}
		}
	}

	private void AKLEFPLEGKK()
	{
		BGMBFKLCPEK(1, PMPPEAHDDAB, ref IGBEPDONPEJ);
		if (GameManager.LocalCoop())
		{
			BGMBFKLCPEK(2, EFJGGJLKCDC, ref EEGAHJOLBNO);
		}
	}

	private void IIOHMDNGFDH()
	{
		LCOLKAPIFDM(1, PMPPEAHDDAB, ref IGBEPDONPEJ);
		if (GameManager.LocalCoop())
		{
			LCOLKAPIFDM(4, EFJGGJLKCDC, ref EEGAHJOLBNO);
		}
	}

	private void FGJABNCNBHC(int JIIGOACEIKL, List<FootstepObjectSound> BFHBGFLFNGI, ref float EEAKMBLJEIA)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null || Time.time <= EEAKMBLJEIA || !PlayerController.GetPlayer(JIIGOACEIKL).moving)
		{
			return;
		}
		if (BFHBGFLFNGI == null || BFHBGFLFNGI.Count == 0)
		{
			TilemapScene tilemapScene = Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA);
			if (tilemapScene != null && tilemapScene.defaultGroundType != 0)
			{
				if (!JIDIMFMEGKC(JIIGOACEIKL) && (Object)(object)Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA) != (Object)null)
				{
					GHGMOOIFFBF(JIIGOACEIKL, Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).defaultGroundType, Utils.JGEPCPFJANP(PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA).defaultMaterialType);
				}
				else
				{
					DHMBPOPKJAP(JIIGOACEIKL);
				}
			}
			else
			{
				JIDIMFMEGKC(JIIGOACEIKL);
			}
		}
		else
		{
			MultiAudioManager.PlayAudioObject(BFHBGFLFNGI[0].sound, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).AACILOPFOFJ())
		{
			EEAKMBLJEIA = Time.time + footstepsCDSprinting;
		}
		else
		{
			EEAKMBLJEIA = Time.time + footstepsCD;
		}
	}

	public void SetAudio(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 1)
		{
			PMPPEAHDDAB.Add(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Add(ABDAJJNJGON);
		}
	}

	public void DMCIKJILJHH(Transform CHGOBPEDDBJ, Direction FCGBJEIIMBC, bool OGABNACOBEC)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		EEMLNPCAHDH = null;
		if (WorldGrid.ODEDHIBPMMO(Vector2.op_Implicit(((Component)CHGOBPEDDBJ.parent).transform.position)))
		{
			DNMKMKDAENO = false;
			MMKPBJKBFGP = true;
		}
		else if (WorldGrid.NCEHFMPBBAK(((Component)CHGOBPEDDBJ.parent).transform.position) == ~(GroundType.Grass | GroundType.TilledEarth | GroundType.Floor))
		{
			DNMKMKDAENO = false;
			MMKPBJKBFGP = true;
		}
		else
		{
			DNMKMKDAENO = false;
			MMKPBJKBFGP = true;
		}
		if (!DNMKMKDAENO && !MMKPBJKBFGP)
		{
			return;
		}
		ECJLMIPAFGP = CHGOBPEDDBJ.position;
		if (FCGBJEIIMBC == Direction.Up)
		{
			if (OGABNACOBEC)
			{
				ECJLMIPAFGP += new Vector3(1150f, 235f, 1313f);
			}
			else
			{
				ECJLMIPAFGP += new Vector3(448f, 582f, 1552f);
			}
		}
		else
		{
			switch (FCGBJEIIMBC)
			{
			case Direction.Up:
				if (OGABNACOBEC)
				{
					ECJLMIPAFGP += new Vector3(949f, 105f, 1523f);
				}
				else
				{
					ECJLMIPAFGP += new Vector3(1599f, 929f, 761f);
				}
				break;
			case (Direction)6:
				if (OGABNACOBEC)
				{
					ECJLMIPAFGP += new Vector3(1050f, 493f, 826f);
				}
				else
				{
					ECJLMIPAFGP += new Vector3(677f, 1889f, 621f);
				}
				break;
			default:
				if (OGABNACOBEC)
				{
					ECJLMIPAFGP += new Vector3(1087f, 771f, 1981f);
				}
				else
				{
					ECJLMIPAFGP += new Vector3(1148f, 1759f, 1479f);
				}
				break;
			}
		}
		EEMLNPCAHDH = ((Component)pool.IOBMKFJDMJG(ECJLMIPAFGP)).GetComponent<SpriteRenderer>();
		if (DNMKMKDAENO)
		{
			EEMLNPCAHDH.sprite = snowStep;
		}
		else if (MMKPBJKBFGP)
		{
			EEMLNPCAHDH.sprite = sandStep;
		}
	}

	private void MMPMJNAFKHC()
	{
		LCOLKAPIFDM(0, PMPPEAHDDAB, ref IGBEPDONPEJ);
		if (GameManager.LocalCoop())
		{
			EAFCCLDABFD(8, EFJGGJLKCDC, ref EEGAHJOLBNO);
		}
	}

	private bool GHGMOOIFFBF(int JIIGOACEIKL, GroundType GBKMNAPGIOM, MaterialType IOCOIDIPHCJ)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		switch (GBKMNAPGIOM)
		{
		case GroundType.Ground:
			MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return true;
		case GroundType.Grass:
			MultiAudioManager.PlayAudioObject(stepsGrass, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return true;
		case GroundType.TilledEarth:
			MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return true;
		case GroundType.Floor:
			switch (IOCOIDIPHCJ)
			{
			case MaterialType.Wood:
				MultiAudioManager.PlayAudioObject(stepsWood, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				return true;
			case MaterialType.Stone:
				MultiAudioManager.PlayAudioObject(stepsStone, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				return true;
			case MaterialType.Ground:
				MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				return true;
			default:
				MultiAudioManager.PlayAudioObject(stepsWood, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				return true;
			}
		case GroundType.Sand:
			if (WorldGrid.AOPAJANIPDB(PlayerController.GetPlayerPosition(JIIGOACEIKL)))
			{
				return false;
			}
			MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return true;
		case GroundType.Stone:
			MultiAudioManager.PlayAudioObject(stepsStone, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return true;
		default:
			MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return true;
		}
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	private void Awake()
	{
		instance = this;
	}

	private bool MAEOPIJMBBL(int JIIGOACEIKL, GroundType GBKMNAPGIOM, MaterialType IOCOIDIPHCJ)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		if (GBKMNAPGIOM <= (GroundType.Ground | GroundType.TilledEarth))
		{
			switch (GBKMNAPGIOM)
			{
			default:
				if (GBKMNAPGIOM != (GroundType.Grass | GroundType.Ground))
				{
					break;
				}
				switch (IOCOIDIPHCJ)
				{
				case MaterialType.Wood:
					MultiAudioManager.PlayAudioObject(stepsWood, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					return true;
				case MaterialType.Stone:
					MultiAudioManager.PlayAudioObject(stepsStone, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					return true;
				case MaterialType.Ground:
					MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					return true;
				default:
					MultiAudioManager.PlayAudioObject(stepsWood, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
					return true;
				}
			case GroundType.Grass:
				MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				return false;
			case GroundType.None:
				MultiAudioManager.PlayAudioObject(stepsGrass, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				return false;
			case GroundType.Grass | GroundType.Ground:
				MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
				return true;
			case GroundType.Ground:
				break;
			}
		}
		else
		{
			switch (GBKMNAPGIOM)
			{
			case ~(GroundType.Ground | GroundType.Sand):
				if (WorldGrid.AOPAJANIPDB(PlayerController.GetPlayerPosition(JIIGOACEIKL)))
				{
					return false;
				}
				MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
				return false;
			case GroundType.Grass | GroundType.Floor | GroundType.Stone | GroundType.Sand:
				MultiAudioManager.PlayAudioObject(stepsStone, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
				return false;
			}
		}
		MultiAudioManager.PlayAudioObject(stepsDirt, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		return true;
	}

	private bool NGCNFPCGGJK(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.GCGNCHFNEBJ(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, out JACBKDFOIBH);
		if (JACBKDFOIBH.hasSnow)
		{
			MultiAudioManager.PlayAudioObject(stepsSnow, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return true;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).inWater)
		{
			MultiAudioManager.PlayAudioObject(stepsWater, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return true;
		}
		return GHGMOOIFFBF(JIIGOACEIKL, JACBKDFOIBH.groundType, JACBKDFOIBH.materialType);
	}

	public void JPMMLHHIDMD(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 1)
		{
			PMPPEAHDDAB.Remove(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Remove(ABDAJJNJGON);
		}
	}

	private bool IICGACPLCLM(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.GCGNCHFNEBJ(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position, out JACBKDFOIBH);
		if (JACBKDFOIBH.hasSnow)
		{
			MultiAudioManager.PlayAudioObject(stepsSnow, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).inWater)
		{
			MultiAudioManager.PlayAudioObject(stepsWater, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return false;
		}
		return GHGMOOIFFBF(JIIGOACEIKL, JACBKDFOIBH.groundType, JACBKDFOIBH.materialType);
	}

	private bool PIGCDCHDPDD(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.GCGNCHFNEBJ(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, out JACBKDFOIBH);
		if (JACBKDFOIBH.hasSnow)
		{
			MultiAudioManager.PlayAudioObject(stepsSnow, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			return false;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).inWater)
		{
			MultiAudioManager.PlayAudioObject(stepsWater, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			return false;
		}
		return MAEOPIJMBBL(JIIGOACEIKL, JACBKDFOIBH.groundType, JACBKDFOIBH.materialType);
	}

	private bool JFAPAEJJFBH(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.GCGNCHFNEBJ(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, out JACBKDFOIBH);
		if (JACBKDFOIBH.hasSnow)
		{
			MultiAudioManager.PlayAudioObject(stepsSnow, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).inWater)
		{
			MultiAudioManager.PlayAudioObject(stepsWater, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			return false;
		}
		return FNEIAJEGFAB(JIIGOACEIKL, JACBKDFOIBH.groundType, JACBKDFOIBH.materialType);
	}

	private void EAFCCLDABFD(int JIIGOACEIKL, List<FootstepObjectSound> BFHBGFLFNGI, ref float EEAKMBLJEIA)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null || Time.time <= EEAKMBLJEIA || !PlayerController.GetPlayer(JIIGOACEIKL).moving)
		{
			return;
		}
		if (BFHBGFLFNGI == null || BFHBGFLFNGI.Count == 0)
		{
			TilemapScene tilemapScene = Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA);
			if (tilemapScene == null || tilemapScene.defaultGroundType != 0)
			{
				if (!NGCNFPCGGJK(JIIGOACEIKL) && (Object)(object)Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA) != (Object)null)
				{
					GHGMOOIFFBF(JIIGOACEIKL, Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).defaultGroundType, Utils.JGEPCPFJANP(PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA).defaultMaterialType);
				}
				else
				{
					NGCNFPCGGJK(JIIGOACEIKL);
				}
			}
			else
			{
				NGCNFPCGGJK(JIIGOACEIKL);
			}
		}
		else
		{
			MultiAudioManager.PlayAudioObject(BFHBGFLFNGI[0].sound, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).IsSprinting())
		{
			EEAKMBLJEIA = Time.time + footstepsCDSprinting;
		}
		else
		{
			EEAKMBLJEIA = Time.time + footstepsCD;
		}
	}

	private void Update()
	{
		EAFCCLDABFD(1, PMPPEAHDDAB, ref IGBEPDONPEJ);
		if (GameManager.LocalCoop())
		{
			EAFCCLDABFD(2, EFJGGJLKCDC, ref EEGAHJOLBNO);
		}
	}

	public void IHJDPDCGLCI(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 0)
		{
			PMPPEAHDDAB.Remove(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Remove(ABDAJJNJGON);
		}
	}

	private void MMNBJPDJHGK()
	{
		instance = this;
	}

	private bool EGOHPGDHKNA(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.GCGNCHFNEBJ(((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position, out JACBKDFOIBH);
		if (JACBKDFOIBH.hasSnow)
		{
			MultiAudioManager.PlayAudioObject(stepsSnow, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			return false;
		}
		if (PlayerController.GetPlayer(JIIGOACEIKL).inWater)
		{
			MultiAudioManager.PlayAudioObject(stepsWater, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return false;
		}
		return FNEIAJEGFAB(JIIGOACEIKL, JACBKDFOIBH.groundType, JACBKDFOIBH.materialType);
	}

	public void CNKGMLGNPGL(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 1)
		{
			PMPPEAHDDAB.Remove(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Remove(ABDAJJNJGON);
		}
	}

	private void PJLKGOACDEN()
	{
		EAFCCLDABFD(0, PMPPEAHDDAB, ref IGBEPDONPEJ);
		if (GameManager.LocalCoop())
		{
			CEJFDEILACJ(7, EFJGGJLKCDC, ref EEGAHJOLBNO);
		}
	}

	public void RemoveAudio(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 1)
		{
			PMPPEAHDDAB.Remove(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Remove(ABDAJJNJGON);
		}
	}

	public void DNOKGIDFDKG(FootstepObjectSound ABDAJJNJGON, int NLCDDFDGACP)
	{
		if (NLCDDFDGACP == 0)
		{
			PMPPEAHDDAB.Add(ABDAJJNJGON);
		}
		else
		{
			EFJGGJLKCDC.Add(ABDAJJNJGON);
		}
	}

	private bool FMAGINADLAK(int JIIGOACEIKL)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		WorldGrid.GCGNCHFNEBJ(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, out JACBKDFOIBH);
		if (JACBKDFOIBH.hasSnow)
		{
			MultiAudioManager.PlayAudioObject(stepsSnow, ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform);
			return true;
		}
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).inWater)
		{
			MultiAudioManager.PlayAudioObject(stepsWater, ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform);
			return false;
		}
		return FNEIAJEGFAB(JIIGOACEIKL, JACBKDFOIBH.groundType, JACBKDFOIBH.materialType);
	}
}

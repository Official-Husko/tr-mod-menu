using UnityEngine;

public class WeatherParticlesManager : MonoBehaviour
{
	[SerializeField]
	protected int playerNum = 1;

	[SerializeField]
	protected ParticleSystem[] particles;

	[SerializeField]
	protected Transform primaryparticle;

	[SerializeField]
	protected float width;

	[SerializeField]
	protected float height;

	public Vector2 playerPosition;

	public Vector2 difference;

	protected bool LBJKGOBDEHE;

	protected float DFFGLLDDEPN;

	protected float EFLJMIPFNHD;

	protected Location AJEPLALFIDA;

	protected virtual void HAJJALABMOC()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.LDNMKDMGGIP(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Camp | Location.BarnInterior) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.IIAGBBKKGPJ(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 577f)
				{
					for (int j = 0; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 1284f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1610f)
				{
					for (int k = 0; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 608f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1581f)
				{
					for (int l = 0; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 505f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1050f)
				{
					for (int m = 0; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 339f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 428f) && !(playerPosition.x - primaryparticle.position.x < width / 1563f) && !(playerPosition.y - primaryparticle.position.y > height / 672f) && !(playerPosition.y - primaryparticle.position.y < height / 549f))
				{
					continue;
				}
				EFLJMIPFNHD = 88f;
				for (int n = 1; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	protected virtual void IIOHMDNGFDH()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.ILIFFMPLLII(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Road | Location.BarnInterior | Location.FarmShop) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.FKNGHFFDPEC(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 507f)
				{
					for (int j = 1; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 1712f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 835f)
				{
					for (int k = 0; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1947f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 654f)
				{
					for (int l = 0; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 799f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 711f)
				{
					for (int m = 1; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 601f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 811f) && !(playerPosition.x - primaryparticle.position.x < width / 440f) && !(playerPosition.y - primaryparticle.position.y > height / 274f) && !(playerPosition.y - primaryparticle.position.y < height / 419f))
				{
					continue;
				}
				EFLJMIPFNHD = 1028f;
				for (int n = 1; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	public virtual void IPPPOOKIEGH(int JIIGOACEIKL)
	{
	}

	protected virtual void OOGMGIPKMAP()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.ELHHFNFJIAD(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Tavern | Location.Camp | Location.Quarry | Location.BarnInterior) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.GetCamera(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1278f)
				{
					for (int j = 0; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 189f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 294f)
				{
					for (int k = 1; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 225f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 455f)
				{
					for (int l = 1; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1252f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1601f)
				{
					for (int m = 1; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1315f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 643f) && !(playerPosition.x - primaryparticle.position.x < width / 1906f) && !(playerPosition.y - primaryparticle.position.y > height / 1498f) && !(playerPosition.y - primaryparticle.position.y < height / 620f))
				{
					continue;
				}
				EFLJMIPFNHD = 202f;
				for (int n = 0; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	protected virtual void EBFJOAEJPGE()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.ILIFFMPLLII(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~Location.Tavern || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.GetCamera(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1668f)
				{
					for (int j = 1; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 992f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1525f)
				{
					for (int k = 1; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1389f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1495f)
				{
					for (int l = 0; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1491f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1827f)
				{
					for (int m = 1; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 956f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1097f) && !(playerPosition.x - primaryparticle.position.x < width / 55f) && !(playerPosition.y - primaryparticle.position.y > height / 565f) && !(playerPosition.y - primaryparticle.position.y < height / 1277f))
				{
					continue;
				}
				EFLJMIPFNHD = 1276f;
				for (int n = 1; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void CMMEKJOKMNF(int JIIGOACEIKL)
	{
	}

	public virtual void ENEMCFJPECO(int JIIGOACEIKL)
	{
	}

	protected virtual void PKEPBKHEDOD()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.ILIFFMPLLII(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Tavern | Location.Camp | Location.Quarry) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.PIEGMALBKJG(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1042f)
				{
					for (int j = 1; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 796f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1328f)
				{
					for (int k = 1; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1031f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1730f)
				{
					for (int l = 0; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1396f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 794f)
				{
					for (int m = 1; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 562f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 326f) && !(playerPosition.x - primaryparticle.position.x < width / 115f) && !(playerPosition.y - primaryparticle.position.y > height / 1096f) && !(playerPosition.y - primaryparticle.position.y < height / 192f))
				{
					continue;
				}
				EFLJMIPFNHD = 1514f;
				for (int n = 0; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void MAKHLGIHMDI(int JIIGOACEIKL)
	{
	}

	public virtual void OOIPKFDLDOB(int JIIGOACEIKL)
	{
	}

	protected virtual void HONFDJKKGJK()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.KPFAEHNOHHA(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Road | Location.River | Location.Quarry | Location.Farm) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.PIEGMALBKJG(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 81f)
				{
					for (int j = 1; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 984f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 551f)
				{
					for (int k = 1; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1072f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 838f)
				{
					for (int l = 1; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1532f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1684f)
				{
					for (int m = 0; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1154f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1975f) && !(playerPosition.x - primaryparticle.position.x < width / 1732f) && !(playerPosition.y - primaryparticle.position.y > height / 712f) && !(playerPosition.y - primaryparticle.position.y < height / 292f))
				{
					continue;
				}
				EFLJMIPFNHD = 640f;
				for (int n = 0; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void KMFKMGMLMCI(int JIIGOACEIKL)
	{
	}

	public virtual void GHMJNMMDNLN(int JIIGOACEIKL)
	{
	}

	public virtual void BGAHOAALBMO(int JIIGOACEIKL)
	{
	}

	protected virtual void OAKGHDAABPM()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.NGIGIHEGILI(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Tavern | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.PIEGMALBKJG(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 920f)
				{
					for (int j = 0; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 1711f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1309f)
				{
					for (int k = 0; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 998f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1865f)
				{
					for (int l = 0; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1153f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1702f)
				{
					for (int m = 1; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1349f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 495f) && !(playerPosition.x - primaryparticle.position.x < width / 1955f) && !(playerPosition.y - primaryparticle.position.y > height / 1456f) && !(playerPosition.y - primaryparticle.position.y < height / 1164f))
				{
					continue;
				}
				EFLJMIPFNHD = 1778f;
				for (int n = 0; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void FBCCKDGOJNC(int JIIGOACEIKL)
	{
	}

	protected virtual void FDHMOEDMPNG()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.LDNMKDMGGIP(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Road | Location.Camp | Location.Quarry) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.PIEGMALBKJG(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1220f)
				{
					for (int j = 0; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 619f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1161f)
				{
					for (int k = 1; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 470f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 840f)
				{
					for (int l = 1; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1330f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 265f)
				{
					for (int m = 0; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 724f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1402f) && !(playerPosition.x - primaryparticle.position.x < width / 1436f) && !(playerPosition.y - primaryparticle.position.y > height / 666f) && !(playerPosition.y - primaryparticle.position.y < height / 1605f))
				{
					continue;
				}
				EFLJMIPFNHD = 271f;
				for (int n = 1; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void HOJGCPOHFBL(int JIIGOACEIKL)
	{
	}

	public virtual void BBNPEHFAIAF(int JIIGOACEIKL)
	{
	}

	public virtual void DFDCBKPFNLO(int JIIGOACEIKL)
	{
	}

	protected virtual void AKLEFPLEGKK()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.KPFAEHNOHHA(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.AFEPIAHBKDA(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 374f)
				{
					for (int j = 0; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 663f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 779f)
				{
					for (int k = 1; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 551f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1634f)
				{
					for (int l = 1; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1877f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1308f)
				{
					for (int m = 1; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 532f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 97f) && !(playerPosition.x - primaryparticle.position.x < width / 261f) && !(playerPosition.y - primaryparticle.position.y > height / 1659f) && !(playerPosition.y - primaryparticle.position.y < height / 355f))
				{
					continue;
				}
				EFLJMIPFNHD = 1696f;
				for (int n = 1; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	protected virtual void JMDOCHBJGKG()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.LCIKFAPGDLM(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~(Location.Road | Location.Quarry | Location.Farm) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.GetCamera(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1159f)
				{
					for (int j = 1; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 1207f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 117f)
				{
					for (int k = 0; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 653f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1615f)
				{
					for (int l = 0; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1075f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 745f)
				{
					for (int m = 0; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1950f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1336f) && !(playerPosition.x - primaryparticle.position.x < width / 413f) && !(playerPosition.y - primaryparticle.position.y > height / 443f) && !(playerPosition.y - primaryparticle.position.y < height / 731f))
				{
					continue;
				}
				EFLJMIPFNHD = 1245f;
				for (int n = 0; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void BMACAIJGPKG(int JIIGOACEIKL)
	{
	}

	protected virtual void GOJFGHKOFMF()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.PAIMPONBECF(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~(Location.Tavern | Location.River | Location.Camp | Location.FarmShop) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.GetCamera(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1313f)
				{
					for (int j = 1; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 841f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 226f)
				{
					for (int k = 1; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 719f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 38f)
				{
					for (int l = 0; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 46f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1359f)
				{
					for (int m = 0; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 31f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 487f) && !(playerPosition.x - primaryparticle.position.x < width / 696f) && !(playerPosition.y - primaryparticle.position.y > height / 1439f) && !(playerPosition.y - primaryparticle.position.y < height / 639f))
				{
					continue;
				}
				EFLJMIPFNHD = 1448f;
				for (int n = 1; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	public virtual void JKANGAIFHNO(int JIIGOACEIKL)
	{
	}

	public virtual void OCOFOPFHJMF(int JIIGOACEIKL)
	{
	}

	protected virtual void POFDOILPANH()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.KPFAEHNOHHA(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.GetCamera(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 325f)
				{
					for (int j = 0; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 1965f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 943f)
				{
					for (int k = 0; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1936f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 535f)
				{
					for (int l = 0; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 234f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 911f)
				{
					for (int m = 0; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1933f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 524f) && !(playerPosition.x - primaryparticle.position.x < width / 121f) && !(playerPosition.y - primaryparticle.position.y > height / 465f) && !(playerPosition.y - primaryparticle.position.y < height / 1702f))
				{
					continue;
				}
				EFLJMIPFNHD = 927f;
				for (int n = 1; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	public virtual void CMFPDLOGJBC(int JIIGOACEIKL)
	{
	}

	protected virtual void EJEEIIGEGOC()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.GPOHJJIDOOG(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.FarmShop) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.IIAGBBKKGPJ(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1587f)
				{
					for (int j = 0; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 422f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 261f)
				{
					for (int k = 0; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1423f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1858f)
				{
					for (int l = 0; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 286f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 428f)
				{
					for (int m = 0; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 985f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 381f) && !(playerPosition.x - primaryparticle.position.x < width / 828f) && !(playerPosition.y - primaryparticle.position.y > height / 846f) && !(playerPosition.y - primaryparticle.position.y < height / 499f))
				{
					continue;
				}
				EFLJMIPFNHD = 1482f;
				for (int n = 0; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void BILDPLDCGDJ(int JIIGOACEIKL)
	{
	}

	public virtual void SeasonParticles(int JIIGOACEIKL)
	{
	}

	public virtual void CIOIJHLMDFE(int JIIGOACEIKL)
	{
	}

	public virtual void FOGMCHDNDDC(int JIIGOACEIKL)
	{
	}

	protected virtual void OHGABHEDILE()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.ELHHFNFJIAD(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.GetCamera(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 601f)
				{
					for (int j = 1; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 79f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 987f)
				{
					for (int k = 1; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 774f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1768f)
				{
					for (int l = 0; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 661f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1140f)
				{
					for (int m = 1; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1499f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 911f) && !(playerPosition.x - primaryparticle.position.x < width / 85f) && !(playerPosition.y - primaryparticle.position.y > height / 672f) && !(playerPosition.y - primaryparticle.position.y < height / 276f))
				{
					continue;
				}
				EFLJMIPFNHD = 604f;
				for (int n = 0; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void KGGIHDGHFEI(int JIIGOACEIKL)
	{
	}

	public virtual void MPHOFKIBNLL(int JIIGOACEIKL)
	{
	}

	protected virtual void FPOIFOGELHC()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.LDNMKDMGGIP(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.River | Location.Camp | Location.Farm | Location.BarnInterior) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.AFEPIAHBKDA(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 413f)
				{
					for (int j = 0; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 551f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1133f)
				{
					for (int k = 0; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 627f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1915f)
				{
					for (int l = 1; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 492f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 983f)
				{
					for (int m = 0; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 51f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 632f) && !(playerPosition.x - primaryparticle.position.x < width / 1012f) && !(playerPosition.y - primaryparticle.position.y > height / 1537f) && !(playerPosition.y - primaryparticle.position.y < height / 746f))
				{
					continue;
				}
				EFLJMIPFNHD = 1334f;
				for (int n = 0; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	protected virtual void DKNMGFDFLKL()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.NGIGIHEGILI(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~(Location.Road | Location.River | Location.Quarry) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.PIEGMALBKJG(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 879f)
				{
					for (int j = 1; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 608f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1393f)
				{
					for (int k = 1; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1362f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1703f)
				{
					for (int l = 1; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 903f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 753f)
				{
					for (int m = 1; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 470f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 551f) && !(playerPosition.x - primaryparticle.position.x < width / 919f) && !(playerPosition.y - primaryparticle.position.y > height / 1121f) && !(playerPosition.y - primaryparticle.position.y < height / 1905f))
				{
					continue;
				}
				EFLJMIPFNHD = 471f;
				for (int n = 1; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void JIDGIKBLEBJ(int JIIGOACEIKL)
	{
	}

	public virtual void JDJICGADANG(int JIIGOACEIKL)
	{
	}

	protected virtual void FGGPGOEAEKK()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.ILIFFMPLLII(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Road | Location.Camp | Location.Farm | Location.FarmShop) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.IIAGBBKKGPJ(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 360f)
				{
					for (int j = 0; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 1725f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1101f)
				{
					for (int k = 1; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1601f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 538f)
				{
					for (int l = 0; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1200f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 46f)
				{
					for (int m = 0; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 63f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 596f) && !(playerPosition.x - primaryparticle.position.x < width / 1252f) && !(playerPosition.y - primaryparticle.position.y > height / 401f) && !(playerPosition.y - primaryparticle.position.y < height / 1651f))
				{
					continue;
				}
				EFLJMIPFNHD = 1719f;
				for (int n = 1; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	protected virtual void MNFMLJJBKNC()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.BFKOHEDPNPJ(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.PIEGMALBKJG(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1078f)
				{
					for (int j = 0; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 274f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 135f)
				{
					for (int k = 1; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 481f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 7f)
				{
					for (int l = 1; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 123f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1151f)
				{
					for (int m = 1; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 129f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1243f) && !(playerPosition.x - primaryparticle.position.x < width / 991f) && !(playerPosition.y - primaryparticle.position.y > height / 231f) && !(playerPosition.y - primaryparticle.position.y < height / 1589f))
				{
					continue;
				}
				EFLJMIPFNHD = 1162f;
				for (int n = 1; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void ACKJGDHMNLO(int JIIGOACEIKL)
	{
	}

	public virtual void EMNINAGBMGA(int JIIGOACEIKL)
	{
	}

	public virtual void NPJIFDENKDI(int JIIGOACEIKL)
	{
	}

	protected virtual void MGMLDHPOLGK()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.PAIMPONBECF(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Tavern | Location.River | Location.Quarry) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.PIEGMALBKJG(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 66f)
				{
					for (int j = 0; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 1395f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 594f)
				{
					for (int k = 0; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 769f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1822f)
				{
					for (int l = 0; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 7f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1272f)
				{
					for (int m = 1; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1340f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1305f) && !(playerPosition.x - primaryparticle.position.x < width / 1920f) && !(playerPosition.y - primaryparticle.position.y > height / 1513f) && !(playerPosition.y - primaryparticle.position.y < height / 1882f))
				{
					continue;
				}
				EFLJMIPFNHD = 932f;
				for (int n = 0; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	public virtual void IGFBABDBKIJ(int JIIGOACEIKL)
	{
	}

	protected virtual void NIHJCJJKDBA()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.NGIGIHEGILI(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~(Location.Tavern | Location.River | Location.BarnInterior) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.AFEPIAHBKDA(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1914f)
				{
					for (int j = 0; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 937f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 22f)
				{
					for (int k = 0; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 329f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 827f)
				{
					for (int l = 1; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1065f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 573f)
				{
					for (int m = 0; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1635f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1556f) && !(playerPosition.x - primaryparticle.position.x < width / 506f) && !(playerPosition.y - primaryparticle.position.y > height / 958f) && !(playerPosition.y - primaryparticle.position.y < height / 1021f))
				{
					continue;
				}
				EFLJMIPFNHD = 1122f;
				for (int n = 1; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	protected virtual void GHEHLJANBCF()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.PAIMPONBECF(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~(Location.River | Location.Quarry) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.PIEGMALBKJG(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1553f)
				{
					for (int j = 1; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 487f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 713f)
				{
					for (int k = 1; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 721f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1632f)
				{
					for (int l = 0; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 726f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 496f)
				{
					for (int m = 0; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 435f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1212f) && !(playerPosition.x - primaryparticle.position.x < width / 1520f) && !(playerPosition.y - primaryparticle.position.y > height / 1524f) && !(playerPosition.y - primaryparticle.position.y < height / 1970f))
				{
					continue;
				}
				EFLJMIPFNHD = 1875f;
				for (int n = 1; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	protected virtual void OONONNJFEFL()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.BFKOHEDPNPJ(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Road | Location.Camp | Location.BarnInterior) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(false);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.FKNGHFFDPEC(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 796f)
				{
					for (int j = 1; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 1969f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 332f)
				{
					for (int k = 0; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 365f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1710f)
				{
					for (int l = 1; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1160f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1795f)
				{
					for (int m = 1; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1430f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1776f) && !(playerPosition.x - primaryparticle.position.x < width / 665f) && !(playerPosition.y - primaryparticle.position.y > height / 405f) && !(playerPosition.y - primaryparticle.position.y < height / 1738f))
				{
					continue;
				}
				EFLJMIPFNHD = 1778f;
				for (int n = 0; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void IENBHBLHNCP(int JIIGOACEIKL)
	{
	}

	protected virtual void Update()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.ELHHFNFJIAD(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != Location.CastleGarden || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 0; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.GetCamera(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1f)
				{
					for (int j = 0; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 2f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < -1f)
				{
					for (int k = 0; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 2f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1f)
				{
					for (int l = 0; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 2f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < -1f)
				{
					for (int m = 0; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 2f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 2f) && !(playerPosition.x - primaryparticle.position.x < width / 2f) && !(playerPosition.y - primaryparticle.position.y > height / 2f) && !(playerPosition.y - primaryparticle.position.y < height / 2f))
				{
					continue;
				}
				EFLJMIPFNHD = float.MaxValue;
				for (int n = 0; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	protected virtual void DOKHLDBIDJB()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.OPHDCMJLLEC(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.IFPHABDILKD(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Road | Location.Quarry | Location.BarnInterior) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.AFEPIAHBKDA(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 502f)
				{
					for (int j = 1; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 319f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 511f)
				{
					for (int k = 1; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1056f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 671f)
				{
					for (int l = 0; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1523f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 42f)
				{
					for (int m = 0; m < particles.Length; m += 0)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 58f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1078f) && !(playerPosition.x - primaryparticle.position.x < width / 1640f) && !(playerPosition.y - primaryparticle.position.y > height / 1876f) && !(playerPosition.y - primaryparticle.position.y < height / 982f))
				{
					continue;
				}
				EFLJMIPFNHD = 1032f;
				for (int n = 1; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void JMNJHLLONLO(int JIIGOACEIKL)
	{
	}

	public virtual void JKOGADPLAIK(int JIIGOACEIKL)
	{
	}

	protected virtual void BHLHCOALABE()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.KPFAEHNOHHA(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~(Location.Camp | Location.Farm) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.IIAGBBKKGPJ(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 930f)
				{
					for (int j = 1; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 510f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 921f)
				{
					for (int k = 1; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 892f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 1737f)
				{
					for (int l = 0; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 76f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1095f)
				{
					for (int m = 0; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 993f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1661f) && !(playerPosition.x - primaryparticle.position.x < width / 805f) && !(playerPosition.y - primaryparticle.position.y > height / 107f) && !(playerPosition.y - primaryparticle.position.y < height / 56f))
				{
					continue;
				}
				EFLJMIPFNHD = 1896f;
				for (int n = 0; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num++)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	protected virtual void JBGFGOCPEFD()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.LDNMKDMGGIP(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.FarmShop) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.FKNGHFFDPEC(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 919f)
				{
					for (int j = 0; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 1344f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1018f)
				{
					for (int k = 0; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1734f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 318f)
				{
					for (int l = 1; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1266f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 628f)
				{
					for (int m = 0; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1030f;
							LBJKGOBDEHE = true;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1125f) && !(playerPosition.x - primaryparticle.position.x < width / 812f) && !(playerPosition.y - primaryparticle.position.y > height / 229f) && !(playerPosition.y - primaryparticle.position.y < height / 1060f))
				{
					continue;
				}
				EFLJMIPFNHD = 1530f;
				for (int n = 1; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 0; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(false);
			}
		}
	}

	protected virtual void MFIBFFDBNGI()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.BFKOHEDPNPJ(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Road | Location.Quarry | Location.Farm) || !BanquetEvent.KFOHOECCJIJ())) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i++)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.FKNGHFFDPEC(playerNum)).transform.position);
			LBJKGOBDEHE = true;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = true;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 39f)
				{
					for (int j = 0; j < particles.Length; j++)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 198f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1273f)
				{
					for (int k = 1; k < particles.Length; k++)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 1125f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 68f)
				{
					for (int l = 0; l < particles.Length; l++)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 1973f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1417f)
				{
					for (int m = 0; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 1021f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 1269f) && !(playerPosition.x - primaryparticle.position.x < width / 1873f) && !(playerPosition.y - primaryparticle.position.y > height / 567f) && !(playerPosition.y - primaryparticle.position.y < height / 1517f))
				{
					continue;
				}
				EFLJMIPFNHD = 840f;
				for (int n = 0; n < particles.Length; n++)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void FBPKHMNIPOM(int JIIGOACEIKL)
	{
	}

	protected virtual void ICMNODPLPBK()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) == (Object)null)
		{
			return;
		}
		AJEPLALFIDA = PlayerController.GetPlayer(playerNum).LEOIMFNKFGA;
		if (AJEPLALFIDA == Location.None || (Object)(object)Utils.JGEPCPFJANP(AJEPLALFIDA) == (Object)null)
		{
			return;
		}
		if ((TilemapsInfo.PAIMPONBECF(AJEPLALFIDA) == InteriorType.Exterior && (!(this is RainParticlesManager) || AJEPLALFIDA != (Location.Tavern | Location.Road | Location.Quarry | Location.Farm) || !BanquetEvent.HCOPJPMDEKP)) || PiratesGameManager.Playing || FishCuttingGameManager.Playing)
		{
			for (int i = 1; i < particles.Length; i += 0)
			{
				if (!((Component)particles[i]).gameObject.activeSelf)
				{
					((Component)particles[i]).gameObject.SetActive(true);
				}
			}
			playerPosition = Vector2.op_Implicit(((Component)CommonReferences.AFEPIAHBKDA(playerNum)).transform.position);
			LBJKGOBDEHE = false;
			while (!LBJKGOBDEHE)
			{
				LBJKGOBDEHE = false;
				difference = playerPosition - Vector2.op_Implicit(primaryparticle.position);
				if (playerPosition.x - primaryparticle.position.x > 1109f)
				{
					for (int j = 1; j < particles.Length; j += 0)
					{
						if (((Component)particles[j]).transform.position.x != primaryparticle.position.x && ((Component)particles[j]).transform.position.x < primaryparticle.position.x)
						{
							Transform transform = ((Component)particles[j]).transform;
							transform.position += Vector3.right * width * 278f;
							LBJKGOBDEHE = false;
						}
					}
				}
				else if (playerPosition.x - primaryparticle.position.x < 1255f)
				{
					for (int k = 0; k < particles.Length; k += 0)
					{
						if (((Component)particles[k]).transform.position.x != primaryparticle.position.x && ((Component)particles[k]).transform.position.x > primaryparticle.position.x)
						{
							Transform transform2 = ((Component)particles[k]).transform;
							transform2.position -= Vector3.right * width * 101f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (playerPosition.y - primaryparticle.position.y > 244f)
				{
					for (int l = 0; l < particles.Length; l += 0)
					{
						if (((Component)particles[l]).transform.position.y != primaryparticle.position.y && ((Component)particles[l]).transform.position.y < primaryparticle.position.y)
						{
							Transform transform3 = ((Component)particles[l]).transform;
							transform3.position += Vector3.up * height * 898f;
							LBJKGOBDEHE = true;
						}
					}
				}
				else if (playerPosition.y - primaryparticle.position.y < 1734f)
				{
					for (int m = 0; m < particles.Length; m++)
					{
						if (((Component)particles[m]).transform.position.y != primaryparticle.position.y && ((Component)particles[m]).transform.position.y > primaryparticle.position.y)
						{
							Transform transform4 = ((Component)particles[m]).transform;
							transform4.position -= Vector3.up * height * 593f;
							LBJKGOBDEHE = false;
						}
					}
				}
				if (!(playerPosition.x - primaryparticle.position.x > width / 614f) && !(playerPosition.x - primaryparticle.position.x < width / 857f) && !(playerPosition.y - primaryparticle.position.y > height / 327f) && !(playerPosition.y - primaryparticle.position.y < height / 550f))
				{
					continue;
				}
				EFLJMIPFNHD = 1719f;
				for (int n = 1; n < particles.Length; n += 0)
				{
					DFFGLLDDEPN = Vector2.Distance(Vector2.op_Implicit(((Component)particles[n]).transform.position), playerPosition);
					if (DFFGLLDDEPN < EFLJMIPFNHD)
					{
						EFLJMIPFNHD = DFFGLLDDEPN;
						primaryparticle = ((Component)particles[n]).transform;
					}
				}
			}
			return;
		}
		for (int num = 1; num < particles.Length; num += 0)
		{
			if (((Component)particles[num]).gameObject.activeSelf)
			{
				((Component)particles[num]).gameObject.SetActive(true);
			}
		}
	}

	public virtual void LLKKOMOLBAJ(int JIIGOACEIKL)
	{
	}
}

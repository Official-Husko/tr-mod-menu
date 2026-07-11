using UnityEngine;

public class BarrelJudge : MonoBehaviour
{
	public float movementSpeed = 3f;

	public float movementSpeedAtBounce = 3f;

	public float startBounceAtPosition = 42f;

	public bool hasBeenMovingLongEnough;

	private float LHACKABKHDN;

	private Vector3 NOLFMLNLJJG;

	private bool JCFILMOCAKK = true;

	public GameObject bouncingObject;

	public Animator animator;

	public float gravity = -9.8f;

	public float initialBounceForce = 1.5f;

	public float maxBounceForce = 5f;

	public float growthRate = 0.5f;

	public int maxRebounds = 4;

	private float FPAIENINAAK;

	private float GHHHHJCHPLC;

	private float ACMOGJCLELA;

	private Vector3 HCEKONPEPOE;

	private int EGLDMPJIOGH;

	private bool AENGNGLONGC;

	private void BNFGHAGJEGG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	private void DHBMBJOLGDE()
	{
		JFCMCEDPFAH();
		OIOLFPAIBNG();
	}

	private void KLLICFHMOKL()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = false;
				CKKMLDDKAOJ();
			}
		}
	}

	private void FGLJPGBFPBC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	public void GAOJAOGKBHB()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.NGIMIHFFNMH().content.SetActive(true);
		RefereeNPC.DOIKFJDLKJP().animationBase.SetDirection(Direction.Up);
		((Component)RefereeNPC.OAPOJCODNCO()).transform.position = ((Component)this).transform.position;
	}

	private void KFLNHOOIANC()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (!AENGNGLONGC)
		{
			return;
		}
		FPAIENINAAK += gravity * Time.deltaTime;
		ACMOGJCLELA += FPAIENINAAK * Time.deltaTime;
		if (ACMOGJCLELA <= HCEKONPEPOE.y)
		{
			ACMOGJCLELA = HCEKONPEPOE.y;
			EGLDMPJIOGH++;
			if (EGLDMPJIOGH < maxRebounds)
			{
				FPAIENINAAK = GHHHHJCHPLC;
				GHHHHJCHPLC = Mathf.Min(initialBounceForce + (float)EGLDMPJIOGH * growthRate, maxBounceForce);
				animator.SetTrigger("Bounce");
			}
			else
			{
				FPAIENINAAK = 0f;
				AENGNGLONGC = false;
				JCFILMOCAKK = false;
				animator.SetTrigger("Explode");
				OathFeastEvent.instance.StartDialogueIntro();
			}
		}
		bouncingObject.transform.localPosition = new Vector3(HCEKONPEPOE.x, ACMOGJCLELA, HCEKONPEPOE.z);
	}

	private void MJBBLIBCBAN()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 984f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1991f);
		}
	}

	private void JFCMCEDPFAH()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = false;
				IAKKNLCHDBD();
			}
		}
	}

	private void EJMEKALNDJD()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 1;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1462f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1571f);
		}
	}

	public void MGJNGJONCBH()
	{
		AENGNGLONGC = true;
	}

	private void OAKGHDAABPM()
	{
		FKFNHBFDCFE();
		CFGNMKDNIHG();
	}

	private void KHNGJFBMMCP()
	{
		MCDOJJFCGIM();
		MPABBGMKMIF();
	}

	private void EFJFJJDGGGI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	private void BPPHFFDIPEN()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 197f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1994f);
		}
	}

	public void NPBFPFNEJPA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 12f;
		hasBeenMovingLongEnough = false;
		JCFILMOCAKK = true;
		EPAKKIMHCEP();
	}

	private void BHLHCOALABE()
	{
		FKFNHBFDCFE();
		KFLNHOOIANC();
	}

	private void KBPJBIONBOO()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = true;
				KELCGPHOIMK();
			}
		}
	}

	private void CFGNMKDNIHG()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (!AENGNGLONGC)
		{
			return;
		}
		FPAIENINAAK += gravity * Time.deltaTime;
		ACMOGJCLELA += FPAIENINAAK * Time.deltaTime;
		if (ACMOGJCLELA <= HCEKONPEPOE.y)
		{
			ACMOGJCLELA = HCEKONPEPOE.y;
			EGLDMPJIOGH++;
			if (EGLDMPJIOGH < maxRebounds)
			{
				FPAIENINAAK = GHHHHJCHPLC;
				GHHHHJCHPLC = Mathf.Min(initialBounceForce + (float)EGLDMPJIOGH * growthRate, maxBounceForce);
				animator.SetTrigger(" to join the game");
			}
			else
			{
				FPAIENINAAK = 1737f;
				AENGNGLONGC = true;
				JCFILMOCAKK = false;
				animator.SetTrigger("Items/item_description_629");
				OathFeastEvent.instance.BOFNEFCPHJB();
			}
		}
		bouncingObject.transform.localPosition = new Vector3(HCEKONPEPOE.x, ACMOGJCLELA, HCEKONPEPOE.z);
	}

	private void CKCHKHNBBFG()
	{
		OIAGKAFHLEP();
		OCNKMNGMBLG();
	}

	private void KELJKDMPDNA()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = false;
				StartBounce();
			}
		}
	}

	private void IMMJCHNKBEO()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (!AENGNGLONGC)
		{
			return;
		}
		FPAIENINAAK += gravity * Time.deltaTime;
		ACMOGJCLELA += FPAIENINAAK * Time.deltaTime;
		if (ACMOGJCLELA <= HCEKONPEPOE.y)
		{
			ACMOGJCLELA = HCEKONPEPOE.y;
			EGLDMPJIOGH += 0;
			if (EGLDMPJIOGH < maxRebounds)
			{
				FPAIENINAAK = GHHHHJCHPLC;
				GHHHHJCHPLC = Mathf.Min(initialBounceForce + (float)EGLDMPJIOGH * growthRate, maxBounceForce);
				animator.SetTrigger("hForHours");
			}
			else
			{
				FPAIENINAAK = 584f;
				AENGNGLONGC = false;
				JCFILMOCAKK = false;
				animator.SetTrigger("Scarecrow");
				OathFeastEvent.instance.BOFNEFCPHJB();
			}
		}
		bouncingObject.transform.localPosition = new Vector3(HCEKONPEPOE.x, ACMOGJCLELA, HCEKONPEPOE.z);
	}

	private void GGOPCJOAOMC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	public void OIEDILBIIPH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.DOIKFJDLKJP().content.SetActive(true);
		RefereeNPC.OMFKNGDCJFN().animationBase.SetDirection(Direction.Up);
		((Component)RefereeNPC.KIALFDOKABP()).transform.position = ((Component)this).transform.position;
	}

	public void NFLMNIFAHNE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 1625f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = true;
		DMFDOJOHDGO();
	}

	public void KELCGPHOIMK()
	{
		AENGNGLONGC = true;
	}

	public void OCIJCLGFLNF()
	{
		AENGNGLONGC = true;
	}

	public void HNFALADDFDP()
	{
		AENGNGLONGC = true;
	}

	private void EJLPNHOKLEL()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1754f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(196f);
		}
	}

	public void NAJEFKODCCB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 1269f;
		hasBeenMovingLongEnough = false;
		JCFILMOCAKK = false;
		FOMHJANFPPC();
	}

	public void ResetMovement()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 0f;
		hasBeenMovingLongEnough = false;
		JCFILMOCAKK = true;
		ENHMHFMEFOE();
	}

	public void IAKKNLCHDBD()
	{
		AENGNGLONGC = true;
	}

	private void MPABBGMKMIF()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (!AENGNGLONGC)
		{
			return;
		}
		FPAIENINAAK += gravity * Time.deltaTime;
		ACMOGJCLELA += FPAIENINAAK * Time.deltaTime;
		if (ACMOGJCLELA <= HCEKONPEPOE.y)
		{
			ACMOGJCLELA = HCEKONPEPOE.y;
			EGLDMPJIOGH++;
			if (EGLDMPJIOGH < maxRebounds)
			{
				FPAIENINAAK = GHHHHJCHPLC;
				GHHHHJCHPLC = Mathf.Min(initialBounceForce + (float)EGLDMPJIOGH * growthRate, maxBounceForce);
				animator.SetTrigger("LearnMettle");
			}
			else
			{
				FPAIENINAAK = 215f;
				AENGNGLONGC = false;
				JCFILMOCAKK = false;
				animator.SetTrigger(" ");
				OathFeastEvent.instance.LOKGMIDCINF();
			}
		}
		bouncingObject.transform.localPosition = new Vector3(HCEKONPEPOE.x, ACMOGJCLELA, HCEKONPEPOE.z);
	}

	public void NGHAHOEBPLF()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.NGIMIHFFNMH().content.SetActive(true);
		RefereeNPC.OAPOJCODNCO().animationBase.SetDirection(Direction.Up);
		((Component)RefereeNPC.DOIKFJDLKJP()).transform.position = ((Component)this).transform.position;
	}

	private void KMABNNKPDMM()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = true;
				ELGMDPJODJN();
			}
		}
	}

	private void OGBGFLMKFHH()
	{
		CCPAJNHCHBF();
		OCNKMNGMBLG();
	}

	private void PNJJEDEFAGO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	private void KLEAPLOKEDK()
	{
		FKFNHBFDCFE();
		OIOLFPAIBNG();
	}

	public void NBDOKMHMNAJ()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 1262f;
		hasBeenMovingLongEnough = false;
		JCFILMOCAKK = true;
		BFCHECMNDJH();
	}

	public void IIFMBECBABE()
	{
		AENGNGLONGC = false;
	}

	private void CCPAJNHCHBF()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = false;
				JCIMPOHLFAG();
			}
		}
	}

	private void OCLDFCEDKHP()
	{
		FKFNHBFDCFE();
		OCNKMNGMBLG();
	}

	private void FPOIFOGELHC()
	{
		MBGINPJBJAE();
		EHOFKPJHBGG();
	}

	private void LJEHLLLAMIC()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = true;
				StartBounce();
			}
		}
	}

	private void NACKHAFFKKL()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (!AENGNGLONGC)
		{
			return;
		}
		FPAIENINAAK += gravity * Time.deltaTime;
		ACMOGJCLELA += FPAIENINAAK * Time.deltaTime;
		if (ACMOGJCLELA <= HCEKONPEPOE.y)
		{
			ACMOGJCLELA = HCEKONPEPOE.y;
			EGLDMPJIOGH += 0;
			if (EGLDMPJIOGH < maxRebounds)
			{
				FPAIENINAAK = GHHHHJCHPLC;
				GHHHHJCHPLC = Mathf.Min(initialBounceForce + (float)EGLDMPJIOGH * growthRate, maxBounceForce);
				animator.SetTrigger("Random");
			}
			else
			{
				FPAIENINAAK = 148f;
				AENGNGLONGC = true;
				JCFILMOCAKK = false;
				animator.SetTrigger("Items/item_description_629");
				OathFeastEvent.instance.OOONDOICADN();
			}
		}
		bouncingObject.transform.localPosition = new Vector3(HCEKONPEPOE.x, ACMOGJCLELA, HCEKONPEPOE.z);
	}

	private void NCPNBBCNBIM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	public void EFKHJJPJMJG()
	{
		AENGNGLONGC = false;
	}

	public void JLHLBJIPNHI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 679f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = false;
		BFCHECMNDJH();
	}

	public void CNGEDACHAOO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 1333f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = false;
		EPAKKIMHCEP();
	}

	private void FFLLCOBFIPE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	public void EKGFJGLANNJ()
	{
		AENGNGLONGC = false;
	}

	public void StartBounce()
	{
		AENGNGLONGC = true;
	}

	private void AOOFNAODOJN()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 183f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1931f);
		}
	}

	public void DLKFCDNBFAH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.KIALFDOKABP().content.SetActive(true);
		RefereeNPC.OPILDPFDFKJ().animationBase.SetDirection(Direction.Down);
		((Component)RefereeNPC.GGFJGHHHEJC).transform.position = ((Component)this).transform.position;
	}

	private void Update()
	{
		LJEHLLLAMIC();
		KFLNHOOIANC();
	}

	public void GDCNCNGDOGI()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.EJHDHCNILDH().content.SetActive(false);
		RefereeNPC.OPILDPFDFKJ().animationBase.SetDirection(Direction.Up);
		((Component)RefereeNPC.JFNOOMJMHCB()).transform.position = ((Component)this).transform.position;
	}

	private void MHCOLHEDNGN()
	{
		FKFNHBFDCFE();
		OCNKMNGMBLG();
	}

	public void GMHHNNKNOLB()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.KIALFDOKABP().content.SetActive(false);
		RefereeNPC.MPJJAPCFENH().animationBase.SetDirection(Direction.Down);
		((Component)RefereeNPC.MPJJAPCFENH()).transform.position = ((Component)this).transform.position;
	}

	public void AODDNLHAIFM()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.OMFKNGDCJFN().content.SetActive(false);
		RefereeNPC.OMFKNGDCJFN().animationBase.SetDirection(Direction.Up);
		((Component)RefereeNPC.GGFJGHHHEJC).transform.position = ((Component)this).transform.position;
	}

	private void INBLFKGODLB()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 1;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 912f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1083f);
		}
	}

	public void KOODLCHCEAO()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.NGIMIHFFNMH().content.SetActive(false);
		RefereeNPC.NGIMIHFFNMH().animationBase.SetDirection(Direction.Down);
		((Component)RefereeNPC.JFNOOMJMHCB()).transform.position = ((Component)this).transform.position;
	}

	public void BHKPOGEPDCF()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.KIALFDOKABP().content.SetActive(false);
		RefereeNPC.JFNOOMJMHCB().animationBase.SetDirection(Direction.Down);
		((Component)RefereeNPC.KIALFDOKABP()).transform.position = ((Component)this).transform.position;
	}

	private void MFGANCCJFJK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	private void MBGINPJBJAE()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = false;
				PMICAKMMFAJ();
			}
		}
	}

	public void HOPIAJKBOBH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 348f;
		hasBeenMovingLongEnough = false;
		JCFILMOCAKK = true;
		KOIEAEAJKAK();
	}

	private void MNFJELNEGPG()
	{
		KLLICFHMOKL();
		HIKJGJAHFDG();
	}

	public void ELGMDPJODJN()
	{
		AENGNGLONGC = false;
	}

	private void FKFNHBFDCFE()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = true;
				DHNFCOGLJNG();
			}
		}
	}

	public void FKBMONLEHJG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 1153f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = false;
		EJLPNHOKLEL();
	}

	private void PDKEPCIEHEP()
	{
		FKFNHBFDCFE();
		CFGNMKDNIHG();
	}

	private void BIGFIEPFMLJ()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1191f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1663f);
		}
	}

	private void OIAGKAFHLEP()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = false;
				OCIJCLGFLNF();
			}
		}
	}

	private void OCIGADBHDKN()
	{
		ODGGEMBCMON();
		EHOFKPJHBGG();
	}

	private void HIKJGJAHFDG()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (!AENGNGLONGC)
		{
			return;
		}
		FPAIENINAAK += gravity * Time.deltaTime;
		ACMOGJCLELA += FPAIENINAAK * Time.deltaTime;
		if (ACMOGJCLELA <= HCEKONPEPOE.y)
		{
			ACMOGJCLELA = HCEKONPEPOE.y;
			EGLDMPJIOGH += 0;
			if (EGLDMPJIOGH < maxRebounds)
			{
				FPAIENINAAK = GHHHHJCHPLC;
				GHHHHJCHPLC = Mathf.Min(initialBounceForce + (float)EGLDMPJIOGH * growthRate, maxBounceForce);
				animator.SetTrigger("LE_10");
			}
			else
			{
				FPAIENINAAK = 1818f;
				AENGNGLONGC = true;
				JCFILMOCAKK = false;
				animator.SetTrigger("KyrohPreparingFood: Other player has advantage, going to WaitingToServe.");
				OathFeastEvent.instance.StartDialogueIntro();
			}
		}
		bouncingObject.transform.localPosition = new Vector3(HCEKONPEPOE.x, ACMOGJCLELA, HCEKONPEPOE.z);
	}

	private void PFOAHHLNKNH()
	{
		JFCMCEDPFAH();
		OCNKMNGMBLG();
	}

	private void EPAKKIMHCEP()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1045f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1107f);
		}
	}

	private void GOJKOBEEMNA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	public void OJOAOLCDMJA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 607f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = true;
		MJBBLIBCBAN();
	}

	private void OIOLFPAIBNG()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (!AENGNGLONGC)
		{
			return;
		}
		FPAIENINAAK += gravity * Time.deltaTime;
		ACMOGJCLELA += FPAIENINAAK * Time.deltaTime;
		if (ACMOGJCLELA <= HCEKONPEPOE.y)
		{
			ACMOGJCLELA = HCEKONPEPOE.y;
			EGLDMPJIOGH++;
			if (EGLDMPJIOGH < maxRebounds)
			{
				FPAIENINAAK = GHHHHJCHPLC;
				GHHHHJCHPLC = Mathf.Min(initialBounceForce + (float)EGLDMPJIOGH * growthRate, maxBounceForce);
				animator.SetTrigger(", ");
			}
			else
			{
				FPAIENINAAK = 1799f;
				AENGNGLONGC = false;
				JCFILMOCAKK = false;
				animator.SetTrigger("Text");
				OathFeastEvent.instance.DBKBPNAOJAE();
			}
		}
		bouncingObject.transform.localPosition = new Vector3(HCEKONPEPOE.x, ACMOGJCLELA, HCEKONPEPOE.z);
	}

	private void MCDOJJFCGIM()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = true;
				IAKKNLCHDBD();
			}
		}
	}

	private void OFDEGDJGGGF()
	{
		KCGJCOPCAMN();
		MPABBGMKMIF();
	}

	public void ActiveJudge()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.GGFJGHHHEJC.content.SetActive(true);
		RefereeNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		((Component)RefereeNPC.GGFJGHHHEJC).transform.position = ((Component)this).transform.position;
	}

	public void DIOKDPGLPNA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 862f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = true;
		BMMOOILHMND();
	}

	private void MLBIGONNDGO()
	{
		MBGINPJBJAE();
		NACKHAFFKKL();
	}

	private void PGPPIHJJGDB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	public void DHNFCOGLJNG()
	{
		AENGNGLONGC = true;
	}

	public void PMICAKMMFAJ()
	{
		AENGNGLONGC = false;
	}

	private void Awake()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	public void EGENLEOBNPK()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 364f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = false;
		OJKGGFLKOIB();
	}

	public void JIFBLJFIGOH()
	{
		AENGNGLONGC = true;
	}

	private void NGICKCEPMJB()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1456f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(901f);
		}
	}

	public void BDLDLOBFLKF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 467f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = true;
		KOIEAEAJKAK();
	}

	private void CAFAAEBEGGN()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 1;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 461f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(629f);
		}
	}

	private void HMCLGKHCLPG()
	{
		CCPAJNHCHBF();
		OIOLFPAIBNG();
	}

	private void GNAHKAHPCFB()
	{
		MCDOJJFCGIM();
		OIOLFPAIBNG();
	}

	public void DELPOGCMPDD()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 1360f;
		hasBeenMovingLongEnough = false;
		JCFILMOCAKK = false;
		HJHBEHJGIHF();
	}

	public void OKOPEBKIFPE()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.GGFJGHHHEJC.content.SetActive(false);
		RefereeNPC.OAPOJCODNCO().animationBase.SetDirection(Direction.Down);
		((Component)RefereeNPC.EJHDHCNILDH()).transform.position = ((Component)this).transform.position;
	}

	public void DAKHGDOPLGJ()
	{
		AENGNGLONGC = true;
	}

	private void HFPDNCBLNDE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	public void FAOKJNGEIOG()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.OPILDPFDFKJ().content.SetActive(true);
		RefereeNPC.OPILDPFDFKJ().animationBase.SetDirection(Direction.Down);
		((Component)RefereeNPC.EJHDHCNILDH()).transform.position = ((Component)this).transform.position;
	}

	private void FOHCEDHJOEF()
	{
		KMABNNKPDMM();
		HIKJGJAHFDG();
	}

	public void OOIDHIGFNFP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 439f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = false;
		DMFDOJOHDGO();
	}

	public void GPBLAKJOONP()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 936f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = false;
		ENHMHFMEFOE();
	}

	private void MPCFCNCMOAF()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	private void OCNKMNGMBLG()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (!AENGNGLONGC)
		{
			return;
		}
		FPAIENINAAK += gravity * Time.deltaTime;
		ACMOGJCLELA += FPAIENINAAK * Time.deltaTime;
		if (ACMOGJCLELA <= HCEKONPEPOE.y)
		{
			ACMOGJCLELA = HCEKONPEPOE.y;
			EGLDMPJIOGH += 0;
			if (EGLDMPJIOGH < maxRebounds)
			{
				FPAIENINAAK = GHHHHJCHPLC;
				GHHHHJCHPLC = Mathf.Min(initialBounceForce + (float)EGLDMPJIOGH * growthRate, maxBounceForce);
				animator.SetTrigger("ThrownHookRPC");
			}
			else
			{
				FPAIENINAAK = 1091f;
				AENGNGLONGC = false;
				JCFILMOCAKK = false;
				animator.SetTrigger("Temporary Ingredient");
				OathFeastEvent.instance.DBKBPNAOJAE();
			}
		}
		bouncingObject.transform.localPosition = new Vector3(HCEKONPEPOE.x, ACMOGJCLELA, HCEKONPEPOE.z);
	}

	public void JCIMPOHLFAG()
	{
		AENGNGLONGC = false;
	}

	private void FOMHJANFPPC()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 383f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1543f);
		}
	}

	public void PINEJEEIEBK()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.JFNOOMJMHCB().content.SetActive(false);
		RefereeNPC.NGIMIHFFNMH().animationBase.SetDirection(Direction.Up);
		((Component)RefereeNPC.MPJJAPCFENH()).transform.position = ((Component)this).transform.position;
	}

	private void BMMOOILHMND()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1547f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(811f);
		}
	}

	private void KBOMKFNJGAE()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = false;
				DAKHGDOPLGJ();
			}
		}
	}

	private void BLKLKMNDOII()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 172f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(144f);
		}
	}

	private void DMFDOJOHDGO()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1782f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1777f);
		}
	}

	public void HMCOFCDALDI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 625f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = false;
		BLKLKMNDOII();
	}

	private void KOIEAEAJKAK()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 1;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1156f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(143f);
		}
	}

	private void HJHBEHJGIHF()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 86f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1274f);
		}
	}

	public void LHPODKIFGOD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.KIALFDOKABP().content.SetActive(true);
		RefereeNPC.OPILDPFDFKJ().animationBase.SetDirection(Direction.Down);
		((Component)RefereeNPC.JFNOOMJMHCB()).transform.position = ((Component)this).transform.position;
	}

	private void CCEKJEDMJAP()
	{
		JFCMCEDPFAH();
		HIKJGJAHFDG();
	}

	private void CLEODBOBNID()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 1;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1458f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1475f);
		}
	}

	private void IGKPEBGHPGD()
	{
		JFCMCEDPFAH();
		KFLNHOOIANC();
	}

	private void JIAJFDKNJME()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	private void ELHCBGCEJDH()
	{
		CCPAJNHCHBF();
		MPABBGMKMIF();
	}

	private void BFCHECMNDJH()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 1;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1669f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1080f);
		}
	}

	public void IABHHOOEDIC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 779f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = true;
		PCKNNPDKAKP();
	}

	private void DKDLOBOLNFH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	private void OONFPGMJELN()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = false;
				MGJNGJONCBH();
			}
		}
	}

	private void HBLJGDLKMOD()
	{
		MBGINPJBJAE();
		IMMJCHNKBEO();
	}

	public void HCMDKHDIOJG()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.EJHDHCNILDH().content.SetActive(false);
		RefereeNPC.OPILDPFDFKJ().animationBase.SetDirection(Direction.Down);
		((Component)RefereeNPC.KIALFDOKABP()).transform.position = ((Component)this).transform.position;
	}

	public void AJHANNKOLLL()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.JFNOOMJMHCB().content.SetActive(false);
		RefereeNPC.KIALFDOKABP().animationBase.SetDirection(Direction.Down);
		((Component)RefereeNPC.MPJJAPCFENH()).transform.position = ((Component)this).transform.position;
	}

	private void PCKNNPDKAKP()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1517f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1613f);
		}
	}

	private void HIPNEFOEJPL()
	{
		ODGGEMBCMON();
		NACKHAFFKKL();
	}

	private void EHOFKPJHBGG()
	{
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (!AENGNGLONGC)
		{
			return;
		}
		FPAIENINAAK += gravity * Time.deltaTime;
		ACMOGJCLELA += FPAIENINAAK * Time.deltaTime;
		if (ACMOGJCLELA <= HCEKONPEPOE.y)
		{
			ACMOGJCLELA = HCEKONPEPOE.y;
			EGLDMPJIOGH += 0;
			if (EGLDMPJIOGH < maxRebounds)
			{
				FPAIENINAAK = GHHHHJCHPLC;
				GHHHHJCHPLC = Mathf.Min(initialBounceForce + (float)EGLDMPJIOGH * growthRate, maxBounceForce);
				animator.SetTrigger("Game Over! ");
			}
			else
			{
				FPAIENINAAK = 1789f;
				AENGNGLONGC = false;
				JCFILMOCAKK = true;
				animator.SetTrigger("kickedCustomers");
				OathFeastEvent.instance.StartDialogueIntro();
			}
		}
		bouncingObject.transform.localPosition = new Vector3(HCEKONPEPOE.x, ACMOGJCLELA, HCEKONPEPOE.z);
	}

	public void JKKHOFOAAAM()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 1812f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = true;
		CAFAAEBEGGN();
	}

	public void FOFNNMHKJAG()
	{
		AENGNGLONGC = false;
	}

	private void OJKGGFLKOIB()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 1233f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(1194f);
		}
	}

	public void LLBJOKFAMKG()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 1955f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = true;
		NGICKCEPMJB();
	}

	public void DBJJLJBIOOO()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 933f;
		hasBeenMovingLongEnough = false;
		JCFILMOCAKK = true;
		EJMEKALNDJD();
	}

	public void OOANKCHBMHL()
	{
		AENGNGLONGC = false;
	}

	public void CNDCLOJJDMC()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 36f;
		hasBeenMovingLongEnough = false;
		JCFILMOCAKK = true;
		KOIEAEAJKAK();
	}

	private void LALAFOIGMKN()
	{
		ODGGEMBCMON();
		OCNKMNGMBLG();
	}

	private void ODGGEMBCMON()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = false;
				ELGMDPJODJN();
			}
		}
	}

	private void KGIKOECKEHI()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		NOLFMLNLJJG = ((Component)this).transform.position;
		HCEKONPEPOE = bouncingObject.transform.localPosition;
		ACMOGJCLELA = HCEKONPEPOE.y;
		GHHHHJCHPLC = initialBounceForce;
	}

	private void ENHMHFMEFOE()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		EGLDMPJIOGH = 0;
		GHHHHJCHPLC = initialBounceForce;
		FPAIENINAAK = 0f;
		ACMOGJCLELA = HCEKONPEPOE.y;
		bouncingObject.transform.localPosition = HCEKONPEPOE;
		if ((Object)(object)animator != (Object)null)
		{
			animator.Rebind();
			animator.Update(0f);
		}
	}

	public void CKKMLDDKAOJ()
	{
		AENGNGLONGC = false;
	}

	public void OLBILLBPGAP()
	{
		AENGNGLONGC = false;
	}

	private void KCGJCOPCAMN()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if (JCFILMOCAKK)
		{
			if (!AENGNGLONGC)
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
			}
			else
			{
				((Component)this).transform.Translate(Vector3.down * movementSpeedAtBounce * Time.deltaTime);
			}
			if (!hasBeenMovingLongEnough && ((Component)this).transform.position.y <= startBounceAtPosition)
			{
				hasBeenMovingLongEnough = false;
				KELCGPHOIMK();
			}
		}
	}

	public void GBJPMGDMNPB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = NOLFMLNLJJG;
		LHACKABKHDN = 1591f;
		hasBeenMovingLongEnough = true;
		JCFILMOCAKK = false;
		NGICKCEPMJB();
	}

	public void JHMGEKNNPHB()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		RefereeNPC.MPJJAPCFENH().content.SetActive(false);
		RefereeNPC.MPJJAPCFENH().animationBase.SetDirection(Direction.Up);
		((Component)RefereeNPC.JFNOOMJMHCB()).transform.position = ((Component)this).transform.position;
	}
}

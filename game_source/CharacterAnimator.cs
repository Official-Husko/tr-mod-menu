using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class CharacterAnimator : BaseAnimator
{
	[Serializable]
	public struct BodyPartLayers
	{
		public BodyPart bodyPart;

		public ReskinAnimation[] layersReskin;
	}

	public Action<int> OnToolHit = delegate
	{
	};

	public Action<int> OnToolStart = delegate
	{
	};

	public Action<int> OnToolEnd = delegate
	{
	};

	public Action<int, bool> ActivatedEatObjects = delegate
	{
	};

	public Action<bool, bool, SurfaceSortOrder, byte> ActivatedCleanSprites = delegate
	{
	};

	public Action<Direction, Gender> FaceActivation = delegate
	{
	};

	public Action<Direction> LayerOrder = delegate
	{
	};

	public Animator animator;

	public CharacterAnimation animation;

	public bool isUI;

	public GameObject bootsAboveLegsParent;

	public GameObject bootsBelowLegsParent;

	public GameObject bootsR;

	public GameObject bootsL;

	[SerializeField]
	private PlayerController playerController;

	public int fullBodyIndex;

	public int armsIndex;

	public int armLIndex;

	public int sleeveRIndex;

	public int legLIndex;

	public int weaponIndex;

	public int faceIndex;

	public int staticHairIndex;

	public int effectIndex;

	public int extraIndex;

	public ReskinAnimation[] allReskins;

	public ReskinAnimation[] reskins;

	public ReskinAnimation[] reskinsArms;

	public ReskinAnimation[] reskinsArmL;

	public ReskinAnimation[] reskinsSleeveR;

	public ReskinAnimation[] reskinsLegL;

	public ReskinAnimation[] reskinsWeapon;

	public ReskinAnimation[] reskinsFace;

	public ReskinAnimation[] reskinsStaticHair;

	public ReskinAnimation[] reskinsEffect;

	public ReskinAnimation[] reskinExtras;

	public BodyPartLayers[] bodyPartLayers;

	[SerializeField]
	private GameObject[] femaleSpritesToActivate;

	[SerializeField]
	private GameObject[] maleSpritesToActivate;

	public ReturnToOriginalParent cleaningSpritesToActivate;

	public ReturnToOriginalParent eatingSpritesToActivate;

	private Transform JBEMPHPCOGO;

	public GameObject mug;

	public GameObject spoon;

	public GameObject sandwich;

	public GameObject femaleFace;

	public GameObject maleFace;

	[SerializeField]
	private SpriteRenderer maleNoseSR;

	[SerializeField]
	private SpriteRenderer maleBeardSR;

	[SerializeField]
	private GameObject maleBeard;

	[SerializeField]
	private GameObject maleBeardUp;

	[SerializeField]
	private GameObject maleHelmetLight;

	[SerializeField]
	private GameObject femaleHelmetLight;

	[SerializeField]
	private SpriteRenderer[] tableMaskInteraction;

	[SerializeField]
	private SpriteRenderer[] cleanMaskInteraction;

	[SerializeField]
	private SpriteRenderer[] waterMaskInteraction;

	public GameObject snowStep;

	public float minBlinkingTime = 1f;

	public float maxBlinkingTime = 10f;

	public SpriteRenderer[] openedEyes;

	public SpriteRenderer[] closedEyes;

	public Image[] openedEyesI;

	public Image[] closedEyesI;

	private float PLGEKFIPMJJ;

	private float LGGPCAGINGN;

	public GameObject[] pickSparks;

	public GameObject[] pickSparksUp;

	public GameObject[] pickSparksDown;

	public GameObject[] pickDust;

	public GameObject[] pickDustUp;

	public GameObject[] pickDustDown;

	public GameObject[] mobDustDown;

	public GameObject[] mobDustUp;

	public GameObject[] mobDustRight;

	public GameObject[] mobDustRight2;

	public GameObject[] weaponDustDown;

	public GameObject[] weaponDustUp;

	public GameObject[] weaponDustRight;

	public GameObject[] axDust;

	public GameObject[] axWood;

	public GameObject[] axDustUp;

	public GameObject[] axWoodUp;

	public GameObject[] axDustDown;

	public GameObject[] axWoodDown;

	public GameObject[] hoeDirtDown;

	public GameObject[] hoeDirtUp;

	public GameObject[] hoeDirtRight;

	public GameObject[] wateringEffectDown;

	public GameObject[] wateringEffectUp;

	public GameObject[] wateringEffectRight;

	private GameObject EIHGGPGFPPH;

	private int LOPMFFLECMG;

	private int OEMMDHFEBID;

	private int OHFEDMPGFMA;

	private int BJPFPMBENLD;

	private int ANKBKJBCDIF;

	private int IENCOHNMMHH;

	private int FKMCOEJMJFF;

	private int CMCELHKBFKJ;

	private int IONILMBDACN;

	private int GAHNGHGNIEE;

	private SurfaceSortOrder EGCGEHJNCCP;

	[HideInInspector]
	public OnlineCustomizableCharacterAnimation onlineAnimation;

	private Direction IOILEOOIFCP;

	private bool BLIIJFKGKKF;

	private Direction LJFJKKKNNOE;

	private Gender GJGMEFBNFGH;

	private bool AOHGDALLGCA;

	private bool COKEBDOCMFE;

	public bool stoppingToClean;

	private Coroutine IFOMIJFKHMP;

	public bool MLBGEKOIALK
	{
		get
		{
			return COKEBDOCMFE;
		}
		set
		{
			COKEBDOCMFE = value;
			if (value)
			{
				return;
			}
			if (IFOMIJFKHMP != null)
			{
				((MonoBehaviour)this).StopCoroutine(IFOMIJFKHMP);
				IFOMIJFKHMP = null;
			}
			if ((Object)(object)cleaningSpritesToActivate != (Object)null && (Object)(object)((Component)cleaningSpritesToActivate).gameObject != (Object)null)
			{
				if (((Component)cleaningSpritesToActivate).gameObject.activeSelf)
				{
					if ((Object)(object)EGCGEHJNCCP != (Object)null)
					{
						EGCGEHJNCCP.RemoveFromSurface(((Component)cleaningSpritesToActivate).transform);
					}
					cleaningSpritesToActivate.ReturnToParent();
					((Component)cleaningSpritesToActivate).gameObject.SetActive(false);
				}
			}
			else if ((Object)(object)EGCGEHJNCCP != (Object)null)
			{
				EGCGEHJNCCP.RemoveNullsFromSurface();
			}
			EnableCleanMaskInteraction(NJHMBMGKCPL: false);
		}
	}

	public void SpawnPickUpEffect()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pickSparksUp.Length; i++)
		{
			if (!pickSparksUp[i].activeSelf)
			{
				pickSparksUp[i].gameObject.SetActive(true);
				pickSparksUp[i].transform.position = Utils.BMBMPKNANAC(pickSparksUp[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < pickDustUp.Length; j++)
		{
			if (!pickDustUp[j].activeSelf)
			{
				pickDustUp[j].gameObject.SetActive(true);
				pickDustUp[j].transform.position = Utils.BMBMPKNANAC(pickDustUp[j].transform.position);
				break;
			}
		}
	}

	public void DIFLPHJFADE()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < axDustDown.Length; i += 0)
		{
			if (!axDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				axDustDown[i].transform.SetParent((Transform)null);
				axDustDown[i].transform.localScale = lossyScale;
				axDustDown[i].gameObject.SetActive(false);
				axDustDown[i].transform.position = Utils.BMBMPKNANAC(axDustDown[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < axWoodDown.Length; j++)
		{
			if (!axWoodDown[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				axWoodDown[j].transform.SetParent((Transform)null);
				axWoodDown[j].transform.localScale = lossyScale2;
				axWoodDown[j].gameObject.SetActive(true);
				axWoodDown[j].transform.position = Utils.BMBMPKNANAC(axWoodDown[j].transform.position);
				break;
			}
		}
	}

	public void SpawnPickDownEffect()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pickSparksDown.Length; i++)
		{
			if (!pickSparksDown[i].activeSelf)
			{
				pickSparksDown[i].gameObject.SetActive(true);
				pickSparksDown[i].transform.position = Utils.BMBMPKNANAC(pickSparksDown[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < pickDustDown.Length; j++)
		{
			if (!pickDustDown[j].activeSelf)
			{
				pickDustDown[j].gameObject.SetActive(true);
				pickDustDown[j].transform.position = Utils.BMBMPKNANAC(pickDustDown[j].transform.position);
				break;
			}
		}
	}

	public void SpawnHoeEffectDown()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < hoeDirtDown.Length; i++)
		{
			if (!hoeDirtDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				hoeDirtDown[i].gameObject.SetActive(true);
				hoeDirtDown[i].transform.SetParent((Transform)null);
				hoeDirtDown[i].transform.localScale = lossyScale;
				hoeDirtDown[i].transform.position = Utils.BMBMPKNANAC(hoeDirtDown[i].transform.position);
				break;
			}
		}
	}

	public void FCGKBNGPNAC()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			OnToolStart(playerController.KLIHELDIPDP());
		}
	}

	public void JEEGLAGCNIE()
	{
		stoppingToClean = true;
	}

	public void CleanStopping()
	{
		stoppingToClean = true;
	}

	private void NKDFMFFDGKC()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)cleaningSpritesToActivate != (Object)null)
			{
				JBEMPHPCOGO = ((Component)cleaningSpritesToActivate).transform.parent;
			}
			PLGEKFIPMJJ = Time.timeSinceLevelLoad + Random.Range(minBlinkingTime, maxBlinkingTime);
			PLGEKFIPMJJ = 611f;
		}
	}

	public void SpawnPickEffect()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pickSparks.Length; i++)
		{
			if (!pickSparks[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				pickSparks[i].transform.SetParent((Transform)null);
				pickSparks[i].transform.localScale = lossyScale;
				pickSparks[i].gameObject.SetActive(true);
				pickSparks[i].transform.position = Utils.BMBMPKNANAC(pickSparks[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < pickDust.Length; j++)
		{
			if (!pickDust[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				pickDust[j].transform.SetParent((Transform)null);
				pickDust[j].transform.localScale = lossyScale2;
				pickDust[j].gameObject.SetActive(true);
				pickDust[j].transform.position = Utils.BMBMPKNANAC(pickDust[j].transform.position);
				break;
			}
		}
	}

	private void Start()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)cleaningSpritesToActivate != (Object)null)
			{
				JBEMPHPCOGO = ((Component)cleaningSpritesToActivate).transform.parent;
			}
			PLGEKFIPMJJ = Time.timeSinceLevelLoad + Random.Range(minBlinkingTime, maxBlinkingTime);
			PLGEKFIPMJJ = float.MaxValue;
		}
	}

	public void SpawnAxUpEffect()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < axDustUp.Length; i++)
		{
			if (!axDustUp[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				axDustUp[i].transform.SetParent((Transform)null);
				axDustUp[i].transform.localScale = lossyScale;
				axDustUp[i].gameObject.SetActive(true);
				axDustUp[i].transform.position = Utils.BMBMPKNANAC(axDustUp[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < axWoodUp.Length; j++)
		{
			if (!axWoodUp[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				axWoodUp[j].transform.SetParent((Transform)null);
				axWoodUp[j].transform.localScale = lossyScale2;
				axWoodUp[j].gameObject.SetActive(true);
				axWoodUp[j].transform.position = Utils.BMBMPKNANAC(axWoodUp[j].transform.position);
				break;
			}
		}
	}

	public void ToolStart()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			OnToolStart(playerController.GetPlayerNum());
		}
	}

	public void DeactivateCleanSprites()
	{
		if ((Object)(object)cleaningSpritesToActivate != (Object)null && ((Component)cleaningSpritesToActivate).gameObject.activeSelf)
		{
			if ((Object)(object)EGCGEHJNCCP != (Object)null)
			{
				EGCGEHJNCCP.RemoveFromSurface(((Component)cleaningSpritesToActivate).transform);
			}
			cleaningSpritesToActivate.ReturnToParent();
			((Component)cleaningSpritesToActivate).gameObject.SetActive(false);
			EnableCleanMaskInteraction(NJHMBMGKCPL: false);
		}
	}

	public void SpawnMopEffectRight()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < mobDustRight.Length; i++)
		{
			if (!mobDustRight[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				mobDustRight[i].transform.SetParent((Transform)null);
				mobDustRight[i].transform.localScale = lossyScale;
				mobDustRight[i].gameObject.SetActive(true);
				mobDustRight[i].transform.position = Utils.BMBMPKNANAC(mobDustRight[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < mobDustRight2.Length; j++)
		{
			if (!mobDustRight2[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				mobDustRight2[j].transform.SetParent((Transform)null);
				mobDustRight2[j].transform.localScale = lossyScale2;
				mobDustRight2[j].gameObject.SetActive(true);
				mobDustRight2[j].transform.position = Utils.BMBMPKNANAC(mobDustRight2[j].transform.position);
				break;
			}
		}
	}

	public void PAAMJBIIHEB()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			OnToolStart(playerController.GetPlayerNum());
		}
	}

	public void ActivateEatGameObjects(int GLFNNCJKOEN, bool PJEILLAADOC = false, bool CDPAMNIPPEC = true)
	{
		switch (GLFNNCJKOEN)
		{
		case 0:
			if (((Component)eatingSpritesToActivate).gameObject.activeSelf)
			{
				if (!PJEILLAADOC)
				{
					eatingSpritesToActivate.ReturnToParent();
					((Component)eatingSpritesToActivate).gameObject.SetActive(false);
				}
				mug.SetActive(false);
				spoon.SetActive(false);
				sandwich.SetActive(false);
			}
			break;
		case 1:
			((Component)eatingSpritesToActivate).gameObject.SetActive(true);
			mug.SetActive(true);
			spoon.SetActive(false);
			sandwich.SetActive(false);
			break;
		case 2:
			((Component)eatingSpritesToActivate).gameObject.SetActive(true);
			mug.SetActive(false);
			spoon.SetActive(true);
			sandwich.SetActive(false);
			break;
		case 3:
			((Component)eatingSpritesToActivate).gameObject.SetActive(true);
			mug.SetActive(false);
			spoon.SetActive(false);
			sandwich.SetActive(true);
			break;
		case 99:
			((Component)eatingSpritesToActivate).gameObject.SetActive(true);
			mug.SetActive(false);
			spoon.SetActive(false);
			sandwich.SetActive(false);
			break;
		}
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			ActivatedEatObjects?.Invoke(GLFNNCJKOEN, PJEILLAADOC);
		}
	}

	public void IMIAFKEHCEC(int HLOIOAOICEG)
	{
		((Renderer)EIHGGPGFPPH.GetComponent<SpriteRenderer>()).sortingOrder = HLOIOAOICEG;
	}

	public void CheckOrderInLayers(Direction MPLCIAKAPGL)
	{
		if (!Application.isPlaying || (Object)(object)maleBeardSR == (Object)null)
		{
			return;
		}
		switch (MPLCIAKAPGL)
		{
		case Direction.Up:
			if (((Renderer)maleBeardSR).sortingOrder != 68)
			{
				((Renderer)maleBeardSR).sortingOrder = 60;
				((Renderer)maleNoseSR).sortingOrder = -100;
			}
			break;
		case Direction.Down:
			if (((Renderer)maleBeardSR).sortingOrder != 69)
			{
				((Renderer)maleBeardSR).sortingOrder = 92;
				((Renderer)maleNoseSR).sortingOrder = 95;
			}
			break;
		default:
			if (((Renderer)maleBeardSR).sortingOrder != 91)
			{
				((Renderer)maleBeardSR).sortingOrder = 92;
				((Renderer)maleNoseSR).sortingOrder = 91;
			}
			break;
		}
		if (((Component)this).gameObject.activeSelf)
		{
			NMNKAGILAAG(MPLCIAKAPGL);
		}
	}

	public void GetAllReskins()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(true);
	}

	private void EIFFGMPALBD()
	{
		PHGEBLFGPKM();
		if (Application.isPlaying)
		{
			GCLNHDPMBJE();
		}
	}

	private void LateUpdate()
	{
		PHGEBLFGPKM();
		if (Application.isPlaying)
		{
			GCLNHDPMBJE();
		}
	}

	public void SpawnWeaponEffectDown()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < weaponDustDown.Length; i++)
		{
			if (!weaponDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				weaponDustDown[i].transform.SetParent((Transform)null);
				weaponDustDown[i].transform.localScale = lossyScale;
				weaponDustDown[i].gameObject.SetActive(true);
				weaponDustDown[i].transform.position = Utils.BMBMPKNANAC(weaponDustDown[i].transform.position);
				break;
			}
		}
	}

	public void UnblockMovement()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			PlayerController.RemoveMovementBlocker(playerController.GetPlayerNum(), (Object)(object)this);
		}
	}

	public void BlockMovement()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			PlayerController.AddMovementBlocker(playerController.GetPlayerNum(), (Object)(object)this);
		}
	}

	private void EDDMDEBBPHI(Direction MPLCIAKAPGL)
	{
		if (OnlineManager.PlayingOnline())
		{
			IOILEOOIFCP = MPLCIAKAPGL;
			if (!BLIIJFKGKKF)
			{
				BLIIJFKGKKF = true;
				((MonoBehaviour)this).StartCoroutine(JKLNHDFLLPF());
			}
		}
	}

	private void IMMJPOPPKMK()
	{
		for (int i = 0; i < openedEyes.Length; i++)
		{
			((Component)openedEyes[i]).gameObject.SetActive(true);
		}
		for (int j = 0; j < openedEyesI.Length; j++)
		{
			((Component)openedEyesI[j]).gameObject.SetActive(true);
		}
		for (int k = 0; k < closedEyes.Length; k++)
		{
			((Component)closedEyes[k]).gameObject.SetActive(false);
		}
		for (int l = 0; l < closedEyesI.Length; l++)
		{
			((Component)closedEyesI[l]).gameObject.SetActive(false);
		}
	}

	private void FNLALBILPAJ(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (OnlineManager.PlayingOnline())
		{
			LJFJKKKNNOE = MPLCIAKAPGL;
			GJGMEFBNFGH = OHMAEGCHIOC;
			if (!AOHGDALLGCA)
			{
				AOHGDALLGCA = true;
				((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(IHJAKLFCEKK());
			}
		}
	}

	public void PGDCPOPJLMA(bool NJHMBMGKCPL)
	{
		for (int i = 1; i < waterMaskInteraction.Length; i += 0)
		{
			if (NJHMBMGKCPL)
			{
				waterMaskInteraction[i].maskInteraction = (SpriteMaskInteraction)0;
			}
			else
			{
				waterMaskInteraction[i].maskInteraction = (SpriteMaskInteraction)0;
			}
		}
	}

	[SpecialName]
	public void IMFGFDGCEKK(bool AODONKKHPBP)
	{
		COKEBDOCMFE = AODONKKHPBP;
		if (AODONKKHPBP)
		{
			return;
		}
		if (IFOMIJFKHMP != null)
		{
			((MonoBehaviour)this).StopCoroutine(IFOMIJFKHMP);
			IFOMIJFKHMP = null;
		}
		if ((Object)(object)cleaningSpritesToActivate != (Object)null && (Object)(object)((Component)cleaningSpritesToActivate).gameObject != (Object)null)
		{
			if (((Component)cleaningSpritesToActivate).gameObject.activeSelf)
			{
				if ((Object)(object)EGCGEHJNCCP != (Object)null)
				{
					EGCGEHJNCCP.RemoveFromSurface(((Component)cleaningSpritesToActivate).transform, IGIDKEAAIHL: true, GFNHAMCPEAK: false);
				}
				cleaningSpritesToActivate.PPDKJDHJLPE();
				((Component)cleaningSpritesToActivate).gameObject.SetActive(true);
			}
		}
		else if ((Object)(object)EGCGEHJNCCP != (Object)null)
		{
			EGCGEHJNCCP.MLEFLAJAHOA();
		}
		EnableCleanMaskInteraction(NJHMBMGKCPL: false);
	}

	public void CleanStart()
	{
		if ((Object)(object)playerController != (Object)null && (Object)(object)InteractObject.GetPlayer(playerController.GetPlayerNum()).GetCurrentInteractGO() != (Object)null)
		{
			InteractObject.GetPlayer(playerController.GetPlayerNum()).table = InteractObject.GetPlayer(playerController.GetPlayerNum()).GetCurrentInteractGO().GetComponent<Table>();
		}
		stoppingToClean = false;
		MLBGEKOIALK = true;
	}

	public void AKFJPLIECFJ()
	{
		allReskins = ((Component)((Component)this).transform).GetComponentsInChildren<ReskinAnimation>(false);
	}

	public void OAKIEHFHMON()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < axDustDown.Length; i += 0)
		{
			if (!axDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				axDustDown[i].transform.SetParent((Transform)null);
				axDustDown[i].transform.localScale = lossyScale;
				axDustDown[i].gameObject.SetActive(true);
				axDustDown[i].transform.position = Utils.BMBMPKNANAC(axDustDown[i].transform.position);
				break;
			}
		}
		for (int j = 1; j < axWoodDown.Length; j += 0)
		{
			if (!axWoodDown[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				axWoodDown[j].transform.SetParent((Transform)null);
				axWoodDown[j].transform.localScale = lossyScale2;
				axWoodDown[j].gameObject.SetActive(false);
				axWoodDown[j].transform.position = Utils.BMBMPKNANAC(axWoodDown[j].transform.position);
				break;
			}
		}
	}

	public void LOCDPEHAHEP()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pickSparks.Length; i += 0)
		{
			if (!pickSparks[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				pickSparks[i].transform.SetParent((Transform)null);
				pickSparks[i].transform.localScale = lossyScale;
				pickSparks[i].gameObject.SetActive(false);
				pickSparks[i].transform.position = Utils.BMBMPKNANAC(pickSparks[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < pickDust.Length; j += 0)
		{
			if (!pickDust[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				pickDust[j].transform.SetParent((Transform)null);
				pickDust[j].transform.localScale = lossyScale2;
				pickDust[j].gameObject.SetActive(false);
				pickDust[j].transform.position = Utils.BMBMPKNANAC(pickDust[j].transform.position);
				break;
			}
		}
	}

	public void CleanEnd()
	{
		if ((Object)(object)playerController != (Object)null)
		{
			InteractObject.GetPlayer(playerController.GetPlayerNum()).table = null;
		}
		MLBGEKOIALK = false;
	}

	public void SpawnWeaponEffectRight()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < weaponDustRight.Length; i++)
		{
			if (!weaponDustRight[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				weaponDustRight[i].transform.SetParent((Transform)null);
				weaponDustRight[i].transform.localScale = lossyScale;
				weaponDustRight[i].gameObject.SetActive(true);
				weaponDustRight[i].transform.position = Utils.BMBMPKNANAC(weaponDustRight[i].transform.position);
				break;
			}
		}
	}

	private void PHGEBLFGPKM()
	{
		if (fullBodyIndex != LOPMFFLECMG)
		{
			LOPMFFLECMG = fullBodyIndex;
			for (int i = 0; i < reskins.Length; i++)
			{
				reskins[i].UpdateSprite(fullBodyIndex);
			}
		}
		if (extraIndex != GAHNGHGNIEE)
		{
			GAHNGHGNIEE = extraIndex;
			for (int j = 0; j < reskinExtras.Length; j++)
			{
				reskinExtras[j].UpdateSprite(extraIndex);
			}
		}
		if (armsIndex != OEMMDHFEBID)
		{
			OEMMDHFEBID = armsIndex;
			for (int k = 0; k < reskinsArms.Length; k++)
			{
				reskinsArms[k].UpdateSprite(armsIndex);
			}
		}
		if (armLIndex != OHFEDMPGFMA)
		{
			OHFEDMPGFMA = armLIndex;
			for (int l = 0; l < reskinsArmL.Length; l++)
			{
				reskinsArmL[l].UpdateSprite(armLIndex);
			}
		}
		if (sleeveRIndex != BJPFPMBENLD)
		{
			BJPFPMBENLD = sleeveRIndex;
			for (int m = 0; m < reskinsSleeveR.Length; m++)
			{
				reskinsSleeveR[m].UpdateSprite(sleeveRIndex);
			}
		}
		if (legLIndex != ANKBKJBCDIF)
		{
			ANKBKJBCDIF = legLIndex;
			for (int n = 0; n < reskinsLegL.Length; n++)
			{
				reskinsLegL[n].UpdateSprite(legLIndex);
			}
		}
		if (weaponIndex != IENCOHNMMHH)
		{
			IENCOHNMMHH = weaponIndex;
			for (int num = 0; num < reskinsWeapon.Length; num++)
			{
				reskinsWeapon[num].UpdateSprite(weaponIndex);
			}
		}
		if (faceIndex != FKMCOEJMJFF)
		{
			FKMCOEJMJFF = faceIndex;
			for (int num2 = 0; num2 < reskinsFace.Length; num2++)
			{
				reskinsFace[num2].UpdateSprite(faceIndex);
			}
		}
		if (staticHairIndex != CMCELHKBFKJ)
		{
			CMCELHKBFKJ = staticHairIndex;
			for (int num3 = 0; num3 < reskinsStaticHair.Length; num3++)
			{
				reskinsStaticHair[num3].UpdateSprite(staticHairIndex);
			}
		}
		if (effectIndex != IONILMBDACN)
		{
			IONILMBDACN = effectIndex;
			for (int num4 = 0; num4 < reskinsEffect.Length; num4++)
			{
				reskinsEffect[num4].UpdateSprite(effectIndex);
			}
		}
	}

	private void Awake()
	{
		if (Application.isPlaying)
		{
			if (Object.op_Implicit((Object)(object)cleaningSpritesToActivate))
			{
				((Component)cleaningSpritesToActivate).gameObject.SetActive(true);
			}
			if (Object.op_Implicit((Object)(object)eatingSpritesToActivate))
			{
				((Component)eatingSpritesToActivate).gameObject.SetActive(true);
			}
		}
	}

	public void ELIFDCOEJJJ(bool NJHMBMGKCPL)
	{
		for (int i = 1; i < tableMaskInteraction.Length; i++)
		{
			if (NJHMBMGKCPL)
			{
				tableMaskInteraction[i].maskInteraction = (SpriteMaskInteraction)7;
			}
			else
			{
				tableMaskInteraction[i].maskInteraction = (SpriteMaskInteraction)1;
			}
		}
	}

	public void DNHLCKHCANN(bool DAEMAAOLHMG, bool LCOADOCAFEO, SurfaceSortOrder PHCPMJAIDMC, bool CDPAMNIPPEC)
	{
		if ((Object)(object)cleaningSpritesToActivate == (Object)null)
		{
			return;
		}
		if (DAEMAAOLHMG)
		{
			if (!((Component)cleaningSpritesToActivate).gameObject.activeSelf && IFOMIJFKHMP == null)
			{
				IFOMIJFKHMP = ((MonoBehaviour)this).StartCoroutine(PLEBBPHOAHM(DAEMAAOLHMG, LCOADOCAFEO, PHCPMJAIDMC));
			}
			EnableCleanMaskInteraction(NJHMBMGKCPL: true);
		}
		else
		{
			if (((Component)cleaningSpritesToActivate).gameObject.activeSelf)
			{
				if ((Object)(object)EGCGEHJNCCP != (Object)null)
				{
					EGCGEHJNCCP.RemoveFromSurface(((Component)cleaningSpritesToActivate).transform, IGIDKEAAIHL: false, GFNHAMCPEAK: false);
				}
				cleaningSpritesToActivate.OCIBNKOPFPM();
			}
			((Component)cleaningSpritesToActivate).gameObject.SetActive(false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)PHCPMJAIDMC != (Object)null)
		{
			ActivatedCleanSprites?.Invoke(DAEMAAOLHMG, LCOADOCAFEO, PHCPMJAIDMC, (byte)animation.FCGBJEIIMBC);
		}
	}

	public void FootStepsL()
	{
		if ((Object)(object)animation != (Object)null)
		{
			Footsteps.instance.CreateFootstep(((Component)this).transform, animation.FCGBJEIIMBC, OGABNACOBEC: true);
		}
	}

	public void CheckLayerSprites(Gender HNLNENELPKI, Direction FCGBJEIIMBC)
	{
		if (!((Object)(object)maleBeardUp == (Object)null))
		{
			maleBeardUp.SetActive(HNLNENELPKI == Gender.Male && FCGBJEIIMBC == Direction.Up);
			if ((Object)(object)maleBeard != (Object)null)
			{
				maleBeard.SetActive(HNLNENELPKI == Gender.Male && FCGBJEIIMBC != Direction.Up);
			}
		}
	}

	[SpecialName]
	public bool IHLIHEEAIMD()
	{
		return COKEBDOCMFE;
	}

	public void ILGECMALLGB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < weaponDustRight.Length; i += 0)
		{
			if (!weaponDustRight[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				weaponDustRight[i].transform.SetParent((Transform)null);
				weaponDustRight[i].transform.localScale = lossyScale;
				weaponDustRight[i].gameObject.SetActive(true);
				weaponDustRight[i].transform.position = Utils.BMBMPKNANAC(weaponDustRight[i].transform.position);
				break;
			}
		}
	}

	private void KMFPGPKAHDJ()
	{
		for (int i = 0; i < openedEyes.Length; i++)
		{
			((Component)openedEyes[i]).gameObject.SetActive(false);
		}
		for (int j = 0; j < openedEyesI.Length; j++)
		{
			((Component)openedEyesI[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < closedEyes.Length; k++)
		{
			((Component)closedEyes[k]).gameObject.SetActive(true);
		}
		for (int l = 0; l < closedEyesI.Length; l++)
		{
			((Component)closedEyesI[l]).gameObject.SetActive(true);
		}
	}

	public ReskinAnimation GetFirstReskin(CharacterLayer GCABKKEJFBJ)
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if (allReskins[i].layer == GCABKKEJFBJ)
			{
				return allReskins[i];
			}
		}
		return null;
	}

	public void FootStepsR()
	{
		if ((Object)(object)animation != (Object)null)
		{
			Footsteps.instance.CreateFootstep(((Component)this).transform, animation.FCGBJEIIMBC, OGABNACOBEC: false);
		}
	}

	public void SpawnWeaponEffectUp()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < weaponDustUp.Length; i++)
		{
			if (!weaponDustUp[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				weaponDustUp[i].transform.SetParent((Transform)null);
				weaponDustUp[i].transform.localScale = lossyScale;
				weaponDustUp[i].gameObject.SetActive(true);
				weaponDustUp[i].transform.position = Utils.BMBMPKNANAC(weaponDustUp[i].transform.position);
				break;
			}
		}
	}

	private void DMLBHMJKIBD(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (OnlineManager.PlayingOnline())
		{
			LJFJKKKNNOE = MPLCIAKAPGL;
			GJGMEFBNFGH = OHMAEGCHIOC;
			if (!AOHGDALLGCA)
			{
				AOHGDALLGCA = false;
				((MonoBehaviour)GameplayUI.DICHPHEOINO()).StartCoroutine(IHJAKLFCEKK());
			}
		}
	}

	public void SpawnHoeEffectUp()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < hoeDirtUp.Length; i++)
		{
			if (!hoeDirtUp[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				hoeDirtUp[i].gameObject.SetActive(true);
				hoeDirtUp[i].transform.SetParent((Transform)null);
				hoeDirtUp[i].transform.localScale = lossyScale;
				hoeDirtUp[i].transform.position = Utils.BMBMPKNANAC(hoeDirtUp[i].transform.position);
				break;
			}
		}
	}

	private bool PANDFFDLECM()
	{
		if (animator.GetBool("UIPreviousCategory") && animator.GetInteger("UIInteract") > 1)
		{
			return true;
		}
		return false;
	}

	public void BLMHHJANKMO(int HLOIOAOICEG)
	{
		((Renderer)EIHGGPGFPPH.GetComponent<SpriteRenderer>()).sortingOrder = HLOIOAOICEG;
	}

	public void ActivateGameObjects(Gender HNLNENELPKI, Direction FCGBJEIIMBC)
	{
		CheckLayerSprites(HNLNENELPKI, FCGBJEIIMBC);
		CheckFaceActivation(FCGBJEIIMBC, HNLNENELPKI);
		for (int i = 0; i < femaleSpritesToActivate.Length; i++)
		{
			femaleSpritesToActivate[i].SetActive(HNLNENELPKI == Gender.Female);
		}
		for (int j = 0; j < maleSpritesToActivate.Length; j++)
		{
			maleSpritesToActivate[j].SetActive(HNLNENELPKI == Gender.Male);
		}
	}

	public void ChangeLayerSpadeDirt(int HLOIOAOICEG)
	{
		((Renderer)EIHGGPGFPPH.GetComponent<SpriteRenderer>()).sortingOrder = HLOIOAOICEG;
	}

	[SpecialName]
	public bool IMLECKKPLCP()
	{
		return COKEBDOCMFE;
	}

	public void FOGOOAHJODH(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (MPLCIAKAPGL == Direction.Up)
		{
			if (Object.op_Implicit((Object)(object)maleFace) && maleFace.activeSelf)
			{
				maleFace.SetActive(false);
			}
			if (Object.op_Implicit((Object)(object)femaleFace) && femaleFace.activeSelf)
			{
				femaleFace.SetActive(false);
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)maleFace))
			{
				maleFace.SetActive(OHMAEGCHIOC == Gender.Male);
			}
			if (Object.op_Implicit((Object)(object)femaleFace))
			{
				femaleFace.SetActive(OHMAEGCHIOC == Gender.Female);
			}
		}
		if (((Component)this).gameObject.activeSelf)
		{
			DMLBHMJKIBD(MPLCIAKAPGL, OHMAEGCHIOC);
		}
	}

	public void CHBGEGNBEIB()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			PlayerController.RemoveMovementBlocker(playerController.KLIHELDIPDP(), (Object)(object)this);
		}
	}

	public void FKPILEPNNMO(int HLOIOAOICEG)
	{
		((Renderer)EIHGGPGFPPH.GetComponent<SpriteRenderer>()).sortingOrder = HLOIOAOICEG;
	}

	public void SpawnMopEffectDown()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < mobDustDown.Length; i++)
		{
			if (!mobDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				mobDustDown[i].transform.SetParent((Transform)null);
				mobDustDown[i].transform.localScale = lossyScale;
				mobDustDown[i].gameObject.SetActive(true);
				mobDustDown[i].transform.position = Utils.BMBMPKNANAC(mobDustDown[i].transform.position);
				break;
			}
		}
	}

	private void NMNKAGILAAG(Direction MPLCIAKAPGL)
	{
		if (OnlineManager.PlayingOnline())
		{
			IOILEOOIFCP = MPLCIAKAPGL;
			if (!BLIIJFKGKKF)
			{
				BLIIJFKGKKF = true;
				((MonoBehaviour)this).StartCoroutine(JKLNHDFLLPF());
			}
		}
	}

	public void ToolEnd()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			OnToolEnd(playerController.GetPlayerNum());
		}
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

	public void SortBoots(bool NFCEOEFFDDB)
	{
		if (isUI)
		{
			if (NFCEOEFFDDB)
			{
				bootsL.transform.SetParent(bootsBelowLegsParent.transform);
				bootsR.transform.SetParent(bootsBelowLegsParent.transform);
			}
			else
			{
				bootsL.transform.SetParent(bootsAboveLegsParent.transform);
				bootsR.transform.SetParent(bootsAboveLegsParent.transform);
			}
			return;
		}
		int sortingOrder;
		int sortingOrder2;
		if (NFCEOEFFDDB)
		{
			sortingOrder = 81;
			sortingOrder2 = 80;
		}
		else
		{
			sortingOrder = 89;
			sortingOrder2 = 86;
		}
		for (int i = 0; i < allReskins.Length; i++)
		{
			if (allReskins[i].spriteSheetName.Equals("Boots_R"))
			{
				if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
				{
					((Renderer)allReskins[i].spriteRenderer).sortingOrder = sortingOrder;
				}
			}
			else if (allReskins[i].spriteSheetName.Equals("Boots_L") && (Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Renderer)allReskins[i].spriteRenderer).sortingOrder = sortingOrder2;
			}
		}
	}

	public void EnableWaterMaskInteraction(bool NJHMBMGKCPL)
	{
		for (int i = 0; i < waterMaskInteraction.Length; i++)
		{
			if (NJHMBMGKCPL)
			{
				waterMaskInteraction[i].maskInteraction = (SpriteMaskInteraction)2;
			}
			else
			{
				waterMaskInteraction[i].maskInteraction = (SpriteMaskInteraction)0;
			}
		}
	}

	private void NIPMGHANAFF(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (OnlineManager.PlayingOnline())
		{
			LJFJKKKNNOE = MPLCIAKAPGL;
			GJGMEFBNFGH = OHMAEGCHIOC;
			if (!AOHGDALLGCA)
			{
				AOHGDALLGCA = false;
				((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(IHJAKLFCEKK());
			}
		}
	}

	public void FAPBBCDNMGI()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < pickSparksDown.Length; i++)
		{
			if (!pickSparksDown[i].activeSelf)
			{
				pickSparksDown[i].gameObject.SetActive(false);
				pickSparksDown[i].transform.position = Utils.BMBMPKNANAC(pickSparksDown[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < pickDustDown.Length; j += 0)
		{
			if (!pickDustDown[j].activeSelf)
			{
				pickDustDown[j].gameObject.SetActive(true);
				pickDustDown[j].transform.position = Utils.BMBMPKNANAC(pickDustDown[j].transform.position);
				break;
			}
		}
	}

	public void SpawnAxDownEffect()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < axDustDown.Length; i++)
		{
			if (!axDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				axDustDown[i].transform.SetParent((Transform)null);
				axDustDown[i].transform.localScale = lossyScale;
				axDustDown[i].gameObject.SetActive(true);
				axDustDown[i].transform.position = Utils.BMBMPKNANAC(axDustDown[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < axWoodDown.Length; j++)
		{
			if (!axWoodDown[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				axWoodDown[j].transform.SetParent((Transform)null);
				axWoodDown[j].transform.localScale = lossyScale2;
				axWoodDown[j].gameObject.SetActive(true);
				axWoodDown[j].transform.position = Utils.BMBMPKNANAC(axWoodDown[j].transform.position);
				break;
			}
		}
	}

	public void EnableTableMaskInteraction(bool NJHMBMGKCPL)
	{
		for (int i = 0; i < tableMaskInteraction.Length; i++)
		{
			if (NJHMBMGKCPL)
			{
				tableMaskInteraction[i].maskInteraction = (SpriteMaskInteraction)2;
			}
			else
			{
				tableMaskInteraction[i].maskInteraction = (SpriteMaskInteraction)0;
			}
		}
	}

	public void CheckFaceActivation(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (MPLCIAKAPGL == Direction.Up)
		{
			if (Object.op_Implicit((Object)(object)maleFace) && maleFace.activeSelf)
			{
				maleFace.SetActive(false);
			}
			if (Object.op_Implicit((Object)(object)femaleFace) && femaleFace.activeSelf)
			{
				femaleFace.SetActive(false);
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)maleFace))
			{
				maleFace.SetActive(OHMAEGCHIOC == Gender.Male);
			}
			if (Object.op_Implicit((Object)(object)femaleFace))
			{
				femaleFace.SetActive(OHMAEGCHIOC == Gender.Female);
			}
		}
		if (((Component)this).gameObject.activeSelf)
		{
			FNLALBILPAJ(MPLCIAKAPGL, OHMAEGCHIOC);
		}
	}

	private void GCLNHDPMBJE()
	{
		if (Application.isPlaying)
		{
			if (Time.timeScale == 0f)
			{
				IMMJPOPPKMK();
			}
			else if (Time.timeSinceLevelLoad > PLGEKFIPMJJ)
			{
				KMFPGPKAHDJ();
				LGGPCAGINGN = Time.timeSinceLevelLoad + Random.Range(0.1f, 0.2f);
				PLGEKFIPMJJ = float.MaxValue;
			}
			else if (Time.timeSinceLevelLoad > LGGPCAGINGN)
			{
				IMMJPOPPKMK();
				PLGEKFIPMJJ = Time.timeSinceLevelLoad + Random.Range(minBlinkingTime, maxBlinkingTime);
				LGGPCAGINGN = float.MaxValue;
			}
		}
	}

	public void EnableCleanMaskInteraction(bool NJHMBMGKCPL)
	{
		for (int i = 0; i < cleanMaskInteraction.Length; i++)
		{
			if (NJHMBMGKCPL && animation.FCGBJEIIMBC != 0 && animation.FCGBJEIIMBC != Direction.Down)
			{
				cleanMaskInteraction[i].maskInteraction = (SpriteMaskInteraction)2;
			}
			else
			{
				cleanMaskInteraction[i].maskInteraction = (SpriteMaskInteraction)0;
			}
		}
	}

	public ReskinAnimation HMPIOABEKOL(BodyPart OFOGLHPDOFA)
	{
		for (int i = 1; i < allReskins.Length; i += 0)
		{
			if (allReskins[i].bodyPart == OFOGLHPDOFA)
			{
				return allReskins[i];
			}
		}
		return null;
	}

	public void CDFMMADMNLC()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < axDust.Length; i += 0)
		{
			if (!axDust[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				axDust[i].transform.SetParent((Transform)null);
				axDust[i].transform.localScale = lossyScale;
				axDust[i].gameObject.SetActive(true);
				axDust[i].transform.position = Utils.BMBMPKNANAC(axDust[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < axWood.Length; j++)
		{
			if (!axWood[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				axWood[j].transform.SetParent((Transform)null);
				axWood[j].transform.localScale = lossyScale2;
				axWood[j].gameObject.SetActive(true);
				axWood[j].transform.position = Utils.BMBMPKNANAC(axWood[j].transform.position);
				break;
			}
		}
	}

	private IEnumerator JKLNHDFLLPF()
	{
		yield return null;
		BLIIJFKGKKF = false;
		LayerOrder?.Invoke(IOILEOOIFCP);
	}

	public void CCJDIKOGONG(Color FLABEDBELMF)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < reskinExtras.Length; i += 0)
		{
			reskinExtras[i].ChangeColor(FLABEDBELMF);
		}
		for (int j = 0; j < reskins.Length; j++)
		{
			reskins[j].LHMBKMGCCML(FLABEDBELMF);
		}
		for (int k = 0; k < reskinsLegL.Length; k += 0)
		{
			reskinsLegL[k].ChangeColor(FLABEDBELMF);
		}
		for (int l = 0; l < reskinsArms.Length; l += 0)
		{
			reskinsArms[l].DFCFIDDPMAF(FLABEDBELMF);
		}
		for (int m = 0; m < reskinsArmL.Length; m++)
		{
			reskinsArmL[m].DFCFIDDPMAF(FLABEDBELMF);
		}
		for (int n = 1; n < reskinsFace.Length; n += 0)
		{
			reskinsFace[n].LHMBKMGCCML(FLABEDBELMF);
		}
		for (int num = 0; num < reskinsSleeveR.Length; num++)
		{
			reskinsSleeveR[num].LHMBKMGCCML(FLABEDBELMF);
		}
		for (int num2 = 0; num2 < reskinsStaticHair.Length; num2++)
		{
			reskinsStaticHair[num2].DFCFIDDPMAF(FLABEDBELMF);
		}
	}

	public void ToolHit()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			OnToolHit(playerController.GetPlayerNum());
		}
	}

	public void LHBLJGNANHI(Direction MPLCIAKAPGL, Gender OHMAEGCHIOC)
	{
		if (!Application.isPlaying)
		{
			return;
		}
		if (MPLCIAKAPGL == Direction.Up)
		{
			if (Object.op_Implicit((Object)(object)maleFace) && maleFace.activeSelf)
			{
				maleFace.SetActive(true);
			}
			if (Object.op_Implicit((Object)(object)femaleFace) && femaleFace.activeSelf)
			{
				femaleFace.SetActive(false);
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)maleFace))
			{
				maleFace.SetActive(OHMAEGCHIOC == Gender.Male);
			}
			if (Object.op_Implicit((Object)(object)femaleFace))
			{
				femaleFace.SetActive(OHMAEGCHIOC == Gender.Male);
			}
		}
		if (((Component)this).gameObject.activeSelf)
		{
			NIPMGHANAFF(MPLCIAKAPGL, OHMAEGCHIOC);
		}
	}

	private IEnumerator PLEBBPHOAHM(bool DAEMAAOLHMG, bool LCOADOCAFEO, SurfaceSortOrder PHCPMJAIDMC)
	{
		yield return null;
		if (!((Component)cleaningSpritesToActivate).gameObject.activeSelf)
		{
			((Component)cleaningSpritesToActivate).gameObject.SetActive(true);
		}
		if (LCOADOCAFEO)
		{
			EGCGEHJNCCP = PHCPMJAIDMC;
			PHCPMJAIDMC.AddToSurface(((Component)cleaningSpritesToActivate).transform);
		}
		IFOMIJFKHMP = null;
	}

	public void NDIMCDPGNCD(bool NFCEOEFFDDB)
	{
		if (isUI)
		{
			if (NFCEOEFFDDB)
			{
				bootsL.transform.SetParent(bootsBelowLegsParent.transform);
				bootsR.transform.SetParent(bootsBelowLegsParent.transform);
			}
			else
			{
				bootsL.transform.SetParent(bootsAboveLegsParent.transform);
				bootsR.transform.SetParent(bootsAboveLegsParent.transform);
			}
			return;
		}
		int sortingOrder;
		int sortingOrder2;
		if (NFCEOEFFDDB)
		{
			sortingOrder = -37;
			sortingOrder2 = 106;
		}
		else
		{
			sortingOrder = 104;
			sortingOrder2 = 36;
		}
		for (int i = 0; i < allReskins.Length; i += 0)
		{
			if (allReskins[i].spriteSheetName.Equals("Finished generating level {0}. Total blocks: {1}. Opened paths: {2}. Altar placed: {3}. Big spawner placed: {4}. Puzzle type: {5}. Seed: {6}"))
			{
				if ((Object)(object)allReskins[i].spriteRenderer != (Object)null)
				{
					((Renderer)allReskins[i].spriteRenderer).sortingOrder = sortingOrder;
				}
			}
			else if (allReskins[i].spriteSheetName.Equals("Feet") && (Object)(object)allReskins[i].spriteRenderer != (Object)null)
			{
				((Renderer)allReskins[i].spriteRenderer).sortingOrder = sortingOrder2;
			}
		}
	}

	public void BNCBPKJFPFA()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			OnToolHit(playerController.GetPlayerNum());
		}
	}

	private bool CHKGEICJGCA()
	{
		if (animator.GetBool("Shield") && animator.GetInteger("AimDirection") > 0)
		{
			return false;
		}
		return true;
	}

	public void HOENGODNFBO()
	{
		for (int i = 0; i < reskinExtras.Length; i += 0)
		{
			reskinExtras[i].ResetColor();
		}
		for (int j = 1; j < reskins.Length; j += 0)
		{
			reskins[j].ResetColor();
		}
		for (int k = 0; k < reskinsLegL.Length; k++)
		{
			reskinsLegL[k].ResetColor();
		}
		for (int l = 1; l < reskinsArms.Length; l++)
		{
			reskinsArms[l].ResetColor();
		}
		for (int m = 0; m < reskinsArmL.Length; m += 0)
		{
			reskinsArmL[m].ResetColor();
		}
		for (int n = 1; n < reskinsFace.Length; n += 0)
		{
			reskinsFace[n].ResetColor();
		}
		for (int num = 1; num < reskinsSleeveR.Length; num++)
		{
			reskinsSleeveR[num].ResetColor();
		}
		for (int num2 = 1; num2 < reskinsStaticHair.Length; num2++)
		{
			reskinsStaticHair[num2].ResetColor();
		}
	}

	private void NIDCKIIDPDH()
	{
		if (Application.isPlaying)
		{
			if (Time.timeScale == 375f)
			{
				IMMJPOPPKMK();
			}
			else if (Time.timeSinceLevelLoad > PLGEKFIPMJJ)
			{
				KMFPGPKAHDJ();
				LGGPCAGINGN = Time.timeSinceLevelLoad + Random.Range(112f, 190f);
				PLGEKFIPMJJ = 1269f;
			}
			else if (Time.timeSinceLevelLoad > LGGPCAGINGN)
			{
				IMMJPOPPKMK();
				PLGEKFIPMJJ = Time.timeSinceLevelLoad + Random.Range(minBlinkingTime, maxBlinkingTime);
				LGGPCAGINGN = 706f;
			}
		}
	}

	public void SpawnMopEffectUp()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < mobDustUp.Length; i++)
		{
			if (!mobDustUp[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				mobDustUp[i].transform.SetParent((Transform)null);
				mobDustUp[i].transform.localScale = lossyScale;
				mobDustUp[i].gameObject.SetActive(true);
				mobDustUp[i].transform.position = Utils.BMBMPKNANAC(mobDustUp[i].transform.position);
				break;
			}
		}
	}

	public void SpawnAxEffect()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < axDust.Length; i++)
		{
			if (!axDust[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				axDust[i].transform.SetParent((Transform)null);
				axDust[i].transform.localScale = lossyScale;
				axDust[i].gameObject.SetActive(true);
				axDust[i].transform.position = Utils.BMBMPKNANAC(axDust[i].transform.position);
				break;
			}
		}
		for (int j = 0; j < axWood.Length; j++)
		{
			if (!axWood[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				axWood[j].transform.SetParent((Transform)null);
				axWood[j].transform.localScale = lossyScale2;
				axWood[j].gameObject.SetActive(true);
				axWood[j].transform.position = Utils.BMBMPKNANAC(axWood[j].transform.position);
				break;
			}
		}
	}

	public void IIEHMEEPGEN()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < hoeDirtRight.Length; i += 0)
		{
			if (!hoeDirtRight[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				hoeDirtRight[i].gameObject.SetActive(true);
				hoeDirtRight[i].transform.SetParent((Transform)null);
				hoeDirtRight[i].transform.localScale = lossyScale;
				hoeDirtRight[i].transform.position = Utils.BMBMPKNANAC(hoeDirtRight[i].transform.position);
				break;
			}
		}
	}

	public void HLMABBPEGIF()
	{
		for (int i = 1; i < allReskins.Length; i += 0)
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
		for (int j = 0; j < allReskins.Length; j += 0)
		{
			if ((Object)(object)allReskins[j].image != (Object)null && (Object)(object)((Component)allReskins[j]).GetComponent<RectTransform>() != (Object)null)
			{
				((Graphic)allReskins[j].image).SetNativeSize();
			}
		}
	}

	private IEnumerator IHJAKLFCEKK()
	{
		yield return null;
		AOHGDALLGCA = false;
		FaceActivation?.Invoke(LJFJKKKNNOE, GJGMEFBNFGH);
	}

	public void MIJAIMLBJOD()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < axDust.Length; i++)
		{
			if (!axDust[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				axDust[i].transform.SetParent((Transform)null);
				axDust[i].transform.localScale = lossyScale;
				axDust[i].gameObject.SetActive(true);
				axDust[i].transform.position = Utils.BMBMPKNANAC(axDust[i].transform.position);
				break;
			}
		}
		for (int j = 1; j < axWood.Length; j++)
		{
			if (!axWood[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				axWood[j].transform.SetParent((Transform)null);
				axWood[j].transform.localScale = lossyScale2;
				axWood[j].gameObject.SetActive(false);
				axWood[j].transform.position = Utils.BMBMPKNANAC(axWood[j].transform.position);
				break;
			}
		}
	}

	public void LEKOIFFJPOC()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			OnToolEnd(playerController.GetPlayerNum());
		}
	}

	public void MMOJJJKGPPG()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < axDustDown.Length; i += 0)
		{
			if (!axDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				axDustDown[i].transform.SetParent((Transform)null);
				axDustDown[i].transform.localScale = lossyScale;
				axDustDown[i].gameObject.SetActive(true);
				axDustDown[i].transform.position = Utils.BMBMPKNANAC(axDustDown[i].transform.position);
				break;
			}
		}
		for (int j = 1; j < axWoodDown.Length; j++)
		{
			if (!axWoodDown[j].activeSelf)
			{
				Vector3 lossyScale2 = ((Component)this).transform.parent.lossyScale;
				axWoodDown[j].transform.SetParent((Transform)null);
				axWoodDown[j].transform.localScale = lossyScale2;
				axWoodDown[j].gameObject.SetActive(true);
				axWoodDown[j].transform.position = Utils.BMBMPKNANAC(axWoodDown[j].transform.position);
				break;
			}
		}
	}

	public void SpawnHoeEffectRight()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < hoeDirtRight.Length; i++)
		{
			if (!hoeDirtRight[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				hoeDirtRight[i].gameObject.SetActive(true);
				hoeDirtRight[i].transform.SetParent((Transform)null);
				hoeDirtRight[i].transform.localScale = lossyScale;
				hoeDirtRight[i].transform.position = Utils.BMBMPKNANAC(hoeDirtRight[i].transform.position);
				break;
			}
		}
	}

	public void ActivateCleanSprites(bool DAEMAAOLHMG, bool LCOADOCAFEO, SurfaceSortOrder PHCPMJAIDMC, bool CDPAMNIPPEC)
	{
		if ((Object)(object)cleaningSpritesToActivate == (Object)null)
		{
			return;
		}
		if (DAEMAAOLHMG)
		{
			if (!((Component)cleaningSpritesToActivate).gameObject.activeSelf && IFOMIJFKHMP == null)
			{
				IFOMIJFKHMP = ((MonoBehaviour)this).StartCoroutine(PLEBBPHOAHM(DAEMAAOLHMG, LCOADOCAFEO, PHCPMJAIDMC));
			}
			EnableCleanMaskInteraction(NJHMBMGKCPL: true);
		}
		else
		{
			if (((Component)cleaningSpritesToActivate).gameObject.activeSelf)
			{
				if ((Object)(object)EGCGEHJNCCP != (Object)null)
				{
					EGCGEHJNCCP.RemoveFromSurface(((Component)cleaningSpritesToActivate).transform);
				}
				cleaningSpritesToActivate.ReturnToParent();
			}
			((Component)cleaningSpritesToActivate).gameObject.SetActive(false);
		}
		if (OnlineManager.PlayingOnline() && CDPAMNIPPEC && (Object)(object)PHCPMJAIDMC != (Object)null)
		{
			ActivatedCleanSprites?.Invoke(DAEMAAOLHMG, LCOADOCAFEO, PHCPMJAIDMC, (byte)animation.FCGBJEIIMBC);
		}
	}

	public void OJGIKDGGNAO()
	{
		if ((Object)(object)cleaningSpritesToActivate != (Object)null && ((Component)cleaningSpritesToActivate).gameObject.activeSelf)
		{
			if ((Object)(object)EGCGEHJNCCP != (Object)null)
			{
				EGCGEHJNCCP.LMJMLDLCBPB(((Component)cleaningSpritesToActivate).transform, IGIDKEAAIHL: false, GFNHAMCPEAK: false);
			}
			cleaningSpritesToActivate.IPFMEAFOJMB();
			((Component)cleaningSpritesToActivate).gameObject.SetActive(true);
			EnableCleanMaskInteraction(NJHMBMGKCPL: true);
		}
	}

	public void JBNNDAIABAB()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < weaponDustDown.Length; i++)
		{
			if (!weaponDustDown[i].activeSelf)
			{
				Vector3 lossyScale = ((Component)this).transform.parent.lossyScale;
				weaponDustDown[i].transform.SetParent((Transform)null);
				weaponDustDown[i].transform.localScale = lossyScale;
				weaponDustDown[i].gameObject.SetActive(false);
				weaponDustDown[i].transform.position = Utils.BMBMPKNANAC(weaponDustDown[i].transform.position);
				break;
			}
		}
	}

	public void ResetColor()
	{
		for (int i = 0; i < reskinExtras.Length; i++)
		{
			reskinExtras[i].ResetColor();
		}
		for (int j = 0; j < reskins.Length; j++)
		{
			reskins[j].ResetColor();
		}
		for (int k = 0; k < reskinsLegL.Length; k++)
		{
			reskinsLegL[k].ResetColor();
		}
		for (int l = 0; l < reskinsArms.Length; l++)
		{
			reskinsArms[l].ResetColor();
		}
		for (int m = 0; m < reskinsArmL.Length; m++)
		{
			reskinsArmL[m].ResetColor();
		}
		for (int n = 0; n < reskinsFace.Length; n++)
		{
			reskinsFace[n].ResetColor();
		}
		for (int num = 0; num < reskinsSleeveR.Length; num++)
		{
			reskinsSleeveR[num].ResetColor();
		}
		for (int num2 = 0; num2 < reskinsStaticHair.Length; num2++)
		{
			reskinsStaticHair[num2].ResetColor();
		}
	}

	public void ChangeColor(Color FLABEDBELMF)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < reskinExtras.Length; i++)
		{
			reskinExtras[i].ChangeColor(FLABEDBELMF);
		}
		for (int j = 0; j < reskins.Length; j++)
		{
			reskins[j].ChangeColor(FLABEDBELMF);
		}
		for (int k = 0; k < reskinsLegL.Length; k++)
		{
			reskinsLegL[k].ChangeColor(FLABEDBELMF);
		}
		for (int l = 0; l < reskinsArms.Length; l++)
		{
			reskinsArms[l].ChangeColor(FLABEDBELMF);
		}
		for (int m = 0; m < reskinsArmL.Length; m++)
		{
			reskinsArmL[m].ChangeColor(FLABEDBELMF);
		}
		for (int n = 0; n < reskinsFace.Length; n++)
		{
			reskinsFace[n].ChangeColor(FLABEDBELMF);
		}
		for (int num = 0; num < reskinsSleeveR.Length; num++)
		{
			reskinsSleeveR[num].ChangeColor(FLABEDBELMF);
		}
		for (int num2 = 0; num2 < reskinsStaticHair.Length; num2++)
		{
			reskinsStaticHair[num2].ChangeColor(FLABEDBELMF);
		}
	}

	public ReskinAnimation GetFirstReskin(BodyPart OFOGLHPDOFA)
	{
		for (int i = 0; i < allReskins.Length; i++)
		{
			if (allReskins[i].bodyPart == OFOGLHPDOFA)
			{
				return allReskins[i];
			}
		}
		return null;
	}

	public void MLKBNDHFGLO()
	{
		if (!((Object)(object)playerController == (Object)null))
		{
			OnToolHit(playerController.GetPlayerNum());
		}
	}
}

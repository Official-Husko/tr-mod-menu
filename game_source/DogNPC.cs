using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DogNPC : NPC, IProximity, IInteractable, ISelectable, IHoverable
{
	public enum DogInteractionType
	{
		None,
		Bark,
		Friendly,
		Aggressive,
		Sleep,
		Dig,
		Drink,
		Eat,
		Toy,
		Smell,
		Scratch
	}

	public enum DogBreed
	{
		Beagle,
		Bernard,
		BorderCollie,
		Boxer,
		Husky,
		Shepard,
		Shiba
	}

	[CompilerGenerated]
	private sealed class OELJIGGOBOJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DogNPC _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public OELJIGGOBOJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DogNPC dogNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if ((Object)(object)dogNPC.dogInteractable != (Object)null)
				{
					dogNPC.dogAnimation.FCGBJEIIMBC = dogNPC.dogInteractable.lookDirection;
				}
				else if ((Object)(object)dogNPC.currentDogBowl != (Object)null)
				{
					if (dogNPC.currentDogBowl.placeable.direction == Direction.Up || dogNPC.currentDogBowl.placeable.direction == Direction.Down)
					{
						if (((Component)dogNPC.currentDogBowl).transform.position.x > ((Component)dogNPC).transform.position.x)
						{
							dogNPC.dogAnimation.FCGBJEIIMBC = Direction.Right;
						}
						else
						{
							dogNPC.dogAnimation.FCGBJEIIMBC = Direction.Left;
						}
					}
					else if (((Component)dogNPC.currentDogBowl).transform.position.y > ((Component)dogNPC).transform.position.y)
					{
						dogNPC.dogAnimation.FCGBJEIIMBC = Direction.Up;
					}
					else
					{
						dogNPC.dogAnimation.FCGBJEIIMBC = Direction.Down;
					}
				}
				else
				{
					for (int i = 1; i <= 2; i++)
					{
						if (!WorldGrid.APKPGNDDJHC(((Component)dogNPC).transform.position + Utils.NGFODNCHPHB(dogNPC.dogAnimation.FCGBJEIIMBC) * 0.25f * (float)i))
						{
							dogNPC.dogAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(dogNPC.dogAnimation.FCGBJEIIMBC);
							break;
						}
					}
				}
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class BBHBNIFKCHC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int relationship;

		public int dogSelected;

		public string dogName;

		public GameDate birthday;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public BBHBNIFKCHC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				InstantiateDog(relationship, dogSelected, dogName, birthday, Vector2.op_Implicit(HAIPIEMDGFD));
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public static DogNPC instance;

	public DogBreed dogBreed;

	public string dogName;

	public GameDate birthday;

	public DogAnimator dogAnimator;

	public DogAnimation dogAnimation;

	public DogRelationship dogRelationship;

	public Animator behaviour;

	public float runSpeed;

	public PlayerController playerFollowing;

	public Vector3 lastPlayerPosition;

	public OnlineDog onlineDog;

	public DogState behaviourState;

	public DogStateBase dogCurrentState;

	public DogInteractable dogInteractable;

	public DogHole currentDogHole;

	public float timeToSearchForHole;

	public float timeToSearchToy;

	public bool stopOrder;

	public PetBowl currentDogBowl;

	private float LHGHCPEAABC;

	private static Vector3 HAIPIEMDGFD = new Vector3(10.5f, -14f, 0f);

	private Vector3 AADMIOHCEEB;

	public GameObject dirt;

	public GameObject snow;

	public AnimationNPCSounds animationNPCSounds;

	public void Pet(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (Time.timeSinceLevelLoad >= LHGHCPEAABC)
		{
			LHGHCPEAABC = Time.timeSinceLevelLoad + 5f;
			dogRelationship.Pet();
			dogAnimation.LoveEmote();
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.SendPet();
			}
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void IPMFEOLFONA()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Component)this).transform.position = Vector2.op_Implicit(new Vector2(1924f, 250f));
			JINJODIENIN(DogState.Idle);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("" + ex.Message));
		}
	}

	public void CCKMDEOLNGO(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).LKOGGHNGBKD("ReceiveItemContainerColor"))
		{
			if (stopOrder || (Object)(object)playerFollowing != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL))
			{
				KMCCDIHFDFK(JIIGOACEIKL, CDPAMNIPPEC: false);
			}
			else
			{
				MLIKLKIDMBM(CDPAMNIPPEC: false);
			}
		}
	}

	public void TeleportToInitialPoint()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Component)this).transform.position = Vector2.op_Implicit(new Vector2(9f, -14f));
			ChangeState(DogState.Idle);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in DogNPC.TeleportToInitialPoint: " + ex.Message));
		}
	}

	public IEnumerator GOBIELKMHHF()
	{
		yield return null;
		yield return null;
		if ((Object)(object)dogInteractable != (Object)null)
		{
			dogAnimation.FCGBJEIIMBC = dogInteractable.lookDirection;
			yield break;
		}
		if ((Object)(object)currentDogBowl != (Object)null)
		{
			if (currentDogBowl.placeable.direction == Direction.Up || currentDogBowl.placeable.direction == Direction.Down)
			{
				if (((Component)currentDogBowl).transform.position.x > ((Component)this).transform.position.x)
				{
					dogAnimation.FCGBJEIIMBC = Direction.Right;
				}
				else
				{
					dogAnimation.FCGBJEIIMBC = Direction.Left;
				}
			}
			else if (((Component)currentDogBowl).transform.position.y > ((Component)this).transform.position.y)
			{
				dogAnimation.FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				dogAnimation.FCGBJEIIMBC = Direction.Down;
			}
			yield break;
		}
		for (int i = 1; i <= 2; i++)
		{
			if (!WorldGrid.APKPGNDDJHC(((Component)this).transform.position + Utils.NGFODNCHPHB(dogAnimation.FCGBJEIIMBC) * 0.25f * (float)i))
			{
				dogAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(dogAnimation.FCGBJEIIMBC);
				break;
			}
		}
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		if (DogUI.Get(JIIGOACEIKL).IsOpen())
		{
			DogUI.Get(JIIGOACEIKL).CloseUI();
		}
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(onlineDog);
		}
		return true;
	}

	public bool BLPDCBLMODH(int JIIGOACEIKL)
	{
		HJMCKLGGHBM(JIIGOACEIKL);
		return true;
	}

	public bool HOGBEKJNJBM(int JIIGOACEIKL)
	{
		return true;
	}

	public void PAACEHIKKBI()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Component)this).transform.position = Vector2.op_Implicit(new Vector2(616f, 895f));
			ChangeState((DogState)6);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Items/item_name_614" + ex.Message));
		}
	}

	public bool JENDIAHPKNK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void Unfollow(bool CDPAMNIPPEC)
	{
		if (!((Object)(object)playerFollowing != (Object)null) || playerFollowing.LEOIMFNKFGA != Location.PetShop)
		{
			stopOrder = true;
			if (OnlineManager.MasterOrOffline())
			{
				ChangeState(DogState.Idle);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.SendUnfollow();
			}
		}
	}

	public void LGJPLHOKJLN(int JIIGOACEIKL)
	{
	}

	public bool ONDLNJAJKEH(int JIIGOACEIKL)
	{
		return false;
	}

	public void FHPIBJNKBEN(int JIIGOACEIKL)
	{
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonUp("</color> to inventory?"))
		{
			if (stopOrder || (Object)(object)playerFollowing != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL))
			{
				NPBPAMNPCAP(JIIGOACEIKL, CDPAMNIPPEC: false);
			}
			else
			{
				GMEJJINEKIN(CDPAMNIPPEC: false);
			}
		}
	}

	public void NLLENLLOBLH(int JIIGOACEIKL)
	{
		if (PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL).GetButtonUp("City/Rhia/Introduce"))
		{
			if (stopOrder || (Object)(object)playerFollowing != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL))
			{
				Follow(JIIGOACEIKL, CDPAMNIPPEC: false);
			}
			else
			{
				MLIKLKIDMBM(CDPAMNIPPEC: true);
			}
		}
	}

	private static IEnumerator IFKMICNABAF(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		InstantiateDog(IHNEJFGAENM, DKEDKLAJEBJ, EENNAOMJDLO, GDNLNDKBLJJ, Vector2.op_Implicit(HAIPIEMDGFD));
	}

	public void ACFKEPAOCOH(PlayerController PKCHNBPBHFL, bool CDPAMNIPPEC)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		playerFollowing = PKCHNBPBHFL;
		lastPlayerPosition = ((Component)playerFollowing).transform.position;
		stopOrder = true;
		if (OnlineManager.MasterOrOffline())
		{
			IHMEOKNMHIJ(DogState.IdleNearPlayer);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.SendFollow();
		}
	}

	public bool BCGBODLPDEB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (Time.timeSinceLevelLoad >= LHGHCPEAABC)
			{
				ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Quest/Entry/41/Dialogue Text"));
			}
			if ((Object)(object)playerFollowing == (Object)null || playerFollowing.LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.BarnInterior))
			{
				if (stopOrder || (Object)(object)playerFollowing != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL))
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("LE_9"));
				}
				else
				{
					ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Key2"));
				}
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.PrevNext, LocalisationSystem.Get("Dismiss"));
			return true;
		}
		return true;
	}

	public bool KHAFEICJIMJ(int JIIGOACEIKL)
	{
		if (KFKPIHAJIFJ(JIIGOACEIKL))
		{
			PJEGBNAHOGK(JIIGOACEIKL, CDPAMNIPPEC: true);
			return false;
		}
		return false;
	}

	public bool ECPCDLJHOEL(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineDog.uniqueId);
				return true;
			}
			CBHFGGAMOOE(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	private void EDFFBEGFDDJ()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() && (Object)(object)dogCurrentState != (Object)null)
		{
			dogCurrentState.PAGELNPDBPJ();
		}
		if (OnlineManager.IsMasterClient() && Object.op_Implicit((Object)(object)onlineDog) && AADMIOHCEEB != ((Component)this).transform.position)
		{
			onlineDog.MELNFFGJECB();
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}

	public void OCDDAPDCIEE(PlayerController NLCDDFDGACP, bool CDPAMNIPPEC)
	{
		if (!((Object)(object)playerFollowing != (Object)(object)NLCDDFDGACP))
		{
			GMEJJINEKIN(CDPAMNIPPEC);
		}
	}

	public bool OJEKCHFOICK(int JIIGOACEIKL)
	{
		if (IFMMLFLIJJK(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineDog.uniqueId);
				return true;
			}
			HJMCKLGGHBM(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void PJEGBNAHOGK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (Time.timeSinceLevelLoad >= LHGHCPEAABC)
		{
			LHGHCPEAABC = Time.timeSinceLevelLoad + 582f;
			dogRelationship.PGIBFMDAIBJ();
			dogAnimation.KOJAPAMICLJ();
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.SendPet();
			}
		}
	}

	public bool DOGBEDLPOMJ(int JIIGOACEIKL)
	{
		return true;
	}

	public void NPBPAMNPCAP(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		Follow(PlayerController.OPHDCMJLLEC(JIIGOACEIKL), CDPAMNIPPEC);
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			Pet(JIIGOACEIKL, CDPAMNIPPEC: true);
			return true;
		}
		return false;
	}

	public static void InstantianteDogNextFrame(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(OHCBCIODBIN(IHNEJFGAENM, DKEDKLAJEBJ, EENNAOMJDLO, GDNLNDKBLJJ));
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public void StartWalking()
	{
		((Component)this).transform.parent = null;
	}

	public bool LKELFKFPNPJ(int JIIGOACEIKL)
	{
		if (IFMMLFLIJJK(JIIGOACEIKL))
		{
			PJEGBNAHOGK(JIIGOACEIKL, CDPAMNIPPEC: true);
			return false;
		}
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public static void HPDCPDOCKPC(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ, Vector2 IMOBLFMHKOD, bool GFNHAMCPEAK = true, bool CDPAMNIPPEC = true)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.GetDogPrefab((DogBreed)DKEDKLAJEBJ), Vector2.op_Implicit(IMOBLFMHKOD), Quaternion.identity);
		instance.dogRelationship.AJKBGMDFLFP(IHNEJFGAENM);
		instance.dogName = EENNAOMJDLO;
		instance.birthday = GDNLNDKBLJJ;
		instance.dogBreed = (DogBreed)DKEDKLAJEBJ;
		if (GFNHAMCPEAK)
		{
			instance.HDGJJMIDFNO(0, CDPAMNIPPEC);
		}
	}

	public void KPJAFINEDOJ()
	{
		((Component)this).transform.parent = null;
	}

	public bool BGOGFOBCPLA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool GEPPGFMABFG()
	{
		if (dogBreed != 0 && dogBreed != (DogBreed)7)
		{
			return dogBreed == (DogBreed)7;
		}
		return false;
	}

	public bool AGHFLOOECJH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void EJDLBJGJAAN(int JIIGOACEIKL)
	{
	}

	public bool ABBEMDMCPHI(int JIIGOACEIKL)
	{
		if (BKPEBOBAIJI(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineDog.uniqueId);
				return false;
			}
			PCJAEMFLGOC(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public IEnumerator ChangeDirectionNextFrame()
	{
		yield return null;
		yield return null;
		if ((Object)(object)dogInteractable != (Object)null)
		{
			dogAnimation.FCGBJEIIMBC = dogInteractable.lookDirection;
			yield break;
		}
		if ((Object)(object)currentDogBowl != (Object)null)
		{
			if (currentDogBowl.placeable.direction == Direction.Up || currentDogBowl.placeable.direction == Direction.Down)
			{
				if (((Component)currentDogBowl).transform.position.x > ((Component)this).transform.position.x)
				{
					dogAnimation.FCGBJEIIMBC = Direction.Right;
				}
				else
				{
					dogAnimation.FCGBJEIIMBC = Direction.Left;
				}
			}
			else if (((Component)currentDogBowl).transform.position.y > ((Component)this).transform.position.y)
			{
				dogAnimation.FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				dogAnimation.FCGBJEIIMBC = Direction.Down;
			}
			yield break;
		}
		for (int i = 1; i <= 2; i++)
		{
			if (!WorldGrid.APKPGNDDJHC(((Component)this).transform.position + Utils.NGFODNCHPHB(dogAnimation.FCGBJEIIMBC) * 0.25f * (float)i))
			{
				dogAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(dogAnimation.FCGBJEIIMBC);
				break;
			}
		}
	}

	private void HIPNEFOEJPL()
	{
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (dogAnimation.DogIsDigging() || behaviourState == DogState.Toy)
			{
				return;
			}
			if ((Object)(object)playerFollowing != (Object)null && TilemapsInfo.PAIMPONBECF(playerFollowing.LEOIMFNKFGA) == InteriorType.Exterior && !stopOrder)
			{
				if (AGCOFLAJHMN() && behaviourState != 0 && Vector2.Distance(Vector2.op_Implicit(((Component)playerFollowing).transform.position), Vector2.op_Implicit(((Component)this).transform.position)) > 1481f)
				{
					JINJODIENIN(DogState.IdleNearPlayer);
				}
				if (Time.timeSinceLevelLoad > timeToSearchForHole)
				{
					DogHoleManager.instance.MKBFMLFBHHN(out currentDogHole);
					if ((Object)(object)currentDogHole != (Object)null)
					{
						timeToSearchForHole = Time.timeSinceLevelLoad + 1413f;
						JINJODIENIN(DogState.Toy);
					}
					else
					{
						timeToSearchForHole = Time.timeSinceLevelLoad + 257f;
					}
				}
			}
			else if (behaviourState != (DogState)6)
			{
				ChangeState(DogState.IdleNearPlayer);
			}
			if (Time.timeSinceLevelLoad > timeToSearchToy && behaviourState != (DogState)6)
			{
				if (PetToy.JBNBIHJPHII(Vector2.op_Implicit(((Component)this).transform.position), 1263f))
				{
					timeToSearchToy = Time.timeSinceLevelLoad + 828f;
					CHFKPKDBIJL(DogState.Toy);
				}
				else
				{
					timeToSearchToy = Time.timeSinceLevelLoad + 1572f;
				}
			}
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == (Location.Tavern | Location.Camp | Location.BarnInterior) && ((Object)(object)playerFollowing == (Object)null || playerFollowing.LEOIMFNKFGA == ~(Location.Tavern | Location.Road | Location.Farm)))
			{
				if (dogAnimation.FCGBJEIIMBC != Direction.Down)
				{
					dogAnimation.FCGBJEIIMBC = Direction.Down;
				}
				dogAnimation.CGELCJDBGNK(DogInteractionType.Bark, CDPAMNIPPEC: false);
			}
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == ~(Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior))
			{
				if ((Object)(object)animationNPCSounds.audioObjects[1] != (Object)(object)Sound.DIHCEGINELM().dogStep)
				{
					animationNPCSounds.audioObjects[0] = Sound.BNBMNOMFFBE().dogStep;
				}
			}
			else if ((Object)(object)animationNPCSounds.audioObjects[0] != (Object)(object)Sound.MAIDHAPANEB().dogStepSoft)
			{
				animationNPCSounds.audioObjects[0] = Sound.DIHCEGINELM().dogStepSoft;
			}
		}
		if ((Object)(object)playerFollowing != (Object)null)
		{
			lastPlayerPosition = ((Component)playerFollowing).transform.position;
		}
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		PCJAEMFLGOC(JIIGOACEIKL);
		return true;
	}

	public void DHGFHNALOAH(Vector2 LAFNLCMIHHL, Action NNBPENENIIC, Action PDOBHPLPKHG, float BHJFNFPIILG, bool MFCMOOKEHMN)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		walkTo.speed = speed;
		walkTo.run = true;
		walkTo.followPlayerDistance = BHJFNFPIILG;
		walkTo.runningSpeed = runSpeed;
		walkTo.GHDMBFOAAHK(LAFNLCMIHHL, MFCMOOKEHMN, NGAKHGJANLO: false);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, PDOBHPLPKHG);
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, NNBPENENIIC);
		walkTo.NOFKEMGPFEO();
	}

	public bool JLBADAPMLEH(int JIIGOACEIKL)
	{
		if (PEBMANKLJNN(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.GMJPOKECENH(onlineDog.uniqueId);
				return false;
			}
			PCJAEMFLGOC(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void HDGJJMIDFNO(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		Follow(PlayerController.OPHDCMJLLEC(JIIGOACEIKL), CDPAMNIPPEC);
	}

	public static void BNOPLOHELNG(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(NJALIDABMNM(IHNEJFGAENM, DKEDKLAJEBJ, EENNAOMJDLO, GDNLNDKBLJJ));
	}

	public bool ACLPKJGGPFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private static IEnumerator ANFPLGJMDCA(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		InstantiateDog(IHNEJFGAENM, DKEDKLAJEBJ, EENNAOMJDLO, GDNLNDKBLJJ, Vector2.op_Implicit(HAIPIEMDGFD));
	}

	public void NFCLPJONDJB()
	{
		((Component)this).transform.parent = null;
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineDog.uniqueId);
				return false;
			}
			PCJAEMFLGOC(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool AHJGDENBOJL(int JIIGOACEIKL)
	{
		if (PEBMANKLJNN(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineDog.uniqueId);
				return true;
			}
			CBHFGGAMOOE(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void CFJOGFDANJH(Vector2 LAFNLCMIHHL, Action NNBPENENIIC, Action PDOBHPLPKHG, float BHJFNFPIILG, bool MFCMOOKEHMN)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		walkTo.speed = speed;
		walkTo.run = false;
		walkTo.followPlayerDistance = BHJFNFPIILG;
		walkTo.runningSpeed = runSpeed;
		walkTo.KBEENHPEOAB(LAFNLCMIHHL, MFCMOOKEHMN);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, PDOBHPLPKHG);
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, NNBPENENIIC);
		walkTo.PEHELKCIECB();
	}

	public bool KGPDHFFEDKP(int JIIGOACEIKL)
	{
		if (PEBMANKLJNN(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(onlineDog.uniqueId);
				return false;
			}
			CBHFGGAMOOE(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).GetButtonUp("Use"))
		{
			if (stopOrder || (Object)(object)playerFollowing != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL))
			{
				Follow(JIIGOACEIKL, CDPAMNIPPEC: true);
			}
			else
			{
				Unfollow(CDPAMNIPPEC: true);
			}
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void MHCOLHEDNGN()
	{
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (dogAnimation.DogIsDigging() || behaviourState == DogState.FollowPlayer)
			{
				return;
			}
			if ((Object)(object)playerFollowing != (Object)null && TilemapsInfo.ILIFFMPLLII(playerFollowing.LEOIMFNKFGA) == InteriorType.Exterior && !stopOrder)
			{
				if (IsThePlayerMoving() && behaviourState != 0 && Vector2.Distance(Vector2.op_Implicit(((Component)playerFollowing).transform.position), Vector2.op_Implicit(((Component)this).transform.position)) > 319f)
				{
					CHFKPKDBIJL(DogState.IdleNearPlayer);
				}
				if (Time.timeSinceLevelLoad > timeToSearchForHole)
				{
					DogHoleManager.instance.MKBFMLFBHHN(out currentDogHole);
					if ((Object)(object)currentDogHole != (Object)null)
					{
						timeToSearchForHole = Time.timeSinceLevelLoad + 1490f;
						IHMEOKNMHIJ(DogState.Idle);
					}
					else
					{
						timeToSearchForHole = Time.timeSinceLevelLoad + 1651f;
					}
				}
			}
			else if (behaviourState != (DogState)7)
			{
				IHMEOKNMHIJ((DogState)8);
			}
			if (Time.timeSinceLevelLoad > timeToSearchToy && behaviourState != DogState.Stopped)
			{
				if (PetToy.IsAnyToyInDistance(Vector2.op_Implicit(((Component)this).transform.position), 1970f))
				{
					timeToSearchToy = Time.timeSinceLevelLoad + 92f;
					GIIJKKALBEM((DogState)7);
				}
				else
				{
					timeToSearchToy = Time.timeSinceLevelLoad + 474f;
				}
			}
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == ~Location.FarmShop && ((Object)(object)playerFollowing == (Object)null || playerFollowing.LEOIMFNKFGA == (Location.Tavern | Location.River)))
			{
				if (dogAnimation.FCGBJEIIMBC != 0)
				{
					dogAnimation.NCAJNNHBHJM(Direction.Up);
				}
				dogAnimation.CGELCJDBGNK(DogInteractionType.Bark);
			}
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == ~(Location.Tavern | Location.Camp))
			{
				if ((Object)(object)animationNPCSounds.audioObjects[1] != (Object)(object)Sound.GGFJGHHHEJC.dogStep)
				{
					animationNPCSounds.audioObjects[1] = Sound.MAIDHAPANEB().dogStep;
				}
			}
			else if ((Object)(object)animationNPCSounds.audioObjects[0] != (Object)(object)Sound.DIHCEGINELM().dogStepSoft)
			{
				animationNPCSounds.audioObjects[0] = Sound.BNBMNOMFFBE().dogStepSoft;
			}
		}
		if ((Object)(object)playerFollowing != (Object)null)
		{
			lastPlayerPosition = ((Component)playerFollowing).transform.position;
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(TeleportToInitialPoint));
	}

	private void Update()
	{
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			if (dogAnimation.DogIsDigging() || behaviourState == DogState.Stopped)
			{
				return;
			}
			if ((Object)(object)playerFollowing != (Object)null && TilemapsInfo.ELHHFNFJIAD(playerFollowing.LEOIMFNKFGA) == InteriorType.Exterior && !stopOrder)
			{
				if (IsThePlayerMoving() && behaviourState != 0 && Vector2.Distance(Vector2.op_Implicit(((Component)playerFollowing).transform.position), Vector2.op_Implicit(((Component)this).transform.position)) > 4.5f)
				{
					ChangeState(DogState.FollowPlayer);
				}
				if (Time.timeSinceLevelLoad > timeToSearchForHole)
				{
					DogHoleManager.instance.SearchForHoles(out currentDogHole);
					if ((Object)(object)currentDogHole != (Object)null)
					{
						timeToSearchForHole = Time.timeSinceLevelLoad + 120f;
						ChangeState(DogState.FindHole);
					}
					else
					{
						timeToSearchForHole = Time.timeSinceLevelLoad + 5f;
					}
				}
			}
			else if (behaviourState != DogState.Idle)
			{
				ChangeState(DogState.Idle);
			}
			if (Time.timeSinceLevelLoad > timeToSearchToy && behaviourState != DogState.FindHole)
			{
				if (PetToy.IsAnyToyInDistance(Vector2.op_Implicit(((Component)this).transform.position), 5f))
				{
					timeToSearchToy = Time.timeSinceLevelLoad + 300f;
					ChangeState(DogState.Toy);
				}
				else
				{
					timeToSearchToy = Time.timeSinceLevelLoad + 5f;
				}
			}
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.PetShop && ((Object)(object)playerFollowing == (Object)null || playerFollowing.LEOIMFNKFGA == Location.PetShop))
			{
				if (dogAnimation.FCGBJEIIMBC != Direction.Down)
				{
					dogAnimation.FCGBJEIIMBC = Direction.Down;
				}
				dogAnimation.DogAnimations(DogInteractionType.Friendly);
			}
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == Location.City)
			{
				if ((Object)(object)animationNPCSounds.audioObjects[1] != (Object)(object)Sound.GGFJGHHHEJC.dogStep)
				{
					animationNPCSounds.audioObjects[1] = Sound.GGFJGHHHEJC.dogStep;
				}
			}
			else if ((Object)(object)animationNPCSounds.audioObjects[1] != (Object)(object)Sound.GGFJGHHHEJC.dogStepSoft)
			{
				animationNPCSounds.audioObjects[1] = Sound.GGFJGHHHEJC.dogStepSoft;
			}
		}
		if ((Object)(object)playerFollowing != (Object)null)
		{
			lastPlayerPosition = ((Component)playerFollowing).transform.position;
		}
	}

	public void HDACGDLCPFC(PlayerController NLCDDFDGACP, bool CDPAMNIPPEC)
	{
		if (!((Object)(object)playerFollowing != (Object)(object)NLCDDFDGACP))
		{
			Unfollow(CDPAMNIPPEC);
		}
	}

	public bool HFKCPOFAKKB(Action NNBPENENIIC, Action PDOBHPLPKHG, ref DogInteractionType FPJOAOFIHEO)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, 7) == 0 && PetBowl.COKKAMDCKDD(((Component)this).transform))
		{
			currentDogBowl = PetBowl.PHEDIGAHNAK(((Component)this).transform);
			if ((Object)(object)currentDogBowl != (Object)null)
			{
				if (Random.Range(0, 7) == 0 && currentDogBowl.withFood && currentDogBowl.IsAnyPositionAvailable(BNPDMNCBJHL: true, GDCLFLFLFBM: true))
				{
					FPJOAOFIHEO = DogInteractionType.Aggressive;
					IIAGOMMJLML(currentDogBowl.PNLPJNDHOFH(Vector2.op_Implicit(((Component)this).transform.position), BNPDMNCBJHL: true, GDCLFLFLFBM: false), NNBPENENIIC, PDOBHPLPKHG, 1288f, MFCMOOKEHMN: true);
					return false;
				}
				if (currentDogBowl.withWater && currentDogBowl.HILFJDLABEE(BNPDMNCBJHL: false, GDCLFLFLFBM: true))
				{
					FPJOAOFIHEO = DogInteractionType.Sleep;
					PMCPFPBLGFE(currentDogBowl.GetNearPosition(Vector2.op_Implicit(((Component)this).transform.position), BNPDMNCBJHL: true, GDCLFLFLFBM: true), NNBPENENIIC, PDOBHPLPKHG, 556f, MFCMOOKEHMN: true);
					return false;
				}
			}
		}
		return true;
	}

	public bool PGLHDOHLPJM(int JIIGOACEIKL)
	{
		if (DogUI.PNCKAKBBKJL(JIIGOACEIKL).BGLJFMHCFJF())
		{
			DogUI.AEJKCONFPHB(JIIGOACEIKL).BOBCIFEDJED();
		}
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(onlineDog);
		}
		return true;
	}

	public void KKIJHAOIAHL(PlayerController PKCHNBPBHFL, bool CDPAMNIPPEC)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		playerFollowing = PKCHNBPBHFL;
		lastPlayerPosition = ((Component)playerFollowing).transform.position;
		stopOrder = true;
		if (OnlineManager.MasterOrOffline())
		{
			CHFKPKDBIJL(DogState.IdleNearPlayer);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.IIICJJHHBGJ();
		}
	}

	public void HNOFLLABDEF(int JIIGOACEIKL)
	{
	}

	private void Start()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		timeToSearchToy = Time.timeSinceLevelLoad + 60f;
		AADMIOHCEEB = ((Component)this).transform.position;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PetBowl.UnfillOnPlayerAwakeDogBowl));
	}

	public bool BKPEBOBAIJI(int JIIGOACEIKL)
	{
		if (ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL).GetSelectedItem() is Hoe)
		{
			return true;
		}
		if (ActionBarInventory.BNMEANGDMIP(JIIGOACEIKL).JDAFPKOHJPC() is Spade)
		{
			return false;
		}
		if (ActionBarInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem() is Rod)
		{
			return false;
		}
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).KNFEPKBIHND();
	}

	public void FJCOMGJDAGP(PlayerController NLCDDFDGACP, bool CDPAMNIPPEC)
	{
		if (!((Object)(object)playerFollowing != (Object)(object)NLCDDFDGACP))
		{
			Unfollow(CDPAMNIPPEC);
		}
	}

	public bool IFBJHCHDHCI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KFKPIHAJIFJ(JIIGOACEIKL))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (Time.timeSinceLevelLoad >= LHGHCPEAABC)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("ReceivePipePuzzleSolved"));
			}
			if ((Object)(object)playerFollowing == (Object)null || playerFollowing.LEOIMFNKFGA != ~(Location.Road | Location.BarnInterior))
			{
				if (stopOrder || (Object)(object)playerFollowing != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL))
				{
					ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Items/item_name_596"));
				}
				else
				{
					ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Access"));
				}
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("itemFirePlace"));
			return false;
		}
		return false;
	}

	public void GNCLBACINCA(DogState PPBDOGCNEAH)
	{
		behaviourState = PPBDOGCNEAH;
		behaviour.SetTrigger(behaviourState.ToString());
	}

	public bool CAMIICALHCP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void AOHDOMAKLFI(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		if (Time.timeSinceLevelLoad >= LHGHCPEAABC)
		{
			LHGHCPEAABC = Time.timeSinceLevelLoad + 1992f;
			dogRelationship.HLLDMKHMHPL();
			dogAnimation.LoveEmote();
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.SendPet();
			}
		}
	}

	public void JINJODIENIN(DogState PPBDOGCNEAH)
	{
		behaviourState = PPBDOGCNEAH;
		behaviour.SetTrigger(behaviourState.ToString());
	}

	public bool KOLGJHCLPNE(int JIIGOACEIKL)
	{
		if (ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC() is Hoe)
		{
			return true;
		}
		if (ActionBarInventory.DACNEICGAAE(JIIGOACEIKL, LAGHIOKLJGH: true).GetSelectedItem() is Spade)
		{
			return false;
		}
		if (ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).FGGKCJDFNEK() is Rod)
		{
			return true;
		}
		return DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void PCJAEMFLGOC(int JIIGOACEIKL)
	{
		SelectObject.GetPlayer(JIIGOACEIKL).SelectGameObject((MonoBehaviour)(object)this);
		DogUI.Get(JIIGOACEIKL).OpenUI();
	}

	public void BAHNOBMFFLL(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		Follow(PlayerController.OPHDCMJLLEC(JIIGOACEIKL), CDPAMNIPPEC);
	}

	public void CHFKPKDBIJL(DogState PPBDOGCNEAH)
	{
		behaviourState = PPBDOGCNEAH;
		behaviour.SetTrigger(behaviourState.ToString());
	}

	private static IEnumerator FGFKNPEEECE(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		InstantiateDog(IHNEJFGAENM, DKEDKLAJEBJ, EENNAOMJDLO, GDNLNDKBLJJ, Vector2.op_Implicit(HAIPIEMDGFD));
	}

	public bool JAOBDGJMCFH(int JIIGOACEIKL)
	{
		return false;
	}

	public void Follow(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		Follow(PlayerController.GetPlayer(JIIGOACEIKL), CDPAMNIPPEC);
	}

	public bool AGBPAGIILDG(int JIIGOACEIKL)
	{
		if (KOLGJHCLPNE(JIIGOACEIKL))
		{
			PJEGBNAHOGK(JIIGOACEIKL, CDPAMNIPPEC: false);
			return true;
		}
		return true;
	}

	public void Follow(PlayerController PKCHNBPBHFL, bool CDPAMNIPPEC)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		playerFollowing = PKCHNBPBHFL;
		lastPlayerPosition = ((Component)playerFollowing).transform.position;
		stopOrder = false;
		if (OnlineManager.MasterOrOffline())
		{
			ChangeState(DogState.IdleNearPlayer);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.SendFollow();
		}
	}

	public bool BAGPKDFCDPN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void AMIAGLLJELM()
	{
		((Component)this).transform.parent = null;
	}

	public void PMCPFPBLGFE(Vector2 LAFNLCMIHHL, Action NNBPENENIIC, Action PDOBHPLPKHG, float BHJFNFPIILG, bool MFCMOOKEHMN)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		walkTo.speed = speed;
		walkTo.run = true;
		walkTo.followPlayerDistance = BHJFNFPIILG;
		walkTo.runningSpeed = runSpeed;
		walkTo.KBEENHPEOAB(LAFNLCMIHHL, MFCMOOKEHMN);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, PDOBHPLPKHG);
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, NNBPENENIIC);
		walkTo.EHDKLBLKBEO();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
			if (Time.timeSinceLevelLoad >= LHGHCPEAABC)
			{
				ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Pet"));
			}
			if ((Object)(object)playerFollowing == (Object)null || playerFollowing.LEOIMFNKFGA != Location.PetShop)
			{
				if (stopOrder || (Object)(object)playerFollowing != (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL))
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("FollowMe"));
				}
				else
				{
					ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Stay"));
				}
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Information"));
			return true;
		}
		return false;
	}

	public bool IFMMLFLIJJK(int JIIGOACEIKL)
	{
		if (ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC() is Hoe)
		{
			return false;
		}
		if (ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem() is Spade)
		{
			return false;
		}
		if (ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetSelectedItem() is Rod)
		{
			return true;
		}
		return DecorationMode.KKJABELKCNM(JIIGOACEIKL).IDPGEBNGDJD();
	}

	private static IEnumerator OHCBCIODBIN(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		InstantiateDog(IHNEJFGAENM, DKEDKLAJEBJ, EENNAOMJDLO, GDNLNDKBLJJ, Vector2.op_Implicit(HAIPIEMDGFD));
	}

	private void OHGABHEDILE()
	{
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (dogAnimation.PMJAACAJDJG() || behaviourState == (DogState)6)
			{
				return;
			}
			if ((Object)(object)playerFollowing != (Object)null && TilemapsInfo.IFPHABDILKD(playerFollowing.LEOIMFNKFGA) == InteriorType.Exterior && !stopOrder)
			{
				if (IsThePlayerMoving() && behaviourState != 0 && Vector2.Distance(Vector2.op_Implicit(((Component)playerFollowing).transform.position), Vector2.op_Implicit(((Component)this).transform.position)) > 609f)
				{
					ChangeState(DogState.FollowPlayer);
				}
				if (Time.timeSinceLevelLoad > timeToSearchForHole)
				{
					DogHoleManager.instance.MNLMHKJMAHP(out currentDogHole);
					if ((Object)(object)currentDogHole != (Object)null)
					{
						timeToSearchForHole = Time.timeSinceLevelLoad + 927f;
						CHFKPKDBIJL(DogState.FindHole);
					}
					else
					{
						timeToSearchForHole = Time.timeSinceLevelLoad + 143f;
					}
				}
			}
			else if (behaviourState != DogState.FindHole)
			{
				IHMEOKNMHIJ(DogState.IdleNearPlayer);
			}
			if (Time.timeSinceLevelLoad > timeToSearchToy && behaviourState != DogState.Idle)
			{
				if (PetToy.JBNBIHJPHII(Vector2.op_Implicit(((Component)this).transform.position), 767f))
				{
					timeToSearchToy = Time.timeSinceLevelLoad + 109f;
					ChangeState(DogState.Idle);
				}
				else
				{
					timeToSearchToy = Time.timeSinceLevelLoad + 194f;
				}
			}
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == ~(Location.Tavern | Location.Quarry | Location.Farm | Location.BarnInterior) && ((Object)(object)playerFollowing == (Object)null || playerFollowing.LEOIMFNKFGA == ~(Location.River | Location.Camp | Location.Farm)))
			{
				if (dogAnimation.FCGBJEIIMBC != Direction.Down)
				{
					dogAnimation.FCGBJEIIMBC = Direction.Down;
				}
				dogAnimation.CGELCJDBGNK(DogInteractionType.Toy, CDPAMNIPPEC: false);
			}
			if (WorldGrid.HJPCBBGHPDA(((Component)this).transform.position) == ~(Location.Tavern | Location.Camp | Location.Quarry | Location.FarmShop))
			{
				if ((Object)(object)animationNPCSounds.audioObjects[1] != (Object)(object)Sound.MAIDHAPANEB().dogStep)
				{
					animationNPCSounds.audioObjects[0] = Sound.GGFJGHHHEJC.dogStep;
				}
			}
			else if ((Object)(object)animationNPCSounds.audioObjects[0] != (Object)(object)Sound.OKAPNFPFPFP().dogStepSoft)
			{
				animationNPCSounds.audioObjects[0] = Sound.BNBMNOMFFBE().dogStepSoft;
			}
		}
		if ((Object)(object)playerFollowing != (Object)null)
		{
			lastPlayerPosition = ((Component)playerFollowing).transform.position;
		}
	}

	public IEnumerator KAPBLFHIDKF()
	{
		yield return null;
		yield return null;
		if ((Object)(object)dogInteractable != (Object)null)
		{
			dogAnimation.FCGBJEIIMBC = dogInteractable.lookDirection;
			yield break;
		}
		if ((Object)(object)currentDogBowl != (Object)null)
		{
			if (currentDogBowl.placeable.direction == Direction.Up || currentDogBowl.placeable.direction == Direction.Down)
			{
				if (((Component)currentDogBowl).transform.position.x > ((Component)this).transform.position.x)
				{
					dogAnimation.FCGBJEIIMBC = Direction.Right;
				}
				else
				{
					dogAnimation.FCGBJEIIMBC = Direction.Left;
				}
			}
			else if (((Component)currentDogBowl).transform.position.y > ((Component)this).transform.position.y)
			{
				dogAnimation.FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				dogAnimation.FCGBJEIIMBC = Direction.Down;
			}
			yield break;
		}
		for (int i = 1; i <= 2; i++)
		{
			if (!WorldGrid.APKPGNDDJHC(((Component)this).transform.position + Utils.NGFODNCHPHB(dogAnimation.FCGBJEIIMBC) * 0.25f * (float)i))
			{
				dogAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(dogAnimation.FCGBJEIIMBC);
				break;
			}
		}
	}

	public bool GEPMJKMFLAH(int JIIGOACEIKL)
	{
		return true;
	}

	public bool KECABGFHKPK()
	{
		if (dogBreed != 0 && dogBreed != DogBreed.BorderCollie)
		{
			return dogBreed == DogBreed.Shepard;
		}
		return true;
	}

	public void IHMEOKNMHIJ(DogState PPBDOGCNEAH)
	{
		behaviourState = PPBDOGCNEAH;
		behaviour.SetTrigger(behaviourState.ToString());
	}

	public void MCBCBFIMLJD()
	{
		((Component)this).transform.parent = null;
	}

	public bool CANOIJPJMBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool OACGLOIMNGP()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)playerFollowing != (Object)null && ((Component)playerFollowing).transform.position != lastPlayerPosition)
		{
			return true;
		}
		return true;
	}

	public bool PEBMANKLJNN(int JIIGOACEIKL)
	{
		if (ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).JDAFPKOHJPC() is Hoe)
		{
			return false;
		}
		if (ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL).JDAFPKOHJPC() is Spade)
		{
			return true;
		}
		if (ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL, LAGHIOKLJGH: true).FGGKCJDFNEK() is Rod)
		{
			return true;
		}
		return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).KNFEPKBIHND();
	}

	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(TeleportToInitialPoint));
			CommonReferences commonReferences2 = CommonReferences.GGFJGHHHEJC;
			commonReferences2.OnPlayerAwake = (Action)Delegate.Remove(commonReferences2.OnPlayerAwake, new Action(PetBowl.UnfillOnPlayerAwakeDogBowl));
		}
	}

	private void CBHFGGAMOOE(int JIIGOACEIKL)
	{
		SelectObject.GetPlayer(JIIGOACEIKL).IPINANKCIDJ((MonoBehaviour)(object)this);
		DogUI.AEJKCONFPHB(JIIGOACEIKL).OpenUI();
	}

	public void JGNENDCKJAC(int JIIGOACEIKL)
	{
	}

	private void GBFPCABGAII()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		timeToSearchToy = Time.timeSinceLevelLoad + 317f;
		AADMIOHCEEB = ((Component)this).transform.position;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PetBowl.UnfillOnPlayerAwakeDogBowl));
	}

	public IEnumerator OOJJHGOGMGM()
	{
		yield return null;
		yield return null;
		if ((Object)(object)dogInteractable != (Object)null)
		{
			dogAnimation.FCGBJEIIMBC = dogInteractable.lookDirection;
			yield break;
		}
		if ((Object)(object)currentDogBowl != (Object)null)
		{
			if (currentDogBowl.placeable.direction == Direction.Up || currentDogBowl.placeable.direction == Direction.Down)
			{
				if (((Component)currentDogBowl).transform.position.x > ((Component)this).transform.position.x)
				{
					dogAnimation.FCGBJEIIMBC = Direction.Right;
				}
				else
				{
					dogAnimation.FCGBJEIIMBC = Direction.Left;
				}
			}
			else if (((Component)currentDogBowl).transform.position.y > ((Component)this).transform.position.y)
			{
				dogAnimation.FCGBJEIIMBC = Direction.Up;
			}
			else
			{
				dogAnimation.FCGBJEIIMBC = Direction.Down;
			}
			yield break;
		}
		for (int i = 1; i <= 2; i++)
		{
			if (!WorldGrid.APKPGNDDJHC(((Component)this).transform.position + Utils.NGFODNCHPHB(dogAnimation.FCGBJEIIMBC) * 0.25f * (float)i))
			{
				dogAnimation.FCGBJEIIMBC = Utils.ABNPPDOGEPM(dogAnimation.FCGBJEIIMBC);
				break;
			}
		}
	}

	public void MLIKLKIDMBM(bool CDPAMNIPPEC)
	{
		if (!((Object)(object)playerFollowing != (Object)null) || playerFollowing.LEOIMFNKFGA != (Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			stopOrder = true;
			if (OnlineManager.MasterOrOffline())
			{
				ChangeState(DogState.FollowPlayer);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.MLOHKGDEKLF();
			}
		}
	}

	public static void InstantiateDog(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ, Vector2 IMOBLFMHKOD, bool GFNHAMCPEAK = true, bool CDPAMNIPPEC = true)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.GetDogPrefab((DogBreed)DKEDKLAJEBJ), Vector2.op_Implicit(IMOBLFMHKOD), Quaternion.identity);
		instance.dogRelationship.SetRelationship(IHNEJFGAENM);
		instance.dogName = EENNAOMJDLO;
		instance.birthday = GDNLNDKBLJJ;
		instance.dogBreed = (DogBreed)DKEDKLAJEBJ;
		if (GFNHAMCPEAK)
		{
			instance.Follow(1, CDPAMNIPPEC);
		}
	}

	public bool IsThePlayerMoving()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)playerFollowing != (Object)null && ((Component)playerFollowing).transform.position != lastPlayerPosition)
		{
			return true;
		}
		return false;
	}

	public void GIIJKKALBEM(DogState PPBDOGCNEAH)
	{
		behaviourState = PPBDOGCNEAH;
		behaviour.SetTrigger(behaviourState.ToString());
	}

	private void DEFIFMAOPCM()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() && (Object)(object)dogCurrentState != (Object)null)
		{
			dogCurrentState.HLLKOEPGGIL();
		}
		if (OnlineManager.IsMasterClient() && Object.op_Implicit((Object)(object)onlineDog) && AADMIOHCEEB != ((Component)this).transform.position)
		{
			onlineDog.MELNFFGJECB();
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}

	public void ICGGFMEPNON(PlayerController NLCDDFDGACP, bool CDPAMNIPPEC)
	{
		if (!((Object)(object)playerFollowing != (Object)(object)NLCDDFDGACP))
		{
			DAEGAKJKNEM(CDPAMNIPPEC);
		}
	}

	public bool GHPMOPMMLJI(int JIIGOACEIKL)
	{
		if (PEBMANKLJNN(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.GMJPOKECENH(onlineDog.uniqueId);
				return true;
			}
			HJMCKLGGHBM(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public void BKAGIMELGOD(int JIIGOACEIKL)
	{
	}

	public void DAEGAKJKNEM(bool CDPAMNIPPEC)
	{
		if (!((Object)(object)playerFollowing != (Object)null) || playerFollowing.LEOIMFNKFGA != (Location.Tavern | Location.Quarry | Location.Farm))
		{
			stopOrder = true;
			if (OnlineManager.MasterOrOffline())
			{
				JINJODIENIN((DogState)8);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.SendUnfollow();
			}
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Hoe)
		{
			return false;
		}
		if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Spade)
		{
			return false;
		}
		if (ActionBarInventory.GetPlayer(JIIGOACEIKL).GetSelectedItem() is Rod)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void NCIBKMLIIAJ()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		timeToSearchToy = Time.timeSinceLevelLoad + 1441f;
		AADMIOHCEEB = ((Component)this).transform.position;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PetBowl.OKBFFBNMILN));
	}

	public bool ODMLNAMALJE(int JIIGOACEIKL)
	{
		if (BKPEBOBAIJI(JIIGOACEIKL))
		{
			AOHDOMAKLFI(JIIGOACEIKL, CDPAMNIPPEC: false);
			return true;
		}
		return false;
	}

	public void DGPCNLBJIKK(int JIIGOACEIKL)
	{
	}

	private void HJMCKLGGHBM(int JIIGOACEIKL)
	{
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).IPINANKCIDJ((MonoBehaviour)(object)this);
		DogUI.DPBGKDNKDGM(JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void HKKBNKNBHPJ(PlayerController PKCHNBPBHFL, bool CDPAMNIPPEC)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		playerFollowing = PKCHNBPBHFL;
		lastPlayerPosition = ((Component)playerFollowing).transform.position;
		stopOrder = false;
		if (OnlineManager.PGAGDFAEEFB())
		{
			CHFKPKDBIJL(DogState.FollowPlayer);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			onlineDog.IIICJJHHBGJ();
		}
	}

	public void GHAHHGPDNNH(int JIIGOACEIKL)
	{
	}

	private void FixedUpdate()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline() && (Object)(object)dogCurrentState != (Object)null)
		{
			dogCurrentState.HMLMFDKLCCM();
		}
		if (OnlineManager.IsMasterClient() && Object.op_Implicit((Object)(object)onlineDog) && AADMIOHCEEB != ((Component)this).transform.position)
		{
			onlineDog.UpdateDogPosition();
			AADMIOHCEEB = ((Component)this).transform.position;
		}
	}

	public static void OIBHOMBGDJB(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ, Vector2 IMOBLFMHKOD, bool GFNHAMCPEAK = true, bool CDPAMNIPPEC = true)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.GetDogPrefab((DogBreed)DKEDKLAJEBJ), Vector2.op_Implicit(IMOBLFMHKOD), Quaternion.identity);
		instance.dogRelationship.GHFAHKPKKDO(IHNEJFGAENM);
		instance.dogName = EENNAOMJDLO;
		instance.birthday = GDNLNDKBLJJ;
		instance.dogBreed = (DogBreed)DKEDKLAJEBJ;
		if (GFNHAMCPEAK)
		{
			instance.Follow(0, CDPAMNIPPEC);
		}
	}

	public bool FDIKILPBDPI(int JIIGOACEIKL)
	{
		if (DogUI.DPBGKDNKDGM(JIIGOACEIKL).HDEPMJIDJEM())
		{
			DogUI.COIEMAJLHAM(JIIGOACEIKL).CloseUI();
		}
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(onlineDog);
		}
		return false;
	}

	public void KMCCDIHFDFK(int JIIGOACEIKL, bool CDPAMNIPPEC)
	{
		Follow(PlayerController.OPHDCMJLLEC(JIIGOACEIKL), CDPAMNIPPEC);
	}

	public void IIAGOMMJLML(Vector2 LAFNLCMIHHL, Action NNBPENENIIC, Action PDOBHPLPKHG, float BHJFNFPIILG, bool MFCMOOKEHMN)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		walkTo.speed = speed;
		walkTo.run = false;
		walkTo.followPlayerDistance = BHJFNFPIILG;
		walkTo.runningSpeed = runSpeed;
		walkTo.OGLJDLEGJAA(LAFNLCMIHHL, !MFCMOOKEHMN);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, PDOBHPLPKHG);
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, NNBPENENIIC);
		walkTo.EHDKLBLKBEO();
	}

	public bool CDDJCCMHHPE(int JIIGOACEIKL)
	{
		return true;
	}

	public void OONFAEHPEFI(int JIIGOACEIKL)
	{
		if (PlayerInputs.GetPlayer(JIIGOACEIKL).KFAFNEJNDDL("NetworkSync "))
		{
			if (stopOrder || (Object)(object)playerFollowing != (Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL))
			{
				HDGJJMIDFNO(JIIGOACEIKL, CDPAMNIPPEC: false);
			}
			else
			{
				DAEGAKJKNEM(CDPAMNIPPEC: false);
			}
		}
	}

	public void CHJOPGFLEGM()
	{
		((Component)this).transform.parent = null;
	}

	public bool HHDFHHDOFBL(int JIIGOACEIKL)
	{
		if (IFMMLFLIJJK(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.GMJPOKECENH(onlineDog.uniqueId);
				return true;
			}
			CBHFGGAMOOE(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public void StartWalking(Vector2 LAFNLCMIHHL, Action NNBPENENIIC, Action PDOBHPLPKHG, float BHJFNFPIILG, bool MFCMOOKEHMN)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		walkTo.speed = speed;
		walkTo.run = true;
		walkTo.followPlayerDistance = BHJFNFPIILG;
		walkTo.runningSpeed = runSpeed;
		walkTo.FNNPPBDFBCI(LAFNLCMIHHL, !MFCMOOKEHMN);
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, PDOBHPLPKHG);
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, NNBPENENIIC);
		walkTo.PEHELKCIECB();
	}

	public bool AFAKDGJEKFG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void GMEJJINEKIN(bool CDPAMNIPPEC)
	{
		if (!((Object)(object)playerFollowing != (Object)null) || playerFollowing.LEOIMFNKFGA != ~(Location.Camp | Location.Farm | Location.BarnInterior))
		{
			stopOrder = true;
			if (OnlineManager.PGAGDFAEEFB())
			{
				GIIJKKALBEM((DogState)8);
			}
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				onlineDog.SendUnfollow();
			}
		}
	}

	public bool KFKPIHAJIFJ(int JIIGOACEIKL)
	{
		if (ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL).FGGKCJDFNEK() is Hoe)
		{
			return false;
		}
		if (ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true).JDAFPKOHJPC() is Spade)
		{
			return false;
		}
		if (ActionBarInventory.IFGBDFBGAED(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JDAFPKOHJPC() is Rod)
		{
			return false;
		}
		return DecorationMode.GetPlayer(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool AGCOFLAJHMN()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)playerFollowing != (Object)null && ((Component)playerFollowing).transform.position != lastPlayerPosition)
		{
			return false;
		}
		return true;
	}

	public IEnumerator FLEMLDJBGJP()
	{
		return new OELJIGGOBOJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HKIEDFHDAJD()
	{
		((Component)this).transform.parent = null;
	}

	public bool HEBIALAMFPC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CheckIfItNeedsToEatOrDrink(Action NNBPENENIIC, Action PDOBHPLPKHG, ref DogInteractionType FPJOAOFIHEO)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		if (Random.Range(0, 5) == 0 && PetBowl.IsThereAPetBowlNear(((Component)this).transform))
		{
			currentDogBowl = PetBowl.FindTheNearestPetBowl(((Component)this).transform);
			if ((Object)(object)currentDogBowl != (Object)null)
			{
				if (Random.Range(0, 2) == 0 && currentDogBowl.withFood && currentDogBowl.IsAnyPositionAvailable(BNPDMNCBJHL: false, GDCLFLFLFBM: false))
				{
					FPJOAOFIHEO = DogInteractionType.Eat;
					StartWalking(currentDogBowl.GetNearPosition(Vector2.op_Implicit(((Component)this).transform.position), BNPDMNCBJHL: false, GDCLFLFLFBM: false), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: true);
					return true;
				}
				if (currentDogBowl.withWater && currentDogBowl.IsAnyPositionAvailable(BNPDMNCBJHL: true, GDCLFLFLFBM: false))
				{
					FPJOAOFIHEO = DogInteractionType.Drink;
					StartWalking(currentDogBowl.GetNearPosition(Vector2.op_Implicit(((Component)this).transform.position), BNPDMNCBJHL: true, GDCLFLFLFBM: false), NNBPENENIIC, PDOBHPLPKHG, 0f, MFCMOOKEHMN: true);
					return true;
				}
			}
		}
		return false;
	}

	public bool NAFEELIOEBK(int JIIGOACEIKL)
	{
		if (DogUI.Get(JIIGOACEIKL).IsOpen())
		{
			DogUI.MIAOGLENOHL(JIIGOACEIKL).CloseUI();
		}
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(onlineDog);
		}
		return false;
	}

	public void Unfollow(PlayerController NLCDDFDGACP, bool CDPAMNIPPEC)
	{
		if (!((Object)(object)playerFollowing != (Object)(object)NLCDDFDGACP))
		{
			Unfollow(CDPAMNIPPEC);
		}
	}

	public static void IAANGAMHAFC(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(ANFPLGJMDCA(IHNEJFGAENM, DKEDKLAJEBJ, EENNAOMJDLO, GDNLNDKBLJJ));
	}

	public void ChangeState(DogState PPBDOGCNEAH)
	{
		behaviourState = PPBDOGCNEAH;
		behaviour.SetTrigger(behaviourState.ToString());
	}

	public bool IsASmallDog()
	{
		if (dogBreed != 0 && dogBreed != DogBreed.BorderCollie)
		{
			return dogBreed == DogBreed.Shiba;
		}
		return true;
	}

	public bool KGEDLMDOIAH(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void AACKHOBBDNG(PlayerController NLCDDFDGACP, bool CDPAMNIPPEC)
	{
		if (!((Object)(object)playerFollowing != (Object)(object)NLCDDFDGACP))
		{
			GMEJJINEKIN(CDPAMNIPPEC);
		}
	}

	public void PLKFEPAHAEK(int JIIGOACEIKL)
	{
	}

	public void POEJLKMJDPF(int JIIGOACEIKL)
	{
	}

	private static IEnumerator FLKKDDIFAHD(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ)
	{
		yield return null;
		InstantiateDog(IHNEJFGAENM, DKEDKLAJEBJ, EENNAOMJDLO, GDNLNDKBLJJ, Vector2.op_Implicit(HAIPIEMDGFD));
	}

	private static IEnumerator NJALIDABMNM(int IHNEJFGAENM, int DKEDKLAJEBJ, string EENNAOMJDLO, GameDate GDNLNDKBLJJ)
	{
		return new BBHBNIFKCHC(1)
		{
			relationship = IHNEJFGAENM,
			dogSelected = DKEDKLAJEBJ,
			dogName = EENNAOMJDLO,
			birthday = GDNLNDKBLJJ
		};
	}
}

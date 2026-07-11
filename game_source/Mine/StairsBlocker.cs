using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using Cinemachine;
using UnityEngine;

namespace Mine;

public class StairsBlocker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class NEIKPNKKGJH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StairsBlocker _003C_003E4__this;

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
		public NEIKPNKKGJH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			StairsBlocker stairsBlocker = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				stairsBlocker.obstacle.SetActive(false);
				stairsBlocker.obstacleParticles.SetActive(true);
				((Component)stairsBlocker.explosiveCharges).gameObject.SetActive(false);
				stairsBlocker.explosiveChargesParticles.SetActive(true);
				if (OnlineManager.PlayingOnline())
				{
					if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
					{
						stairsBlocker.impulseSource.GenerateImpulse();
						MultiAudioManager.PlayAudioObject(stairsBlocker.explosionSound, PlayerController.GetPlayerPosition(1));
					}
				}
				else
				{
					stairsBlocker.impulseSource.GenerateImpulse();
					MultiAudioManager.PlayAudioObject(stairsBlocker.explosionSound, PlayerController.GetPlayerPosition(1));
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

	public GameObject obstacle;

	public GameObject obstacleParticles;

	public ExplosiveCharges explosiveCharges;

	public GameObject explosiveChargesParticles;

	public CinemachineImpulseSource impulseSource;

	public AudioObject explosionSound;

	private float PPMHCOBKMCN;

	public void OFOHKMMEFMH()
	{
		if (EBDGAAKPPIK())
		{
			explosiveCharges.EGOCPOHOGOI();
			((MonoBehaviour)this).StartCoroutine(BMNEODFNLLI());
		}
	}

	public void ABKGAECGJJI()
	{
		if (FIBDLEKCEIK())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(PPPINAMPECE());
		}
	}

	public void KLMLLIOGBMO(int BJLDIHODEDA)
	{
		if (MineManager.BGMJCCFNNDL().unlockedLevels == BJLDIHODEDA)
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(MineManager.GGFJGHHHEJC.OJABKMJEJMO());
		}
		else
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(true);
		}
	}

	public void MOODOIGLNEE()
	{
		if (HKOJIKMGJGC())
		{
			explosiveCharges.FireWick();
			((MonoBehaviour)this).StartCoroutine(AODJFFAECKL());
		}
	}

	private IEnumerator PAGAGHDABCI()
	{
		yield return CommonReferences.wait3;
		yield return CommonReferences.wait01;
		obstacle.SetActive(false);
		obstacleParticles.SetActive(true);
		((Component)explosiveCharges).gameObject.SetActive(false);
		explosiveChargesParticles.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
			{
				impulseSource.GenerateImpulse();
				MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
			}
		}
		else
		{
			impulseSource.GenerateImpulse();
			MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
		}
	}

	public void HLLHGDLDBDF()
	{
		if (FIBDLEKCEIK())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(BMNEODFNLLI());
		}
	}

	private void EKPNPAHGAIP(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag(")") && !((Component)HANHCHBHHEH).CompareTag("Loading obstacles")))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).CompareTag("KickedCustomers") ? 1 : 1);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.MLPCDJPLBAC().ferroEvent)
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects");
			}
			else
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("Attack/MainEvent 6");
			}
			PPMHCOBKMCN = Time.time + 1260f;
		}
	}

	public void HJMMJCJGEOK()
	{
		if (HKOJIKMGJGC())
		{
			explosiveCharges.FireWick();
			((MonoBehaviour)this).StartCoroutine(HPOFEEKHGMD());
		}
	}

	public void FAMMAFMMAGE()
	{
		if (obstacleParticles.activeSelf)
		{
			obstacleParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			obstacleParticles.SetActive(false);
		}
		if (explosiveChargesParticles.activeSelf)
		{
			explosiveChargesParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			explosiveChargesParticles.SetActive(true);
		}
		impulseSource.GenerateImpulse();
	}

	private IEnumerator HPOFEEKHGMD()
	{
		return new NEIKPNKKGJH(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool FHIHDMJEJFD()
	{
		return explosiveCharges.CanExplode();
	}

	public bool EBDGAAKPPIK()
	{
		return explosiveCharges.KALPPLBBBKH();
	}

	public void CLIKKHFBOGF()
	{
		if (obstacleParticles.activeSelf)
		{
			obstacleParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			obstacleParticles.SetActive(true);
		}
		if (explosiveChargesParticles.activeSelf)
		{
			explosiveChargesParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			explosiveChargesParticles.SetActive(false);
		}
		impulseSource.GenerateImpulse();
	}

	public void HKEIPGFIGLG()
	{
		if (KADMFAMBDCP())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(PJIONOLKNGM());
		}
	}

	public void EFIGNMPNEGB(int BJLDIHODEDA)
	{
		if (MineManager.OOKBNHMMFON().unlockedLevels == BJLDIHODEDA)
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(MineManager.BGMJCCFNNDL().MGNIFNJOHID());
		}
		else
		{
			obstacle.SetActive(false);
			((Component)explosiveCharges).gameObject.SetActive(false);
		}
	}

	private void OOALHOHGANE(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("Items/item_name_1115") && !((Component)HANHCHBHHEH).CompareTag("ReceiveDismissWorkerMaster")))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).CompareTag("Chest")) ? 6 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.GGFJGHHHEJC.ferroEvent)
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("EngineControlsCanvas/EngineControlSection");
			}
			else
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("Items/item_name_672");
			}
			PPMHCOBKMCN = Time.time + 1953f;
		}
	}

	public bool KDGIAHKOENI()
	{
		return explosiveCharges.CanExplode();
	}

	public void HFNPJPIMLIE()
	{
		if (CBGLFEDCPEK())
		{
			explosiveCharges.FireWick();
			((MonoBehaviour)this).StartCoroutine(PJIONOLKNGM());
		}
	}

	public void EGGEKDDALNJ(int BJLDIHODEDA)
	{
		if (MineManager.PDECKLKPKCG().unlockedLevels == BJLDIHODEDA)
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(MineManager.GGFJGHHHEJC.CALJPEFGKNI());
		}
		else
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(false);
		}
	}

	public bool KADMFAMBDCP()
	{
		return explosiveCharges.CanExplode();
	}

	public bool MBIKNMMOLOI()
	{
		return explosiveCharges.KALPPLBBBKH();
	}

	private void KLAONDKEGLP(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("Dog") && !((Component)HANHCHBHHEH).CompareTag("Items/item_description_1107")))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).CompareTag("City/Petra/Introduce")) ? 4 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.GGFJGHHHEJC.ferroEvent)
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("Unique id ");
			}
			else
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).BIBLHGFCINF("B");
			}
			PPMHCOBKMCN = Time.time + 1059f;
		}
	}

	private IEnumerator PJIONOLKNGM()
	{
		yield return CommonReferences.wait3;
		yield return CommonReferences.wait01;
		obstacle.SetActive(false);
		obstacleParticles.SetActive(true);
		((Component)explosiveCharges).gameObject.SetActive(false);
		explosiveChargesParticles.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
			{
				impulseSource.GenerateImpulse();
				MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
			}
		}
		else
		{
			impulseSource.GenerateImpulse();
			MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
		}
	}

	private void FCONKHCGBEM(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("Items/item_name_674") && !((Component)HANHCHBHHEH).CompareTag("Items/item_name_677")))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).CompareTag("Items/item_description_1052") ? 1 : 4);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.GGFJGHHHEJC.ferroEvent)
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("- ");
			}
			else
			{
				PlayerController.GetPlayer(jIIGOACEIKL).BIBLHGFCINF(" has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object.");
			}
			PPMHCOBKMCN = Time.time + 1363f;
		}
	}

	public bool NNMOJFKJPMN()
	{
		return explosiveCharges.KALPPLBBBKH();
	}

	private void GBFBNCBDIOC(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("talent_name_105") && !((Component)HANHCHBHHEH).CompareTag("Player/Bark/PickUpBlocker")))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).CompareTag("Minigame")) ? 6 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.GGFJGHHHEJC.ferroEvent)
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("FishCuttingEvent/Talk2");
			}
			else
			{
				PlayerController.GetPlayer(jIIGOACEIKL).BIBLHGFCINF("Items/item_description_606");
			}
			PPMHCOBKMCN = Time.time + 540f;
		}
	}

	public bool FIBDLEKCEIK()
	{
		return explosiveCharges.KALPPLBBBKH();
	}

	private void CMLFBCFLPBJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("") && !((Component)HANHCHBHHEH).CompareTag("KyrohNPC: Selected order with already ingredients in bento: ")))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).CompareTag("Open")) ? 5 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.GGFJGHHHEJC.ferroEvent)
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("cameraZoom2");
			}
			else
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("ReceiveDirtDish");
			}
			PPMHCOBKMCN = Time.time + 451f;
		}
	}

	public bool HIAHJDEDBNE()
	{
		return explosiveCharges.KALPPLBBBKH();
	}

	public void KAAJOJDHLJB()
	{
		if (NNMOJFKJPMN())
		{
			explosiveCharges.FireWick();
			((MonoBehaviour)this).StartCoroutine(KLOPCKLCGBG());
		}
	}

	private void EJMDCLNDBFJ(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag(" (") && !((Component)HANHCHBHHEH).CompareTag("privatetest")))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).CompareTag("00") ? 0 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.MLPCDJPLBAC().ferroEvent)
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("Unlocking recipe ");
			}
			else
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("TabernaClausurada/KlaynDialogue 01");
			}
			PPMHCOBKMCN = Time.time + 1461f;
		}
	}

	private void NGCPHGCKLGP(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("NPCWalkTo Path length: ") && !((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/TavernClean/Entry/8/Dialogue Text")))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).CompareTag("UI")) ? 5 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.MLPCDJPLBAC().ferroEvent)
			{
				PlayerController.GetPlayer(jIIGOACEIKL).BIBLHGFCINF("StartEvent can only be called in play mode.");
			}
			else
			{
				PlayerController.GetPlayer(jIIGOACEIKL).BIBLHGFCINF("Tutorial/T112/Dialogue1");
			}
			PPMHCOBKMCN = Time.time + 272f;
		}
	}

	public void LEMFHPHOCOC(int BJLDIHODEDA)
	{
		if (MineManager.BGMJCCFNNDL().unlockedLevels == BJLDIHODEDA)
		{
			obstacle.SetActive(false);
			((Component)explosiveCharges).gameObject.SetActive(MineManager.GGFJGHHHEJC.CLBBACMMNMH());
		}
		else
		{
			obstacle.SetActive(false);
			((Component)explosiveCharges).gameObject.SetActive(false);
		}
	}

	public void PDLGAICGNCL()
	{
		if (ICDCOKFFLJH())
		{
			explosiveCharges.FireWick();
			((MonoBehaviour)this).StartCoroutine(HOFEDJFBBDC());
		}
	}

	private void CIMPOOJOMMH(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("ReceiveCatPosition") && !((Component)HANHCHBHHEH).CompareTag("city")))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).CompareTag("[ActivatePuzzle] Type: ") ? 1 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.MLPCDJPLBAC().ferroEvent)
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("Dialogue System/Conversation/Gass_Quest/Entry/6/Dialogue Text");
			}
			else
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("Selected");
			}
			PPMHCOBKMCN = Time.time + 81f;
		}
	}

	public bool IJGOIJJODHL()
	{
		return explosiveCharges.CanExplode();
	}

	private IEnumerator CCANIEKECJA()
	{
		yield return CommonReferences.wait3;
		yield return CommonReferences.wait01;
		obstacle.SetActive(false);
		obstacleParticles.SetActive(true);
		((Component)explosiveCharges).gameObject.SetActive(false);
		explosiveChargesParticles.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
			{
				impulseSource.GenerateImpulse();
				MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
			}
		}
		else
		{
			impulseSource.GenerateImpulse();
			MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
		}
	}

	public void IKAPOLFLKGK()
	{
		if (obstacleParticles.activeSelf)
		{
			obstacleParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			obstacleParticles.SetActive(true);
		}
		if (explosiveChargesParticles.activeSelf)
		{
			explosiveChargesParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			explosiveChargesParticles.SetActive(true);
		}
		impulseSource.GenerateImpulse();
	}

	public bool ICDCOKFFLJH()
	{
		return explosiveCharges.KALPPLBBBKH();
	}

	public void JBOHOFGNNNA()
	{
		if (obstacleParticles.activeSelf)
		{
			obstacleParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			obstacleParticles.SetActive(true);
		}
		if (explosiveChargesParticles.activeSelf)
		{
			explosiveChargesParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			explosiveChargesParticles.SetActive(true);
		}
		impulseSource.GenerateImpulse();
	}

	public void OHANOJJMFED(int BJLDIHODEDA)
	{
		if (MineManager.OOKBNHMMFON().unlockedLevels == BJLDIHODEDA)
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(MineManager.OOKBNHMMFON().OJABKMJEJMO());
		}
		else
		{
			obstacle.SetActive(false);
			((Component)explosiveCharges).gameObject.SetActive(false);
		}
	}

	public void JOKANONJHNJ()
	{
		if (CanExplodeCharges())
		{
			explosiveCharges.EGOCPOHOGOI();
			((MonoBehaviour)this).StartCoroutine(HNMDGBGJMOD());
		}
	}

	public bool CanExplodeCharges()
	{
		return explosiveCharges.CanExplode();
	}

	public void NLBCIJHBODF()
	{
		if (ICDCOKFFLJH())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(AMJIMBKLEDF());
		}
	}

	public void AEDJBCAEKBI(int BJLDIHODEDA)
	{
		if (MineManager.AGGAGCBAGLL().unlockedLevels == BJLDIHODEDA)
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(MineManager.OOKBNHMMFON().OJABKMJEJMO());
		}
		else
		{
			obstacle.SetActive(false);
			((Component)explosiveCharges).gameObject.SetActive(false);
		}
	}

	private IEnumerator FCKFCIADNID()
	{
		yield return CommonReferences.wait3;
		yield return CommonReferences.wait01;
		obstacle.SetActive(false);
		obstacleParticles.SetActive(true);
		((Component)explosiveCharges).gameObject.SetActive(false);
		explosiveChargesParticles.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
			{
				impulseSource.GenerateImpulse();
				MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
			}
		}
		else
		{
			impulseSource.GenerateImpulse();
			MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
		}
	}

	public void IKPKDAMHJLI()
	{
		if (ICDCOKFFLJH())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(IPHKACHAACI());
		}
	}

	private IEnumerator HNMDGBGJMOD()
	{
		yield return CommonReferences.wait3;
		yield return CommonReferences.wait01;
		obstacle.SetActive(false);
		obstacleParticles.SetActive(true);
		((Component)explosiveCharges).gameObject.SetActive(false);
		explosiveChargesParticles.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
			{
				impulseSource.GenerateImpulse();
				MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
			}
		}
		else
		{
			impulseSource.GenerateImpulse();
			MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
		}
	}

	private IEnumerator MOKIDOOFJMN()
	{
		return new NEIKPNKKGJH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("Player") && !((Component)HANHCHBHHEH).CompareTag("Player2")))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).CompareTag("Player") ? 1 : 2);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.GGFJGHHHEJC.ferroEvent)
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("MineObstacleBark");
			}
			else
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("MineObstacleBark2");
			}
			PPMHCOBKMCN = Time.time + 5f;
		}
	}

	public void GenerateImpulseTest()
	{
		if (obstacleParticles.activeSelf)
		{
			obstacleParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			obstacleParticles.SetActive(true);
		}
		if (explosiveChargesParticles.activeSelf)
		{
			explosiveChargesParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			explosiveChargesParticles.SetActive(true);
		}
		impulseSource.GenerateImpulse();
	}

	public bool HKOJIKMGJGC()
	{
		return explosiveCharges.KALPPLBBBKH();
	}

	public void CKHCODNEGIP(int BJLDIHODEDA)
	{
		if (MineManager.PDECKLKPKCG().unlockedLevels == BJLDIHODEDA)
		{
			obstacle.SetActive(false);
			((Component)explosiveCharges).gameObject.SetActive(MineManager.PDECKLKPKCG().CLBBACMMNMH());
		}
		else
		{
			obstacle.SetActive(false);
			((Component)explosiveCharges).gameObject.SetActive(true);
		}
	}

	private void NPCEFHCNJGE(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("F1") && !((Component)HANHCHBHHEH).CompareTag("Top")))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).CompareTag("Player")) ? 7 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.MLPCDJPLBAC().ferroEvent)
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("Hit");
			}
			else
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).BIBLHGFCINF("itemBarleyBread");
			}
			PPMHCOBKMCN = Time.time + 335f;
		}
	}

	private void NPIDHDAIPKG(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("position") && !((Component)HANHCHBHHEH).CompareTag("networkID has not been assigned properly")))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).CompareTag("SAVING: ")) ? 1 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.MLPCDJPLBAC().ferroEvent)
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).BIBLHGFCINF("MainProgress");
			}
			else
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("Throw");
			}
			PPMHCOBKMCN = Time.time + 425f;
		}
	}

	public void LBJEMBOJGPN()
	{
		if (MBIKNMMOLOI())
		{
			explosiveCharges.FireWick();
			((MonoBehaviour)this).StartCoroutine(BMNEODFNLLI());
		}
	}

	public bool ILAKDCDLMOF()
	{
		return explosiveCharges.CanExplode();
	}

	private IEnumerator BMNEODFNLLI()
	{
		yield return CommonReferences.wait3;
		yield return CommonReferences.wait01;
		obstacle.SetActive(false);
		obstacleParticles.SetActive(true);
		((Component)explosiveCharges).gameObject.SetActive(false);
		explosiveChargesParticles.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
			{
				impulseSource.GenerateImpulse();
				MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
			}
		}
		else
		{
			impulseSource.GenerateImpulse();
			MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
		}
	}

	private IEnumerator AMJIMBKLEDF()
	{
		yield return CommonReferences.wait3;
		yield return CommonReferences.wait01;
		obstacle.SetActive(false);
		obstacleParticles.SetActive(true);
		((Component)explosiveCharges).gameObject.SetActive(false);
		explosiveChargesParticles.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
			{
				impulseSource.GenerateImpulse();
				MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
			}
		}
		else
		{
			impulseSource.GenerateImpulse();
			MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
		}
	}

	public void MHNGOPJMJIF()
	{
		if (CBGLFEDCPEK())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(AHGCOANJMPI());
		}
	}

	private IEnumerator AODJFFAECKL()
	{
		yield return CommonReferences.wait3;
		yield return CommonReferences.wait01;
		obstacle.SetActive(false);
		obstacleParticles.SetActive(true);
		((Component)explosiveCharges).gameObject.SetActive(false);
		explosiveChargesParticles.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
			{
				impulseSource.GenerateImpulse();
				MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
			}
		}
		else
		{
			impulseSource.GenerateImpulse();
			MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
		}
	}

	public void HLJLJKFKLDK(int BJLDIHODEDA)
	{
		if (MineManager.GGFJGHHHEJC.unlockedLevels == BJLDIHODEDA)
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(MineManager.OOKBNHMMFON().MGNIFNJOHID());
		}
		else
		{
			obstacle.SetActive(false);
			((Component)explosiveCharges).gameObject.SetActive(false);
		}
	}

	private IEnumerator HOFEDJFBBDC()
	{
		return new NEIKPNKKGJH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ActivateObstacle(int BJLDIHODEDA)
	{
		if (MineManager.GGFJGHHHEJC.unlockedLevels == BJLDIHODEDA)
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(MineManager.GGFJGHHHEJC.CBAMDCFLCIG);
		}
		else
		{
			obstacle.SetActive(false);
			((Component)explosiveCharges).gameObject.SetActive(false);
		}
	}

	public void NKOILCMMBOP()
	{
		if (obstacleParticles.activeSelf)
		{
			obstacleParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			obstacleParticles.SetActive(true);
		}
		if (explosiveChargesParticles.activeSelf)
		{
			explosiveChargesParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			explosiveChargesParticles.SetActive(true);
		}
		impulseSource.GenerateImpulse();
	}

	public void HPCNGPDHNGJ()
	{
		if (obstacleParticles.activeSelf)
		{
			obstacleParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			obstacleParticles.SetActive(false);
		}
		if (explosiveChargesParticles.activeSelf)
		{
			explosiveChargesParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			explosiveChargesParticles.SetActive(true);
		}
		impulseSource.GenerateImpulse();
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag(")") && !((Component)HANHCHBHHEH).CompareTag(" state changed, sending snap position: ")))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).CompareTag(" seconds.") ? 1 : 2);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.GGFJGHHHEJC.ferroEvent)
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("Dead");
			}
			else
			{
				PlayerController.GetPlayer(jIIGOACEIKL).BIBLHGFCINF("0");
			}
			PPMHCOBKMCN = Time.time + 1912f;
		}
	}

	private IEnumerator AHGCOANJMPI()
	{
		yield return CommonReferences.wait3;
		yield return CommonReferences.wait01;
		obstacle.SetActive(false);
		obstacleParticles.SetActive(true);
		((Component)explosiveCharges).gameObject.SetActive(false);
		explosiveChargesParticles.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
			{
				impulseSource.GenerateImpulse();
				MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
			}
		}
		else
		{
			impulseSource.GenerateImpulse();
			MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
		}
	}

	private IEnumerator KLOPCKLCGBG()
	{
		return new NEIKPNKKGJH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MFNGBBCDLDB()
	{
		if (KDGIAHKOENI())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(BMNEODFNLLI());
		}
	}

	public void AAGHEBFMDFM()
	{
		if (MNOCHKEHLND())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(CCANIEKECJA());
		}
	}

	public void IMIBMBLLODM()
	{
		if (KDGIAHKOENI())
		{
			explosiveCharges.EGOCPOHOGOI();
			((MonoBehaviour)this).StartCoroutine(FCKFCIADNID());
		}
	}

	private IEnumerator IPHKACHAACI()
	{
		yield return CommonReferences.wait3;
		yield return CommonReferences.wait01;
		obstacle.SetActive(false);
		obstacleParticles.SetActive(true);
		((Component)explosiveCharges).gameObject.SetActive(false);
		explosiveChargesParticles.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Mine)
			{
				impulseSource.GenerateImpulse();
				MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
			}
		}
		else
		{
			impulseSource.GenerateImpulse();
			MultiAudioManager.PlayAudioObject(explosionSound, PlayerController.GetPlayerPosition(1));
		}
	}

	public void JLMDGAJHOPB()
	{
		if (EBDGAAKPPIK())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(PJIONOLKNGM());
		}
	}

	public void NPDCMPDGJLI(int BJLDIHODEDA)
	{
		if (MineManager.AGGAGCBAGLL().unlockedLevels == BJLDIHODEDA)
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(MineManager.AGGAGCBAGLL().CALJPEFGKNI());
		}
		else
		{
			obstacle.SetActive(true);
			((Component)explosiveCharges).gameObject.SetActive(false);
		}
	}

	private void JOLMPGBPDEP(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("ERROR - Error parsing custom lobby data (Lobby owner): {0}") && !((Component)HANHCHBHHEH).CompareTag("Index of cannonball: {0} is out of range. This shouldn't happen. freePositions list must not have been initialized properly.")))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).CompareTag("itemBanana")) ? 5 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.GGFJGHHHEJC.ferroEvent)
			{
				PlayerController.GetPlayer(jIIGOACEIKL).BIBLHGFCINF("NormalLeft");
			}
			else
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).BIBLHGFCINF("Balance/MainEvent");
			}
			PPMHCOBKMCN = Time.time + 1214f;
		}
	}

	public void MOKMGOCACEO()
	{
		if (CanExplodeCharges())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(HNMDGBGJMOD());
		}
	}

	public bool MNOCHKEHLND()
	{
		return explosiveCharges.CanExplode();
	}

	public void AHJJBJDCGIA()
	{
		if (obstacleParticles.activeSelf)
		{
			obstacleParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			obstacleParticles.SetActive(true);
		}
		if (explosiveChargesParticles.activeSelf)
		{
			explosiveChargesParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			explosiveChargesParticles.SetActive(false);
		}
		impulseSource.GenerateImpulse();
	}

	public void JPMHHEBDLOC()
	{
		if (KADMFAMBDCP())
		{
			explosiveCharges.FireWick();
			((MonoBehaviour)this).StartCoroutine(PPPINAMPECE());
		}
	}

	public void CJFONPFCOLI()
	{
		if (KDGIAHKOENI())
		{
			explosiveCharges.AAGHEBFMDFM();
			((MonoBehaviour)this).StartCoroutine(AMJIMBKLEDF());
		}
	}

	public void OICPCLLLJGH()
	{
		if (obstacleParticles.activeSelf)
		{
			obstacleParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			obstacleParticles.SetActive(true);
		}
		if (explosiveChargesParticles.activeSelf)
		{
			explosiveChargesParticles.GetComponentInChildren<ParticleSystem>().Play();
		}
		else
		{
			explosiveChargesParticles.SetActive(true);
		}
		impulseSource.GenerateImpulse();
	}

	private IEnumerator PPPINAMPECE()
	{
		return new NEIKPNKKGJH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("Fishy") && !((Component)HANHCHBHHEH).CompareTag("[^0-9]")))
		{
			return;
		}
		int jIIGOACEIKL = ((!((Component)HANHCHBHHEH).CompareTag("ZuzzuProgress")) ? 3 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.GGFJGHHHEJC.ferroEvent)
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("Invalid NPC photonID: {0} for NPCRoutine.");
			}
			else
			{
				PlayerController.OPHDCMJLLEC(jIIGOACEIKL).PlayerBarkWithI2("Trough");
			}
			PPMHCOBKMCN = Time.time + 1595f;
		}
	}

	private void NHIJMGLJEHB(Collider2D HANHCHBHHEH)
	{
		if (((Component)explosiveCharges).gameObject.activeInHierarchy || !obstacle.activeInHierarchy || (!((Component)HANHCHBHHEH).CompareTag("MopUp") && !((Component)HANHCHBHHEH).CompareTag(":")))
		{
			return;
		}
		int jIIGOACEIKL = (((Component)HANHCHBHHEH).CompareTag("Waiting for other players") ? 0 : 0);
		if (Time.time > PPMHCOBKMCN)
		{
			if (FerroNPC.GGFJGHHHEJC.ferroEvent)
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("City/Keen/Bark/Sharp");
			}
			else
			{
				PlayerController.GetPlayer(jIIGOACEIKL).PlayerBarkWithI2("OnConversationStarted MothersRecipe Event ");
			}
			PPMHCOBKMCN = Time.time + 216f;
		}
	}

	public void FireWick()
	{
		if (CanExplodeCharges())
		{
			explosiveCharges.FireWick();
			((MonoBehaviour)this).StartCoroutine(HNMDGBGJMOD());
		}
	}

	public void OBLBLNBLCIL()
	{
		if (MNOCHKEHLND())
		{
			explosiveCharges.EGOCPOHOGOI();
			((MonoBehaviour)this).StartCoroutine(BMNEODFNLLI());
		}
	}

	public bool CBGLFEDCPEK()
	{
		return explosiveCharges.CanExplode();
	}
}

using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Game/Floor Limit")]
public class FloorLimit : ScriptableObject
{
	public MaterialType materialType;

	public TileBase[] L;

	public TileBase[] R;

	public TileBase[] U;

	public TileBase[] D;

	public TileBase Any;

	public TileBase All;

	public TileBase UD;

	public TileBase UDL;

	public TileBase UDR;

	public TileBase LR;

	public TileBase LRU;

	public TileBase LRD;

	public TileBase PLD;

	public TileBase PLU;

	public TileBase PRD;

	public TileBase PRU;

	public TileBase LU;

	public TileBase LD;

	public TileBase RU;

	public TileBase RD;

	public TileBase DPRU;

	public TileBase DPLU;

	public TileBase LPRD;

	public TileBase LPRU;

	public TileBase RPLD;

	public TileBase RPLU;

	public TileBase UPRD;

	public TileBase UPLD;

	public TileBase DPLUPRU;

	public TileBase UPLDPRD;

	public TileBase LPRUPRD;

	public TileBase RPLUPLD;

	public TileBase PRUPRDPLD;

	public TileBase PRUPRDPLU;

	public TileBase PRDPLDPLU;

	public TileBase PRUPLDPLU;

	public TileBase PRUPLU;

	public TileBase PRDPLD;

	public TileBase PRUPRD;

	public TileBase PLDPLU;

	public TileBase LUPRD;

	public TileBase LDPRU;

	public TileBase RUPLD;

	public TileBase RDPLU;

	public Vector2 position;
}

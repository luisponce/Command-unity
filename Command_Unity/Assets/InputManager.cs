using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
	
	public GameObject actor;

	public int enumCommandIzquierda = (int) EnumCommandos.Left;
	public int enumCommandDerecha = (int) EnumCommandos.Rigth;
	public int enumCommandAdelante = (int) EnumCommandos.Forward;
	public int enumCommandAtras = (int) EnumCommandos.Backwards;
	public int enumCommandJump = (int) EnumCommandos.Jump;

	private Command flechaIzqCommand;
	private Command flechaDerCommand;
	private Command flechaAdelanteCommand;
	private Command flechaAtrasCommand;
	private Command spaceCommand;

	Mover m;

	// Use this for initialization
	void Start () {
		m = actor.GetComponent<Mover>();

		flechaIzqCommand = new MoverIzquierdaCommand(m);
		flechaDerCommand = new MoverDerechaCommand(m);
		flechaAdelanteCommand = new MoverAdelanteCommand(m);
		flechaAtrasCommand = new MoverAtrasCommand(m);

		spaceCommand = new JumpCommand(m);
	}
	
	// Update is called once per frame
	void Update () {
		flechaIzqCommand = getCommandFormEnum(enumCommandIzquierda);
		flechaDerCommand = getCommandFormEnum(enumCommandDerecha);
		flechaAdelanteCommand = getCommandFormEnum(enumCommandAdelante);
		flechaAtrasCommand = getCommandFormEnum(enumCommandAtras);
		spaceCommand = getCommandFormEnum(enumCommandJump);


		if (Input.GetKey(KeyCode.LeftArrow)){
			flechaIzqCommand.Execute();
		} else if (Input.GetKey(KeyCode.RightArrow)){
			flechaDerCommand.Execute();
		} else  if (Input.GetKey(KeyCode.UpArrow)){
			flechaAdelanteCommand.Execute();
		} else  if (Input.GetKey(KeyCode.DownArrow)){
			flechaAtrasCommand.Execute();
		} else  if (Input.GetKeyDown(KeyCode.Space)){
			spaceCommand.Execute();
		}
	}

	public Command getCommandFormEnum(int enumCommand){
		switch (enumCommand){
		case (int) EnumCommandos.Jump:
			return new JumpCommand(m);

		case (int) EnumCommandos.Forward:
			return new MoverAdelanteCommand(m);

		case (int) EnumCommandos.Backwards:
			return new MoverAtrasCommand(m);

		case (int) EnumCommandos.Rigth:
			return new MoverDerechaCommand(m);

		case (int) EnumCommandos.Left:
			return new MoverIzquierdaCommand(m);

		default:
			Debug.Log(enumCommand + " enum no valido");
			break;

		}

		return null;
	}
}

using UnityEngine;
using System.Collections;

public abstract class Command {

	public Mover actor; 

	public Command(Mover actor){
		this.actor = actor;
	}

	public abstract void Execute();
}

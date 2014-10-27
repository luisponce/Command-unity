using UnityEngine;
using System.Collections;

public class JumpCommand : Command {

	public JumpCommand(Mover actor) : base(actor){

	}

	public override void Execute(){
		actor.saltar();
	}
}

public class MoverAdelanteCommand : Command {
	
	public MoverAdelanteCommand(Mover actor) : base(actor){
		
	}
	
	public override void Execute(){
		actor.moverFrente();
	}
}

public class MoverAtrasCommand : Command {
	
	public MoverAtrasCommand(Mover actor) : base(actor){
		
	}
	
	public override void Execute(){
		actor.moverAtras();
	}
}

public class MoverIzquierdaCommand : Command {
	
	public MoverIzquierdaCommand(Mover m) : base(m){
		actor = m;
	}
	
	public override void Execute(){
		base.actor.moverIzquierda();
	}
}

public class MoverDerechaCommand : Command {
	
	public MoverDerechaCommand(Mover actor) : base(actor){
		
	}
	
	public override void Execute(){
		actor.moverDerecha();
	}
}

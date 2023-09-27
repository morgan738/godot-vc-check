using Godot;
using System;

public partial class scene_1 : Label
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_button_pressed()
	{
		var global = GetNode<globalScript>("/root/GlobalScript");
		global.GotoScene("res://scene_2.tscn");
	}
}
//comment in scene 1


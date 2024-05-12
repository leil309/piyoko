using Godot;
using System;

public partial class game : Node2D
{
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// 대부분 Godot 게임들은 Alt + Enter로 관리하지 않고, 설정값으로 관리하는듯
		if (Input.IsActionPressed("toggle_fullscreen") &&
			(DisplayServer.WindowGetMode() == DisplayServer.WindowMode.Windowed ||
			 DisplayServer.WindowGetMode() == DisplayServer.WindowMode.Maximized))
		{
			DisplayServer.WindowSetMode(DisplayServer.WindowMode.Fullscreen);
		}
		else if (Input.IsActionPressed("toggle_fullscreen") && DisplayServer.WindowGetMode() == DisplayServer.WindowMode.Fullscreen)
		{
			DisplayServer.WindowSetMode(DisplayServer.WindowMode.Windowed);
		}

		if (Input.IsActionJustPressed("esc"))
		{
			GetTree().ChangeSceneToFile("res://menu.tscn");
		}
	}
}
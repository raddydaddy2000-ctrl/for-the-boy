using System;

public class CPHInline
{
	public bool Execute()
	{
        // Play the sound
        CPH.PlaySound(@"C:\Users\nzmah\OneDrive\Desktop\aura.mp3", 1.0f, false, "subGoalSound", true);
		return true;
	}
}

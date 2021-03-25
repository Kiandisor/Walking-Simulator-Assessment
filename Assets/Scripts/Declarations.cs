namespace Declarations {
	public struct tags
	{
		public const string _ground  = "Ground";
		public const string _crystal = "Collectables";
		public const string _button  = "Button";
	}

	public struct positions
	{
		public const string _horizontal_axis = "Horizontal";
		public const string _vertical_axis   = "Vertical";
	}

	public struct inputs
	{
		public const int    _left_click   = 0;

		public const string _jump_button  = "Jump";
		public const string _mouse_x_axis = "Mouse X";
		public const string _joystick_x_axis = "Right JoyStick X";
		public const string _mouse_y_axis = "Mouse Y";
		public const string _joystick_y_axis = "Right JoyStick Y";
	}

	public struct buttons 
	{
		public const string _menu     = "Menu Button";
		public const string _settings = "Settings Button";
		public const string _play     = "Play Button";
		public const string _quit     = "Quit Button";
	}

	public struct levels
	{
		public const string _main_menu    = "Main Menu";
		public const string _forest_level = "Main Game Scene";
	}

	public struct scene_names 
	{
		public const string _menu = "Main Menu";
		public const string _game = "Main Game Scene";
		public const string _cave = "Cave Maze";
	}

	/* Crystal Manager */

	/** State for the crystals being collected */
	public enum collect_status { collected, not_collected }

	/* Button Manager */

	/** State for the buttons being pressed or not */
	public enum pressed { no,yes }
}

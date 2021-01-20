using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Declarations {
	public struct tags
	{
		public static string _ground = "Ground";
		public static string _crystal = "Collectables";
		public static string _button = "Button";
	}

	public struct positions
	{
		public static string _horizontal_axis = "Horizontal";
		public static string _vertical_axis = "Vertical";

	}

	public struct inputs
	{
		public static string _jump_button = "Jump";
		public static string _m = "";

		public static int _left_click = 0;

		public static string _mouse_x_axis = "Mouse X";
		public static string _mouse_y_axis = "Mouse Y";
	}

	public struct levels
	{
		public static string _main_menu = "Level 0";
		public static string _forest_level = "Level 1";
		public static string _cave_level = "Level 2";
	}

	/* Crystal Manager */

	/** State for the crystals being collected */
	public enum collect_status { collected, not_collected }

	/** Time that the crystal was added to the crystal manager */
	public enum created_time { start, late }

	/* Button Manager */

	/** State for the buttons being pressed or not */
	public enum pressed { no,yes }
}

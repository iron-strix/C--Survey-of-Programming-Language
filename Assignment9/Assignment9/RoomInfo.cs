//Nigel Little
//CITP 3310v03
//05/01/2022

using System;

namespace Assignment9
{
	public class RoomInfo
	{
		//private vars
		private double length;
		private double width;
		private bool hasTV;
		private static double houseSize;

		//ctors
		public RoomInfo()
		{
			length = 0;
			width = 0;
			hasTV = false;
		}

		public RoomInfo(double l, double w)
		{
			length = l;
			width = w;
			hasTV = false;
		}

		public RoomInfo(double l, double w, bool tv)
		{
			length = l;
			width = w;
			hasTV = tv;
		}

		//properties
		public double Length
		{
			get { return length; }
			set { length = value; }
		}

		public double Width
		{
			get { return width; }
			set { width = value; }
		}

		public bool HasTV
		{
			get { return hasTV; }
			set { hasTV = value; }
		}

		public static double HouseSize
		{
			get { return houseSize; }
			set { houseSize = value; }
		}

		//functions
		//calculates room size and updates the house size
		public void calcRoomSize()
		{
			double roomSize = length * width;
			houseSize += roomSize;
		}

		/*override ToString to allow easy printing*/
		public override string ToString()
		{
			return "Room Length: " + length + "\nRoom Width: " + width + "\nRoom Size: " + (length * width) + "\n";
		}
	}

}

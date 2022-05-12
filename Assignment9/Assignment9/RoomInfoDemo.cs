//Nigel Little
//CITP 3310v03
//05/01/2022

using System;

namespace Assignment9
{
	public class RoomInfoDemo
	{
		public static void Main(string[] args)
		{
			//array created, but elements not initialized
			//must initialize elements for objects to function
			RoomInfo[] roomArray = new RoomInfo[4];

			//initialize
			roomArray[0] = new RoomInfo();
			roomArray[1] = new RoomInfo(5, 5); // testing ctor
			roomArray[2] = new RoomInfo(9, 5, true); //testing ctor
			roomArray[3] = new RoomInfo();

			//possible to use syntax:
			//Object[] obj = {
			//new { key = "key", value = "value"}
			//}; etc

			Console.WriteLine("This demo program will take room dimensions of 4 rooms inside a house and gather information about the room.");
			Console.WriteLine("=======================================================================================================\n");

			//call getData for each room
			foreach (RoomInfo room in roomArray)
			{
				getData(room);
			}

			//display room and house size
			foreach (RoomInfo room in roomArray)
			{
				Console.WriteLine(room); //overridden ToString
			}

			//display number of rooms that have TV
			int numberOfTV = 0;
			foreach (RoomInfo room in roomArray)
			{
				if (room.HasTV)
				{
					numberOfTV++;
				}
			}

			Console.WriteLine("Number of TVs in House: {0}", numberOfTV);
		}

		//using RoomInfo object, prompt user for length/width
		//of each room, prompt user for Y/N for TV and update
		//hasTV boolean
		public static void getData(RoomInfo room)
		{
			//prompt for width
			double width;
			Console.Write("Enter the width of the room: ");
			double.TryParse(Console.ReadLine(), out width);

			//prompt for length
			double length;
			Console.Write("Enter the length of the room: ");
			double.TryParse(Console.ReadLine(), out length);

			//prompt for TV
			char tv = 'U';
			Console.Write("Does the room have a TV? (Y/N): ");
			char.TryParse(Console.ReadLine(), out tv);
			
			//update object properties
			if (tv == 'Y' || tv == 'y')
            {
				room.HasTV = true;
            }

			room.Length = length;
			room.Width = width;
			room.calcRoomSize();

			Console.WriteLine(); //to make the console screen look nice
		}
	}
}
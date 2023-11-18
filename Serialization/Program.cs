using System.Runtime.Serialization.Formatters.Binary; // Import Serialization into the system
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Serialization
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Serialize object to txt

			//Step 1: Create an instance/object of the Event class 
			Event event1 = new Event(1, "Calgary");


			//Step 2: Serialize the object and the pathway of where it will be saved

			string pathOfEncoded = "events.txt"; // create a pathway of where our encodedData will print to
			string encodedData = JsonSerializer.Serialize(event1); // serialize the object using the JsonSerializer.Serialize method


			//Step 3: Save the serialized object into a file using File.WriteAllText(param1, param2) - param1 = pathway, param2 = 

			File.WriteAllText(pathOfEncoded, encodedData); //Write the serialized data to the path 

			//Validate the object was serialized into a text file by printing:
			Console.WriteLine("Wrote to txt file");



			//Deserialize the txt file 

			//Step 1: Read the serialized data from the file 

			string decodeSerializedData = File.ReadAllText(pathOfEncoded);

			//Step 2: Create an object as a placeholder to put the data to be deserialized 

			Event decodedData = JsonSerializer.Deserialize<Event>(decodeSerializedData);

			//Step 3: Validate that deserialization worked by printing
			Console.WriteLine(decodedData.EventNumber);
			Console.WriteLine(decodedData.Location);

			ReadFromFile();

		}

		static void ReadFromFile()
		{

			string pathToEventFile = "file.txt";

			using (StreamWriter writer = new StreamWriter(pathToEventFile))
			{
				writer.WriteLine("Hackathon");
			}

			using(StreamReader reader = new StreamReader(pathToEventFile))
			{

			

				//Reading the first character
				reader.BaseStream.Seek(0, SeekOrigin.Begin); // goes to the beginning 

				int firstCharPos = reader.Read(); // Reads the first character of the word "Hackathon" and find its corresponding number based on the ASCII table // The parent object

				char firstChar = (char)firstCharPos; // converting the int to char by downcast the parent object to the child as a char vs a string- Child c = (Child)p

				Console.WriteLine($"The First Character is: {firstChar}");


				//Read the middle character
				// Reset the stream position to the beginning
				reader.BaseStream.Seek(0, SeekOrigin.Begin);

				int middleCharPos = (int)(reader.BaseStream.Length / 2); // read the length of the stream and find the middle, when you find it, cast it to the middleChar integer

				reader.BaseStream.Seek(middleCharPos, SeekOrigin.Begin); // use the position of the middle term to change the position of the pointer

				int middleCharNum = reader.Read(); //read the numerical position of the middle char

				char middleChar = (char)middleCharNum; // down cast the middle char Num into the middleChar object but as character 

				Console.WriteLine($"The Middle Character is: {middleChar}");



				// Read the last character

				int lastCharPos = (int)(reader.BaseStream.Length - 1); // read the length of the stream and find the last, when you find it, cast it to the lastChar integer

				reader.BaseStream.Seek(lastCharPos, SeekOrigin.Begin); // use the position of the last term to change the position of the pointer

				int lastCharNum = reader.Read(); //read the numerical position of the last char

				char lastChar = (char)lastCharNum; // down cast the last char Num into the last Char object but as character 

				Console.WriteLine($"The Last Character is: {lastChar}");

			}


		}
	}

	
}
// DON'T WORK Correctly

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_4.Light_the_Torches
{
    class Torches
    {
        static void Main(string[] args)
        {

            //input

            int numberOfRooms = int.Parse(Console.ReadLine());
            string series = Console.ReadLine();
            string commands;
            List<string> commandsList = new List<string>();

            while (true)
            {
                commands = Console.ReadLine(); 
                commandsList.Add(commands);
                if (commands == "END") 
                {
                    break;
                }
            }

            //change the room state
            string[] roomsLights = new string[numberOfRooms];
            int currentPosition = 0;

            for (int i = 0; i < numberOfRooms; i++)
            {

                if (currentPosition > series.Length - 1)
                {
                    currentPosition = 0;
                }
                roomsLights[i] = series[currentPosition].ToString();
                currentPosition++;


            }

            int currentRoom = (roomsLights.Length) / 2;
            int step;
            string resultString;
          

            for (int i = 0; i < commandsList.Count; i++)
            {
                    if (commandsList[i].Contains("END"))
                    {
                        break;
                    }

                    resultString = Regex.Match(commandsList[i], @"\d+").Value;          //get the number from string
                    step = int.Parse(resultString);

                    if (commandsList[i].Contains("L"))                                  //L is contained only in command LEFT-->check for command LEFT
                    {

                        if (currentRoom - step - 1 <= 0)
                        {
                            currentRoom = 0;
                            if (commandsList[i]!=commandsList[i+1])
                            {
                                continue;
                            }
                            

                        }
                        else
                        {
                            currentRoom = currentRoom - step - 1;
                        }
                        if (roomsLights[currentRoom] == "L")
                        {
                            roomsLights[currentRoom] = "D";
                        }
                        else
                        {
                            roomsLights[currentRoom] = "L";
                        }
                    }
                    if (commandsList[i].Contains("R"))
                    {
                        if (currentRoom + step + 1 >= roomsLights.Length)
                        {
                            currentRoom = roomsLights.Length-1;
                            if (commandsList[i] != commandsList[i + 1])
                            {
                                continue;
                            }

                        }
                        else
                        {
                            currentRoom = currentRoom + step + 1;
                        }
                        if (roomsLights[currentRoom] == "L")
                        {
                            roomsLights[currentRoom] = "D";
                        }
                        else
                        {
                            roomsLights[currentRoom] = "L";
                        }
                    }

            }

            int counter = 0;
            int praysNumber;

            for (int i = 0; i < roomsLights.Length; i++)
            {
                if (roomsLights[i]=="D")
                {
                    counter++;
                }
            }

            praysNumber =counter * 'D';
            Console.WriteLine(praysNumber);
        }
    }
}


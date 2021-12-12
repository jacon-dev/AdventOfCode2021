using System.Linq;

namespace Day2
{
    public class SubmarineControls
    {
        public static double MoveSubmarine(string[] inputDirections)
        {
            var depth = 0;
            var horizontalPosition = 0;

            foreach (var direction in inputDirections)
            {
                var movement = direction.Split(" ").First();
                int.TryParse(direction.Split(" ").Last(), out var distance);
                switch (movement)
                {
                    case "forward" : horizontalPosition += distance;
                        break;
                    case "up" : depth -= distance ;
                        break;
                    case "down" : depth += distance;
                        break;
                }
            }

            return depth * horizontalPosition;
        }

        public static double AimSubmarine(string[] inputDirections)
        {
            var depth = 0;
            var horizontalPosition = 0;
            var aim = 0;

            foreach (var direction in inputDirections)
            {
                var movement = direction.Split(" ").First();
                int.TryParse(direction.Split(" ").Last(), out var distance);

                switch (movement)
                {
                    case "forward" : horizontalPosition += distance;
                        depth += aim * distance;
                        break;
                    case "up" : aim -= distance ;
                        break;
                    case "down" : aim += distance;
                        break;
                }
            }

            return depth * horizontalPosition;
        }
    }
}
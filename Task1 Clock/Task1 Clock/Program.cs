// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

// Angle between the 0 numeral and the minute hand
static double MinuteAngle(int minutes)
{
    return 6 * minutes;     // 360 / 60 * minutes
}

// Angle between the 0 numeral and the hour hand
static double HourAngle(int hours, int minutes)
{
    double hourFraction = 0.5 * minutes;         // 30 / 60 * minutes
    return 30 * (hours % 12) + hourFraction;     // 360 / 12 * hours
                                                 // hours % 12 for 24 hour time format 
}

// Difference between the minute and the hour hand angles
static double HandsAngleDifference(int hours, int minutes)
{
    double difference = Math.Abs(HourAngle(hours, minutes) - MinuteAngle(minutes));

    // Checking if the angle difference is wide angle
    if (difference > 180) difference = 360 - difference;
    
    return difference;
}

// Compensation for double rounding errors during tests
static bool AlmostEqual(double val1, double val2, double precision = 0.000001)
{
    return Math.Abs(val1 - val2) < precision;
}

Debug.Assert(AlmostEqual(HandsAngleDifference(0, 0), 0));
Debug.Assert(AlmostEqual(HandsAngleDifference(0, 30), 165));
Debug.Assert(AlmostEqual(HandsAngleDifference(4, 0), 120));
Debug.Assert(AlmostEqual(HandsAngleDifference(5, 30), 15));
Debug.Assert(AlmostEqual(HandsAngleDifference(11, 45), 82.5));
Debug.Assert(AlmostEqual(HandsAngleDifference(12, 0), 0));
Debug.Assert(AlmostEqual(HandsAngleDifference(20, 0), 120));

// User interaction
Console.WriteLine("Enter time in hh:mm format: ");

string[] hands = Console.ReadLine().Split(new char[] {' ', ':'});
int hourHand = Int32.Parse(hands[0]);
int minuteHand = Int32.Parse(hands[1]);
double angleDifference = HandsAngleDifference(hourHand, minuteHand);

Console.Write($"The angle between hands is {angleDifference} degrees");
Console.ReadKey();
